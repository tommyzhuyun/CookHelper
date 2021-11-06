using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace CookHelper.Data
{
    public class Manager
    {
        public readonly CookingRecipe recipe;
        public readonly ItemDB itemdb;
        public readonly ItemDBChina db;
        public readonly BaseItem BaseItem;
        public FavoriteManager favorite;
        public float dpiX, dpiY;
        public bool OnDPIWorking { set; get; }
        public Manager()
        {
            recipe = new CookingRecipe("DataBase/cookingrecipe.xml");
            itemdb = new ItemDB("DataBase/itemdb.xml");
            db = new ItemDBChina("DataBase/itemdb.china.txt");
            BaseItem = new BaseItem("DataBase/Shop.xml", "DataBase/Mission.xml", "DataBase/Skill.xml");
            favorite = null;
            using (Graphics graphics = Graphics.FromHwnd(IntPtr.Zero))
            {
                dpiX = graphics.DpiX;
                dpiY = graphics.DpiY;
            }
            OnDPIWorking = false;
        }

        public void Update(string filename)
        {
            try
            {
                favorite = new FavoriteManager(filename);
            }
            catch (Exception)
            { }
        }

        public void Update(FavoriteManager favorite)
        {
            this.favorite = favorite;
        }

        public bool HighDPI
        {
            get
            {
                return dpiX != 96 || dpiY != 96;
            }
        }

        public string ClassIDtoName(string id)
        {
            return ClassIDtoName(itemdb.ReadItemDBFromID(id));
        }

        public string ClassIDtoName(ITEM ID)
        {
            if (ID != null)
                return ID.GetName(db);
            else
                return "???";
        }

        public Image GetImageFromId(int id)
        {
            return GetImageFromId(id.ToString());
        }

        public Image GetImageFromId(string id)
        {
            Image item = GetImage("./img/item/" + id + ".png");
            if (item == null)
                return GetImage("./img/item/unknow.png");
            else
                return item;
        }

        public Image GetImageFromAction(string ActionName)
        {
            return GetImage("./img/Skill/10020" + ActionName + ".png");
        }

        public Image GetImage(string filename)
        {
            if (File.Exists(filename))
            {
                Image get = Image.FromFile(filename);
                if (!OnDPIWorking)
                    return get;
                Bitmap HighDPI = new Bitmap((int)(get.Width * dpiX / 96), (int)(get.Height * dpiX / 96));
                using (Graphics g = Graphics.FromImage(HighDPI))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                    g.DrawImage(get, 0, 0, HighDPI.Width, HighDPI.Height);
                }
                get.Dispose();
                return HighDPI;
            }
            else
                return null;
        }

        public List<MENU> ReadRecipe()
        {
            return recipe.ReadMenusOnDepth(IsBase);
        }
        
        public bool IsBase(string ClassID)
        {
            return BaseItem.HasItem(ClassID);
        }

        public MENU ReadFirstRecipe(string id)
        {
            return recipe.GetMenu(id);
        }

        public ITEM ReadItemDBFromID(string id)
        {
            return itemdb.ReadItemDBFromID(id);
        }
        /*
        public Dictionary<string, string> GetFoodEffect(int id)
        {
            Dictionary<string, string> ED = new Dictionary<string, string>();
            ITEM item = itemdb.ReadItemDBFromID(id);
            if (item == null)
                return ED;
            BUFFER buffer = item.FoodEffect;
            if (buffer == null)
                return ED;
            foreach (var effect in buffer.Effects)
            {
                ED.Add(effect.Name, effect.Amount);
            }
            return ED;
        }
        */
        /*
        public BUFFER ReadBufferFromItem(ITEM item)
        {
            if (item == null)
                return null;
            return item.FoodEffect;
        }

        /*
        public List<EFFECT> ReadEffectFromBuffer(BUFFER buffer)
        {
            if (buffer != null)
                return buffer.Effects;
            else
                return null;
        }

        public List<EFFECT> ReadEffectFromItem(ITEM item)
        {
            return ReadEffectFromBuffer(ReadBufferFromItem(item));
        }*/

        public bool IsMenu(MENUSOURCE source)
        {
            return recipe.IsMenu(source);
        }

        public bool IsMenu(string ClassID)
        {
            return recipe.IsMenu(ClassID);
        }
        public Sorting GetSourceSorting(MENUSOURCE source)
        {
            if (source == null)
                return null;
            string ClassID = source.ClassID;

            bool IsMenu = recipe.IsMenu(ClassID);
            MENU menu = recipe.GetMenu(ClassID);
            ITEM item = itemdb.ReadItemDBFromID(ClassID);

            if (BaseItem.HasItem(ClassID))
                IsMenu = false;
            Sorting sorter = new Sorting(ClassIDtoName(ClassID), source.ClassIDInt, IsMenu, menu, item);
            return sorter;
        }

        public Sorting GetSorting(List<Sorting> sbase, int ClassID)
        {
            return sbase.Find(x => x.ClassID == ClassID);
        }


        public List<Sorting> GetBaseItem(Sorting sort)
        {
            if (sort == null)
                throw new NullReferenceException("sort is null");
            List<Sorting> source = new List<Sorting>();
            if (sort.IsMenu && sort.Menu != null)
            {
                var list = sort.Menu.Essential;
                foreach (var li in list)
                {
                    Sorting a = GetSourceSorting(li);
                    var loop = GetBaseItem(a);
                    foreach (var lo in loop)
                    {
                        source.Add(lo);
                    }
                }
            }
            else if (!sort.IsMenu)
            {
                source.Add(sort);
            }
            return source;
        }

        public List<Statistic> CountOnSorting(List<Sorting> sortings)
        {
            List<Statistic> counton = new List<Statistic>();
            foreach (var sort in sortings)
            {
                var check = counton.FirstOrDefault(x => x.Sorting.ClassID == sort.ClassID);
                if (check != null)
                {
                    check.CountOn();
                }
                else
                {
                    Status status = Status.UnKown;
                    if (BaseItem.ItemCanBuy(sort.ClassID.ToString()))
                    {
                        status = Status.CanBuy;
                    }
                    else if (BaseItem.ItemCanMission(sort.ClassID.ToString()))
                    {
                        status = Status.CanMission;
                    }
                    else if (BaseItem.ItemCanSkill(sort.ClassID.ToString()))
                    {
                        status = Status.CanSkill;
                    }
                    else if (sort.IsMenu)
                    {
                        status = Status.CanCook;
                    }
                    counton.Add(new Statistic(sort, status));
                }
            }

            return counton.OrderBy(a => a.Status).ThenBy(a => a.Sorting.ClassID).ToList();
        }

        public List<EFFECT> ReadMenuEffect(string menu)
        {
            var db = itemdb.ReadItemDBFromID(menu);
            if (db == null)
                return new List<EFFECT>();
            var foodeffect = db.FoodEffect;
            if (foodeffect != null)
                return foodeffect.Effects;
            else
                return new List<EFFECT>();
        }

    }
}

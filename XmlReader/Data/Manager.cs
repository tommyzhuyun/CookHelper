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

        public Manager()
        {
            recipe = new CookingRecipe("DataBase/cookingrecipe.xml");
            itemdb = new ItemDB("DataBase/itemdb.xml");
            db = new ItemDBChina("DataBase/itemdb.china.txt");
            BaseItem = new BaseItem("DataBase/Shop.xml", "DataBase/Mission.xml", "DataBase/Skill.xml");
            favorite = null;
        }

        public void Update(string filename)
        {
            try
            {
                favorite = new FavoriteManager(filename);
            }
            catch (Exception)
            {

            }
        }

        public void Update(FavoriteManager favorite)
        {
            this.favorite = favorite;
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

        public Image GetImageFromId(string id)
        {
            string file = "./img/item/" + id + ".png";
            if (File.Exists(file))
            {
                Image image = Image.FromFile(file);
                return image;
            }
            else
            {
                if (File.Exists("./img/item/unknow.png"))
                {
                    Image image = Image.FromFile("./img/item/unknow.png");
                    return image;
                }
                else
                    return null;
            }
        }

        public Image GetImageFromId(int id)
        {
            return GetImageFromId(id.ToString());
        }

        public Image GetImageFromAction(string ActionName)
        {
            string file = "./img/Skill/10020" + ActionName + ".png";
            if (File.Exists(file))
            {
                Image image = Image.FromFile(file);
                return image;
            }
            else
            {
                return null;
            }
        }

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

        public List<MENU> ReadRecipe()
        {
            return recipe.ReadMenus(GetDepth);
        }

        public int GetDepth(MENU menu)
        {
            var RecipeElements = recipe.Recipe.Descendants("recipe");
            var Essential = menu.Essential;
            int[] depth = new int[Essential.Count];
            int i = 0;
            foreach (var es in Essential)
            {
                if (BaseItem.HasItem(es.ClassID))
                {
                    depth[i] = 1;
                }
                else
                {
                    var found = RecipeElements.Where(x => x.Attribute("result_item")?.Value == es.ClassID.ToString());
                    if (found.Count() != 0)
                    {
                        MENU m = new MENU(found.First());
                        depth[i] = 1 + GetDepth(m);
                    }
                    else
                    {
                        depth[i] = 1;
                    }
                }
                i++;
            }
            return depth.Sum();
        }

        

        public bool IsBase(string ClassID)
        {
            return BaseItem.HasItem(ClassID);
        }

        public MENU ReadFirstRecipe(string id)
        {
            var c = ReadRecipe();
            return c.Where((x)=>x.SuccessID == id).FirstOrDefault();
        }

        public ITEM ReadItemDBFromID(string id)
        {
            return itemdb.ReadItemDBFromID(id);
        }

        public BUFFER ReadBufferFromItem(ITEM item)
        {
            if (item == null)
                return null;
            return item.FoodEffect;
        }

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
        }

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
            bool IsSuccess = recipe.IsSuccess(source);
            bool IsTrash = recipe.IsTrash(source);

            MENU menu = recipe.GetMenu(source);
            ITEM item = ReadItemDBFromID(source.ClassID);
            bool IsMenu = IsSuccess || IsTrash;
            if (BaseItem.HasItem(source.ClassID))
                IsMenu = false;
            Sorting sorter = new Sorting(ClassIDtoName(source.ClassID), source.ClassIDInt, IsMenu, menu, item);
            return sorter;
        }

        public Sorting GetSorting(List<Sorting> sbase,int ClassID)
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
                foreach(var li in list)
                {
                    Sorting a = GetSourceSorting(li);
                    var loop = GetBaseItem(a);
                    foreach(var lo in loop)
                    {
                        source.Add(lo);
                    }
                }
            }else if (!sort.IsMenu)
            {
                source.Add(sort);
            }
            return source;
        }

        public List<Statistic> CountOnSorting(List<Sorting> sortings)
        {
            List<Statistic> counton = new List<Statistic>();
            foreach(var sort in sortings)
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
                    }else if (sort.IsMenu)
                    {
                        status = Status.CanCook;
                    }
                    counton.Add(new Statistic(sort, status));
                }
            }

            counton.Sort((a, b) => a.Status - b.Status);
            return counton;
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

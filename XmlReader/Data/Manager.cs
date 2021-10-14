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
            recipe = new CookingRecipe();
            itemdb = new ItemDB();
            db = new ItemDBChina();
            BaseItem = new BaseItem();
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

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace CookHelper.Data
{
    public class CookingRecipe
    {
        private readonly XDocument Recipe;

        private readonly Dictionary<string, MENU> Recipes;

        public CookingRecipe() : this("cookingrecipe.xml")
        { }

        public CookingRecipe(string name)
        {
            Recipe = XDocument.Load(name);
            Recipes = ReadMenus();
        }

        private Dictionary<string, MENU> ReadMenus()
        {
            var Items = new Dictionary<string, MENU>();
            foreach (XElement RecipeElement in Recipe.Descendants("recipe"))
            {
                MENU re = new MENU(RecipeElement);
                string success = re.SuccessID;
                string trash = re.TrashID;
                if (success != null)
                    Items[success] = re;
                if (trash != null)
                    Items[trash] = re;
            }
            return Items;
        }
        /*
        public HashSet<string> ReadMenuList()
        {
            var HRecipes = new HashSet<string>();
            foreach (var re in Recipes.Values)
            {
                HRecipes.Add(re.SuccessID);
                HRecipes.Add(re.TrashID);
            }
            return HRecipes;
        }
        */
        public SortedSet<string> ReadItems()
        {
            SortedSet<string> items = new SortedSet<string>();

            foreach (var re in Recipes.Values)
            {
                items.Add(re.SuccessID);
                items.Add(re.TrashID);
                foreach (var ess in re.Essential)
                {
                    items.Add(ess.ClassID);
                }
            }
            items.Remove("");
            items.Remove(null);
            return items;
        }
        
        public List<MENU> ReadMenusOnDepth(Func<string, bool> HasBaseItem)
        {
            foreach (MENU Recipe in Recipes.Values)
            {
                Recipe.UpdateDepth(GetDepth(null, Recipe, HasBaseItem));
            }
            return Recipes.Values.ToList();
        }

        public int GetDepth(MENU FirstCall, MENU OnCall, Func<string, bool> HasBaseItem)
        {
            if (FirstCall == OnCall)
                return 0;
            if (FirstCall == null)
                FirstCall = OnCall;

            var Essential = OnCall.Essential;

            int[] depth = new int[Essential.Count];
            int i = 0;
            foreach (var es in Essential)
            {
                depth[i] = 1;
                if (!HasBaseItem(es.ClassID))
                {
                    if (Recipes.TryGetValue(es.ClassID, out MENU found))
                    {
                        found.MenuBasedIncrement();
                        depth[i] = 1 + GetDepth(FirstCall, found, HasBaseItem);
                    }
                }
                i++;
            }
            return depth.Sum();
        }

        public MENU GetMenu(MENUSOURCE source)
        {
            if (Recipes.TryGetValue(source.ClassID, out MENU menu))
                return menu;
            else
                return null;
        }

        public MENU GetMenu(string ClassID)
        {
            if (Recipes.TryGetValue(ClassID, out MENU menu))
                return menu;
            else
                return null;
        }

        public bool IsMenu(MENUSOURCE source)
        {
            return IsMenu(source.ClassID);
        }

        public bool IsMenu(string ClassID)
        {
            return Recipes.ContainsKey(ClassID);
        }

        public bool IsSuccess(MENUSOURCE source)
        {
            if (source != null)
                return IsSuccess(source.ClassID);
            else
                return false;
        }

        public bool IsTrash(MENUSOURCE source)
        {
            if (source != null)
                return IsTrash(source.ClassID);
            else
                return false;
        }

        public bool IsSuccess(string ClassID)
        {
            return Recipes.Values.FirstOrDefault(x => x.IsSuccess(ClassID)) != null;
        }

        public bool IsTrash(string ClassID)
        {
            return Recipes.Values.FirstOrDefault(x => x.IsTrash(ClassID)) != null;
        }

    }
}

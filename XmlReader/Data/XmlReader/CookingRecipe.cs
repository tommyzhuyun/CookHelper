using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace CookHelper.Data
{
    public class CookingRecipe
    {
        public XDocument Recipe { private set; get; }

        public CookingRecipe()
        {
            Recipe = XDocument.Load("cookingrecipe.xml");
        }

        public CookingRecipe(string name)
        {
            Recipe = XDocument.Load(name);
        }

        public List<MENU> ReadMenus(Func<MENU,int> CalDepth)
        {
            var Recipes = new List<MENU>();
            foreach (XElement RecipeElements in Recipe.Descendants("recipe"))
            {
                MENU re = new MENU(RecipeElements);
                re.UpdateDepth(CalDepth(re));
                Recipes.Add(re);
            }
            return Recipes;
        }

        public SortedSet<string> ReadItems(Func<MENU, int> CalDepth)
        {
            SortedSet<string> items = new SortedSet<string>();

            var Recipes = ReadMenus(CalDepth);
            foreach (var re in Recipes)
            {
                items.Add(re.SuccessID);
                items.Add(re.TrashID);
                foreach (var ess in re.Essential)
                {
                    items.Add(ess.ClassID);
                }
            }
            items.Remove("");

            return items;
        }

        public MENU GetMenu(MENUSOURCE source)
        {
            var c = Recipe.Descendants("recipe").
                LastOrDefault((x) => 
                x.Attribute("result_item")?.Value == source.ClassID.ToString() 
                || x.Attribute("trash_item")?.Value == source.ClassID.ToString());
            if (c != null)
                return new MENU(c);
            else
                return null;
        }

        public bool IsMenu(MENUSOURCE source)
        {
            return IsSuccess(source) || IsTrash(source);
        }

        public bool IsMenu(string ClassID)
        {
            return IsSuccess(ClassID) || IsTrash(ClassID);
        }

        public bool IsSuccess(MENUSOURCE source)
        {
            return Recipe.Descendants("recipe").
                LastOrDefault((x) =>
                x.Attribute("result_item")?.Value == source?.ClassID.ToString()) != null;
        }
        public bool IsTrash(MENUSOURCE source)
        {
            return Recipe.Descendants("recipe").
                LastOrDefault((x) =>
                x.Attribute("trash_item")?.Value == source?.ClassID.ToString()) != null;
        }

        public bool IsSuccess(string ClassID)
        {
            return Recipe.Descendants("recipe").
                LastOrDefault((x) =>
                x.Attribute("result_item")?.Value == ClassID) != null;
        }
        public bool IsTrash(string ClassID)
        {
            return Recipe.Descendants("recipe").
                LastOrDefault((x) =>
                x.Attribute("trash_item")?.Value == ClassID) != null;
        }

    }
}

using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace XmlReader.Data
{
    public class CookingRecipe
    {
        protected XDocument Recipe { private set; get; }

        public CookingRecipe()
        {
            Recipe = XDocument.Load("cookingrecipe.xml");
        }

        public CookingRecipe(string name)
        {
            Recipe = XDocument.Load(name);
        }

        public List<MENU> ReadMenus()
        {
            var Recipes = new List<MENU>();
            foreach (XElement RecipeElements in Recipe.Descendants("recipe"))
            {
                MENU re = new MENU(RecipeElements);
                re.UpdateDepth(ResultEqualToItem(re));
                Recipes.Add(re);
            }
            return Recipes;
        }

        public SortedSet<string> ReadItems()
        {
            SortedSet<string> items = new SortedSet<string>();

            var Recipes = ReadMenus();
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

        public int ResultEqualToItem(MENU menu)
        {
            var RecipeElements = Recipe.Descendants("recipe");
            var Essential = menu.Essential;
            int[] depth = new int[Essential.Count];
            int i = 0;
            foreach (var es in Essential)
            {
                var found = RecipeElements.Where(x => x.Attribute("result_item")?.Value == es.ClassID.ToString());
                if (found.Count() != 0)
                {
                    MENU m = new MENU(found.First());
                    depth[i] = 1 + ResultEqualToItem(m);
                }
                else
                {
                    depth[i] = 1;
                }
                i++;
            }
            return depth.Sum();
        }

    }
}

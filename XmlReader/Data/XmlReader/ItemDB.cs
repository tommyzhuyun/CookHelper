using System.Collections.Generic;
using System.Xml.Linq;

namespace CookHelper.Data
{
    public class ItemDB
    {
        private readonly XDocument Itemdb;

        private readonly Dictionary<string, ITEM> Mabi_Item;

        public ItemDB() : this("itemdb.xml")
        { }

        public ItemDB(string filename)
        {
            Itemdb = XDocument.Load(filename);
            Mabi_Item = ReadItemDB();
        }

        private Dictionary<string, ITEM> ReadItemDB()
        {
            var Items = new Dictionary<string, ITEM>();
            foreach (var RecipeElements in Itemdb.Descendants("Mabi_Item"))
            {
                ITEM item = new ITEM(RecipeElements);
                Items[item.ClassID] = item;
            }
            return Items;
        }

        public List<ITEM> ReadItemDBFromRecipe(List<MENU> menus)
        {
            var Items = new List<ITEM>();
            foreach (var menu in menus)
            {
                var item = ReadItemDBFromID(menu.SuccessID);
                if (item != null)
                    Items.Add(item);
                var trash = ReadItemDBFromID(menu.TrashID);
                if (trash != null)
                    Items.Add(trash);
            }
            Items.RemoveAll(x => x == null);
            return Items;
        }

        public SortedSet<string> ReadItemDBFromSet(SortedSet<string> index)
        {
            var items = new SortedSet<string>();

            foreach (string i in index)
            {
                ITEM item = ReadItemDBFromID(i);
                if (item != null)
                {
                    items.Add(item.NameID);
                    items.Add(item.DescID);
                }
            }
            items.Remove(null);
            items.Remove("");
            return items;
        }


        public ITEM ReadItemDBFromID(int ID)
        {
            return ReadItemDBFromID(ID.ToString());
        }

        public ITEM ReadItemDBFromID(string ID)
        {
            if (Mabi_Item.TryGetValue(ID, out ITEM item))
                return item;
            else
                return null;
        }


    }
}

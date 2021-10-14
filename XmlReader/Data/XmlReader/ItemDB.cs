using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace CookHelper.Data
{
    public class ItemDB
    {
        public XDocument Itemdb { private set; get; }

        public readonly IEnumerable<XElement> Mabi_Item;

        public ItemDB()
        {
            Itemdb = XDocument.Load("itemdb.xml");
            Mabi_Item = Itemdb.Descendants("Mabi_Item");
        }

        public ItemDB(string filename)
        {
            Itemdb = XDocument.Load(filename);
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
            Items.RemoveAll(x=>x == null);
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
            var item = Itemdb.Descendants("Mabi_Item").LastOrDefault(x => x.Attribute("ID")?.Value == ID);
            if (item != null)
                return new ITEM(item);
            else
                return null;

        }


        public List<ITEM> ReadItemDB()
        {
            var Items = new List<ITEM>();
            foreach (var RecipeElements in Itemdb.Descendants("Mabi_Item"))
            {
                Items.Add(new ITEM(RecipeElements));
            }
            Items.RemoveAll(x=>x == null);
            return Items;
        }
    }
}

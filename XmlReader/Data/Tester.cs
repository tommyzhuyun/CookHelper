using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace XmlReader.Data
{
    class Tester
    {

        public static void Shop()
        {
            var Shop = XDocument.Load("Shop.xml");
            var Item = Shop.Descendants("Item");
            var ItemDBs = new Dictionary<string, string>();
            var DBs = File.ReadAllLines("Items.csv");
            foreach (var d in DBs)
            {
                var split = d.Split(':');
                ItemDBs.Add(split[0], split[1]);
            }

            foreach (var it in Item)
            {
                var ClassID = it.Attribute("ClassID");
                var Name = it.Attribute("Name");
                if (ClassID.Value.Length == 0)
                {
                    var find = ItemDBs.FirstOrDefault((i) => i.Value == Name.Value).Key;
                    //Console.WriteLine(find);
                    it.SetAttributeValue("ClassID", find);
                }

            }
            Shop.Save("Shop2.xml");

        }


        public static void Items()
        {
            var recipe = new CookingRecipe();
            var items = recipe.ReadItems();
            var itemdb = new ItemDB();
            var set = itemdb.ReadItemDBFromSet(items);

            var db = new ItemDBChina(set);

            string func(int x)
            {
                ITEM ID = itemdb.ReadItemDBFromID(x);
                if (ID != null)
                {
                    var id = ID.Name(db);
                    return id;
                }
                else
                {
                    //Console.WriteLine("ClassID:" + x);
                    return "NAN";
                }
            }

            Encoding enc = Encoding.GetEncoding("utf-16");
            StreamWriter writer = new StreamWriter(@"./Items.csv", false, enc);
            foreach (var m in items)
            {
                //Console.WriteLine(m.Depth);
                //if (menus.FindAll((x) => x.SuccessID == m || x.TrashID == m).Count == 0)
                writer.WriteLine(m.ToString() + ":" + func(m));
            }
            writer.Close();
        }


        public static void Depth()
        {
            var recipe = new CookingRecipe();
            var menus = recipe.ReadMenus();

            var itemdb = new ItemDB();
            var db = new ItemDBChina();
            string func(int x)
            {
                ITEM ID = itemdb.ReadItemDBFromID(x);
                if (ID != null)
                {
                    var id = ID.Name(db);
                    return id;
                }
                else
                {
                    Console.WriteLine("ClassID:" + x);
                    return "NAN";
                }

            }
            string mfc(List<MENUSOURCE> m)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var menu in m)
                {
                    sb.Append(func(menu.ClassID) + ",");
                }
                return sb.ToString();
            }


            Encoding enc = Encoding.GetEncoding("utf-16");
            StreamWriter writer = new StreamWriter(@"./test.csv", false, enc);
            foreach (var m in menus)
            {
                var ess = m.Essential;
                var add = m.Additional;
                //Console.WriteLine(m.Depth);
                writer.WriteLine(m.Depth + "," +
                    func(m.SuccessID) + ","
                    + mfc(ess));
            }
            writer.Close();
        }


        public static void Source()
        {
            var recipe = new CookingRecipe();
            var menus = recipe.ReadMenus();

            var itemdb = new ItemDB();
            var db = new ItemDBChina();
            string func(int x)
            {
                ITEM ID = itemdb.ReadItemDBFromID(x);
                var id = ID.Name(db);
                return id;
            }

            Encoding enc = Encoding.GetEncoding("utf-16");
            StreamWriter writer = new StreamWriter(@"./test.csv", false, enc);
            foreach (var m in menus)
            {
                var ess = m.Essential;
                var add = m.Additional;
                if (ess.Count >= 3 && add.Count > 0)
                {
                    var success = func(m.SuccessID);

                    writer.WriteLine(success + ","
                        + MENUSOURCE.ToString(ess, func) + ","
                        + MENUSOURCE.ToString(add, func));
                }
            }
            writer.Close();
        }


        public static void Effect()
        {
            var recipe = new CookingRecipe();
            var itemdb = new ItemDB();
            var item = itemdb.ReadItemDBFromRecipe(recipe.ReadMenus());
            var db = new ItemDBChina();
            Encoding enc = Encoding.GetEncoding("utf-16");
            StreamWriter writer = new StreamWriter(@"./test.txt", false, enc);


            foreach (var i in item)
            {
                var xml = i.FoodEffect;
                if (xml != null)
                {
                    //Console.WriteLine(i.FoodEffectXml);
                    writer.WriteLine(i.Name(db) + " " + xml);
                }
                else
                {
                    writer.WriteLine(i.Name(db) + " NAN");
                }

            }
            writer.Close();
        }
    }
}

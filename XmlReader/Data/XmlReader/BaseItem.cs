using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CookHelper.Data
{
    public class BaseItem
    {
        public readonly XDocument Shopper;
        public readonly XDocument Skiller;
        public readonly XDocument Mission;
        public BaseItem():this("Shop.xml", "Mission.xml", "Skill.xml")
        {        }

        public BaseItem(string filename1, string filename2, string filename3)
        {
            Shopper = XDocument.Load(filename1);
            Mission = XDocument.Load(filename2);
            Skiller = XDocument.Load(filename3);
            
        }

        public bool HasItem(String ID)
        {
            var a1 = Shopper.Descendants("Shops").Elements("Item").Count(x => x.Attribute("ResultID")?.Value == ID);
            if (a1 > 0)
                return true;
           
            var a2 = Mission.Descendants("Missions").Elements("Item").Count(x => x.Attribute("ResultID")?.Value == ID);
            if (a2 > 0)
                return true;

            var a3 = Skiller.Descendants("Skills").Elements("Item").Count(x => x.Attribute("ResultID")?.Value == ID);
            if (a3 > 0)
                return true;

            return false;
        }

        public bool ItemCanBuy(string ID)
        {
            var a1 = Shopper.Descendants("Shops").Elements("Item").Count(x => x.Attribute("ResultID")?.Value == ID);
            if (a1 > 0)
                return true;
            else
                return false;
        }

        public bool ItemCanMission(string ID)
        {
            var a2 = Mission.Descendants("Missions").Elements("Item").Count(x => x.Attribute("ResultID")?.Value == ID);
            if (a2 > 0)
                return true;
            else
                return false;
        }
        public bool ItemCanSkill(string ID)
        {
            var a3 = Skiller.Descendants("Skills").Elements("Item").Count(x => x.Attribute("ResultID")?.Value == ID);
            if (a3 > 0)
                return true;
            else
                return false;
        }
        

        public List<GETITEM> ItemCouldBuy(string ID)
        {
            return ItemInSide(Shopper.Descendants("Shops"), ID);
        }

        public List<GETITEM> ItemCouldSkill(string ID)
        {
            return ItemInSide(Skiller.Descendants("Skills"), ID);
        }

        public List<GETITEM> ItemCouldMission(string ID)
        {
            return ItemInSide(Mission.Descendants("Missions"), ID);
        }

        private List<GETITEM> ItemInSide(IEnumerable<XElement> descend, string ID)
        {
            List<GETITEM> key = new List<GETITEM>();

            foreach (var Info in descend)
            {
                var t = Info.Elements("Item").Where(x => x.Attribute("ResultID")?.Value == ID);
                if(t.Count()>0)
                    key.Add(new GETITEM(Info));
            }
            return key;
        }



        public static void UpdateXml()
        {
            XDocument shopper = XDocument.Load("Shop.xml");
            Manager manager = new Manager();
            List<ITEM> ITEMList = manager.itemdb.ReadItemDB();
            var shop = shopper.Element("Shopper");
            var Item = shopper.Descendants("Item");
            foreach (var it in Item)
            {
                var ClassID = it.Attribute("ClassID");
                var Name = it.Attribute("Name");
                if (ClassID?.Value == "50134" || ClassID?.Value == "50004")
                    continue;

                var db = manager.db.FindID(Name.Value);
                string desc = manager.db.FindDesc(32828);

                List<ITEM> found = new List<ITEM>();
                if (db.Count == 1)
                {
                    var c = ITEMList.LastOrDefault(x => x.NameID == db[0]);
                    if(c!=null)
                        found.Add(c);
                }
                else if (db.Count > 1)
                {
                    foreach (var d in db)
                    {
                        ITEM a = ITEMList.LastOrDefault(x => x.NameID == d);
                        if (a != null)
                        {
                            found.Add(a);
                            break;
                        }
                    }
                }

                if (found.Count == 0)
                {
                    Console.WriteLine("Not Found: " + ClassID.Value + " : " + Name.Value);
                } 
                else 
                {
                    foreach (var f in found)
                    {
                        if (ClassID?.Value != f?.ClassID.ToString())
                        {
                            Console.WriteLine("Check：" + ClassID?.Value + " <> " + f.ClassID.ToString() + " " + Name.Value);
                            string line = Console.ReadLine();
                            if (line == "y")
                                ClassID.Value = f.ClassID.ToString();
                        }
                    }
                }
            }
            Console.WriteLine("Press y To save");
            string save = Console.ReadLine();
            if (save == "y")
                shopper.Save("Shop2.xml");
        }


    }
}

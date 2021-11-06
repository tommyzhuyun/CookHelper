using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace CookHelper.Data
{
    public class BaseItem
    {
        public readonly XDocument Shopper;
        public readonly XDocument Skiller;
        public readonly XDocument Mission;
        public BaseItem() : this("Shop.xml", "Mission.xml", "Skill.xml")
        { }

        public BaseItem(string Shopper, string Skiller, string Mission)
        {
            this.Shopper = XDocument.Load(Shopper);
            this.Mission = XDocument.Load(Skiller);
            this.Skiller = XDocument.Load(Mission);
        }

        public bool HasItem(String ID)
        {
            var a1 = Shopper.Descendants("Shops").Elements("Item").FirstOrDefault(x => x.Attribute("ResultID")?.Value == ID);
            if (a1 != null)
                return true;

            var a2 = Mission.Descendants("Missions").Elements("Item").FirstOrDefault(x => x.Attribute("ResultID")?.Value == ID);
            if (a2 != null)
                return true;

            var a3 = Skiller.Descendants("Skills").Elements("Item").FirstOrDefault(x => x.Attribute("ResultID")?.Value == ID);
            if (a3 != null)
                return true;

            return false;
        }

        public bool ItemCanBuy(string ID)
        {
            var a1 = Shopper.Descendants("Shops").Elements("Item").FirstOrDefault(x => x.Attribute("ResultID")?.Value == ID);
            if (a1 != null)
                return true;
            else
                return false;
        }

        public bool ItemCanMission(string ID)
        {
            var a2 = Mission.Descendants("Missions").Elements("Item").FirstOrDefault(x => x.Attribute("ResultID")?.Value == ID);
            if (a2 != null)
                return true;
            else
                return false;
        }
        public bool ItemCanSkill(string ID)
        {
            var a3 = Skiller.Descendants("Skills").Elements("Item").FirstOrDefault(x => x.Attribute("ResultID")?.Value == ID);
            if (a3 != null)
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
                if (t.Count() > 0)
                    key.Add(new GETITEM(Info));
            }
            return key;
        }
    }
}

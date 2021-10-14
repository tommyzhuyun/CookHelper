using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CookHelper.Data
{
    public class GETITEM : XmlBase
    {
        public GETITEM(XElement x) : base(x) 
        {         }

        public string Info
        {
            get
            {
                return GetAttributeValue("Info");
            }
        }

        public string NPC
        {
            get
            {
                return GetAttributeValue("NPC");
            }
        }

        public string SkillName
        {
            get
            {
                return GetAttributeValue("SkillName");
            }
        }

        public override string ToString()
        {
            return Info + " - "  + NPC + "" + SkillName ;
        }

        protected IEnumerable<XElement> Items
        {
            get
            {
                return XElement.Elements("Item");
            }
        }

        public List<RESULTITEM> Item
        {
            get
            {
                List<RESULTITEM> res = new List<RESULTITEM>();
                foreach(var i in Items)
                {
                    res.Add(new RESULTITEM(i));
                }
                return res;
            }
        }


        public RESULTITEM ITEM(string ClassID)
        {
            return new RESULTITEM(Items.FirstOrDefault(x => x.Attribute("ResultID")?.Value == ClassID));

        }

        public int HasItemID(string ClassID)
        {
            return Items.Count(x => x.Attribute("ResultID")?.Value == ClassID);

        }

        public int HasItemName(string Name)
        {
            return Items.Count(x => x.Attribute("ResultName")?.Value == Name);
        }

    }
}

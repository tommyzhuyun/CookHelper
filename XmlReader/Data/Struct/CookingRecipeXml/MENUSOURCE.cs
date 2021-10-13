using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace XmlReader.Data
{
    public class MENUSOURCE : XmlBase
    {
        public MENUSOURCE(XElement recipe) : base(recipe)
        { }


        public string ClassID
        {
            get
            {
                return GetAttributeValue("item_id");
            }
        }
        public int ClassIDInt
        {
            get
            {
                return StringToId(ClassID);
            }
        }
        public string Amount
        {
            get
            {
                return GetAttributeValue("amount");
            }
        }

        public int AmountInt
        {
            get
            {
                return FromNumber(Amount);
            }
        }

        public string Min
        {
            get
            {
                return GetAttributeValue("quality_min");
            }
        }

        public int MinInt
        {
            get
            {
                return FromNumber(Min);
            }
        }
        public string Max
        {
            get
            {
                return GetAttributeValue("quality_max");
            }
        }

        public int MaxInt
        {
            get
            {
                return FromNumber(Max);
            }
        }

        public bool GetDepthFlag(List<MENU> menu)
        {
            var found = menu.FindAll((x) => x.SuccessID == ClassID);
            return found.Count != 0;
        }


        override
        public string ToString()
        {
            return $"{ClassID},{Amount},[{Min}-{Max}]";
        }

        public string ToString(Func<string, string> func)
        {
            return $"{func(ClassID)},{Amount},[{Min}-{Max}]";
        }

        public static string ToString(List<MENUSOURCE> ms)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var m in ms)
            {
                sb.Append(m);
                sb.Append(",");
            }
            return sb.ToString();
        }

        public static string ToString(List<MENUSOURCE> ms, Func<string, string> func)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var m in ms)
            {
                sb.Append(m.ToString(func));
                sb.Append(",");
            }
            return sb.ToString();
        }

    }
}

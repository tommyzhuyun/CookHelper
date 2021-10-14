using System;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace CookHelper.Data
{
    public class XmlBase
    {
        protected XElement XElement { private set; get; }

        protected XmlBase(XElement item)
        {
            this.XElement = item;
        }

        protected int StringToId(string value)
        {
            return FromNumber(MatchNum(value));
        }

        protected int FromNumber(string value)
        {
            if (value == null || value == "")
                return 0;
            try
            {
                return int.Parse(value);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        protected string MatchNum(string value)
        {
            string match = null;
            if (value != null)
                match = Regex.Match(value, @"\d+").Value;
            return match;
        }

        protected string GetAttributeValue(string Name)
        {
            var Att = XElement.Attribute(Name);
            if (Att != null)
            {
                return Att.Value;
            }
            else
            {
                return null;
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace XmlReader.Data
{
    public class BUFFER : XmlBase
    {
        public BUFFER(XElement Xml_FoodEffect):base(Xml_FoodEffect)
        {        }

        public static BUFFER FormXmlString(string xml)
        {
            try
            {
                XDocument Food_effect = XDocument.Parse(xml);
                var element = Food_effect.Element("buffer");
                if (element != null)
                    return new BUFFER(element);
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string Duration_Sec
        {
            get
            {
                return MatchNum(GetAttributeValue("duration_sec"));
            }
        }

        public int Duration_SecInt
        {
            get
            {
                return FromNumber(GetAttributeValue("duration_sec"));
            }
        }

        public List<EFFECT> Effects
        {
            get
            {
                List<EFFECT> es = new List<EFFECT>();
                var effects = XElement.Elements("effect");
                foreach(var e in effects)
                {
                    EFFECT effect = new EFFECT(e);
                    es.Add(effect);
                }
                es.RemoveAll(x=>x == null);
                return es;
            }
        } 

        override
        public string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("持续时间:");
            builder.Append(Duration_Sec);
            foreach(var effect in Effects)
            {
                builder.Append(", ");
                builder.Append(effect);
            }
            return builder.ToString();
        }
    }
}
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace CookHelper.Data
{
    public class ITEM : XmlBase
    {
        public ITEM(XElement item) : base(item)
        { }

        public string ClassID
        {
            get
            {
                return MatchNum(GetAttributeValue("ID"));
            }
        }

        public int ClassIDInt
        {
            get
            {
                return FromNumber(GetAttributeValue("ID"));
            }
        }

        public string TextName
        {
            get
            {
                return GetAttributeValue("Text_Name0");
            }
        }

        public string NameID
        {
            get
            {
                return MatchNum(GetAttributeValue("Text_Name1"));
            }
        }

        public int NameIDInt
        {
            get
            {
                return FromNumber(NameID);
            }
        }

        public string GetName(ItemDBChina itemDBChina)
        {
            if (itemDBChina != null)
                return itemDBChina.FindDesc(NameID);
            else
                return "";
        }

        public string DescID
        {
            get
            {
                return MatchNum(GetAttributeValue("Text_Desc1"));
            }
        }

        public int DescIDInt
        {
            get
            {
                return FromNumber(DescID);
            }
        }

        public string GetDesc(ItemDBChina itemDBChina)
        {
            if (itemDBChina != null)
                return itemDBChina.FindDesc(DescID);
            else
                return "";
        }

        public string FileImage
        {
            get
            {
                return GetAttributeValue("File_InvImage");
            }
        }

        /// <summary>
        /// 饱腹值
        /// </summary>
        public string Amount
        {
            get
            {
                return GetAttributeValue("Food_Amount");
            }
        }

        /// <summary>
        /// 饱腹值
        /// </summary>
        public int AmountInt
        {
            get
            {
                return FromNumber(GetAttributeValue("Food_Amount"));
            }
        }

        /// <summary>
        /// 体重
        /// </summary>
        public int Fatness
        {
            get
            {
                return FromNumber(GetAttributeValue("Food_Fatness"));
            }
        }

        /// <summary>
        /// 上身
        /// </summary>
        public int Upper
        {
            get
            {
                return FromNumber(GetAttributeValue("Food_Upper"));
            }
        }

        /// <summary>
        /// 下身
        /// </summary>
        public int Lower
        {
            get
            {
                return FromNumber(GetAttributeValue("Food_Lower"));
            }
        }

        public int Price_Buy
        {
            get
            {
                return FromNumber(GetAttributeValue("Price_Buy"));
            }
        }

        public BUFFER FoodEffect
        {
            get
            {
                if (FoodEffectXml != null) 
                    return BUFFER.FormXmlString(FoodEffectXml);
                else
                    return null;
            }
        }

        public string FoodEffectXml
        {
            get
            {
                var xml = GetAttributeValue("FoodEffectXML");

                if (xml != null)
                {
                    var match = Regex.Match(xml, "<buffer.*?buffer>");
                    if (match.Success)
                        return match.Value.Replace("\\n", "\n");
                    else
                        return null;
                }
                else
                    return null;
            }
        }


    }
}

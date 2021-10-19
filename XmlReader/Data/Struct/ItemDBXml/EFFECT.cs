using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CookHelper.Data
{
    public class EFFECT : XmlBase
    {
        public EFFECT(XElement effect) : base(effect)
        {        }

        public string Param
        {
            get
            {
                return GetAttributeValue("param");
            }
        }

        public string Name
        {
            get
            {
                try
                {
                    return ParamAndName[Param];
                }
                catch (Exception)
                {
                    return "未知效果";
                }
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

        public override string ToString()
        {
            return Name + " : " + Amount;
        }

        /// <summary>
        /// 最大生命值, 最大魔法值.....魔法保护
        /// </summary>
        public static Dictionary<string, string> ParamAndName = new Dictionary<string, string>
        {
            { "lifemax", "最大生命值" },
            { "manamax", "最大魔法值" },
            { "staminamax", "最大体力值" },
            { "str", "力量" },
            { "int", "智力" },
            { "dex", "敏捷" },
            { "will", "意志" },
            { "luck", "幸运" },
            { "attackmax", "最大攻击力" },
            { "attackmin", "最小攻击力" },
            { "defense", "防御" },
            { "defence", "防御" },
            { "protect", "保护" },
            { "magic_attack", "魔法攻击力" },
            { "magic_defense", "魔法防御力" },
            { "magic_protect", "魔法保护" }
        };

        /// <summary>
        /// 最大生命值, 最大魔法值.....魔法保护
        /// </summary>
        public static List<string> NameList = new List<string>
        {
            "最大生命值" ,
            "最大魔法值" ,
            "最大体力值" ,
            "力量" ,
            "智力" ,
            "敏捷" ,
            "意志" ,
            "幸运" ,
            "最大攻击力" ,
            "最小攻击力" ,
            "防御" ,
            "保护" ,
            "魔法攻击力" ,
            "魔法防御力" ,
            "魔法保护" 
        };
    }
}

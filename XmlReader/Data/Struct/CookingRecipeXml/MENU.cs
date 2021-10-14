using System.Collections.Generic;
using System.Xml.Linq;

namespace CookHelper.Data
{
    public class MENU : XmlBase
    {
        public MENU(XElement recipe) : base(recipe)
        {
            Depth = 0;
        }

        public int Depth { private set; get; }

        public void UpdateDepth(int depth)
        {
            Depth = depth;
        }

        public string Action
        {
            get
            {
                return GetAttributeValue("action");
            }
        }

        public string ActionName
        {
            get
            {
                return ActionAndName[Action];
            }
        }

        /// <summary>
        /// 最大生命值, 最大魔法值.....魔法保护
        /// </summary>
        public static Dictionary<string, string> ActionAndName = new Dictionary<string, string>
        {
            { "mix", "混合" },
            { "cook_with_strong_fire", "煎(火)" },
            { "steam", "煮(火)" },
            { "boil", "烧(火)" },
            { "fry_with_much_oil", "炸(火)" },
            { "fry", "炒(火)" },
            { "knead", "和面" },
            { "make_noodle", "做面条" },
            { "make_pasta", "制作意大利面" },
            { "make_jam", "制做果酱(火)" },
            { "make_pie", "制做派" },
            { "steamed_dish", "蒸煮(火)" },
            { "make_pizza", "制作披萨" },
            { "ferment", "发酵" },
            { "sousvide", "水浴法(火)" },
            { "fillet", "切片" }
        };


        public string MenuID
        {
            get
            {
                return MatchNum(GetAttributeValue("localname"));
            }
        }

        public int MenuIDInt
        {
            get
            {
                return StringToId(MenuID);
            }
        }

        public string SuccessID
        {
            get
            {
                return GetAttributeValue("result_item");
            }
        }

        public int SuccessIDInt
        {
            get
            {
                return StringToId(SuccessID);
            }
        }

        public bool IsSuccess(string ClassID)
        {
            return SuccessID == ClassID;
        }

        public bool IsSuccess(int ClassID)
        {
            return SuccessIDInt == ClassID;
        }

        public bool IsTrash(string ClassID)
        {
            return TrashID == ClassID;
        }

        public bool IsTrash(int ClassID)
        {
            return TrashIDInt == ClassID;
        }

        public string TrashID
        {
            get
            {
                return GetAttributeValue("trash_item");
            }
        }

        public int TrashIDInt
        {
            get
            {
                return StringToId(TrashID);
            }
        }

        public string Exp
        {
            get
            {
                return GetAttributeValue("cookexp");
            }
        }

        public string Bundle
        {
            get
            {
                return GetAttributeValue("result_bundle");
            }
        }

        public string Difficulty
        {
            get
            {
                return GetAttributeValue("difficulty");
            }
        }

        public string Event
        {
            get
            {
                return GetAttributeValue("event");
            }
        }

        public string Locale
        {
            get
            {
                return GetAttributeValue("locale");
            }
        }

        public List<MENUSOURCE> Essential
        {
            get
            {
                List<MENUSOURCE> rs = new List<MENUSOURCE>();
                foreach (var essential in XElement.Elements("essential"))
                {
                    foreach (var source in essential.Elements("source"))
                    {
                        rs.Add(new MENUSOURCE(source));
                    }
                }
                return rs;
            }
        }

        public List<MENUSOURCE> Additional
        {
            get
            {
                List<MENUSOURCE> rs = new List<MENUSOURCE>();
                foreach (var additional in XElement.Elements("additional"))
                {
                    foreach (var source in additional.Elements("source"))
                    {
                        rs.Add(new MENUSOURCE(source));
                    }
                }
                return rs;
            }
        }
    }
}

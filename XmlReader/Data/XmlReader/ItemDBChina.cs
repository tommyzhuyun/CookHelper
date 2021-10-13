using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace XmlReader.Data
{
    public class ItemDBChina
    {
        private readonly Dictionary<string, string> ItemDBs;

        public ItemDBChina() : this("itemdb.china.txt")
        { }

        public ItemDBChina(SortedSet<int> st) : this("itemdb.china.txt", st)
        { }

        public ItemDBChina(string filename, SortedSet<int> st)
        {
            ItemDBs = new Dictionary<string, string>();
            var DBs = File.ReadAllLines(filename);
            foreach (var d in DBs)
            {
                var split = d.Split('\t');
                try
                {
                    if (st.Contains(int.Parse(split[0])))
                        ItemDBs.Add(split[0], split[1]);
                }
                catch (Exception) { }
            }
        }

        public ItemDBChina(string filename)
        {
            ItemDBs = new Dictionary<string, string>();
            var DBs = File.ReadAllLines(filename);
            foreach (var d in DBs)
            {
                var split = d.Split('\t');
                ItemDBs.Add(split[0], split[1]);
            }
        }
        /// <summary>
        /// 通过ID查询翻译描述
        /// </summary>
        /// <param name="NameId">ID字符</param>
        /// <returns>返回查询到的描述，异常时返回: NAN</returns>
        public string FindDesc(int NameId)
        {
            return FindDesc(NameId.ToString());
        }

        /// <summary>
        /// 通过ID查询翻译描述
        /// </summary>
        /// <param name="NameId">ID字符</param>
        /// <returns>返回查询到的描述，异常时返回: NAN</returns>
        public string FindDesc(string NameId)
        {
            if (ItemDBs.ContainsKey(NameId))
                return ItemDBs[NameId];
            else
                return "NAN";
        }


        /// <summary>
        /// 返回查询到的ID
        /// </summary>
        /// <param name="Desc">被查询的右侧中文等字符</param>
        /// <returns>返回ID，异常时返回: -1</returns>
        public List<string> FindID(string Desc)
        {
            List<string> list = new List<string>();
            if (ItemDBs.ContainsValue(Desc))
            {
                var find =  ItemDBs.Where(c => c.Value == Desc);
                foreach(var c in find)
                {
                    list.Add(c.Key);
                }
            }
            return list;
        }

    }
}

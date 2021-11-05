using System.Collections.Generic;
using System.Xml.Linq;

namespace CookHelper.Data
{
    public class RESULTITEM : XmlBase
    {
        public RESULTITEM(XElement x) : base(x)
        { }

        public string ClassID
        {
            get
            {
                return GetAttributeValue("ResultID");
            }
        }

        public int ClassIDInt
        {
            get
            {
                return FromNumber(ClassID);
            }
        }

        public string Name
        {
            get
            {
                return GetAttributeValue("ResultName");
            }
        }

        public string ExtraInfo
        {
            get
            {
                return GetAttributeValue("ExtraInfo");
            }
        }

        public List<SOURCEITEM> SourceItem
        {
            get
            {
                List<SOURCEITEM> source = new List<SOURCEITEM>();
                var eles = this.XElement.Elements("Source");
                foreach (var e in eles)
                {
                    source.Add(new SOURCEITEM(e));
                }
                return source;
            }
        }

        public void Remove()
        {
            this.XElement.Remove();
        }

    }
}

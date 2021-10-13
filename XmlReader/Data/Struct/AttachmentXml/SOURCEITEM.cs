using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace XmlReader.Data
{
    public class SOURCEITEM : XmlBase
    {
        public SOURCEITEM(XElement x) : base(x)
        { }


        public string ClassID
        {
            get
            {
                return GetAttributeValue("SourceID");
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
                return GetAttributeValue("SourceName");
            }
        }

        public string ExtraInfo
        {
            get
            {
                return GetAttributeValue("ExtraInfo");
            }
        }


    }
}

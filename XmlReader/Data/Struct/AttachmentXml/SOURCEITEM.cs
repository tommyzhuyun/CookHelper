﻿using System.Xml.Linq;

namespace CookHelper.Data
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

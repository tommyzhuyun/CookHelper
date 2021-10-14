using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CookHelper.Data
{
    public class FavoriteManager
    {
        private XDocument favorite;
        public event EventHandler ItemAdded;
        public FavoriteManager(string filename)
        {
            favorite = XDocument.Load(filename);
        }
        private FavoriteManager(XDocument favorite)
        {
            this.favorite = favorite;
        }

        public static FavoriteManager Create()
        {
            XDocument doc =
                new XDocument(
                new XElement("Favorite")
                );
            return new FavoriteManager(doc);
        }


        public void ReLoad(string filename)
        {
            favorite = XDocument.Load(filename);
        }

        public void Save(string filename)
        {
            favorite.Save(filename);
        }

        public void AddItem(XElement resultitem)
        {
            favorite.Element("Favorite").Add(resultitem);
            ItemAdded(new RESULTITEM(resultitem), EventArgs.Empty);
        }

        public void AddItem(string ClassID, string Name)
        {
            AddItem(GetResultItem(ClassID,Name));
        }

        public void RemoveItem(RESULTITEM foodMenu)
        {
            foodMenu.Remove();
            //////----------------------------------------------
            //ItemRemoved(this, EventArgs.Empty);
        }

        public XElement GetResultItem(string ClassID,string Name)
        {
            XElement element = new XElement("ResultItem");
            element.Add(new XAttribute("ResultID", ClassID));
            element.Add(new XAttribute("ResultName", Name));
            return element;
        }

        public List<RESULTITEM> ReadItem()
        {
            List<RESULTITEM> rs = new List<RESULTITEM>();
            foreach(var c in favorite.Descendants("ResultItem"))
            {
                RESULTITEM res = new RESULTITEM(c);
                rs.Add(res);
            }

            return rs;
        }


    }
}

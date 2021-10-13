using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using XmlReader.Data;

namespace XmlReader
{

    static class Program
    {

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*int ClassID = 50118;
            Manager manager = new Manager();
            MENU menu = manager.ReadFirstRecipe(ClassID.ToString());
            ITEM item = manager.ReadItemDBFromID(ClassID.ToString());
            Sorting sorter = new Sorting(manager.ClassIDtoName(ClassID.ToString()), ClassID, false, menu, item);
            Application.Run(new MaterialForm(sorter,manager));
            */
            Application.Run(new LoadingForm());

        }

    }
}

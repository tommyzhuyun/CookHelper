using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using CookHelper.Data;

namespace CookHelper
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

            Manager manager;
            try
            {
                manager = new Manager();
            }
            catch (Exception e)
            {
                MessageBox.Show("数据库载入失败，程序无法启动：\r\n" + e.Message);
                return;
            }
            if(manager == null)
            {
                MessageBox.Show("NULL异常错误");
                return;
            }
            Application.Run(new LoadingForm(manager));
        }



    }
}

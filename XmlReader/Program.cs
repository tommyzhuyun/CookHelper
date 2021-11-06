using CookHelper.Data;
using System;
using System.Windows.Forms;

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
            catch (Exception a)
            {
                MessageBox.Show("数据库载入失败，程序无法启动：\r\n" + a.Message);
                return;
            }

            if (manager != null)
                Application.Run(new LoadingForm(manager));
        }
    }
}

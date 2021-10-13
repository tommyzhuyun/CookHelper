using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace XmlReader.AUTO
{
    public partial class ItemList : Form
    {
        public Dictionary<string, FoodMenu> FoodMenus;

        public ItemList()
        {
            InitializeComponent();
            FoodMenus = new Dictionary<string, FoodMenu>();
        }

        private void RecipeList_Load(object sender, EventArgs e)
        {
            ExamplePanel.Visible = false;
            //FoodMenu ExampleMenu = new FoodMenu(ExamplePanel, ExamplePic, ExampleCheckBox, ExampleLabel);

            //var MenuAction = CookRecipe.MenuAction();

            //LoadMenu(ExampleMenu, MenuAction);
        }
        protected void LoadMenu(FoodMenu ExampleMenu, Dictionary<string, string> Menu)
        {
            Point rect = ExamplePanel.Location;
            foreach (string ID in Menu.Keys)
            {
                Console.WriteLine(ID);
                FoodMenu fm = new FoodMenu(ExampleMenu, rect, ID);
                FoodMenus.Add(ID, fm);
                FoodMenuPanel.Controls.Add(fm.MenuPanel);
                rect = new Point(rect.X, rect.Y + ExamplePanel.Size.Height + 6);
            }
        }

        protected void RemoveMenu(string key)
        {
            FoodMenu fm = FoodMenus[key];
            FoodMenuPanel.Controls.Remove(fm.MenuPanel);
            FoodMenus.Remove(key);
            fm.Dispose();

            Point location = ExamplePanel.Location;
            foreach (FoodMenu fms in FoodMenus.Values)
            {
                fms.MenuPanel.Location = location;
                location = new Point(location.X, location.Y + ExamplePanel.Size.Height + 6);
            }
        }

        protected void RemoveAllMenu()
        {
            foreach (FoodMenu fm in FoodMenus.Values)
            {
                FoodMenuPanel.Controls.Remove(fm.MenuPanel);
                fm.Dispose();
            }
            FoodMenus.Clear();
        }
    }


    public class FoodMenu : IDisposable
    {
        public readonly Panel MenuPanel;
        public readonly PictureBox MenuPic;
        public readonly CheckBox MenuCheck;
        public readonly TextBox MenuLabel;

        public void Dispose()
        {
            MenuPanel.Dispose();
            MenuPic.Dispose();
            MenuCheck.Dispose();
            MenuLabel.Dispose();
        }

        public FoodMenu(Panel ExamplePanel, PictureBox ExamplePic, CheckBox ExampleCheck, TextBox ExampleLabel)
        {
            MenuPanel = ExamplePanel;
            MenuPic = ExamplePic;
            MenuCheck = ExampleCheck;
            MenuLabel = ExampleLabel;
        }

        public FoodMenu(FoodMenu Example, Point location, string ID)
        {
            MenuPanel = new Panel();

            MenuPic = new PictureBox
            {
                Location = Example.MenuPic.Location,
                BackColor = Example.MenuPic.BackColor,
                Size = Example.MenuPic.Size,
                TabStop = false,
                Name = ID,
            };
            MenuCheck = new CheckBox
            {
                AutoSize = true,
                Location = Example.MenuCheck.Location,
                Size = Example.MenuCheck.Size,
                UseVisualStyleBackColor = true,
                TabStop = false,
                Name = ID,
            };
            MenuLabel = new TextBox
            {
                AutoSize = true,
                Font = Example.MenuLabel.Font,
                Location = Example.MenuLabel.Location,
                Size = Example.MenuLabel.Size,
                TabStop = false,
                Name = ID,
                Text = ID,
            };

            MenuPanel.Controls.Add(MenuPic);
            MenuPanel.Controls.Add(MenuCheck);
            MenuPanel.Controls.Add(MenuLabel);

            MenuPanel.BackColor = Example.MenuPanel.BackColor;
            MenuPanel.Location = location;
            MenuPanel.Name = ID;
            MenuPanel.Size = Example.MenuPanel.Size;
            MenuPanel.TabStop = false;
            MenuPanel.Visible = true;
        }
    }
}

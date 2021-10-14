using CookHelper.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CookHelper
{
    public partial class ItemList : Form
    {
        public List<ItemListTotal> FoodMenus;
        public readonly Manager manager;
        public event EventHandler OnLine;
        public readonly ItemListTotal ExampleMenu;
        public ItemList(Manager manager)
        {
            this.manager = manager;
            InitializeComponent();
            FoodMenus = new List<ItemListTotal>();
            ExampleMenu = new ItemListTotal(ExamplePanel, ExamplePic, ExampleCheckBox, ExampleLabel);
        }

        private void RecipeList_Load(object sender, EventArgs e)
        {
            ExamplePanel.Visible = false;
        }

        protected void AddMenu(RESULTITEM Item)
        {
            ItemListTotal fm = new ItemListTotal(ExampleMenu, Location, Item);
            fm.MenuPic.Image = manager.GetImageFromId(Item.ClassID);
            FoodMenus.Add(fm);
            FoodMenuPanel.Controls.Add(fm.MenuPanel);
        }

        protected void LoadMenu(List<RESULTITEM> Item)
        {
            foreach (RESULTITEM ID in Item)
            {
                AddMenu(ID);
            }
        }

        protected void RemoveAllMenu()
        {
            while (FoodMenus.Count > 0)
            {
                ItemListTotal food = FoodMenus[0];
                FoodMenus.RemoveAt(0);
                manager.favorite.RemoveItem(food.ID);
                FoodMenuPanel.Controls.Remove(food.MenuPanel);
                food.Dispose();
            }
        }

        private void Favorite_ItemAdded(object sender, EventArgs e)
        {
            if(sender is RESULTITEM item)
            {
                AddMenu(item);
            }
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                FileName = "Favorite.xml",
                Filter = "XML文件(*.xml)|*.xml",
                InitialDirectory = "."
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                manager.Update(openFileDialog.FileName);
                if (manager.favorite != null)
                {
                    LoadInfo.Text = "载入完成";
                    manager.favorite.ItemAdded += Favorite_ItemAdded;
                    this.DialogResult = DialogResult.OK;
                    OnLine(this, EventArgs.Empty);
                    LoadMenu(manager.favorite.ReadItem());
                    ChooseAll.Enabled = true;
                    InverseChoose.Enabled = true;
                    DeleteFile.Enabled = true;
                    SaveFile.Enabled = true;
                    Statistic.Enabled = true;
                }
                else
                    LoadInfo.Text = "载入失败";
            }

        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (manager.favorite != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    FileName = "Favorite.xml",
                    Filter = "XML文件(*.xml)|*.xml",
                    InitialDirectory = System.IO.Directory.GetCurrentDirectory(),
                    Title = "请选择保存的位置",
                    RestoreDirectory = true,
                    OverwritePrompt = true,
                    CheckPathExists = true
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    manager.favorite.Save(saveFileDialog.FileName);
                    LoadInfo.Text = "保存成功";
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateFile_Click(object sender, EventArgs e)
        {
            RemoveAllMenu();
            manager.Update(FavoriteManager.Create());
            manager.favorite.ItemAdded += Favorite_ItemAdded;
            this.DialogResult = DialogResult.OK;
            OnLine(this, EventArgs.Empty);
            LoadInfo.Text = "新建";
            ChooseAll.Enabled = true;
            InverseChoose.Enabled = true;
            DeleteFile.Enabled = true;
            SaveFile.Enabled = true;
            Statistic.Enabled = true;
        }

        private void DeleteFile_Click(object sender, EventArgs e)
        {
            if (manager.favorite == null)
                return;

            var list = FoodMenus.FindAll(x => x.MenuCheck.Checked);
            foreach (var lis in list)
                FoodMenus.Remove(lis);

            while (list.Count > 0)
            {
                var item = list[0];
                list.RemoveAt(0);
                manager.favorite.RemoveItem(item.ID);
                FoodMenus.Remove(item);
                FoodMenuPanel.Controls.Remove(item.MenuPanel);
                item.Dispose();
            }

        }

        private void ChooseAll_Click(object sender, EventArgs e)
        {
            foreach(var list in FoodMenus)
            {
                list.MenuCheck.Checked = true;
            }
        }

        private void InverseChoose_Click(object sender, EventArgs e)
        {
            foreach (var list in FoodMenus)
            {
                list.MenuCheck.Checked = !list.MenuCheck.Checked;
            }
        }

        private void Statistic_Click(object sender, EventArgs e)
        {
            List<RESULTITEM> result = new List<RESULTITEM>();
            foreach (var menu in FoodMenus)
                result.Add(menu.ID);
            MaterialTotalForm materialTotalForm = new MaterialTotalForm(manager, result);
            materialTotalForm.Show();
            materialTotalForm.Location = new Point(this.Location.X, this.Bottom);
        }
    }


    public class ItemListTotal : IDisposable
    {
        public readonly Panel MenuPanel;
        public readonly PictureBox MenuPic;
        public readonly CheckBox MenuCheck;
        public readonly TextBox MenuLabel;
        public readonly RESULTITEM ID;

        public void Dispose()
        {
            MenuPanel.Dispose();
            MenuPic.Dispose();
            MenuCheck.Dispose();
            MenuLabel.Dispose();
        }

        public ItemListTotal(Panel ExamplePanel, PictureBox ExamplePic, CheckBox ExampleCheck, TextBox ExampleLabel)
        {
            MenuPanel = ExamplePanel;
            MenuPic = ExamplePic;
            MenuCheck = ExampleCheck;
            MenuLabel = ExampleLabel;
        }

        public ItemListTotal(ItemListTotal Example, Point location, RESULTITEM ID)
        {
            this.ID = ID;
            MenuPanel = new Panel();

            MenuPic = new PictureBox
            {
                Location = Example.MenuPic.Location,
                BackColor = Example.MenuPic.BackColor,
                Dock = Example.MenuPic.Dock,
                Size = Example.MenuPic.Size,
                SizeMode = Example.MenuPic.SizeMode,
                TabStop = false,
                Name = ID.Name,
            };
            MenuCheck = new CheckBox
            {
                AutoSize = true,
                Location = Example.MenuCheck.Location,
                Dock = Example.MenuCheck.Dock,
                Size = Example.MenuCheck.Size,
                UseVisualStyleBackColor = true,
                TabStop = false,
                Name = ID.Name,
            };
            MenuLabel = new TextBox
            {
                AutoSize = true,
                BorderStyle = Example.MenuLabel.BorderStyle,
                BackColor = Example.MenuLabel.BackColor,
                Dock = Example.MenuLabel.Dock,
                ReadOnly = Example.MenuLabel.ReadOnly,
                Font = Example.MenuLabel.Font,
                Location = Example.MenuLabel.Location,
                Size = Example.MenuLabel.Size,
                TabStop = false,
                Name = ID.Name,
                Text = ID.Name,
            };

            MenuPanel.Controls.Add(MenuPic);
            MenuPanel.Controls.Add(MenuCheck);
            MenuPanel.Controls.Add(MenuLabel);
            MenuPanel.Dock = Example.MenuPanel.Dock;
            MenuPanel.BackColor = Example.MenuPanel.BackColor;
            MenuPanel.BorderStyle = Example.MenuPanel.BorderStyle;
            MenuPanel.Location = location;
            MenuPanel.Name = ID.Name;
            MenuPanel.Size = Example.MenuPanel.Size;
            MenuPanel.TabStop = false;
            MenuPanel.Visible = true;
        }
    }
}

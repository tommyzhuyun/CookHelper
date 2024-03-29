﻿using CookHelper.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CookHelper
{
    public partial class ItemList : Form
    {
        public List<ItemListTotal> FoodMenus;
        public List<Sorting> Sorting;
        public readonly Manager manager;
        public event EventHandler OnLine;
        public readonly ItemListTotal ExampleMenu;
        public ItemList(Manager manager)
        {
            this.manager = manager;
            InitializeComponent();
            FoodMenus = new List<ItemListTotal>();
            Sorting = new List<Sorting>();
            ExampleMenu = new ItemListTotal(ExamplePanel, ExamplePic, ExampleCheckBox, ExampleLabel);
        }

        public void UpdateSorting(List<Sorting> Sorting)
        {
            this.Sorting = Sorting;
            Statistic.Tag = true;
            Statistic.Text = "统计";
        }

        private void RecipeList_Load(object sender, EventArgs e)
        {
            ExamplePanel.Visible = false;
        }

        protected void AddMenu(RESULTITEM Item)
        {
            ItemListTotal fm = new ItemListTotal(ExampleMenu, Item);
            fm.MenuPic.Image = manager.GetImageFromId(Item.ClassID);
            fm.MenuCheck.Checked = true;
            fm.MenuCheck.CheckedChanged += MenuCheck_CheckedChanged;
            FoodMenus.Add(fm);
            FoodMenuPanel.Controls.Add(fm.MenuPanel);
        }

        private void MenuCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!OnWorking)
                StatusUp();
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
                manager.favorite.RemoveItem(food.ResultItem);
                FoodMenuPanel.Controls.Remove(food.MenuPanel);
                food.Dispose();
            }
        }

        private void Favorite_ItemAdded(object sender, EventArgs e)
        {
            if (sender is RESULTITEM item)
            {
                AddMenu(item);
                StatusUp();
            }
        }

        private void StatusUp()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (var li in EFFECT.NameList)
            {
                dictionary.Add(li, 0);
            }

            int count = 0;
            foreach (var RecipeMenu in FoodMenus)
            {
                if (RecipeMenu.MenuCheck.Checked)
                {
                    count++;
                    foreach (var Effect in manager.ReadMenuEffect(RecipeMenu.ResultItem.ClassID))
                    {
                        dictionary[Effect.Name] += Effect.AmountInt;
                    }
                }
            }

            StringBuilder sb = new StringBuilder($"庆典料理：{count}/10");

            foreach (var dic in dictionary)
            {
                if (dic.Value != 0)
                    sb.Append($"\r\n{dic.Key} {dic.Value}");
            }
            SumUp.Text = sb.ToString();
        }



        private void LoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                FileName = "Favorite.xml",
                Filter = "XML文件(*.xml)|*.xml",
                InitialDirectory = Environment.CurrentDirectory
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RemoveAllMenu();
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
                    Loading.Text = "静态";
                    FoodMenuPanel.BackColor = Color.White;
                    StatusUp();
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
            SumUp.Text = "";
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
            Loading.Text = "静态";
            FoodMenuPanel.BackColor = Color.White;
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
                manager.favorite.RemoveItem(item.ResultItem);
                FoodMenus.Remove(item);
                FoodMenuPanel.Controls.Remove(item.MenuPanel);
                item.Dispose();
            }
            StatusUp();
        }
        private bool OnWorking = false;

        private void ChooseAll_Click(object sender, EventArgs e)
        {
            OnWorking = true;
            foreach (var list in FoodMenus)
            {
                list.MenuCheck.Checked = true;
            }
            OnWorking = false;
            StatusUp();
        }

        private void InverseChoose_Click(object sender, EventArgs e)
        {
            OnWorking = true;
            foreach (var list in FoodMenus)
            {
                list.MenuCheck.Checked = !list.MenuCheck.Checked;
            }
            OnWorking = false;
            StatusUp();
        }

        private void Statistic_Click(object sender, EventArgs e)
        {
            ProgressBar.Value = 0;
            Loading.Text = "加载中.";
            Loading.Update();
            if (Sorting.Count == 0)
            {
                bool WorkDown = false;
                if (Statistic.Tag is bool boolean)
                    WorkDown = boolean;
                if (!WorkDown)
                {
                    Statistic.Enabled = false;
                    Statistic.Text = "Load.Err";
                    Loading.Text = "未知错误";
                    Loading.Update();
                }
                return;
            }
            Statistic.Enabled = false;
            DeleteFile.Enabled = false;
            LoadFile.Enabled = false;
            CreateFile.Enabled = false;
            SaveFile.Enabled = false;
            InverseChoose.Enabled = false;
            ChooseAll.Enabled = false;
            foreach (var menu in FoodMenus)
            {
                menu.MenuCheck.Enabled = false;
            }

            this.BackgroundWorker.RunWorkerAsync();
        }
        private List<Statistic> data = new List<Statistic>();

        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<Sorting> result = new List<Sorting>();
            int Count = 0, All = FoodMenus.Count;
            foreach (var menu in FoodMenus)
            {
                if (BackgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                if (menu.MenuCheck.Checked)
                {
                    var Sorting = manager.GetSorting(this.Sorting, menu.ResultItem.ClassIDInt);
                    var find = manager.GetBaseItem(Sorting);

                    foreach (var f in find)
                        result.Add(f);
                }
                Count++;
                this.BackgroundWorker.ReportProgress(Count * 95 / All);
            }
            data = manager.CountOnSorting(result);
            this.BackgroundWorker.ReportProgress(100);
        }

        private void BackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (!BackgroundWorker.CancellationPending)
                ProgressBar.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            MaterialTotalForm materialTotalForm = new MaterialTotalForm(manager, data);
            materialTotalForm.Show();
            materialTotalForm.Location = new Point(this.Location.X, this.Bottom);
            Loading.Text = "统计完成";
            this.Statistic.Enabled = true;
            Statistic.Enabled = true;
            DeleteFile.Enabled = true;
            LoadFile.Enabled = true;
            CreateFile.Enabled = true;
            SaveFile.Enabled = true;
            InverseChoose.Enabled = true;
            ChooseAll.Enabled = true;
            foreach (var menu in FoodMenus)
            {
                menu.MenuCheck.Enabled = true;
            }
        }

        private void ItemList_FormClosing(object sender, FormClosingEventArgs e)
        {
            BackgroundWorker.CancelAsync();
        }


        private void OnTop_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = OnTop.Checked;
        }
    }


    public class ItemListTotal : IDisposable
    {
        public readonly Panel MenuPanel;
        public readonly PictureBox MenuPic;
        public readonly CheckBox MenuCheck;
        public readonly TextBox MenuLabel;
        public readonly RESULTITEM ResultItem;

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

        public ItemListTotal(ItemListTotal Example, RESULTITEM ID)
        {
            this.ResultItem = ID;
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
                Dock = Example.MenuCheck.Dock,
                Location = Example.MenuCheck.Location,
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
            //MenuPanel.Location = location;
            MenuPanel.Name = ID.Name;
            MenuPanel.Size = Example.MenuPanel.Size;
            MenuPanel.TabStop = false;
            MenuPanel.Visible = true;
        }
    }
}

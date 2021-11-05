using CookHelper.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CookHelper
{
    public partial class LoadingForm : Form
    {
        private readonly Manager manager;
        private readonly List<Sorting> Menuer;
        private readonly HashSet<int> MenuExist;
        private RecipeSearcher recipe = null;

        public LoadingForm(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
            HighDPI.Enabled = manager.HighDPI;
            Menuer = new List<Sorting>();
            MenuExist = new HashSet<int>();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            this.BackgroundWorker.RunWorkerAsync();
        }

        private void Init(MENU menu)
        {
            int success = menu.SuccessIDInt;
            int trash = menu.TrashIDInt;

            if (success != 0 && !MenuExist.Contains(success))
            {
                ITEM item = manager.ReadItemDBFromID(success.ToString());
                string SuccName = manager.ClassIDtoName(item);
                Sorting sorting = new Sorting(SuccName, success, true, menu, item);
                Menuer.Add(sorting);
                MenuExist.Add(success);
            }

            if (trash != 0 && !MenuExist.Contains(trash))
            {
                ITEM item = manager.ReadItemDBFromID(trash.ToString());
                string trasName = manager.ClassIDtoName(item);
                Sorting sorting = new Sorting(trasName, trash, false, menu, item);
                Menuer.Add(sorting);
                MenuExist.Add(trash);
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var MENUS = manager.ReadRecipe();
            int Count = 0, All = MENUS.Count;
            foreach (var m in MENUS)
            {
                if (BackgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                Init(m);
                Count++;
                this.BackgroundWorker.ReportProgress(Count * 100 / All);
            }
            this.BackgroundWorker.ReportProgress(100);
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!BackgroundWorker.CancellationPending)
            {
                this.ProgressBar.Value = e.ProgressPercentage;
                this.ProgressBar.Invalidate();
            }
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (manager == null)
            {
                MessageBox.Show("无数据库异常");
                Application.Exit();
                return;
            }
            this.DialogResult = DialogResult.OK;
            LoadingLabel.Text = "Done.";
            SearcherButton.Enabled = true;
            SearcherButton.Text = "打开清单";
            if (list != null)
                list.UpdateSorting(Menuer);
        }


        private void Searcher_Click(object sender, EventArgs e)
        {
            recipe = new RecipeSearcher(manager, Menuer);
            SearcherButton.Enabled = false;
            //recipe.ShowInTaskbar = true;
            recipe.Show();
            recipe.FormClosed += Recipe_FormClosed;
            recipe.Location = new System.Drawing.Point(Bounds.Right, Bounds.Y);
        }

        private void Recipe_FormClosed(object sender, FormClosedEventArgs e)
        {
            SearcherButton.Enabled = true;
            this.Show();
        }
        ItemList list = null;
        private void Favorite_Click(object sender, EventArgs e)
        {
            list = new ItemList(manager);
            //list.ShowInTaskbar = true;
            list.Show();
            list.OnLine += List_OnLine;
            list.Location = new System.Drawing.Point(Bounds.Right - list.Bounds.Width, Bounds.Bottom);
            list.FormClosed += List_FormClosed;
            if (!BackgroundWorker.IsBusy)
            {
                list.UpdateSorting(Menuer);
            }
            Favorite.Enabled = false;
        }

        private void List_FormClosed(object sender, FormClosedEventArgs e)
        {
            Favorite.Enabled = true;
            this.Show();
            FileReaded.Text = "已关闭收藏夹";
            if (recipe != null)
            {
                recipe.FavoriteUpdate(false);
            }
            list = null;
        }

        private void List_OnLine(object sender, EventArgs e)
        {
            FileReaded.Text = "已加载收藏夹";
            if (recipe != null)
            {
                recipe.FavoriteUpdate(true);
            }
        }

        private void LoadingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.BackgroundWorker.CancelAsync();
        }

        private void HelpWord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", "ReadMe.txt");
        }

        private void HighDPI_CheckedChanged(object sender, EventArgs e)
        {
            manager.OnDPIWorking = HighDPI.Checked;
        }
    }
}

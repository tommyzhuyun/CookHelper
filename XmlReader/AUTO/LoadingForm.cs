using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using XmlReader.Data;

namespace XmlReader
{
   

    public partial class LoadingForm : Form
    {
        public Manager manager;
        public List<Sorting> Menuer;

        public LoadingForm()
        {
            InitializeComponent();
            this.manager = new Manager();
            Menuer = new List<Sorting>();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            this.BackgroundWorker.RunWorkerAsync();
        }


        private void Init(MENU menu)
        {
            int success = menu.SuccessIDInt;
            int trash = menu.TrashIDInt;

            if (success != 0 && !Menuer.Exists(x => x.ClassID == success)) 
            {
                ITEM item = manager.ReadItemDBFromID(menu.SuccessID);
                string SuccName = manager.ClassIDtoName(item);
                Sorting sorting = new Sorting(SuccName, success, true, menu, item);
                Menuer.Add(sorting);
            }

            if (trash != 0 && !Menuer.Exists(x => x.ClassID == trash))
            {
                ITEM item = manager.ReadItemDBFromID(menu.TrashID);
                string trasName = manager.ClassIDtoName(item);
                Sorting sorting = new Sorting(trasName, trash, false, menu, item);
                Menuer.Add(sorting);
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.BackgroundWorker.ReportProgress(1);
            var MENUS = manager.ReadRecipe();
            int Count = 10, All = MENUS.Count + 10;
            this.BackgroundWorker.ReportProgress(Count * 100 / All);
            foreach (var m in MENUS)
            {
                Init(m);
                Count++;
                this.BackgroundWorker.ReportProgress(Count * 100 / All);
            }
            this.BackgroundWorker.ReportProgress(100);
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.ProgressBar.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            LoadingLabel.Text = "Done.";
            SearcherButton.Enabled = true;
            SearcherButton.Text = "打开清单";
        }

        private void Searcher_Click(object sender, EventArgs e)
        {
            RecipeSearcher recipe = new RecipeSearcher(manager, Menuer);
            recipe.Show();
            if (AutoHide.Checked)
            {
                this.Hide();
                recipe.FormClosed += Recipe_FormClosed;
            }
        }

        private void Recipe_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Favorite_Click(object sender, EventArgs e)
        {

        }
    }
}

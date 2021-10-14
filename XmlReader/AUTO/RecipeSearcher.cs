using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CookHelper.Data;

namespace CookHelper
{
    public partial class RecipeSearcher : Form
    {
        public Manager manager;
        public List<Sorting> Menuer;
        public MenuForm MenuForm;
        public bool MenuOpened = false;

        public RecipeSearcher(Manager manager,List<Sorting> Menuer)
        {
            this.manager = manager;
            this.Menuer = Menuer;
            InitializeComponent();
            
            Technique.SelectedIndex = 0;
            Chosener.SelectedIndex = 0;
        }

        private void RecipeSearcher_Load(object sender, EventArgs e)
        {
            listBox.DataSource = Menuer;
            Ordering(Menuer);
        }

        public void FavoriteUpdate(bool enable)
        {
            FavoriteAdd.Enabled = enable;
            if (MenuForm != null)
            {
                MenuForm.FavoriteUpdate(enable);
            }
        }

        public void Ordering(List<Sorting> Searched)
        {
            if (Searched.Count == 0)
                return;

            switch (Chosener.Text)
            {
                case "全部":
                case "料理日记":
                case "失败产物":
                    Searched.Sort((a, b) => AscendingOrder.Checked ? a.ClassID - b.ClassID : b.ClassID - a.ClassID);
                    break;
                case "深度":
                    Searched.Sort((a, b) => AscendingOrder.Checked ? a.Menu.Depth - b.Menu.Depth : b.Menu.Depth - a.Menu.Depth);
                    break;
                case "上身":
                    Searched.Sort((a, b) => AscendingOrder.Checked ? a.Item.Upper - b.Item.Upper : b.Item.Upper - a.Item.Upper);
                    break;
                case "下身":
                    Searched.Sort((a, b) => AscendingOrder.Checked ? a.Item.Lower - b.Item.Lower : b.Item.Lower - a.Item.Lower);
                    break;
                case "体重":
                    Searched.Sort((a, b) => AscendingOrder.Checked ? a.Item.Fatness - b.Item.Fatness : b.Item.Fatness - a.Item.Fatness);
                    break;
                default:
                    Searched.Sort((a, b) => AscendingOrder.Checked ? a.EffectValue(Chosener.Text) - b.EffectValue(Chosener.Text) : b.EffectValue(Chosener.Text) - a.EffectValue(Chosener.Text));
                    break;
            }
        }

        public List<Sorting> Filter()
        {
            List<Sorting> Searched = Menuer;
            if (string.IsNullOrEmpty(SearchBox.Text) == false)
            {
                Searched = Searched.FindAll(x => x.Name.Contains(SearchBox.Text));
            }
            if (Technique.Text != "全部")
            {
                Searched = Searched.FindAll(x => x.Menu.ActionName == Technique.Text);
            }

            switch (Chosener.Text)
            {
                case "全部":
                case "料理日记":
                    Searched = Searched.FindAll(x => x.ClassID != 0);
                    break;
                case "失败产物":
                    Searched = Searched.FindAll(x => !x.IsSuccess);
                    break;
                case "深度":
                    Searched = Searched.FindAll(x => x.Menu.Depth != 0);
                    break;
                case "上身":
                    Searched = Searched.FindAll(x => x.Item != null && x.Item.Upper != 0);
                    break;
                case "下身":
                    Searched = Searched.FindAll(x => x.Item != null && x.Item.Lower != 0);
                    break;
                case "体重":
                    Searched = Searched.FindAll(x => x.Item != null && x.Item.Fatness != 0);
                    break;
                default:
                    Searched = Searched.FindAll(x => x.HasEffect(Chosener.Text));
                    break;
            }

            if (Searched.Count != 0)
            {
                Ordering(Searched);
                if (manager.favorite != null)
                {
                    FavoriteAdd.Enabled = true;
                }
            }
            else
            {
                Other.Text = "NAN";
                RecipeName.Text = "NAN";
                Pic.Image?.Dispose();
                Pic.Image = null;
                ChoosedNum.Text = "NAN";
                Deepth.Text = "NAN";
                MenuOpen.Enabled = false;
                FavoriteAdd.Enabled = false;
                if (MenuOpened)
                {
                    MenuOpened = false;
                    MenuForm?.Close();
                    MenuOpen.Text = "详细菜单";
                }
            }
            return Searched;
        }

        private void Closer_Click(object sender, EventArgs e)
        {
            MenuForm?.Close();
            MenuForm?.Dispose();
            Close();
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem is Sorting KV)
            {
                Other.Text = "ClassID : " + KV.ClassID.ToString();
                RecipeName.Text = KV.Name.ToString();
                Pic.Image?.Dispose();
                Pic.Image = manager.GetImageFromId(KV.ClassID);
                Pic.Refresh();
                Deepth.Text = "深度 : " + KV.Menu.Depth;

                if (Chosener.Text == "默认" || Chosener.Text == "深度")
                    ChoosedNum.Text = "未筛选";
                else
                {
                    switch (Chosener.Text)
                    {
                        case "料理日记":
                            ChoosedNum.Text = Chosener.Text;
                            break;
                        case "上身":
                            ChoosedNum.Text = Chosener.Text + " : " + KV.Item.Upper;
                            break;
                        case "下身":
                            ChoosedNum.Text = Chosener.Text + " : " + KV.Item.Lower;
                            break;
                        case "体重":
                            ChoosedNum.Text = Chosener.Text + " : " + KV.Item.Fatness;
                            break;
                        default:
                            ChoosedNum.Text = Chosener.Text + " : " + KV.EffectValue(Chosener.Text);
                            break;
                    }
                }

                MenuOpen.Enabled = true;
                if(MenuForm != null && MenuOpened)
                {
                    MenuForm.UpdateMenu(KV);
                }
            }

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            listBox.DataSource = Filter();
        }

        private void Chosener_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox.DataSource = Filter();
        }

        private void Technique_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox.DataSource = Filter();
        }

        private void AscendingOrder_CheckedChanged(object sender, EventArgs e)
        {

            listBox.DataSource = Filter();
        }


        private void MenuOpen_Click(object sender, EventArgs e)
        {
            if (MenuOpened)
            {
                MenuOpened = false;
                if (MenuForm != null)
                MenuForm.Close();
                MenuOpen.Text = "详细菜单";
            }
            else if (listBox.SelectedItem is Sorting KV)
            {
                MenuForm = new MenuForm(KV, manager,MenuOpen);
                MenuForm.FormClosed += MenuForm_FormClosed;
                MenuForm.Show();
                MenuForm.Location = new System.Drawing.Point(this.Location.X + this.Size.Width, this.Location.Y);
                MenuOpen.Text = "关闭菜单";
                MenuOpened = true;
            }

        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuOpened = false;
            MenuOpen.Text = "详细菜单";
        }

        private void FavoriteAdd_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem is Sorting KV)
            {
                manager.favorite.AddItem(KV.ClassID.ToString(), KV.Name);
            }
        }
    }
}

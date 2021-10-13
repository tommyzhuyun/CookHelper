using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using XmlReader.Data;

namespace XmlReader
{
    public partial class MenuForm :Form
    {
        public Sorting RecipeMenu;
        private readonly Manager manager;
        public readonly Control ControlOwner;
        public MenuLists menuList;
        public List<MenuLists> menuLists = new List<MenuLists>();

        public MenuForm(Sorting RecipeMenu, Manager manager, Control Owner)
        {
            this.RecipeMenu = RecipeMenu;
            this.manager = manager;
            this.ControlOwner = Owner;
            InitializeComponent();

        }

        private void InitializeForm()
        {
            this.Text = "菜单 : " + RecipeMenu.Menu.ActionName;
            RecipeName.Text = RecipeMenu.Name;
            ResultPic.Image = manager.GetImageFromId(RecipeMenu.ClassID);
            Technique.Image = manager.GetImageFromAction(RecipeMenu.Menu.ActionName);


            StringBuilder sb = new StringBuilder();
            if (RecipeMenu.Buffer != null)
                sb.Append("持续时间 : " + RecipeMenu.Buffer.Duration_Sec.ToString());
            if (RecipeMenu.Item != null)
            {
                if (RecipeMenu.Item.Fatness != 0)
                    sb.Append("\r\n体重 : " + RecipeMenu.Item.Fatness);
                if (RecipeMenu.Item.Upper != 0)
                    sb.Append("\r\n上身 : " + RecipeMenu.Item.Upper);
                if (RecipeMenu.Item.Lower != 0)
                    sb.Append("\r\n下身 : " + RecipeMenu.Item.Lower);
            }
            if (RecipeMenu.Effect != null)
            {
                foreach (var eff in RecipeMenu.Effect)
                {
                    sb.Append("\r\n" + eff);
                }
            }
            Effect.Text = sb.ToString();
        }

        private void Solution()
        {
            menuLists = new List<MenuLists>();
            var essential = RecipeMenu.Menu.Essential;
            var additional = RecipeMenu.Menu.Additional;

            MenuLists ms = new MenuLists(essential);
            menuLists.Add(ms);

            if (additional.Count > 0)
            {
                if (essential.Count == 2)
                {
                    foreach (var ad in additional)
                        menuLists.Add(new MenuLists(essential[0], essential[1], ad));
                }
                else if (essential.Count == 1)
                {
                    for (int i = 0; i < additional.Count; i++)
                        menuLists.Add(new MenuLists(essential[0], additional[i], null));

                    if (additional.Count > 1)
                        for (int i = 0; i < additional.Count; i++)
                            for (int j = i + 1; j < additional.Count; j++)
                                menuLists.Add(new MenuLists(essential[0], additional[i], additional[j]));
                }
            }
            MenuSelect.BeginUpdate();
            MenuSelect.Items.Clear();
            MenuSelect.Items.Add("方案 : 原始 " + "(共" + (menuLists.Count) + "个)");
            if (menuLists.Count > 1)
            {
                for (int i = 1; i < menuLists.Count; i++)
                {
                    MenuSelect.Items.Add("方案 : " + (i + 1));
                }
            }
            MenuSelect.EndUpdate();
        }

        
       
        private void InitialItem(int SelectIndex)
        {
            if (menuLists.Count <= SelectIndex) 
                return;
            menuList = menuLists[SelectIndex];


            double[] amount = menuList.Amount;
            if (menuList.m1 != null)
            {
                ItemFrom1.Tag = manager.GetSourceSorting(menuList.m1);
                ItemPic1.Image?.Dispose();
                ItemPic1.Image = manager.GetImageFromId(menuList.m1.ClassID);
                ItemPic1.Refresh();
                ItemText1.Text = manager.ClassIDtoName(menuList.m1.ClassID);
                if(manager.recipe.IsSuccess(menuList.m1))
                    ItemValue1.Text = Math.Round(amount[0], 1).ToString();
                else
                    ItemValue1.Text = "0/100";
            }
            if (menuList.m2 != null)
            {
                ItemFrom2.Tag = manager.GetSourceSorting(menuList.m2);
                ItemFrom2.Enabled = true;
                ItemPic2.Image?.Dispose();
                ItemPic2.Image = manager.GetImageFromId(menuList.m2.ClassID);
                ItemPic2.Refresh();
                ItemText2.Text = manager.ClassIDtoName(menuList.m2.ClassID);
                if (manager.recipe.IsSuccess(menuList.m2))
                    ItemValue2.Text = Math.Round(amount[1], 1).ToString();
                else
                    ItemValue2.Text = "0/100";
            }
            else
            {
                ItemFrom2.Tag = null;
                ItemFrom2.Enabled = false;
                ItemPic2.Image?.Dispose();
                ItemPic2.Image = null;
                ItemText2.Text = "";
                ItemValue2.Text = "";
            }
            if (menuList.m3 != null)
            {
                ItemFrom3.Tag = manager.GetSourceSorting(menuList.m3);
                ItemFrom3.Enabled = true;
                ItemPic3.Image?.Dispose();
                ItemPic3.Image = manager.GetImageFromId(menuList.m3.ClassID);
                ItemPic3.Refresh();
                ItemText3.Text = manager.ClassIDtoName(menuList.m3.ClassID);
                if (manager.recipe.IsSuccess(menuList.m3))
                    ItemValue3.Text = Math.Round(amount[2], 1).ToString();
                else
                    ItemValue3.Text = "0/100";
            }
            else
            {
                ItemFrom3.Tag = null;
                ItemFrom3.Enabled = false; 
                ItemPic3.Image?.Dispose();
                ItemPic3.Image = null;
                ItemText3.Text = "";
                ItemValue3.Text = "";
            }
        }


        public void UpdateMenu(Sorting RecipeMenu)
        {
            while (MnForm.Count > 0)
            {
                var fm = MnForm[0];
                MnForm.RemoveAt(0);
                fm?.Close();
                fm?.Dispose();
            }
            while (MtForm.Count > 0)
            {
                var fm = MtForm[0];
                MtForm.RemoveAt(0);
                fm?.Close();
                fm?.Dispose();
            }
            this.RecipeMenu = RecipeMenu;
            InitializeForm();
            Solution();
            InitialItem(0);
            MenuSelect.SelectedIndex = 0;
        }


        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            InitializeForm();
            Solution();
            InitialItem(0);
        }

        private void MenuSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitialItem(MenuSelect.SelectedIndex);
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            while (MnForm.Count > 0) 
            {
                var fm = MnForm[0];
                MnForm.RemoveAt(0);
                fm?.Close();
                fm?.Dispose();
            }
            while (MtForm.Count > 0) 
            {
                var fm = MtForm[0];
                MtForm.RemoveAt(0);
                fm?.Close();
                fm?.Dispose();
            }
        }

        private readonly List<MenuForm> MnForm = new List<MenuForm>();
        private readonly List<MaterialForm> MtForm = new List<MaterialForm>();

        private void ControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Control ControlOwner = null;
            if (sender is MaterialForm material)
            {
                ControlOwner = material.ControlOwner;
            }else if(sender is MenuForm menu)
            {
                ControlOwner = menu.ControlOwner;
            }

            if (ControlOwner != null)
                ((CheckBox)ControlOwner).Checked = false;

        }

        private void ItemCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            Sorting sorting = (Sorting)check.Tag;

            if (check.Checked)
            {
                if (sorting.IsMenu)
                {
                    MenuForm MenForm = new MenuForm(sorting, manager, check);
                    MnForm.Add(MenForm);
                    MenForm.FormClosing += ControlForm_FormClosing;
                    MenForm.Show();
                    MenForm.Location = new System.Drawing.Point(this.Location.X + this.Size.Width, this.Location.Y);
                }
                else
                {
                    MaterialForm MatForm = new MaterialForm(sorting, manager, check);
                    MtForm.Add(MatForm);
                    MatForm.FormClosing += ControlForm_FormClosing;
                    MatForm.Show();
                    MatForm.Location = new System.Drawing.Point(this.Location.X + this.Size.Width, this.Location.Y);
                }
            }
            else
            {
                if (sorting.IsMenu)
                {
                    MenuForm MenForm = MnForm.Find(x => x.ControlOwner == check);
                    if (MenForm != null)
                    {
                        MnForm.Remove(MenForm);
                        MenForm.FormClosing -= ControlForm_FormClosing;
                        MenForm?.Close();
                        MenForm?.Dispose();
                    }
                }
                else
                {
                    MaterialForm MatForm = MtForm.Find(x => x.ControlOwner == check);
                    if (MatForm != null)
                    {
                        MtForm.Remove(MatForm);
                        MatForm.FormClosing -= ControlForm_FormClosing;
                        MatForm?.Close();
                        MatForm?.Dispose();
                    }
                }
            }
        }

        /*
        Form MenuForm1, MenuForm2, MenuForm3;
        bool Form1Showed = false, Form2Showed = false, Form3Showed = false;

        private void MenuForm3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form3Showed = false;
            this.ItemFrom3.Checked = false;
        }
        private void MenuForm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2Showed = false;
            this.ItemFrom2.Checked = false;
        }
        private void MenuForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1Showed = false;
            this.ItemFrom1.Checked = false;
        }
        private void ItemFrom3_CheckedChanged(object sender, EventArgs e)
        {
            MenuLists list = menuLists[MenuSelect.SelectedIndex];
            if (ItemFrom3.Checked && list.m3 != null)
            {
                MenuForm3 = new MenuForm((Sorting)MenuForm3.Tag, manager,MenuForm3);
                MenuForm3.FormClosed += MenuForm3_FormClosed;
                MenuForm3.Show();
                MenuForm3.Location = new System.Drawing.Point(this.Location.X + this.Size.Width, this.Location.Y + 300);
                Form3Showed = true;
                
            }
            else
            {
                if (Form3Showed && MenuForm3 != null)
                {
                    MenuForm3.Close();
                    MenuForm3?.Dispose();
                    Form3Showed = false;
                }
            }
        }

        private void ItemFrom2_CheckedChanged(object sender, EventArgs e)
        {
            MenuLists list = menuLists[MenuSelect.SelectedIndex];
            if (ItemFrom2.Checked && list.m2 != null)
            {
                bool IsSuccess = manager.recipe.IsSuccess(list.m2);
                bool IsTrash = manager.recipe.IsTrash(list.m2);
                if (IsSuccess || IsTrash)
                {
                    MENU menu = manager.recipe.GetMenu(list.m2);
                    ITEM item = manager.ReadItemDBFromID(list.m2.ClassID);
                    Sorting sorter = new Sorting(manager.ClassIDtoName(list.m2.ClassID), list.m2.ClassIDInt, IsSuccess, menu, item);
                    MenuForm2 = new MenuForm(sorter, manager, ItemFrom2);
                    MenuForm2.FormClosed += MenuForm2_FormClosed;
                    MenuForm2.Show();
                    MenuForm2.Location = new System.Drawing.Point(this.Location.X + this.Size.Width, this.Location.Y + 150);
                    Form2Showed = true;
                }
            }
            else
            {
                if (Form2Showed && MenuForm2 != null)
                {
                    MenuForm2.Close();
                    MenuForm2?.Dispose();
                    Form2Showed = false;
                }
            }
        }

        

        private void ItemFrom1_CheckedChanged(object sender, EventArgs e)
        {
            MenuLists list = menuLists[MenuSelect.SelectedIndex];
            if (ItemFrom1.Checked && list.m1 != null)
            {
                bool IsSuccess = manager.recipe.IsSuccess(list.m1);
                bool IsTrash = manager.recipe.IsTrash(list.m1);
                if (IsSuccess || IsTrash)
                {
                    MENU menu = manager.recipe.GetMenu(list.m1);
                    ITEM item = manager.ReadItemDBFromID(list.m1.ClassID);
                    Sorting sorter = new Sorting(manager.ClassIDtoName(list.m1.ClassID), list.m1.ClassIDInt, IsSuccess, menu, item);
                    MenuForm1 = new MenuForm(sorter, manager, ItemFrom3);
                    MenuForm1.FormClosed += MenuForm1_FormClosed;
                    MenuForm1.Show();
                    MenuForm1.Location = new System.Drawing.Point(this.Location.X + this.Size.Width, this.Location.Y);
                    Form1Showed = true;
                }
            }
            else
            {
                if (Form1Showed && MenuForm1 != null)
                {
                    MenuForm1.Close();
                    MenuForm1?.Dispose();
                    Form1Showed = false;
                }
            }
        }*/
    }
}

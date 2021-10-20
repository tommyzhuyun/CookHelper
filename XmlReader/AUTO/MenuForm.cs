using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CookHelper.Data;

namespace CookHelper
{
    public partial class MenuForm :Form
    {
        public Sorting RecipeMenu;
        private readonly Manager manager;
        public readonly Control ControlOwner;
        public MenuLists menuList;
        public List<MenuLists> menuLists = new List<MenuLists>();
        readonly bool IsSuccess = false;

        public MenuForm(Sorting RecipeMenu, Manager manager, Control Owner)
        {
            this.RecipeMenu = RecipeMenu;
            this.manager = manager;
            this.ControlOwner = Owner;
            InitializeComponent();
            if (manager.favorite != null)
            {
                FavoriteAdd.Enabled = true;
            }
            IsSuccess = RecipeMenu.IsSuccess;
        }

        private void InitializeForm()
        {
            this.Text = "菜单 : " + RecipeMenu.Menu.ActionName;
            RecipeName.Text = RecipeMenu.Name;
            ResultPic.Image?.Dispose();
            Technique.Image?.Dispose();
            LeftHand.Image?.Dispose();
            RightHand.Image?.Dispose();
            ResultPic.Image = manager.GetImageFromId(RecipeMenu.ClassID);
            Technique.Image = manager.GetImageFromAction(RecipeMenu.Menu.ActionName);
            switch (RecipeMenu.Menu.Action)
            {
                case "cook_with_strong_fire":
                case "steam":
                case "boil":
                case "fry_with_much_oil":
                case "fry":
                case "make_jam":
                case "steamed_dish":
                    LeftHand.Image = manager.GetImageFromId("40044");
                    RightHand.Image = manager.GetImageFromId("40305");//锅
                    break;
                case "mix":
                    LeftHand.Image = manager.GetImageFromId("40042"); // 菜刀
                    RightHand.Image = manager.GetImageFromId("46005");
                    break;
                case "knead":
                case "make_noodle":
                case "make_pasta":
                case "make_pie":
                case "make_pizza":
                    LeftHand.Image = manager.GetImageFromId("40043");
                    RightHand.Image = manager.GetImageFromId("46005");
                    break;
                case "ferment":
                    LeftHand.Image = manager.GetImageFromId("41406");//发酵容器
                    RightHand.Image = manager.GetImageFromId("46005");
                    break;
                case "sousvide":
                    LeftHand.Image = manager.GetImageFromId("41407");//水浴法专用真空容器
                    RightHand.Image = manager.GetImageFromId("46005");
                    break;
                case "fillet":
                    LeftHand.Image = manager.GetImageFromId("41408");//长菜刀
                    RightHand.Image = manager.GetImageFromId("46005");
                    break;
            }
            LeftHand.Refresh();
            RightHand.Refresh();

            StringBuilder sb = new StringBuilder("ClassID: "+RecipeMenu.ClassID.ToString());
            if (RecipeMenu.Buffer != null)
                sb.Append("\r\n持续时间 : " + RecipeMenu.Buffer.Duration_Sec.ToString());
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

        private void InitialItem()
        {
            if (menuLists.Count <= MenuSelect.SelectedIndex) 
                return;

           
            double[] amount = menuList.Amount;
            if (menuList.m1 != null)
            {
                ItemFrom1.Tag = manager.GetSourceSorting(menuList.m1);
                ItemPic1.Image?.Dispose();
                ItemPic1.Image = manager.GetImageFromId(menuList.m1.ClassID);
                ItemPic1.Refresh();
                ItemText1.Text = manager.ClassIDtoName(menuList.m1.ClassID);
                if(IsSuccess)
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
                if (IsSuccess)
                    ItemValue2.Text = Math.Round(amount[1], 1).ToString();
                else
                    ItemValue2.Text = "0/100";
                Switch2.Enabled = true;
            }
            else
            {
                ItemFrom2.Tag = null;
                ItemFrom2.Enabled = false;
                ItemPic2.Image?.Dispose();
                ItemPic2.Image = null;
                ItemText2.Text = "";
                ItemValue2.Text = "";
                Switch2.Enabled = false;
            }
            if (menuList.m3 != null)
            {
                ItemFrom3.Tag = manager.GetSourceSorting(menuList.m3);
                ItemFrom3.Enabled = true;
                ItemPic3.Image?.Dispose();
                ItemPic3.Image = manager.GetImageFromId(menuList.m3.ClassID);
                ItemPic3.Refresh();
                ItemText3.Text = manager.ClassIDtoName(menuList.m3.ClassID);
                if (IsSuccess)
                    ItemValue3.Text = Math.Round(amount[2], 1).ToString();
                else
                    ItemValue3.Text = "0/100";
                Switch2.Enabled = true;
            }
            else
            {
                ItemFrom3.Tag = null;
                ItemFrom3.Enabled = false; 
                ItemPic3.Image?.Dispose();
                ItemPic3.Image = null;
                ItemText3.Text = "";
                ItemValue3.Text = "";
                Switch2.Enabled = false;
            }
            RulerImage();
        }

        private void RulerImage()
        {
            int Width = RulerImg.Width;
            int Height = RulerImg.Height;
            int[] data = new int[Width * Height];
            int ControlColor = SystemColors.Control.ToArgb();
            int Yellow = Color.Yellow.ToArgb();
            int Cyan = Color.Cyan.ToArgb();
            int HotPink = Color.HotPink.ToArgb();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = ControlColor;
            }
            int value1 = menuList.M1Amount, value2 = menuList.M2Amount, value3 = menuList.M3Amount;
            int sum = value3 + value2 + value1;
            int point1, point2, point3;
            if (IsSuccess)
            {
                point1 = (value1) * (Width) / sum;
                point2 = (value1 + value2) * (Width) / sum;
                point3 = (value1 + value2 + value3) * (Width) / sum;
            }
            else
            {
                point1 = Width;
                point2 = Width;
                point3 = Width;
            }
           // Console.WriteLine(point1 + " " + point2 + " " + point3);
            for (int x = 0; x < Width; x++)//228
            {
                for (int y = 0; y < Height; y++)
                {
                    if (y < 8 && x <= point1)
                        data[x + y * Width] = Yellow;
                    else if (y < 8 && x > point1 && x <= point2)
                        data[x + y * Width] = Cyan;
                    else if (y < 8 && x > point2 && x <= point3)
                        data[x + y * Width] = HotPink;
                }
            }
            Bitmap bitmap = new Bitmap(Width, Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            CookRuler.CopyFromArray(data, bitmap);
            RulerImg.Image?.Dispose();
            RulerImg.Image = bitmap;
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
            MenuSelect.SelectedIndex = 0;
            menuList = menuLists[MenuSelect.SelectedIndex];
            InitialItem();
            if (CookRuler != null)
            {
                if (IsSuccess)
                    CookRuler.Update(menuList.M1Amount, menuList.M2Amount, menuList.M3Amount);
                else
                    CookRuler.Update(100,0,0);
            }
        }


        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            InitializeForm();
            Solution();
            MenuSelect.SelectedIndex = 0;
            menuList = menuLists[MenuSelect.SelectedIndex];
            InitialItem();
        }

        private void MenuSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            menuList = menuLists[MenuSelect.SelectedIndex];
            InitialItem();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            while (MnForm.Count > 0) 
            {
                var fm = MnForm[0];
                MnForm.RemoveAt(0);
                if (fm != null)
                {
                    if (!fm.TopMost)
                    {
                        fm?.Close();
                        fm?.Dispose();
                    }
                }
            }
            while (MtForm.Count > 0) 
            {
                var fm = MtForm[0];
                MtForm.RemoveAt(0);
                fm?.Close();
                fm?.Dispose();
            }
            CookRuler?.Close();
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

        public void FavoriteUpdate(bool enable)
        {
            FavoriteAdd.Enabled = enable;
            foreach(var menu in MnForm)
            {
                menu?.FavoriteUpdate(enable);
            }
            foreach (var menu in MtForm)
            {
                menu?.FavoriteUpdate(enable);
            }
        }

        private void FavoriteAdd_Click(object sender, EventArgs e)
        {
            manager.favorite.AddItem(RecipeMenu.ClassID.ToString(),RecipeMenu.Name);
        }

        private void OnTop_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = OnTop.Checked;
        }

        CookRuler CookRuler = null;
        private void CookRul_Click(object sender, EventArgs e)
        {
            if(CookRuler == null)
            {
                if (IsSuccess)
                    CookRuler = new CookRuler(menuList.M1Amount, menuList.M2Amount, menuList.M3Amount);
                else
                    CookRuler = new CookRuler(100,0,0);
                CookRuler.Show();
                CookRuler.FormClosing += CookRuler_FormClosing;
                CookRuler.Location = new Point(this.Location.X + this.Size.Width - CookRuler.Size.Width, this.Location.Y + this.Size.Height - CookRuler.Size.Height);
                CookRul.Text = "关闭尺子";
            }
            else
            {
                CookRuler.Close();
            }
        }

        private void CookRuler_FormClosing(object sender, FormClosingEventArgs e)
        {
            CookRul.Text = "料理尺";
            CookRuler= null;
        }

        private void Switch1_Click(object sender, EventArgs e)
        {
            menuList.Switch12();
            InitialItem();
            if (CookRuler != null)
            {
                if (IsSuccess)
                    CookRuler.Update(menuList.M1Amount, menuList.M2Amount, menuList.M3Amount);
                else
                    CookRuler.Update(100, 0, 0);
            }
        }

        private void Switch2_Click(object sender, EventArgs e)
        {
            menuList.Switch23();
            InitialItem();
            if (CookRuler != null)
            {
                if (IsSuccess)
                    CookRuler.Update(menuList.M1Amount, menuList.M2Amount, menuList.M3Amount);
                else
                    CookRuler.Update(100, 0, 0);
            }
        }
    }
}

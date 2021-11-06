using CookHelper.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CookHelper
{
    public partial class MaterialForm : Form
    {
        public Sorting RecipeMenu;
        public readonly Control ControlOwner;
        private readonly Manager manager;

        public MaterialForm(Sorting RecipeMenu, Manager manager, Control Owner)
        {
            this.RecipeMenu = RecipeMenu;
            //if (RecipeMenu.Item == null)
            //   throw new Exception("ITEM base need have a value");
            this.ControlOwner = Owner;
            this.manager = manager;
            InitializeComponent();
        }

        public MaterialForm(Sorting RecipeMenu, Manager manager) : this(RecipeMenu, manager, null)
        { }

        private void MaterialForm_Load(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void Closer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private readonly List<Control> ControlList = new List<Control>();
        private void InitializeForm()
        {
            Text = RecipeMenu.Name;
            ItemName.Text = Text;
            ItemID.Text = "ClassID: " + RecipeMenu.ClassID.ToString();
            ItemPic.Image = manager.GetImageFromId(RecipeMenu.ClassID);

            var ItemCouldBuy = manager.BaseItem.ItemCouldBuy(RecipeMenu.ClassID.ToString());
            if (ItemCouldBuy.Count > 0)
            {
                if (RecipeMenu.Item != null)
                {
                    Price.Text = "买入价 - " + RecipeMenu.Item.Price_Buy + " Gold";
                    PriceWed.Text = "周三价 - " + (RecipeMenu.Item.Price_Buy * 0.95).ToString("f0") + " Gold";

                }
                StringBuilder sb1 = new StringBuilder();
                foreach (var npc in ItemCouldBuy)
                {
                    sb1.Append(npc + "\r\n");
                }
                NPC.Text = sb1.ToString();
            }
            else
            {
                PanelNPC.Visible = false;
                this.Size = new Size(this.Size.Width, this.Size.Height - PanelNPC.Height);
            }


            var Mission = manager.BaseItem.ItemCouldMission(RecipeMenu.ClassID.ToString());
            if (Mission.Count > 0)
            {
                GETITEM getitem = Mission[0];
                var items = getitem.Item.Find(x => x.ClassID == RecipeMenu.ClassID.ToString());
                var resource = items.SourceItem;
                MissionInfo.Text = getitem + " - " + items.ExtraInfo;
                foreach (var item in resource)
                {
                    Sorting sorting;
                    if (manager.IsMenu(item.ClassID))
                        sorting = new Sorting(item.Name, item.ClassIDInt, true, manager.ReadFirstRecipe(item.ClassID), manager.ReadItemDBFromID(item.ClassID));
                    else
                        sorting = new Sorting(item.Name, item.ClassIDInt, false, null, manager.ReadItemDBFromID(item.ClassID));

                    CheckBox checkBox = new CheckBox
                    {
                        Checked = false,
                        Appearance = this.SampleCheck.Appearance,
                        Dock = this.SampleCheck.Dock,
                        Font = this.SampleCheck.Font,
                        Size = this.SampleCheck.Size,
                        Tag = sorting,
                        Text = item.Name + " " + item.ExtraInfo
                    };
                    checkBox.CheckedChanged += MissionItemCheck_CheckedChanged;

                    MissionInfoPanel.Controls.Add(checkBox);
                    ControlList.Add(checkBox);
                    if (MissionInfoPanel.Controls.Count > 3)
                    {
                        MissionInfoPanel.Size = new Size(MissionInfoPanel.Width, MissionInfoPanel.Height + checkBox.Size.Height);
                        PanelMission.Size = new Size(PanelMission.Width, PanelMission.Height + checkBox.Size.Height);
                        this.Size = new Size(this.Size.Width, this.Size.Height + checkBox.Size.Height);
                    }
                }
            }
            else
            {
                PanelMission.Visible = false;
                this.Size = new Size(this.Size.Width, this.Size.Height - PanelMission.Size.Height);
            }

            var Skill = manager.BaseItem.ItemCouldSkill(RecipeMenu.ClassID.ToString());
            if (Skill.Count > 0)
            {
                GETITEM getitem = Skill[0];
                SkillPic.Image?.Dispose();
                SkillPic.Image = manager.GetImage($"img/Skill/{getitem.Info}.png");

                var Resultitem = getitem.Item.Find(x => x.ClassID == RecipeMenu.ClassID.ToString());
                SkillInfo.Text = getitem.SkillName + "\r\n" + Resultitem.ExtraInfo;

                var resource = Resultitem.SourceItem;
                if (resource.Count == 0)
                {
                    SkillInfoPanel.Visible = false;
                    PanelSkill.Size = new Size(PanelSkill.Width, PanelSkill.Height - SkillInfoPanel.Size.Height);
                    this.Size = new Size(this.Size.Width, this.Size.Height - SkillInfoPanel.Size.Height);
                }
                else
                    foreach (var item in resource)
                    {
                        Sorting sorting;
                        if (manager.IsMenu(item.ClassID))
                            sorting = new Sorting(item.Name, item.ClassIDInt, true, manager.ReadFirstRecipe(item.ClassID), manager.ReadItemDBFromID(item.ClassID));
                        else
                            sorting = new Sorting(item.Name, item.ClassIDInt, false, null, manager.ReadItemDBFromID(item.ClassID));
                        CheckBox checkBox = new CheckBox
                        {
                            Checked = false,
                            Appearance = this.SampleCheck.Appearance,
                            Dock = this.SampleCheck.Dock,
                            Font = this.SampleCheck.Font,
                            Size = this.SampleCheck.Size,
                            Tag = sorting,
                            Text = item.Name + " " + item.ExtraInfo
                        };
                        checkBox.CheckedChanged += MissionItemCheck_CheckedChanged;

                        SkillInfoPanel.Controls.Add(checkBox);
                        ControlList.Add(checkBox);
                        if (SkillInfoPanel.Controls.Count > 2)
                        {
                            SkillInfoPanel.Size = new Size(SkillInfoPanel.Width, SkillInfoPanel.Height + checkBox.Size.Height);
                            PanelSkill.Size = new Size(PanelSkill.Width, PanelSkill.Height + checkBox.Size.Height);
                            this.Size = new Size(this.Size.Width, this.Size.Height + checkBox.Size.Height);
                        }
                    }
            }
            else
            {
                if (RecipeMenu.IsMenu)
                {
                    SkillPic.Image?.Dispose();
                    SkillPic.Image = manager.GetImage($"img/Skill/10020.png");
                    SkillInfo.Text = "料理";
                    CheckBox checkBox = new CheckBox
                    {
                        Checked = false,
                        Appearance = this.SampleCheck.Appearance,
                        Dock = this.SampleCheck.Dock,
                        Font = this.SampleCheck.Font,
                        Size = this.SampleCheck.Size,
                        Tag = RecipeMenu,
                        Text = RecipeMenu.Name,
                    };
                    checkBox.CheckedChanged += MenuItem_CheckedChanged; ;
                    SkillInfoPanel.Controls.Add(checkBox);
                    ControlList.Add(checkBox);
                }
                else
                {
                    PanelSkill.Visible = false;
                    this.Size = new Size(this.Size.Width, this.Size.Height - PanelSkill.Size.Height);
                }
            }
        }

        private void MenuItem_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            Sorting sorting = (Sorting)check.Tag;

            if (check.Checked)
            {
                MenuForm MnForm = new MenuForm(sorting, manager, check);
                MenuForms.Add(MnForm);
                MnForm.FormClosed += MenuForm_FormClosed;
                MnForm.Show();
                MnForm.Location = new System.Drawing.Point(this.Location.X + this.Size.Width, this.Location.Y);
            }
            else
            {
                MenuForm MaterialForm = MenuForms.Find(x => x.ControlOwner == check);
                MenuForms.Remove(MaterialForm);
                if (MaterialForm != null)
                {
                    MaterialForm.FormClosed -= MenuForm_FormClosed;
                    MaterialForm?.Close();
                }
            }
        }
        private readonly List<MenuForm> MenuForms = new List<MenuForm>();
        private readonly List<MaterialForm> ElemForms = new List<MaterialForm>();
        private void MissionItemCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            Sorting sorting = (Sorting)check.Tag;

            if (check.Checked)
            {
                MaterialForm MaterialForm = new MaterialForm(sorting, manager, check);
                ElemForms.Add(MaterialForm);
                MaterialForm.FormClosed += MenuForm_FormClosed;
                MaterialForm.Show();
                MaterialForm.Location = new System.Drawing.Point(this.Location.X + this.Size.Width, this.Location.Y);
            }
            else
            {
                MaterialForm MaterialForm = ElemForms.Find(x => x.ControlOwner == check);
                ElemForms.Remove(MaterialForm);
                if (MaterialForm != null)
                {
                    MaterialForm.FormClosed -= MenuForm_FormClosed;
                    MaterialForm?.Close();
                }
            }
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MaterialForm material = sender as MaterialForm;

            Control ControlOwner = material?.ControlOwner;
            if (ControlOwner != null)
                ((CheckBox)ControlOwner).Checked = false;
        }

        private void MaterialForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            while (ElemForms.Count > 0)
            {
                var fm = ElemForms[0];
                ElemForms.RemoveAt(0);
                fm?.Close();
                fm?.Dispose();
            }
            while (MenuForms.Count > 0)
            {
                var fm = MenuForms[0];
                MenuForms.RemoveAt(0);
                if (fm != null)
                {
                    if (!fm.TopMost)
                    {
                        fm?.Close();
                        fm?.Dispose();
                    }
                }
            }
        }

        public void FavoriteUpdate(bool enable)
        {
            foreach (var menu in ElemForms)
            {
                menu?.FavoriteUpdate(enable);
            }
            foreach (var menu in MenuForms)
            {
                menu?.FavoriteUpdate(enable);
            }
        }
    }
}

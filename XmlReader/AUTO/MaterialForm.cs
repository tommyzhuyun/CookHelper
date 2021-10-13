using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XmlReader.Data;

namespace XmlReader
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
        {        }

        private readonly List<Control> ControlList = new List<Control>();
        private void InitializeForm()
        {
            Text = RecipeMenu.Name;
            ItemName.Text = Text;
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
                var items = getitem.Item;
                var resource = items[0].SourceItem;
                MissionInfo.Text = getitem + " - " + items[0].ExtraInfo;
                foreach(var item in resource)
                {
                    Sorting sorting = new Sorting(item.Name, item.ClassIDInt, false, null, manager.ReadItemDBFromID(item.ClassID));
                    CheckBox checkBox = new CheckBox();
                    checkBox.Checked = false;
                    checkBox.Appearance = this.SampleCheck.Appearance;
                    checkBox.Dock = this.SampleCheck.Dock;
                    checkBox.Font = this.SampleCheck.Font;
                    checkBox.Size = this.SampleCheck.Size;
                    checkBox.Tag = sorting;
                    checkBox.Text = item.Name +" "+ item.ExtraInfo;
                    checkBox.CheckedChanged += MissionItemCheck_CheckedChanged;

                    MissionInfoPanel.Controls.Add(checkBox);
                    ControlList.Add(checkBox);
                    if(MissionInfoPanel.Controls.Count > 3)
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
            if (Skill.Count > 0) {
                GETITEM getitem = Skill[0];
                SkillPic.Image?.Dispose();
                SkillPic.Image = Image.FromFile($"img/Skill/{getitem.Info}.png");
               

                var Resultitem = getitem.Item.Find(x => x.ClassID == RecipeMenu.ClassID.ToString());
                SkillInfo.Text = getitem.SkillName + "\r\n" + Resultitem.ExtraInfo;

                var resource = Resultitem.SourceItem;
                if(resource.Count == 0)
                {
                    SkillInfoPanel.Visible = false;
                    PanelSkill.Size = new Size(PanelSkill.Width, PanelSkill.Height - SkillInfoPanel.Size.Height);
                    this.Size = new Size(this.Size.Width, this.Size.Height - SkillInfoPanel.Size.Height);
                }
                else
                    foreach (var item in resource)
                    {
                        Sorting sorting = new Sorting(item.Name, item.ClassIDInt, false, null, manager.ReadItemDBFromID(item.ClassID));
                        CheckBox checkBox = new CheckBox();
                        checkBox.Checked = false;
                        checkBox.Appearance = this.SampleCheck.Appearance;
                        checkBox.Dock = this.SampleCheck.Dock;
                        checkBox.Font = this.SampleCheck.Font;
                        checkBox.Size = this.SampleCheck.Size;
                        checkBox.Tag = sorting;
                        checkBox.Text = item.Name + " " + item.ExtraInfo; 
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
                PanelSkill.Visible = false;
                this.Size = new Size(this.Size.Width, this.Size.Height - PanelSkill.Size.Height);
            }
        }

        private readonly List<MaterialForm> ElemForm = new List<MaterialForm>();
        private void MissionItemCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            Sorting sorting = (Sorting)check.Tag;
            
            if (check.Checked)
            {
                MaterialForm MaterialForm = new MaterialForm(sorting, manager, check);
                ElemForm.Add(MaterialForm);
                MaterialForm.FormClosed += MenuForm_FormClosed;
                MaterialForm.Show();
                MaterialForm.Location = new System.Drawing.Point(this.Location.X + this.Size.Width, this.Location.Y);
            }
            else
            {
                MaterialForm MaterialForm = ElemForm.Find(x => x.ControlOwner == check);
                ElemForm.Remove(MaterialForm);
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
            if(ControlOwner != null)
                ((CheckBox)ControlOwner).Checked = false;
        }


        private void MaterialForm_Load(object sender, EventArgs e)
        {
            InitializeForm();
        }


        private void Closer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MaterialForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            while (ElemForm.Count > 0) 
            {
                var fm = ElemForm[0];
                ElemForm.RemoveAt(0);
                fm?.Close();
                fm?.Dispose();
            }
        }
    }
}

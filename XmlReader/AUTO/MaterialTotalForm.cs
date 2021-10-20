using CookHelper.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CookHelper
{
    public partial class MaterialTotalForm : Form
    {
        public readonly Manager manager;
        public List<Statistic> ItemList;
        public readonly MaterialTotal Example;

        public MaterialTotalForm(Manager manager,List<Statistic> rs)
        {
            this.manager = manager;
            this.ItemList = rs;
            InitializeComponent();
            Example = new MaterialTotal(SamplePanel, SamplePic, SampleText, SampleValue, SampleCheck);
        }

        private void MaterialTotalForm_Load(object sender, EventArgs e)
        {
            MaterialTotalForm_Update();
        }

        public void MaterialTotalForm_Update()
        {
            foreach (var list in ItemList)
            {
                MaterialTotal material = new MaterialTotal(Example, list);
                material.MenuPic.Image = manager.GetImageFromId(list.Sorting.ClassID);
                material.MenuCheck.CheckedChanged += SampleCheck_CheckedChanged;
                material.MenuCheck.Tag = list;
                Total.Add(material);
                ListPanel.Controls.Add(material.MenuPanel);
            }
        }

        private readonly List<MaterialTotal> Total = new List<MaterialTotal>();
        public void Clear()
        {
            while(Total.Count > 0)
            {
                MaterialTotal total = Total[0];
                Total.RemoveAt(0);
                ListPanel.Controls.Remove(total.MenuPanel);
                total.Dispose();
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
            }
            else if (sender is MenuForm menu)
            {
                ControlOwner = menu.ControlOwner;
            }

            if (ControlOwner != null)
                ((CheckBox)ControlOwner).Checked = false;

        }

        private void SampleCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            if (!(check.Tag is Statistic sorting))
                return;

            if (check.Checked)
            {
                if (sorting.Sorting.IsMenu)
                {
                    MenuForm MenForm = new MenuForm(sorting.Sorting, manager, check);
                    MnForm.Add(MenForm);
                    MenForm.FormClosing += ControlForm_FormClosing;
                    MenForm.Parent = this;
                    MenForm.TopLevel = false;
                    MenForm.Show();
                    MenForm.Location = new System.Drawing.Point(this.Location.X + this.Size.Width, this.Location.Y);
                }
                else
                {
                    MaterialForm MatForm = new MaterialForm(sorting.Sorting, manager, check);
                    MtForm.Add(MatForm);
                    MatForm.FormClosing += ControlForm_FormClosing;
                    //MatForm.Parent = this;
                    //MatForm.TopLevel = false;
                    MatForm.Show();
                    MatForm.Location = new System.Drawing.Point(this.Location.X + this.Size.Width, this.Location.Y);
                }
            }
            else
            {
                if (sorting.Sorting.IsMenu)
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

        private void MaterialTotalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clear();
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

        private void OnTop_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = OnTop.Checked;
        }
    }

    public class MaterialTotal : IDisposable
    {
        public readonly Panel MenuPanel;
        public readonly PictureBox MenuPic;
        public readonly CheckBox MenuCheck;
        public readonly TextBox MenuText;
        public readonly TextBox MenuValue;
        public readonly Sorting ID;

        public void Dispose()
        {
            MenuPanel.Dispose();
            MenuPic.Dispose();
            MenuCheck.Dispose();
            MenuText.Dispose();
            MenuValue.Dispose();
        }

        public MaterialTotal(Panel ExamplePanel, PictureBox ExamplePic, TextBox ExampleText, TextBox ExampleValue, CheckBox ExampleCheck)
        {
            MenuPanel = ExamplePanel;
            MenuPic = ExamplePic;
            MenuCheck = ExampleCheck;
            MenuText = ExampleText;
            MenuValue = ExampleValue;
        }

        public MaterialTotal(MaterialTotal Example, Statistic ID)
        {
            this.ID = ID.Sorting;
            MenuPanel = new Panel();

            MenuPic = new PictureBox
            {
                Location = Example.MenuPic.Location,
                BackColor = Example.MenuPic.BackColor,
                Dock = Example.MenuPic.Dock,
                Size = Example.MenuPic.Size,
                SizeMode = Example.MenuPic.SizeMode,
                TabStop = false,
                Name = ID.Sorting.Name,
            };
            MenuCheck = new CheckBox
            {
                AutoSize = true,
                Appearance = Example.MenuCheck.Appearance,
                Location = Example.MenuCheck.Location,
                Dock = Example.MenuCheck.Dock,
                Size = Example.MenuCheck.Size,
                TextAlign = Example.MenuCheck.TextAlign,
                UseVisualStyleBackColor = true,
                TabStop = false,
                Name = Example.MenuCheck.Text,
                Text = Example.MenuCheck.Text,
            };
            MenuText = new TextBox
            {
                AutoSize = true,
                BorderStyle = Example.MenuText.BorderStyle,
                BackColor = Example.MenuText.BackColor,
                Dock = Example.MenuText.Dock,
                ReadOnly = Example.MenuText.ReadOnly,
                Font = Example.MenuText.Font,
                Location = Example.MenuText.Location,
                Size = Example.MenuText.Size,
                TextAlign = Example.MenuText.TextAlign,
                Multiline = Example.MenuText.Multiline,
                TabStop = false,
                Text = ID.Sorting.Name,
            };
            MenuValue = new TextBox
            {
                AutoSize = true,
                BorderStyle = Example.MenuValue.BorderStyle,
                BackColor = Example.MenuValue.BackColor,
                Dock = Example.MenuValue.Dock,
                ReadOnly = Example.MenuValue.ReadOnly,
                Font = Example.MenuValue.Font,
                Location = Example.MenuValue.Location,
                Size = Example.MenuValue.Size,
                TextAlign = Example.MenuValue.TextAlign,
                Multiline = Example.MenuValue.Multiline,
                TabStop = false,
                Text = ID.Amount + "个",
            };

            
            MenuPanel.Controls.Add(MenuCheck);
            MenuPanel.Controls.Add(MenuValue);
            MenuPanel.Controls.Add(MenuText);
            MenuPanel.Controls.Add(MenuPic);
            MenuPanel.Dock = Example.MenuPanel.Dock;
            MenuPanel.BackColor = Example.MenuPanel.BackColor;
            MenuPanel.BorderStyle = Example.MenuPanel.BorderStyle;
            //MenuPanel.Location = location;
            MenuPanel.Size = Example.MenuPanel.Size;
            MenuPanel.TabStop = false;
            MenuPanel.Visible = true;
        }
    }
}

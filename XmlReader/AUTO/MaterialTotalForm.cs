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
        public readonly List<RESULTITEM> ItemList;

        public MaterialTotalForm(Manager manager,List<RESULTITEM> rs)
        {
            this.manager = manager;
            this.ItemList = rs;
            InitializeComponent();
        }

        private void MaterialTotalForm_Load(object sender, EventArgs e)
        {


        }



    }

    public class MaterialTotal : IDisposable
    {
        public readonly Panel MenuPanel;
        public readonly PictureBox MenuPic;
        public readonly CheckBox MenuCheck;
        public readonly TextBox MenuText;
        public readonly TextBox MenuValue;
        public readonly RESULTITEM ID;

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

        public MaterialTotal(MaterialTotal Example, Point location, RESULTITEM ID)
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
                TabStop = false,
                Name = ID.Name,
                Text = ID.Name,
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
                TabStop = false,
                Name = ID.Name,
                Text = ID.Name,
            };

            MenuPanel.Controls.Add(MenuPic);
            MenuPanel.Controls.Add(MenuCheck);
            MenuPanel.Controls.Add(MenuText);
            MenuPanel.Controls.Add(MenuValue);
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

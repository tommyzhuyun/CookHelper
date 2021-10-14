
namespace CookHelper
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuSelect = new System.Windows.Forms.ComboBox();
            this.MatrialList = new System.Windows.Forms.CheckBox();
            this.RecipeName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ItemText3 = new System.Windows.Forms.TextBox();
            this.ItemValue3 = new System.Windows.Forms.TextBox();
            this.ItemFrom3 = new System.Windows.Forms.CheckBox();
            this.ItemPic3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ItemText2 = new System.Windows.Forms.TextBox();
            this.ItemValue2 = new System.Windows.Forms.TextBox();
            this.ItemFrom2 = new System.Windows.Forms.CheckBox();
            this.ItemPic2 = new System.Windows.Forms.PictureBox();
            this.Effect = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ItemText1 = new System.Windows.Forms.TextBox();
            this.ItemValue1 = new System.Windows.Forms.TextBox();
            this.ItemFrom1 = new System.Windows.Forms.CheckBox();
            this.ItemPic1 = new System.Windows.Forms.PictureBox();
            this.ResultPic = new System.Windows.Forms.PictureBox();
            this.Technique = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Closer = new System.Windows.Forms.Button();
            this.FavoriteAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPic3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPic2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Technique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuSelect
            // 
            this.MenuSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MenuSelect.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MenuSelect.Items.AddRange(new object[] {
            "默认方案",
            "方案一",
            "方案二"});
            this.MenuSelect.Location = new System.Drawing.Point(144, 289);
            this.MenuSelect.Name = "MenuSelect";
            this.MenuSelect.Size = new System.Drawing.Size(152, 28);
            this.MenuSelect.TabIndex = 24;
            this.MenuSelect.TabStop = false;
            this.MenuSelect.SelectedIndexChanged += new System.EventHandler(this.MenuSelect_SelectedIndexChanged);
            // 
            // MatrialList
            // 
            this.MatrialList.Appearance = System.Windows.Forms.Appearance.Button;
            this.MatrialList.AutoSize = true;
            this.MatrialList.Cursor = System.Windows.Forms.Cursors.Default;
            this.MatrialList.Enabled = false;
            this.MatrialList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MatrialList.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MatrialList.Location = new System.Drawing.Point(221, 359);
            this.MatrialList.Name = "MatrialList";
            this.MatrialList.Size = new System.Drawing.Size(75, 30);
            this.MatrialList.TabIndex = 30;
            this.MatrialList.TabStop = false;
            this.MatrialList.Text = "材料清单";
            this.MatrialList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MatrialList.UseVisualStyleBackColor = true;
            // 
            // RecipeName
            // 
            this.RecipeName.BackColor = System.Drawing.SystemColors.Control;
            this.RecipeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecipeName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecipeName.Location = new System.Drawing.Point(88, 15);
            this.RecipeName.Name = "RecipeName";
            this.RecipeName.ReadOnly = true;
            this.RecipeName.Size = new System.Drawing.Size(210, 22);
            this.RecipeName.TabIndex = 29;
            this.RecipeName.TabStop = false;
            this.RecipeName.Text = "胡椒味浓烈的烤丝绸旗鱼";
            this.RecipeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.ItemText3);
            this.panel4.Controls.Add(this.ItemValue3);
            this.panel4.Controls.Add(this.ItemFrom3);
            this.panel4.Controls.Add(this.ItemPic3);
            this.panel4.Location = new System.Drawing.Point(205, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 150);
            this.panel4.TabIndex = 27;
            // 
            // ItemText3
            // 
            this.ItemText3.BackColor = System.Drawing.Color.White;
            this.ItemText3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemText3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemText3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemText3.Location = new System.Drawing.Point(0, 57);
            this.ItemText3.Multiline = true;
            this.ItemText3.Name = "ItemText3";
            this.ItemText3.ReadOnly = true;
            this.ItemText3.Size = new System.Drawing.Size(86, 33);
            this.ItemText3.TabIndex = 5;
            this.ItemText3.TabStop = false;
            this.ItemText3.Text = "旗鱼";
            this.ItemText3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemValue3
            // 
            this.ItemValue3.BackColor = System.Drawing.Color.HotPink;
            this.ItemValue3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemValue3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemValue3.Location = new System.Drawing.Point(0, 90);
            this.ItemValue3.Name = "ItemValue3";
            this.ItemValue3.Size = new System.Drawing.Size(86, 26);
            this.ItemValue3.TabIndex = 4;
            this.ItemValue3.TabStop = false;
            this.ItemValue3.Text = "100%";
            this.ItemValue3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemFrom3
            // 
            this.ItemFrom3.Appearance = System.Windows.Forms.Appearance.Button;
            this.ItemFrom3.AutoSize = true;
            this.ItemFrom3.Cursor = System.Windows.Forms.Cursors.Default;
            this.ItemFrom3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemFrom3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ItemFrom3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemFrom3.Location = new System.Drawing.Point(0, 116);
            this.ItemFrom3.Name = "ItemFrom3";
            this.ItemFrom3.Size = new System.Drawing.Size(86, 30);
            this.ItemFrom3.TabIndex = 8;
            this.ItemFrom3.TabStop = false;
            this.ItemFrom3.Text = "查询来源";
            this.ItemFrom3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ItemFrom3.UseVisualStyleBackColor = true;
            this.ItemFrom3.CheckedChanged += new System.EventHandler(this.ItemCheck_CheckedChanged);
            // 
            // ItemPic3
            // 
            this.ItemPic3.BackColor = System.Drawing.Color.White;
            this.ItemPic3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemPic3.InitialImage = null;
            this.ItemPic3.Location = new System.Drawing.Point(0, 0);
            this.ItemPic3.Name = "ItemPic3";
            this.ItemPic3.Size = new System.Drawing.Size(86, 61);
            this.ItemPic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ItemPic3.TabIndex = 0;
            this.ItemPic3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.ItemText2);
            this.panel3.Controls.Add(this.ItemValue2);
            this.panel3.Controls.Add(this.ItemFrom2);
            this.panel3.Controls.Add(this.ItemPic2);
            this.panel3.Location = new System.Drawing.Point(109, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 150);
            this.panel3.TabIndex = 28;
            // 
            // ItemText2
            // 
            this.ItemText2.BackColor = System.Drawing.Color.White;
            this.ItemText2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemText2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemText2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemText2.Location = new System.Drawing.Point(0, 57);
            this.ItemText2.Multiline = true;
            this.ItemText2.Name = "ItemText2";
            this.ItemText2.ReadOnly = true;
            this.ItemText2.Size = new System.Drawing.Size(86, 33);
            this.ItemText2.TabIndex = 5;
            this.ItemText2.TabStop = false;
            this.ItemText2.Text = "胡椒味浓烈的烤丝绸旗鱼";
            this.ItemText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemValue2
            // 
            this.ItemValue2.BackColor = System.Drawing.Color.Cyan;
            this.ItemValue2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemValue2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemValue2.Location = new System.Drawing.Point(0, 90);
            this.ItemValue2.Name = "ItemValue2";
            this.ItemValue2.Size = new System.Drawing.Size(86, 26);
            this.ItemValue2.TabIndex = 4;
            this.ItemValue2.TabStop = false;
            this.ItemValue2.Text = "100%";
            this.ItemValue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemFrom2
            // 
            this.ItemFrom2.Appearance = System.Windows.Forms.Appearance.Button;
            this.ItemFrom2.AutoSize = true;
            this.ItemFrom2.Cursor = System.Windows.Forms.Cursors.Default;
            this.ItemFrom2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemFrom2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ItemFrom2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemFrom2.Location = new System.Drawing.Point(0, 116);
            this.ItemFrom2.Name = "ItemFrom2";
            this.ItemFrom2.Size = new System.Drawing.Size(86, 30);
            this.ItemFrom2.TabIndex = 8;
            this.ItemFrom2.TabStop = false;
            this.ItemFrom2.Text = "查询来源";
            this.ItemFrom2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ItemFrom2.UseVisualStyleBackColor = true;
            this.ItemFrom2.CheckedChanged += new System.EventHandler(this.ItemCheck_CheckedChanged);
            // 
            // ItemPic2
            // 
            this.ItemPic2.BackColor = System.Drawing.Color.White;
            this.ItemPic2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemPic2.InitialImage = null;
            this.ItemPic2.Location = new System.Drawing.Point(0, 0);
            this.ItemPic2.Name = "ItemPic2";
            this.ItemPic2.Size = new System.Drawing.Size(86, 61);
            this.ItemPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ItemPic2.TabIndex = 0;
            this.ItemPic2.TabStop = false;
            // 
            // Effect
            // 
            this.Effect.BackColor = System.Drawing.SystemColors.Control;
            this.Effect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Effect.Location = new System.Drawing.Point(12, 289);
            this.Effect.Multiline = true;
            this.Effect.Name = "Effect";
            this.Effect.ReadOnly = true;
            this.Effect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Effect.Size = new System.Drawing.Size(129, 143);
            this.Effect.TabIndex = 23;
            this.Effect.TabStop = false;
            this.Effect.Text = "持续时间 600 秒\r\n防御+25\r\n魔法防御力+25\r\n保护+4\r\n魔法保护+4\r\n力量+60\r\n智力+60\r\n敏捷+60\r\n意志+60\r\n幸运+60";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.ItemText1);
            this.panel2.Controls.Add(this.ItemValue1);
            this.panel2.Controls.Add(this.ItemFrom1);
            this.panel2.Controls.Add(this.ItemPic1);
            this.panel2.Location = new System.Drawing.Point(13, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 150);
            this.panel2.TabIndex = 25;
            // 
            // ItemText1
            // 
            this.ItemText1.BackColor = System.Drawing.Color.White;
            this.ItemText1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemText1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemText1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemText1.Location = new System.Drawing.Point(0, 57);
            this.ItemText1.Multiline = true;
            this.ItemText1.Name = "ItemText1";
            this.ItemText1.ReadOnly = true;
            this.ItemText1.Size = new System.Drawing.Size(86, 33);
            this.ItemText1.TabIndex = 5;
            this.ItemText1.TabStop = false;
            this.ItemText1.Text = "胡椒味浓烈的烤丝绸旗鱼";
            this.ItemText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemValue1
            // 
            this.ItemValue1.BackColor = System.Drawing.Color.Yellow;
            this.ItemValue1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemValue1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemValue1.Location = new System.Drawing.Point(0, 90);
            this.ItemValue1.Name = "ItemValue1";
            this.ItemValue1.Size = new System.Drawing.Size(86, 26);
            this.ItemValue1.TabIndex = 4;
            this.ItemValue1.TabStop = false;
            this.ItemValue1.Text = "100%";
            this.ItemValue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemFrom1
            // 
            this.ItemFrom1.Appearance = System.Windows.Forms.Appearance.Button;
            this.ItemFrom1.AutoSize = true;
            this.ItemFrom1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ItemFrom1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemFrom1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ItemFrom1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemFrom1.Location = new System.Drawing.Point(0, 116);
            this.ItemFrom1.Name = "ItemFrom1";
            this.ItemFrom1.Size = new System.Drawing.Size(86, 30);
            this.ItemFrom1.TabIndex = 8;
            this.ItemFrom1.TabStop = false;
            this.ItemFrom1.Text = "查询来源";
            this.ItemFrom1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ItemFrom1.UseVisualStyleBackColor = true;
            this.ItemFrom1.CheckedChanged += new System.EventHandler(this.ItemCheck_CheckedChanged);
            // 
            // ItemPic1
            // 
            this.ItemPic1.BackColor = System.Drawing.Color.White;
            this.ItemPic1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemPic1.InitialImage = null;
            this.ItemPic1.Location = new System.Drawing.Point(0, 0);
            this.ItemPic1.Name = "ItemPic1";
            this.ItemPic1.Size = new System.Drawing.Size(86, 61);
            this.ItemPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ItemPic1.TabIndex = 0;
            this.ItemPic1.TabStop = false;
            // 
            // ResultPic
            // 
            this.ResultPic.BackColor = System.Drawing.SystemColors.Control;
            this.ResultPic.InitialImage = null;
            this.ResultPic.Location = new System.Drawing.Point(156, 42);
            this.ResultPic.Name = "ResultPic";
            this.ResultPic.Size = new System.Drawing.Size(72, 66);
            this.ResultPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ResultPic.TabIndex = 22;
            this.ResultPic.TabStop = false;
            // 
            // Technique
            // 
            this.Technique.Location = new System.Drawing.Point(12, 12);
            this.Technique.Name = "Technique";
            this.Technique.Size = new System.Drawing.Size(72, 96);
            this.Technique.TabIndex = 26;
            this.Technique.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Location = new System.Drawing.Point(37, 269);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(233, 14);
            this.pictureBox6.TabIndex = 31;
            this.pictureBox6.TabStop = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(221, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 32;
            this.button1.TabStop = false;
            this.button1.Text = "比例修正";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Closer
            // 
            this.Closer.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Closer.Location = new System.Drawing.Point(221, 395);
            this.Closer.Name = "Closer";
            this.Closer.Size = new System.Drawing.Size(75, 30);
            this.Closer.TabIndex = 33;
            this.Closer.Text = "关闭";
            this.Closer.UseVisualStyleBackColor = true;
            this.Closer.Click += new System.EventHandler(this.Close_Click);
            // 
            // FavoriteAdd
            // 
            this.FavoriteAdd.Enabled = false;
            this.FavoriteAdd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FavoriteAdd.Location = new System.Drawing.Point(144, 395);
            this.FavoriteAdd.Name = "FavoriteAdd";
            this.FavoriteAdd.Size = new System.Drawing.Size(74, 30);
            this.FavoriteAdd.TabIndex = 37;
            this.FavoriteAdd.Text = "添加收藏";
            this.FavoriteAdd.UseVisualStyleBackColor = true;
            this.FavoriteAdd.Click += new System.EventHandler(this.FavoriteAdd_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(143, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 38;
            this.button2.TabStop = false;
            this.button2.Text = "比例尺";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 435);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FavoriteAdd);
            this.Controls.Add(this.Closer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.MenuSelect);
            this.Controls.Add(this.MatrialList);
            this.Controls.Add(this.RecipeName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Effect);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ResultPic);
            this.Controls.Add(this.Technique);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.Text = "菜单";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPic3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPic2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Technique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MenuSelect;
        private System.Windows.Forms.CheckBox MatrialList;
        private System.Windows.Forms.TextBox RecipeName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox ItemText3;
        private System.Windows.Forms.TextBox ItemValue3;
        private System.Windows.Forms.CheckBox ItemFrom3;
        private System.Windows.Forms.PictureBox ItemPic3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox ItemText2;
        private System.Windows.Forms.TextBox ItemValue2;
        private System.Windows.Forms.CheckBox ItemFrom2;
        private System.Windows.Forms.PictureBox ItemPic2;
        private System.Windows.Forms.TextBox Effect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ItemText1;
        private System.Windows.Forms.TextBox ItemValue1;
        private System.Windows.Forms.CheckBox ItemFrom1;
        private System.Windows.Forms.PictureBox ItemPic1;
        private System.Windows.Forms.PictureBox ResultPic;
        private System.Windows.Forms.PictureBox Technique;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Closer;
        private System.Windows.Forms.Button FavoriteAdd;
        private System.Windows.Forms.Button button2;
    }
}
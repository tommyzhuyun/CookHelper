
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.MenuSelect = new System.Windows.Forms.ComboBox();
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
            this.RulerImg = new System.Windows.Forms.PictureBox();
            this.Closer = new System.Windows.Forms.Button();
            this.FavoriteAdd = new System.Windows.Forms.Button();
            this.CookRul = new System.Windows.Forms.Button();
            this.OnTop = new System.Windows.Forms.CheckBox();
            this.LeftHand = new System.Windows.Forms.PictureBox();
            this.RightHand = new System.Windows.Forms.PictureBox();
            this.Switch1 = new System.Windows.Forms.Button();
            this.Switch2 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPic3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPic2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Technique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RulerImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightHand)).BeginInit();
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
            this.MenuSelect.Location = new System.Drawing.Point(135, 278);
            this.MenuSelect.Name = "MenuSelect";
            this.MenuSelect.Size = new System.Drawing.Size(161, 28);
            this.MenuSelect.TabIndex = 24;
            this.MenuSelect.TabStop = false;
            this.MenuSelect.SelectedIndexChanged += new System.EventHandler(this.MenuSelect_SelectedIndexChanged);
            // 
            // RecipeName
            // 
            this.RecipeName.BackColor = System.Drawing.SystemColors.Control;
            this.RecipeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecipeName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecipeName.Location = new System.Drawing.Point(80, 0);
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
            this.panel4.Location = new System.Drawing.Point(210, 102);
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
            this.panel3.Location = new System.Drawing.Point(105, 102);
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
            this.Effect.Location = new System.Drawing.Point(0, 278);
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
            this.panel2.Location = new System.Drawing.Point(0, 102);
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
            this.ResultPic.Location = new System.Drawing.Point(149, 30);
            this.ResultPic.Name = "ResultPic";
            this.ResultPic.Size = new System.Drawing.Size(72, 66);
            this.ResultPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ResultPic.TabIndex = 22;
            this.ResultPic.TabStop = false;
            // 
            // Technique
            // 
            this.Technique.Location = new System.Drawing.Point(0, 0);
            this.Technique.Name = "Technique";
            this.Technique.Size = new System.Drawing.Size(72, 96);
            this.Technique.TabIndex = 26;
            this.Technique.TabStop = false;
            // 
            // RulerImg
            // 
            this.RulerImg.BackColor = System.Drawing.Color.White;
            this.RulerImg.Location = new System.Drawing.Point(38, 258);
            this.RulerImg.Name = "RulerImg";
            this.RulerImg.Size = new System.Drawing.Size(232, 14);
            this.RulerImg.TabIndex = 31;
            this.RulerImg.TabStop = false;
            // 
            // Closer
            // 
            this.Closer.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Closer.Location = new System.Drawing.Point(218, 387);
            this.Closer.Name = "Closer";
            this.Closer.Size = new System.Drawing.Size(75, 30);
            this.Closer.TabIndex = 33;
            this.Closer.TabStop = false;
            this.Closer.Text = "关闭";
            this.Closer.UseVisualStyleBackColor = true;
            this.Closer.Click += new System.EventHandler(this.Close_Click);
            // 
            // FavoriteAdd
            // 
            this.FavoriteAdd.Enabled = false;
            this.FavoriteAdd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FavoriteAdd.Location = new System.Drawing.Point(137, 387);
            this.FavoriteAdd.Name = "FavoriteAdd";
            this.FavoriteAdd.Size = new System.Drawing.Size(75, 30);
            this.FavoriteAdd.TabIndex = 37;
            this.FavoriteAdd.TabStop = false;
            this.FavoriteAdd.Text = "添加收藏";
            this.FavoriteAdd.UseVisualStyleBackColor = true;
            this.FavoriteAdd.Click += new System.EventHandler(this.FavoriteAdd_Click);
            // 
            // CookRul
            // 
            this.CookRul.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CookRul.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CookRul.Location = new System.Drawing.Point(218, 351);
            this.CookRul.Name = "CookRul";
            this.CookRul.Size = new System.Drawing.Size(75, 30);
            this.CookRul.TabIndex = 38;
            this.CookRul.TabStop = false;
            this.CookRul.Text = "比例尺";
            this.CookRul.UseVisualStyleBackColor = true;
            this.CookRul.Click += new System.EventHandler(this.CookRul_Click);
            // 
            // OnTop
            // 
            this.OnTop.AutoSize = true;
            this.OnTop.Location = new System.Drawing.Point(159, 360);
            this.OnTop.Name = "OnTop";
            this.OnTop.Size = new System.Drawing.Size(51, 21);
            this.OnTop.TabIndex = 39;
            this.OnTop.TabStop = false;
            this.OnTop.Text = "置顶";
            this.OnTop.UseVisualStyleBackColor = true;
            this.OnTop.CheckedChanged += new System.EventHandler(this.OnTop_CheckedChanged);
            // 
            // LeftHand
            // 
            this.LeftHand.BackColor = System.Drawing.SystemColors.Control;
            this.LeftHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftHand.InitialImage = null;
            this.LeftHand.Location = new System.Drawing.Point(83, 36);
            this.LeftHand.Name = "LeftHand";
            this.LeftHand.Size = new System.Drawing.Size(60, 60);
            this.LeftHand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LeftHand.TabIndex = 40;
            this.LeftHand.TabStop = false;
            // 
            // RightHand
            // 
            this.RightHand.BackColor = System.Drawing.SystemColors.Control;
            this.RightHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RightHand.InitialImage = null;
            this.RightHand.Location = new System.Drawing.Point(227, 36);
            this.RightHand.Name = "RightHand";
            this.RightHand.Size = new System.Drawing.Size(60, 60);
            this.RightHand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RightHand.TabIndex = 41;
            this.RightHand.TabStop = false;
            // 
            // Switch1
            // 
            this.Switch1.Location = new System.Drawing.Point(89, 152);
            this.Switch1.Name = "Switch1";
            this.Switch1.Size = new System.Drawing.Size(16, 41);
            this.Switch1.TabIndex = 42;
            this.Switch1.TabStop = false;
            this.Switch1.Text = "⇄";
            this.Switch1.UseVisualStyleBackColor = true;
            this.Switch1.Click += new System.EventHandler(this.Switch1_Click);
            // 
            // Switch2
            // 
            this.Switch2.Location = new System.Drawing.Point(194, 153);
            this.Switch2.Name = "Switch2";
            this.Switch2.Size = new System.Drawing.Size(16, 41);
            this.Switch2.TabIndex = 43;
            this.Switch2.TabStop = false;
            this.Switch2.Text = "⇄";
            this.Switch2.UseVisualStyleBackColor = true;
            this.Switch2.Click += new System.EventHandler(this.Switch2_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 421);
            this.Controls.Add(this.Switch2);
            this.Controls.Add(this.Switch1);
            this.Controls.Add(this.RightHand);
            this.Controls.Add(this.LeftHand);
            this.Controls.Add(this.OnTop);
            this.Controls.Add(this.CookRul);
            this.Controls.Add(this.FavoriteAdd);
            this.Controls.Add(this.Closer);
            this.Controls.Add(this.RulerImg);
            this.Controls.Add(this.MenuSelect);
            this.Controls.Add(this.RecipeName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Effect);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ResultPic);
            this.Controls.Add(this.Technique);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.RulerImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightHand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MenuSelect;
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
        private System.Windows.Forms.PictureBox RulerImg;
        private System.Windows.Forms.Button Closer;
        private System.Windows.Forms.Button FavoriteAdd;
        private System.Windows.Forms.Button CookRul;
        private System.Windows.Forms.CheckBox OnTop;
        private System.Windows.Forms.PictureBox LeftHand;
        private System.Windows.Forms.PictureBox RightHand;
        private System.Windows.Forms.Button Switch1;
        private System.Windows.Forms.Button Switch2;
    }
}
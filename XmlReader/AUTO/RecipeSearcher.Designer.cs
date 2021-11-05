
namespace CookHelper
{
    partial class RecipeSearcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeSearcher));
            this.listBox = new System.Windows.Forms.ListBox();
            this.Technique = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.DescendingOrder = new System.Windows.Forms.RadioButton();
            this.Chosener = new System.Windows.Forms.ComboBox();
            this.AscendingOrder = new System.Windows.Forms.RadioButton();
            this.MenuOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Other = new System.Windows.Forms.TextBox();
            this.Deepth = new System.Windows.Forms.TextBox();
            this.FavoriteAdd = new System.Windows.Forms.Button();
            this.ChoosedNum = new System.Windows.Forms.TextBox();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.RecipeName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Closer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OnTop = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBox.ItemHeight = 20;
            this.listBox.Items.AddRange(new object[] {
            "胡椒味浓烈的烤丝绸旗鱼"});
            this.listBox.Location = new System.Drawing.Point(0, 65);
            this.listBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(178, 364);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // Technique
            // 
            this.Technique.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Technique.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Technique.FormattingEnabled = true;
            this.Technique.Items.AddRange(new object[] {
            "全部",
            "混合",
            "煎(火)",
            "煮(火)",
            "烧(火)",
            "炸(火)",
            "炒(火)",
            "和面",
            "做面条",
            "制作意大利面",
            "制做果酱(火)",
            "制做派",
            "蒸煮(火)",
            "制作披萨",
            "发酵",
            "水浴法(火)",
            "切片"});
            this.Technique.Location = new System.Drawing.Point(184, 29);
            this.Technique.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Technique.Name = "Technique";
            this.Technique.Size = new System.Drawing.Size(186, 29);
            this.Technique.TabIndex = 2;
            this.Technique.SelectedIndexChanged += new System.EventHandler(this.Technique_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(187, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "料理种类：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DescendingOrder);
            this.panel1.Controls.Add(this.Chosener);
            this.panel1.Controls.Add(this.AscendingOrder);
            this.panel1.Location = new System.Drawing.Point(184, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 57);
            this.panel1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "筛选：";
            // 
            // DescendingOrder
            // 
            this.DescendingOrder.AutoSize = true;
            this.DescendingOrder.Checked = true;
            this.DescendingOrder.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DescendingOrder.Location = new System.Drawing.Point(125, 3);
            this.DescendingOrder.Name = "DescendingOrder";
            this.DescendingOrder.Size = new System.Drawing.Size(55, 24);
            this.DescendingOrder.TabIndex = 1;
            this.DescendingOrder.TabStop = true;
            this.DescendingOrder.Text = "降序";
            this.DescendingOrder.UseVisualStyleBackColor = true;
            // 
            // Chosener
            // 
            this.Chosener.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Chosener.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Chosener.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Chosener.FormattingEnabled = true;
            this.Chosener.Items.AddRange(new object[] {
            "全部",
            "默认",
            "深度",
            "上身",
            "下身",
            "体重",
            "最大生命值",
            "最大魔法值",
            "最大体力值",
            "力量",
            "智力",
            "敏捷",
            "意志",
            "幸运",
            "最大攻击力",
            "最小攻击力",
            "防御",
            "保护",
            "魔法攻击力",
            "魔法防御力",
            "魔法保护",
            "料理日记统计",
            "失败产物",
            "活动产物"});
            this.Chosener.Location = new System.Drawing.Point(0, 28);
            this.Chosener.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Chosener.Name = "Chosener";
            this.Chosener.Size = new System.Drawing.Size(186, 29);
            this.Chosener.TabIndex = 10;
            this.Chosener.SelectedIndexChanged += new System.EventHandler(this.Chosener_SelectedIndexChanged);
            // 
            // AscendingOrder
            // 
            this.AscendingOrder.AutoSize = true;
            this.AscendingOrder.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AscendingOrder.Location = new System.Drawing.Point(64, 3);
            this.AscendingOrder.Name = "AscendingOrder";
            this.AscendingOrder.Size = new System.Drawing.Size(55, 24);
            this.AscendingOrder.TabIndex = 0;
            this.AscendingOrder.Text = "升序";
            this.AscendingOrder.UseVisualStyleBackColor = true;
            this.AscendingOrder.CheckedChanged += new System.EventHandler(this.AscendingOrder_CheckedChanged);
            // 
            // MenuOpen
            // 
            this.MenuOpen.Enabled = false;
            this.MenuOpen.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MenuOpen.Location = new System.Drawing.Point(100, 157);
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.Size = new System.Drawing.Size(75, 30);
            this.MenuOpen.TabIndex = 8;
            this.MenuOpen.TabStop = false;
            this.MenuOpen.Text = "详细菜单";
            this.MenuOpen.UseVisualStyleBackColor = true;
            this.MenuOpen.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "搜索：";
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchBox.Location = new System.Drawing.Point(0, 29);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(178, 26);
            this.SearchBox.TabIndex = 13;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Other);
            this.tabPage1.Controls.Add(this.Deepth);
            this.tabPage1.Controls.Add(this.FavoriteAdd);
            this.tabPage1.Controls.Add(this.ChoosedNum);
            this.tabPage1.Controls.Add(this.Pic);
            this.tabPage1.Controls.Add(this.MenuOpen);
            this.tabPage1.Controls.Add(this.RecipeName);
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(182, 195);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "概要";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Other
            // 
            this.Other.BackColor = System.Drawing.Color.White;
            this.Other.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Other.Dock = System.Windows.Forms.DockStyle.Top;
            this.Other.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Other.Location = new System.Drawing.Point(3, 129);
            this.Other.Name = "Other";
            this.Other.ReadOnly = true;
            this.Other.Size = new System.Drawing.Size(176, 22);
            this.Other.TabIndex = 39;
            this.Other.TabStop = false;
            this.Other.Text = "其他";
            this.Other.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Deepth
            // 
            this.Deepth.BackColor = System.Drawing.Color.White;
            this.Deepth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Deepth.Dock = System.Windows.Forms.DockStyle.Top;
            this.Deepth.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Deepth.Location = new System.Drawing.Point(3, 107);
            this.Deepth.Name = "Deepth";
            this.Deepth.ReadOnly = true;
            this.Deepth.Size = new System.Drawing.Size(176, 22);
            this.Deepth.TabIndex = 38;
            this.Deepth.TabStop = false;
            this.Deepth.Text = "深度";
            this.Deepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FavoriteAdd
            // 
            this.FavoriteAdd.Enabled = false;
            this.FavoriteAdd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FavoriteAdd.Location = new System.Drawing.Point(6, 157);
            this.FavoriteAdd.Name = "FavoriteAdd";
            this.FavoriteAdd.Size = new System.Drawing.Size(75, 30);
            this.FavoriteAdd.TabIndex = 36;
            this.FavoriteAdd.TabStop = false;
            this.FavoriteAdd.Text = "添加收藏";
            this.FavoriteAdd.UseVisualStyleBackColor = true;
            this.FavoriteAdd.Click += new System.EventHandler(this.FavoriteAdd_Click);
            // 
            // ChoosedNum
            // 
            this.ChoosedNum.BackColor = System.Drawing.Color.White;
            this.ChoosedNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChoosedNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChoosedNum.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChoosedNum.ForeColor = System.Drawing.Color.Maroon;
            this.ChoosedNum.Location = new System.Drawing.Point(3, 85);
            this.ChoosedNum.Name = "ChoosedNum";
            this.ChoosedNum.ReadOnly = true;
            this.ChoosedNum.Size = new System.Drawing.Size(176, 22);
            this.ChoosedNum.TabIndex = 33;
            this.ChoosedNum.TabStop = false;
            this.ChoosedNum.Text = "筛选数值";
            this.ChoosedNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Pic
            // 
            this.Pic.BackColor = System.Drawing.Color.White;
            this.Pic.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pic.InitialImage = null;
            this.Pic.Location = new System.Drawing.Point(3, 25);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(176, 60);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pic.TabIndex = 31;
            this.Pic.TabStop = false;
            // 
            // RecipeName
            // 
            this.RecipeName.BackColor = System.Drawing.Color.White;
            this.RecipeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecipeName.Dock = System.Windows.Forms.DockStyle.Top;
            this.RecipeName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RecipeName.Location = new System.Drawing.Point(3, 3);
            this.RecipeName.Name = "RecipeName";
            this.RecipeName.ReadOnly = true;
            this.RecipeName.Size = new System.Drawing.Size(176, 22);
            this.RecipeName.TabIndex = 30;
            this.RecipeName.TabStop = false;
            this.RecipeName.Text = "胡椒味浓烈的烤丝绸旗鱼";
            this.RecipeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(180, 129);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(190, 225);
            this.tabControl1.TabIndex = 11;
            // 
            // Closer
            // 
            this.Closer.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Closer.Location = new System.Drawing.Point(291, 392);
            this.Closer.Name = "Closer";
            this.Closer.Size = new System.Drawing.Size(75, 30);
            this.Closer.TabIndex = 35;
            this.Closer.Text = "关闭";
            this.Closer.UseVisualStyleBackColor = true;
            this.Closer.Click += new System.EventHandler(this.Closer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "在载入收藏夹后才可添加";
            // 
            // OnTop
            // 
            this.OnTop.AutoSize = true;
            this.OnTop.Location = new System.Drawing.Point(226, 399);
            this.OnTop.Name = "OnTop";
            this.OnTop.Size = new System.Drawing.Size(51, 21);
            this.OnTop.TabIndex = 37;
            this.OnTop.TabStop = false;
            this.OnTop.Text = "置顶";
            this.OnTop.UseVisualStyleBackColor = true;
            this.OnTop.CheckedChanged += new System.EventHandler(this.OnTop_CheckedChanged);
            // 
            // RecipeSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(371, 429);
            this.Controls.Add(this.OnTop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Closer);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Technique);
            this.Controls.Add(this.listBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "RecipeSearcher";
            this.Text = "料理搜索";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecipeSearcher_FormClosing);
            this.Load += new System.EventHandler(this.RecipeSearcher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ComboBox Technique;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton DescendingOrder;
        private System.Windows.Forms.RadioButton AscendingOrder;
        private System.Windows.Forms.Button MenuOpen;
        private System.Windows.Forms.ComboBox Chosener;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox ChoosedNum;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.TextBox RecipeName;
        private System.Windows.Forms.Button Closer;
        private System.Windows.Forms.Button FavoriteAdd;
        private System.Windows.Forms.TextBox Other;
        private System.Windows.Forms.TextBox Deepth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox OnTop;
    }
}
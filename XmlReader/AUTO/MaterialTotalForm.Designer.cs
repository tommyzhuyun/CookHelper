
namespace CookHelper
{
    partial class MaterialTotalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialTotalForm));
            this.ListPanel = new System.Windows.Forms.Panel();
            this.SamplePanel = new System.Windows.Forms.Panel();
            this.SampleCheck = new System.Windows.Forms.CheckBox();
            this.SampleValue = new System.Windows.Forms.TextBox();
            this.SampleText = new System.Windows.Forms.TextBox();
            this.SamplePic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.OnTop = new System.Windows.Forms.CheckBox();
            this.ListPanel.SuspendLayout();
            this.SamplePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SamplePic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListPanel
            // 
            this.ListPanel.AutoScroll = true;
            this.ListPanel.Controls.Add(this.SamplePanel);
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPanel.Location = new System.Drawing.Point(0, 28);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(752, 163);
            this.ListPanel.TabIndex = 30;
            // 
            // SamplePanel
            // 
            this.SamplePanel.BackColor = System.Drawing.Color.White;
            this.SamplePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SamplePanel.Controls.Add(this.SampleCheck);
            this.SamplePanel.Controls.Add(this.SampleValue);
            this.SamplePanel.Controls.Add(this.SampleText);
            this.SamplePanel.Controls.Add(this.SamplePic);
            this.SamplePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SamplePanel.Location = new System.Drawing.Point(0, 0);
            this.SamplePanel.Name = "SamplePanel";
            this.SamplePanel.Size = new System.Drawing.Size(90, 163);
            this.SamplePanel.TabIndex = 30;
            this.SamplePanel.Visible = false;
            // 
            // SampleCheck
            // 
            this.SampleCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.SampleCheck.AutoSize = true;
            this.SampleCheck.Cursor = System.Windows.Forms.Cursors.Default;
            this.SampleCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.SampleCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SampleCheck.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SampleCheck.Location = new System.Drawing.Point(0, 115);
            this.SampleCheck.Name = "SampleCheck";
            this.SampleCheck.Size = new System.Drawing.Size(86, 30);
            this.SampleCheck.TabIndex = 8;
            this.SampleCheck.TabStop = false;
            this.SampleCheck.Text = "查询来源";
            this.SampleCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SampleCheck.UseVisualStyleBackColor = true;
            // 
            // SampleValue
            // 
            this.SampleValue.BackColor = System.Drawing.Color.White;
            this.SampleValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.SampleValue.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SampleValue.Location = new System.Drawing.Point(0, 89);
            this.SampleValue.Name = "SampleValue";
            this.SampleValue.Size = new System.Drawing.Size(86, 26);
            this.SampleValue.TabIndex = 4;
            this.SampleValue.TabStop = false;
            this.SampleValue.Text = "10个";
            this.SampleValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SampleText
            // 
            this.SampleText.BackColor = System.Drawing.Color.White;
            this.SampleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SampleText.Dock = System.Windows.Forms.DockStyle.Top;
            this.SampleText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SampleText.Location = new System.Drawing.Point(0, 56);
            this.SampleText.Multiline = true;
            this.SampleText.Name = "SampleText";
            this.SampleText.ReadOnly = true;
            this.SampleText.Size = new System.Drawing.Size(86, 33);
            this.SampleText.TabIndex = 5;
            this.SampleText.TabStop = false;
            this.SampleText.Text = "旗鱼";
            this.SampleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SamplePic
            // 
            this.SamplePic.BackColor = System.Drawing.Color.White;
            this.SamplePic.Dock = System.Windows.Forms.DockStyle.Top;
            this.SamplePic.InitialImage = null;
            this.SamplePic.Location = new System.Drawing.Point(0, 0);
            this.SamplePic.Name = "SamplePic";
            this.SamplePic.Size = new System.Drawing.Size(86, 56);
            this.SamplePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SamplePic.TabIndex = 0;
            this.SamplePic.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.OnTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 28);
            this.panel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "排序方式：未知 → 可料理 → 任务卷轴获取 → 可采集 → 商店购买";
            // 
            // OnTop
            // 
            this.OnTop.AutoSize = true;
            this.OnTop.Location = new System.Drawing.Point(12, 4);
            this.OnTop.Name = "OnTop";
            this.OnTop.Size = new System.Drawing.Size(51, 21);
            this.OnTop.TabIndex = 0;
            this.OnTop.Text = "置顶";
            this.OnTop.UseVisualStyleBackColor = true;
            this.OnTop.CheckedChanged += new System.EventHandler(this.OnTop_CheckedChanged);
            // 
            // MaterialTotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 191);
            this.Controls.Add(this.ListPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaterialTotalForm";
            this.Text = "材料统计窗口";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaterialTotalForm_FormClosing);
            this.Load += new System.EventHandler(this.MaterialTotalForm_Load);
            this.ListPanel.ResumeLayout(false);
            this.SamplePanel.ResumeLayout(false);
            this.SamplePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SamplePic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Panel SamplePanel;
        private System.Windows.Forms.CheckBox SampleCheck;
        private System.Windows.Forms.TextBox SampleValue;
        private System.Windows.Forms.TextBox SampleText;
        private System.Windows.Forms.PictureBox SamplePic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox OnTop;
        private System.Windows.Forms.Label label1;
    }
}
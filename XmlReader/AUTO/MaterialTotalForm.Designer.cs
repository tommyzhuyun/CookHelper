
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
            this.SamplePanel = new System.Windows.Forms.Panel();
            this.SampleCheck = new System.Windows.Forms.CheckBox();
            this.SampleValue = new System.Windows.Forms.TextBox();
            this.SampleText = new System.Windows.Forms.TextBox();
            this.SamplePic = new System.Windows.Forms.PictureBox();
            this.SamplePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SamplePic)).BeginInit();
            this.SuspendLayout();
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
            this.SamplePanel.Size = new System.Drawing.Size(90, 172);
            this.SamplePanel.TabIndex = 29;
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
            this.SampleCheck.CheckedChanged += new System.EventHandler(this.SampleCheck_CheckedChanged);
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
            // MaterialTotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(566, 172);
            this.Controls.Add(this.SamplePanel);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaterialTotalForm";
            this.Text = "MaterialTotalForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaterialTotalForm_FormClosing);
            this.Load += new System.EventHandler(this.MaterialTotalForm_Load);
            this.SamplePanel.ResumeLayout(false);
            this.SamplePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SamplePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SamplePanel;
        private System.Windows.Forms.CheckBox SampleCheck;
        private System.Windows.Forms.TextBox SampleValue;
        private System.Windows.Forms.TextBox SampleText;
        private System.Windows.Forms.PictureBox SamplePic;
    }
}
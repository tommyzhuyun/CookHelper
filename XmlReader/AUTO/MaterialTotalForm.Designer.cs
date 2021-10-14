
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.ItemText3 = new System.Windows.Forms.TextBox();
            this.ItemValue3 = new System.Windows.Forms.TextBox();
            this.ItemFrom3 = new System.Windows.Forms.CheckBox();
            this.ItemPic3 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPic3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.ItemText3);
            this.panel4.Controls.Add(this.ItemValue3);
            this.panel4.Controls.Add(this.ItemFrom3);
            this.panel4.Controls.Add(this.ItemPic3);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 150);
            this.panel4.TabIndex = 28;
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
            this.ItemValue3.BackColor = System.Drawing.Color.White;
            this.ItemValue3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemValue3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemValue3.Location = new System.Drawing.Point(0, 90);
            this.ItemValue3.Name = "ItemValue3";
            this.ItemValue3.Size = new System.Drawing.Size(86, 26);
            this.ItemValue3.TabIndex = 4;
            this.ItemValue3.TabStop = false;
            this.ItemValue3.Text = "10个";
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
            // MaterialTotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 197);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaterialTotalForm";
            this.Text = "MaterialTotalForm";
            this.Load += new System.EventHandler(this.MaterialTotalForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPic3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox ItemText3;
        private System.Windows.Forms.TextBox ItemValue3;
        private System.Windows.Forms.CheckBox ItemFrom3;
        private System.Windows.Forms.PictureBox ItemPic3;
    }
}
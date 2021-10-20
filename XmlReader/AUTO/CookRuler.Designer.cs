
namespace CookHelper
{
    partial class CookRuler
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CookRuler));
            this.RulerPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // RulerPanel
            // 
            this.RulerPanel.Location = new System.Drawing.Point(22, 26);
            this.RulerPanel.Name = "RulerPanel";
            this.RulerPanel.Size = new System.Drawing.Size(232, 16);
            this.RulerPanel.TabIndex = 0;
            // 
            // CookRuler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CookHelper.Properties.Resources.BGI;
            this.ClientSize = new System.Drawing.Size(276, 107);
            this.Controls.Add(this.RulerPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CookRuler";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.CookRuler_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CookRuler_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CookRuler_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CookRuler_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CookRuler_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CookRuler_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RulerPanel;
    }
}


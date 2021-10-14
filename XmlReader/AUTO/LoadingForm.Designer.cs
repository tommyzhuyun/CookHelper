
namespace CookHelper
{
    partial class LoadingForm
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
            this.components = new System.ComponentModel.Container();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SearcherButton = new System.Windows.Forms.Button();
            this.Favorite = new System.Windows.Forms.Button();
            this.AutoHide = new System.Windows.Forms.CheckBox();
            this.FileReaded = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.LoadingLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.WorkerReportsProgress = true;
            this.BackgroundWorker.WorkerSupportsCancellation = true;
            this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.BackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.BackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // SearcherButton
            // 
            this.SearcherButton.Enabled = false;
            this.SearcherButton.Location = new System.Drawing.Point(12, 28);
            this.SearcherButton.Name = "SearcherButton";
            this.SearcherButton.Size = new System.Drawing.Size(101, 30);
            this.SearcherButton.TabIndex = 4;
            this.SearcherButton.Text = "正在载入清单";
            this.SearcherButton.UseVisualStyleBackColor = true;
            this.SearcherButton.Click += new System.EventHandler(this.Searcher_Click);
            // 
            // Favorite
            // 
            this.Favorite.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Favorite.Location = new System.Drawing.Point(12, 64);
            this.Favorite.Name = "Favorite";
            this.Favorite.Size = new System.Drawing.Size(101, 30);
            this.Favorite.TabIndex = 36;
            this.Favorite.Text = "打开收藏夹";
            this.Favorite.UseVisualStyleBackColor = true;
            this.Favorite.Click += new System.EventHandler(this.Favorite_Click);
            // 
            // AutoHide
            // 
            this.AutoHide.AutoSize = true;
            this.AutoHide.Location = new System.Drawing.Point(119, 32);
            this.AutoHide.Name = "AutoHide";
            this.AutoHide.Size = new System.Drawing.Size(84, 24);
            this.AutoHide.TabIndex = 37;
            this.AutoHide.Text = "自动隐藏";
            this.AutoHide.UseVisualStyleBackColor = true;
            // 
            // FileReaded
            // 
            this.FileReaded.AutoSize = true;
            this.FileReaded.Location = new System.Drawing.Point(119, 69);
            this.FileReaded.Name = "FileReaded";
            this.FileReaded.Size = new System.Drawing.Size(93, 20);
            this.FileReaded.TabIndex = 38;
            this.FileReaded.Text = "未载入收藏夹";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Message.Location = new System.Drawing.Point(12, 97);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(223, 22);
            this.Message.TabIndex = 39;
            this.Message.Text = "By 鸡蛋甲天下(潘妮) 1943495203";
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关闭ToolStripMenuItem.Text = "关闭";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关闭ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(120, 22);
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(91, 22);
            this.LoadingLabel.Text = "NowLoading...";
            // 
            // toolStrip2
            // 
            this.toolStrip2.CanOverflow = false;
            this.toolStrip2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.LoadingLabel});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(275, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 124);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.FileReaded);
            this.Controls.Add(this.AutoHide);
            this.Controls.Add(this.Favorite);
            this.Controls.Add(this.SearcherButton);
            this.Controls.Add(this.toolStrip2);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(150, 100);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "LoadingForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "料理助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadingForm_FormClosing);
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private System.Windows.Forms.Button SearcherButton;
        private System.Windows.Forms.Button Favorite;
        private System.Windows.Forms.CheckBox AutoHide;
        private System.Windows.Forms.Label FileReaded;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripLabel LoadingLabel;
        private System.Windows.Forms.ToolStrip toolStrip2;
    }
}
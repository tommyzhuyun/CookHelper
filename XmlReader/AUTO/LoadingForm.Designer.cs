﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SearcherButton = new System.Windows.Forms.Button();
            this.Favorite = new System.Windows.Forms.Button();
            this.FileReaded = new System.Windows.Forms.Label();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.LoadingLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.HelpWord = new System.Windows.Forms.Button();
            this.HighDPI = new System.Windows.Forms.CheckBox();
            this.Message = new System.Windows.Forms.TextBox();
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
            this.SearcherButton.Location = new System.Drawing.Point(5, 28);
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
            this.Favorite.Location = new System.Drawing.Point(5, 64);
            this.Favorite.Name = "Favorite";
            this.Favorite.Size = new System.Drawing.Size(101, 30);
            this.Favorite.TabIndex = 36;
            this.Favorite.Text = "打开收藏夹";
            this.Favorite.UseVisualStyleBackColor = true;
            this.Favorite.Click += new System.EventHandler(this.Favorite_Click);
            // 
            // FileReaded
            // 
            this.FileReaded.AutoSize = true;
            this.FileReaded.Location = new System.Drawing.Point(112, 69);
            this.FileReaded.Name = "FileReaded";
            this.FileReaded.Size = new System.Drawing.Size(93, 20);
            this.FileReaded.TabIndex = 38;
            this.FileReaded.Text = "未载入收藏夹";
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
            this.toolStrip2.Size = new System.Drawing.Size(239, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // HelpWord
            // 
            this.HelpWord.Location = new System.Drawing.Point(112, 28);
            this.HelpWord.Name = "HelpWord";
            this.HelpWord.Size = new System.Drawing.Size(75, 30);
            this.HelpWord.TabIndex = 40;
            this.HelpWord.Text = "帮助文档";
            this.HelpWord.UseVisualStyleBackColor = true;
            this.HelpWord.Click += new System.EventHandler(this.HelpWord_Click);
            // 
            // HighDPI
            // 
            this.HighDPI.AutoSize = true;
            this.HighDPI.BackColor = System.Drawing.SystemColors.Control;
            this.HighDPI.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HighDPI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HighDPI.Location = new System.Drawing.Point(188, 25);
            this.HighDPI.Name = "HighDPI";
            this.HighDPI.Size = new System.Drawing.Size(51, 36);
            this.HighDPI.TabIndex = 41;
            this.HighDPI.TabStop = false;
            this.HighDPI.Text = "高DPI";
            this.HighDPI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HighDPI.UseVisualStyleBackColor = false;
            this.HighDPI.CheckedChanged += new System.EventHandler(this.HighDPI_CheckedChanged);
            // 
            // Message
            // 
            this.Message.BackColor = System.Drawing.SystemColors.Control;
            this.Message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Message.Location = new System.Drawing.Point(0, 100);
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Size = new System.Drawing.Size(239, 19);
            this.Message.TabIndex = 42;
            this.Message.TabStop = false;
            this.Message.Text = "By 鸡蛋甲天下(潘妮) 1943495203";
            this.Message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(239, 126);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.HighDPI);
            this.Controls.Add(this.HelpWord);
            this.Controls.Add(this.FileReaded);
            this.Controls.Add(this.Favorite);
            this.Controls.Add(this.SearcherButton);
            this.Controls.Add(this.toolStrip2);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(200, 100);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "LoadingForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "料理助手V1.3";
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
        private System.Windows.Forms.Label FileReaded;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripLabel LoadingLabel;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.Button HelpWord;
        private System.Windows.Forms.CheckBox HighDPI;
        private System.Windows.Forms.TextBox Message;
    }
}

namespace CookHelper
{
    partial class ItemList
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.LoadFile = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.DeleteFile = new System.Windows.Forms.Button();
            this.Statistic = new System.Windows.Forms.Button();
            this.CreateFile = new System.Windows.Forms.Button();
            this.ChooseAll = new System.Windows.Forms.Button();
            this.InverseChoose = new System.Windows.Forms.Button();
            this.LoadInfo = new System.Windows.Forms.TextBox();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Loading = new System.Windows.Forms.TextBox();
            this.ExamplePanel = new System.Windows.Forms.Panel();
            this.ExampleLabel = new System.Windows.Forms.TextBox();
            this.ExampleCheckBox = new System.Windows.Forms.CheckBox();
            this.ExamplePic = new System.Windows.Forms.PictureBox();
            this.FoodMenuPanel = new System.Windows.Forms.Panel();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.ButtonPanel.SuspendLayout();
            this.ExamplePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExamplePic)).BeginInit();
            this.FoodMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(3, 359);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 30);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "关闭";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LoadFile
            // 
            this.LoadFile.Location = new System.Drawing.Point(3, 72);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(75, 30);
            this.LoadFile.TabIndex = 4;
            this.LoadFile.Text = "载入";
            this.LoadFile.UseVisualStyleBackColor = true;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Enabled = false;
            this.SaveFile.Location = new System.Drawing.Point(3, 144);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(75, 30);
            this.SaveFile.TabIndex = 5;
            this.SaveFile.Text = "保存";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // DeleteFile
            // 
            this.DeleteFile.Enabled = false;
            this.DeleteFile.Location = new System.Drawing.Point(3, 7);
            this.DeleteFile.Name = "DeleteFile";
            this.DeleteFile.Size = new System.Drawing.Size(75, 30);
            this.DeleteFile.TabIndex = 6;
            this.DeleteFile.Text = "删除";
            this.DeleteFile.UseVisualStyleBackColor = true;
            this.DeleteFile.Click += new System.EventHandler(this.DeleteFile_Click);
            // 
            // Statistic
            // 
            this.Statistic.Enabled = false;
            this.Statistic.Location = new System.Drawing.Point(3, 288);
            this.Statistic.Name = "Statistic";
            this.Statistic.Size = new System.Drawing.Size(75, 30);
            this.Statistic.TabIndex = 7;
            this.Statistic.Text = "统计";
            this.Statistic.UseVisualStyleBackColor = true;
            this.Statistic.Click += new System.EventHandler(this.Statistic_Click);
            // 
            // CreateFile
            // 
            this.CreateFile.Location = new System.Drawing.Point(3, 108);
            this.CreateFile.Name = "CreateFile";
            this.CreateFile.Size = new System.Drawing.Size(75, 30);
            this.CreateFile.TabIndex = 9;
            this.CreateFile.Text = "新建";
            this.CreateFile.UseVisualStyleBackColor = true;
            this.CreateFile.Click += new System.EventHandler(this.CreateFile_Click);
            // 
            // ChooseAll
            // 
            this.ChooseAll.Enabled = false;
            this.ChooseAll.Location = new System.Drawing.Point(3, 230);
            this.ChooseAll.Name = "ChooseAll";
            this.ChooseAll.Size = new System.Drawing.Size(75, 30);
            this.ChooseAll.TabIndex = 10;
            this.ChooseAll.Text = "全选";
            this.ChooseAll.UseVisualStyleBackColor = true;
            this.ChooseAll.Click += new System.EventHandler(this.ChooseAll_Click);
            // 
            // InverseChoose
            // 
            this.InverseChoose.Enabled = false;
            this.InverseChoose.Location = new System.Drawing.Point(3, 194);
            this.InverseChoose.Name = "InverseChoose";
            this.InverseChoose.Size = new System.Drawing.Size(75, 30);
            this.InverseChoose.TabIndex = 11;
            this.InverseChoose.Text = "反选";
            this.InverseChoose.UseVisualStyleBackColor = true;
            this.InverseChoose.Click += new System.EventHandler(this.InverseChoose_Click);
            // 
            // LoadInfo
            // 
            this.LoadInfo.BackColor = System.Drawing.SystemColors.Control;
            this.LoadInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoadInfo.Location = new System.Drawing.Point(8, 49);
            this.LoadInfo.Name = "LoadInfo";
            this.LoadInfo.ReadOnly = true;
            this.LoadInfo.Size = new System.Drawing.Size(65, 16);
            this.LoadInfo.TabIndex = 12;
            this.LoadInfo.TabStop = false;
            this.LoadInfo.Text = "未加载";
            this.LoadInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.ProgressBar);
            this.ButtonPanel.Controls.Add(this.Loading);
            this.ButtonPanel.Controls.Add(this.Statistic);
            this.ButtonPanel.Controls.Add(this.LoadInfo);
            this.ButtonPanel.Controls.Add(this.ChooseAll);
            this.ButtonPanel.Controls.Add(this.CloseButton);
            this.ButtonPanel.Controls.Add(this.SaveFile);
            this.ButtonPanel.Controls.Add(this.CreateFile);
            this.ButtonPanel.Controls.Add(this.DeleteFile);
            this.ButtonPanel.Controls.Add(this.InverseChoose);
            this.ButtonPanel.Controls.Add(this.LoadFile);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonPanel.Location = new System.Drawing.Point(300, 0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(81, 393);
            this.ButtonPanel.TabIndex = 13;
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.ProgressBar.Location = new System.Drawing.Point(3, 319);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(75, 23);
            this.ProgressBar.TabIndex = 14;
            // 
            // Loading
            // 
            this.Loading.BackColor = System.Drawing.SystemColors.Control;
            this.Loading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Loading.Location = new System.Drawing.Point(8, 266);
            this.Loading.Name = "Loading";
            this.Loading.ReadOnly = true;
            this.Loading.Size = new System.Drawing.Size(65, 16);
            this.Loading.TabIndex = 13;
            this.Loading.TabStop = false;
            this.Loading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExamplePanel
            // 
            this.ExamplePanel.BackColor = System.Drawing.Color.OldLace;
            this.ExamplePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExamplePanel.Controls.Add(this.ExampleLabel);
            this.ExamplePanel.Controls.Add(this.ExampleCheckBox);
            this.ExamplePanel.Controls.Add(this.ExamplePic);
            this.ExamplePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExamplePanel.Location = new System.Drawing.Point(0, 0);
            this.ExamplePanel.Name = "ExamplePanel";
            this.ExamplePanel.Size = new System.Drawing.Size(300, 56);
            this.ExamplePanel.TabIndex = 3;
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.BackColor = System.Drawing.Color.OldLace;
            this.ExampleLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExampleLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExampleLabel.Location = new System.Drawing.Point(85, 14);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.ReadOnly = true;
            this.ExampleLabel.Size = new System.Drawing.Size(200, 22);
            this.ExampleLabel.TabIndex = 9;
            this.ExampleLabel.Text = "胡椒味浓烈的烤丝绸旗鱼";
            this.ExampleLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExampleCheckBox
            // 
            this.ExampleCheckBox.AutoSize = true;
            this.ExampleCheckBox.Location = new System.Drawing.Point(70, 20);
            this.ExampleCheckBox.Name = "ExampleCheckBox";
            this.ExampleCheckBox.Size = new System.Drawing.Size(15, 14);
            this.ExampleCheckBox.TabIndex = 4;
            this.ExampleCheckBox.TabStop = false;
            this.ExampleCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExamplePic
            // 
            this.ExamplePic.BackColor = System.Drawing.Color.OldLace;
            this.ExamplePic.Dock = System.Windows.Forms.DockStyle.Left;
            this.ExamplePic.Location = new System.Drawing.Point(0, 0);
            this.ExamplePic.Name = "ExamplePic";
            this.ExamplePic.Size = new System.Drawing.Size(64, 54);
            this.ExamplePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ExamplePic.TabIndex = 5;
            this.ExamplePic.TabStop = false;
            // 
            // FoodMenuPanel
            // 
            this.FoodMenuPanel.AutoScroll = true;
            this.FoodMenuPanel.BackColor = System.Drawing.Color.White;
            this.FoodMenuPanel.Controls.Add(this.ExamplePanel);
            this.FoodMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FoodMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.FoodMenuPanel.Name = "FoodMenuPanel";
            this.FoodMenuPanel.Size = new System.Drawing.Size(300, 393);
            this.FoodMenuPanel.TabIndex = 2;
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.WorkerReportsProgress = true;
            this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.BackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.BackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 393);
            this.Controls.Add(this.FoodMenuPanel);
            this.Controls.Add(this.ButtonPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemList";
            this.Text = "收藏夹";
            this.Load += new System.EventHandler(this.RecipeList_Load);
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            this.ExamplePanel.ResumeLayout(false);
            this.ExamplePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExamplePic)).EndInit();
            this.FoodMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button LoadFile;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Button DeleteFile;
        private System.Windows.Forms.Button Statistic;
        private System.Windows.Forms.Button CreateFile;
        private System.Windows.Forms.Button ChooseAll;
        private System.Windows.Forms.Button InverseChoose;
        private System.Windows.Forms.TextBox LoadInfo;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Panel ExamplePanel;
        private System.Windows.Forms.TextBox ExampleLabel;
        private System.Windows.Forms.PictureBox ExamplePic;
        private System.Windows.Forms.CheckBox ExampleCheckBox;
        private System.Windows.Forms.Panel FoodMenuPanel;
        private System.Windows.Forms.TextBox Loading;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}
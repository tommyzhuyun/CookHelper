
namespace CookHelper
{
    partial class MaterialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialForm));
            this.ItemName = new System.Windows.Forms.TextBox();
            this.Closer = new System.Windows.Forms.Button();
            this.PanelMission = new System.Windows.Forms.GroupBox();
            this.MissionInfoPanel = new System.Windows.Forms.Panel();
            this.SampleCheck = new System.Windows.Forms.CheckBox();
            this.MissionInfo = new System.Windows.Forms.TextBox();
            this.PanelSkill = new System.Windows.Forms.GroupBox();
            this.SkillInfo = new System.Windows.Forms.TextBox();
            this.SkillPic = new System.Windows.Forms.PictureBox();
            this.SkillInfoPanel = new System.Windows.Forms.Panel();
            this.ItemPic = new System.Windows.Forms.PictureBox();
            this.PanelNPC = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NPC = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelAtt2 = new System.Windows.Forms.Panel();
            this.PriceWed = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.ItemID = new System.Windows.Forms.TextBox();
            this.PanelMission.SuspendLayout();
            this.MissionInfoPanel.SuspendLayout();
            this.PanelSkill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SkillPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPic)).BeginInit();
            this.PanelNPC.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelAtt2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemName
            // 
            this.ItemName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemName.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemName.Location = new System.Drawing.Point(0, 0);
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Size = new System.Drawing.Size(234, 26);
            this.ItemName.TabIndex = 30;
            this.ItemName.TabStop = false;
            this.ItemName.Text = "胡椒味浓烈的烤丝绸旗鱼";
            this.ItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Closer
            // 
            this.Closer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Closer.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Closer.Location = new System.Drawing.Point(0, 517);
            this.Closer.Name = "Closer";
            this.Closer.Size = new System.Drawing.Size(234, 32);
            this.Closer.TabIndex = 62;
            this.Closer.Text = "关闭";
            this.Closer.UseVisualStyleBackColor = true;
            this.Closer.Click += new System.EventHandler(this.Closer_Click);
            // 
            // PanelMission
            // 
            this.PanelMission.Controls.Add(this.MissionInfoPanel);
            this.PanelMission.Controls.Add(this.MissionInfo);
            this.PanelMission.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelMission.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PanelMission.Location = new System.Drawing.Point(0, 262);
            this.PanelMission.Name = "PanelMission";
            this.PanelMission.Size = new System.Drawing.Size(234, 111);
            this.PanelMission.TabIndex = 67;
            this.PanelMission.TabStop = false;
            this.PanelMission.Text = "任务取得";
            // 
            // MissionInfoPanel
            // 
            this.MissionInfoPanel.Controls.Add(this.SampleCheck);
            this.MissionInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MissionInfoPanel.Location = new System.Drawing.Point(3, 44);
            this.MissionInfoPanel.Name = "MissionInfoPanel";
            this.MissionInfoPanel.Size = new System.Drawing.Size(228, 64);
            this.MissionInfoPanel.TabIndex = 68;
            // 
            // SampleCheck
            // 
            this.SampleCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.SampleCheck.AutoSize = true;
            this.SampleCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.SampleCheck.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SampleCheck.Location = new System.Drawing.Point(0, 0);
            this.SampleCheck.Name = "SampleCheck";
            this.SampleCheck.Size = new System.Drawing.Size(228, 30);
            this.SampleCheck.TabIndex = 52;
            this.SampleCheck.TabStop = false;
            this.SampleCheck.Text = "道具信息";
            this.SampleCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SampleCheck.UseVisualStyleBackColor = true;
            this.SampleCheck.Visible = false;
            // 
            // MissionInfo
            // 
            this.MissionInfo.BackColor = System.Drawing.SystemColors.Control;
            this.MissionInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MissionInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.MissionInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MissionInfo.Location = new System.Drawing.Point(3, 25);
            this.MissionInfo.Name = "MissionInfo";
            this.MissionInfo.ReadOnly = true;
            this.MissionInfo.Size = new System.Drawing.Size(228, 19);
            this.MissionInfo.TabIndex = 67;
            this.MissionInfo.TabStop = false;
            this.MissionInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelSkill
            // 
            this.PanelSkill.Controls.Add(this.SkillInfo);
            this.PanelSkill.Controls.Add(this.SkillPic);
            this.PanelSkill.Controls.Add(this.SkillInfoPanel);
            this.PanelSkill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelSkill.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PanelSkill.Location = new System.Drawing.Point(0, 373);
            this.PanelSkill.Name = "PanelSkill";
            this.PanelSkill.Size = new System.Drawing.Size(234, 144);
            this.PanelSkill.TabIndex = 68;
            this.PanelSkill.TabStop = false;
            this.PanelSkill.Text = "技能取得";
            // 
            // SkillInfo
            // 
            this.SkillInfo.BackColor = System.Drawing.SystemColors.Control;
            this.SkillInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SkillInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.SkillInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SkillInfo.Location = new System.Drawing.Point(63, 25);
            this.SkillInfo.Multiline = true;
            this.SkillInfo.Name = "SkillInfo";
            this.SkillInfo.ReadOnly = true;
            this.SkillInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SkillInfo.Size = new System.Drawing.Size(168, 56);
            this.SkillInfo.TabIndex = 66;
            this.SkillInfo.TabStop = false;
            this.SkillInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SkillPic
            // 
            this.SkillPic.BackColor = System.Drawing.SystemColors.Control;
            this.SkillPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.SkillPic.Location = new System.Drawing.Point(3, 25);
            this.SkillPic.Name = "SkillPic";
            this.SkillPic.Size = new System.Drawing.Size(60, 56);
            this.SkillPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SkillPic.TabIndex = 65;
            this.SkillPic.TabStop = false;
            // 
            // SkillInfoPanel
            // 
            this.SkillInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SkillInfoPanel.Location = new System.Drawing.Point(3, 81);
            this.SkillInfoPanel.Name = "SkillInfoPanel";
            this.SkillInfoPanel.Size = new System.Drawing.Size(228, 60);
            this.SkillInfoPanel.TabIndex = 55;
            // 
            // ItemPic
            // 
            this.ItemPic.BackColor = System.Drawing.SystemColors.Control;
            this.ItemPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemPic.Location = new System.Drawing.Point(0, 52);
            this.ItemPic.Name = "ItemPic";
            this.ItemPic.Size = new System.Drawing.Size(234, 61);
            this.ItemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ItemPic.TabIndex = 64;
            this.ItemPic.TabStop = false;
            // 
            // PanelNPC
            // 
            this.PanelNPC.Controls.Add(this.panel2);
            this.PanelNPC.Controls.Add(this.panel1);
            this.PanelNPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelNPC.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PanelNPC.Location = new System.Drawing.Point(0, 113);
            this.PanelNPC.Name = "PanelNPC";
            this.PanelNPC.Size = new System.Drawing.Size(234, 149);
            this.PanelNPC.TabIndex = 69;
            this.PanelNPC.TabStop = false;
            this.PanelNPC.Text = "贩卖NPC";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NPC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 81);
            this.panel2.TabIndex = 56;
            // 
            // NPC
            // 
            this.NPC.BackColor = System.Drawing.Color.White;
            this.NPC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NPC.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NPC.Location = new System.Drawing.Point(0, 0);
            this.NPC.Multiline = true;
            this.NPC.Name = "NPC";
            this.NPC.ReadOnly = true;
            this.NPC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NPC.Size = new System.Drawing.Size(228, 81);
            this.NPC.TabIndex = 53;
            this.NPC.TabStop = false;
            this.NPC.Text = "\r\n";
            this.NPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelAtt2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 40);
            this.panel1.TabIndex = 55;
            // 
            // PanelAtt2
            // 
            this.PanelAtt2.Controls.Add(this.PriceWed);
            this.PanelAtt2.Controls.Add(this.Price);
            this.PanelAtt2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAtt2.Location = new System.Drawing.Point(0, 0);
            this.PanelAtt2.Name = "PanelAtt2";
            this.PanelAtt2.Size = new System.Drawing.Size(228, 40);
            this.PanelAtt2.TabIndex = 57;
            // 
            // PriceWed
            // 
            this.PriceWed.BackColor = System.Drawing.SystemColors.Control;
            this.PriceWed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceWed.Dock = System.Windows.Forms.DockStyle.Top;
            this.PriceWed.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PriceWed.Location = new System.Drawing.Point(0, 19);
            this.PriceWed.Name = "PriceWed";
            this.PriceWed.ReadOnly = true;
            this.PriceWed.Size = new System.Drawing.Size(228, 19);
            this.PriceWed.TabIndex = 41;
            this.PriceWed.TabStop = false;
            this.PriceWed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.SystemColors.Control;
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Price.Dock = System.Windows.Forms.DockStyle.Top;
            this.Price.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Price.Location = new System.Drawing.Point(0, 0);
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(228, 19);
            this.Price.TabIndex = 39;
            this.Price.TabStop = false;
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemID
            // 
            this.ItemID.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ItemID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemID.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemID.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemID.Location = new System.Drawing.Point(0, 26);
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Size = new System.Drawing.Size(234, 26);
            this.ItemID.TabIndex = 70;
            this.ItemID.TabStop = false;
            this.ItemID.Text = "ClassID";
            this.ItemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 549);
            this.Controls.Add(this.PanelNPC);
            this.Controls.Add(this.PanelMission);
            this.Controls.Add(this.ItemPic);
            this.Controls.Add(this.ItemID);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.PanelSkill);
            this.Controls.Add(this.Closer);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaterialForm";
            this.Text = "Material";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaterialForm_FormClosing);
            this.Load += new System.EventHandler(this.MaterialForm_Load);
            this.PanelMission.ResumeLayout(false);
            this.PanelMission.PerformLayout();
            this.MissionInfoPanel.ResumeLayout(false);
            this.MissionInfoPanel.PerformLayout();
            this.PanelSkill.ResumeLayout(false);
            this.PanelSkill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SkillPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPic)).EndInit();
            this.PanelNPC.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.PanelAtt2.ResumeLayout(false);
            this.PanelAtt2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.Button Closer;
        private System.Windows.Forms.GroupBox PanelMission;
        private System.Windows.Forms.GroupBox PanelSkill;
        private System.Windows.Forms.TextBox SkillInfo;
        private System.Windows.Forms.PictureBox SkillPic;
        private System.Windows.Forms.Panel SkillInfoPanel;
        private System.Windows.Forms.PictureBox ItemPic;
        private System.Windows.Forms.GroupBox PanelNPC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox NPC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelAtt2;
        private System.Windows.Forms.TextBox PriceWed;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Panel MissionInfoPanel;
        private System.Windows.Forms.CheckBox SampleCheck;
        private System.Windows.Forms.TextBox MissionInfo;
        private System.Windows.Forms.TextBox ItemID;
    }
}
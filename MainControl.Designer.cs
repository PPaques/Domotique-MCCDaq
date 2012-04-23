namespace MyhouseDomotique
{
    partial class MainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusBarMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.MenuBarTitleProgramme = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarTitleInt = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarCredit = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureFont = new System.Windows.Forms.PictureBox();
            this.BtWindowKitchen = new System.Windows.Forms.Button();
            this.BtWindowBedroom = new System.Windows.Forms.Button();
            this.BtWindowSaloonL = new System.Windows.Forms.Button();
            this.BtWindowSaloonR = new System.Windows.Forms.Button();
            this.BtDoorKitchen = new System.Windows.Forms.Button();
            this.BtDoorBedroom = new System.Windows.Forms.Button();
            this.BtDoorEnter = new System.Windows.Forms.Button();
            this.ProgressBarBedRoom = new MyhouseDomotique.VertcicalProgressBar();
            this.ProgressBarKitchen = new MyhouseDomotique.VertcicalProgressBar();
            this.ProgressBarSaloon = new MyhouseDomotique.VertcicalProgressBar();
            this.ProgressBarOutdoor = new MyhouseDomotique.VertcicalProgressBar();
            this.fireColdPannelBedRoom = new FireColdPannel();
            this.fireHotBedRoom = new FireHotPannel();
            this.fireColdKitchen = new FireColdPannel();
            this.fireHotKitchen = new FireHotPannel();
            this.fireColdSaloon = new FireColdPannel();
            this.fireHotSaloon = new FireHotPannel();
            this.StatusBar.SuspendLayout();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFont)).BeginInit();
            this.fireColdPannelBedRoom.SuspendLayout();
            this.fireColdKitchen.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarMode});
            resources.ApplyResources(this.StatusBar, "StatusBar");
            this.StatusBar.Name = "StatusBar";
            // 
            // StatusBarMode
            // 
            this.StatusBarMode.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.StatusBarMode.Name = "StatusBarMode";
            resources.ApplyResources(this.StatusBarMode, "StatusBarMode");
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBarTitleProgramme,
            this.MenuBarTitleInt});
            resources.ApplyResources(this.MenuBar, "MenuBar");
            this.MenuBar.Name = "MenuBar";
            // 
            // MenuBarTitleProgramme
            // 
            this.MenuBarTitleProgramme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBarClose});
            this.MenuBarTitleProgramme.Name = "MenuBarTitleProgramme";
            resources.ApplyResources(this.MenuBarTitleProgramme, "MenuBarTitleProgramme");
            // 
            // MenuBarClose
            // 
            this.MenuBarClose.Name = "MenuBarClose";
            resources.ApplyResources(this.MenuBarClose, "MenuBarClose");
            this.MenuBarClose.Click += new System.EventHandler(this.MenuBarClose_Click);
            // 
            // MenuBarTitleInt
            // 
            this.MenuBarTitleInt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBarCredit});
            this.MenuBarTitleInt.Name = "MenuBarTitleInt";
            resources.ApplyResources(this.MenuBarTitleInt, "MenuBarTitleInt");
            // 
            // MenuBarCredit
            // 
            this.MenuBarCredit.Name = "MenuBarCredit";
            resources.ApplyResources(this.MenuBarCredit, "MenuBarCredit");
            // 
            // PictureFont
            // 
            resources.ApplyResources(this.PictureFont, "PictureFont");
            this.PictureFont.Image = global::MyhouseDomotique.Properties.Resources.ImageMaison1;
            this.PictureFont.Name = "PictureFont";
            this.PictureFont.TabStop = false;
            // 
            // BtWindowKitchen
            // 
            resources.ApplyResources(this.BtWindowKitchen, "BtWindowKitchen");
            this.BtWindowKitchen.BackColor = System.Drawing.Color.Black;
            this.BtWindowKitchen.ForeColor = System.Drawing.Color.White;
            this.BtWindowKitchen.Name = "BtWindowKitchen";
            this.BtWindowKitchen.Tag = "10";
            this.BtWindowKitchen.UseVisualStyleBackColor = false;
            this.BtWindowKitchen.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // BtWindowBedroom
            // 
            resources.ApplyResources(this.BtWindowBedroom, "BtWindowBedroom");
            this.BtWindowBedroom.BackColor = System.Drawing.Color.Black;
            this.BtWindowBedroom.ForeColor = System.Drawing.Color.White;
            this.BtWindowBedroom.Name = "BtWindowBedroom";
            this.BtWindowBedroom.Tag = "20";
            this.BtWindowBedroom.UseVisualStyleBackColor = false;
            this.BtWindowBedroom.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // BtWindowSaloonL
            // 
            resources.ApplyResources(this.BtWindowSaloonL, "BtWindowSaloonL");
            this.BtWindowSaloonL.BackColor = System.Drawing.Color.Black;
            this.BtWindowSaloonL.ForeColor = System.Drawing.Color.White;
            this.BtWindowSaloonL.Name = "BtWindowSaloonL";
            this.BtWindowSaloonL.Tag = "01";
            this.BtWindowSaloonL.UseVisualStyleBackColor = false;
            this.BtWindowSaloonL.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // BtWindowSaloonR
            // 
            resources.ApplyResources(this.BtWindowSaloonR, "BtWindowSaloonR");
            this.BtWindowSaloonR.BackColor = System.Drawing.Color.Black;
            this.BtWindowSaloonR.ForeColor = System.Drawing.Color.White;
            this.BtWindowSaloonR.Name = "BtWindowSaloonR";
            this.BtWindowSaloonR.Tag = "02";
            this.BtWindowSaloonR.UseVisualStyleBackColor = false;
            this.BtWindowSaloonR.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // BtDoorKitchen
            // 
            resources.ApplyResources(this.BtDoorKitchen, "BtDoorKitchen");
            this.BtDoorKitchen.BackColor = System.Drawing.Color.Black;
            this.BtDoorKitchen.ForeColor = System.Drawing.Color.White;
            this.BtDoorKitchen.Name = "BtDoorKitchen";
            this.BtDoorKitchen.Tag = "30";
            this.BtDoorKitchen.UseVisualStyleBackColor = false;
            this.BtDoorKitchen.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // BtDoorBedroom
            // 
            resources.ApplyResources(this.BtDoorBedroom, "BtDoorBedroom");
            this.BtDoorBedroom.BackColor = System.Drawing.Color.Black;
            this.BtDoorBedroom.ForeColor = System.Drawing.Color.White;
            this.BtDoorBedroom.Name = "BtDoorBedroom";
            this.BtDoorBedroom.Tag = "40";
            this.BtDoorBedroom.UseVisualStyleBackColor = false;
            this.BtDoorBedroom.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // BtDoorEnter
            // 
            resources.ApplyResources(this.BtDoorEnter, "BtDoorEnter");
            this.BtDoorEnter.BackColor = System.Drawing.Color.Black;
            this.BtDoorEnter.ForeColor = System.Drawing.Color.White;
            this.BtDoorEnter.Name = "BtDoorEnter";
            this.BtDoorEnter.Tag = "00";
            this.BtDoorEnter.UseVisualStyleBackColor = false;
            this.BtDoorEnter.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // ProgressBarBedRoom
            // 
            resources.ApplyResources(this.ProgressBarBedRoom, "ProgressBarBedRoom");
            this.ProgressBarBedRoom.BackColor = System.Drawing.Color.LightGray;
            this.ProgressBarBedRoom.Name = "ProgressBarBedRoom";
            this.ProgressBarBedRoom.Value = 50;
            // 
            // ProgressBarKitchen
            // 
            resources.ApplyResources(this.ProgressBarKitchen, "ProgressBarKitchen");
            this.ProgressBarKitchen.BackColor = System.Drawing.Color.LightGray;
            this.ProgressBarKitchen.Name = "ProgressBarKitchen";
            this.ProgressBarKitchen.Value = 50;
            // 
            // ProgressBarSaloon
            // 
            resources.ApplyResources(this.ProgressBarSaloon, "ProgressBarSaloon");
            this.ProgressBarSaloon.BackColor = System.Drawing.Color.LightGray;
            this.ProgressBarSaloon.Name = "ProgressBarSaloon";
            this.ProgressBarSaloon.Value = 50;
            // 
            // ProgressBarOutdoor
            // 
            resources.ApplyResources(this.ProgressBarOutdoor, "ProgressBarOutdoor");
            this.ProgressBarOutdoor.BackColor = System.Drawing.Color.LightGray;
            this.ProgressBarOutdoor.Name = "ProgressBarOutdoor";
            this.ProgressBarOutdoor.Value = 50;
            // 
            // fireColdPannelBedRoom
            // 
            resources.ApplyResources(this.fireColdPannelBedRoom, "fireColdPannelBedRoom");
            this.fireColdPannelBedRoom.Controls.Add(this.fireHotBedRoom);
            this.fireColdPannelBedRoom.Name = "fireColdPannelBedRoom";
            // 
            // fireHotBedRoom
            // 
            resources.ApplyResources(this.fireHotBedRoom, "fireHotBedRoom");
            this.fireHotBedRoom.Name = "fireHotBedRoom";
            // 
            // fireColdKitchen
            // 
            resources.ApplyResources(this.fireColdKitchen, "fireColdKitchen");
            this.fireColdKitchen.Controls.Add(this.fireHotKitchen);
            this.fireColdKitchen.Name = "fireColdKitchen";
            // 
            // fireHotKitchen
            // 
            resources.ApplyResources(this.fireHotKitchen, "fireHotKitchen");
            this.fireHotKitchen.Name = "fireHotKitchen";
            // 
            // fireColdSaloon
            // 
            resources.ApplyResources(this.fireColdSaloon, "fireColdSaloon");
            this.fireColdSaloon.Name = "fireColdSaloon";
            // 
            // fireHotSaloon
            // 
            resources.ApplyResources(this.fireHotSaloon, "fireHotSaloon");
            this.fireHotSaloon.Name = "fireHotSaloon";
            // 
            // MainControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fireHotSaloon);
            this.Controls.Add(this.fireColdSaloon);
            this.Controls.Add(this.fireColdKitchen);
            this.Controls.Add(this.fireColdPannelBedRoom);
            this.Controls.Add(this.ProgressBarOutdoor);
            this.Controls.Add(this.ProgressBarSaloon);
            this.Controls.Add(this.ProgressBarKitchen);
            this.Controls.Add(this.ProgressBarBedRoom);
            this.Controls.Add(this.BtDoorEnter);
            this.Controls.Add(this.BtDoorBedroom);
            this.Controls.Add(this.BtDoorKitchen);
            this.Controls.Add(this.BtWindowSaloonR);
            this.Controls.Add(this.BtWindowSaloonL);
            this.Controls.Add(this.BtWindowBedroom);
            this.Controls.Add(this.BtWindowKitchen);
            this.Controls.Add(this.PictureFont);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.StatusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainControl";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit);
            this.Load += new System.EventHandler(this.Initialisation);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFont)).EndInit();
            this.fireColdPannelBedRoom.ResumeLayout(false);
            this.fireColdKitchen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarMode;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem MenuBarTitleProgramme;
        private System.Windows.Forms.ToolStripMenuItem MenuBarClose;
        private System.Windows.Forms.ToolStripMenuItem MenuBarTitleInt;
        private System.Windows.Forms.ToolStripMenuItem MenuBarCredit;
        private System.Windows.Forms.PictureBox PictureFont;
        private System.Windows.Forms.Button BtWindowKitchen;
        private System.Windows.Forms.Button BtWindowBedroom;
        private System.Windows.Forms.Button BtWindowSaloonL;
        private System.Windows.Forms.Button BtWindowSaloonR;
        private System.Windows.Forms.Button BtDoorKitchen;
        private System.Windows.Forms.Button BtDoorBedroom;
        private System.Windows.Forms.Button BtDoorEnter;
        private VertcicalProgressBar ProgressBarBedRoom;
        private VertcicalProgressBar ProgressBarKitchen;
        private VertcicalProgressBar ProgressBarSaloon;
        private VertcicalProgressBar ProgressBarOutdoor;
        private FireColdPannel fireColdPannelBedRoom;
        private FireHotPannel fireHotBedRoom;
        private FireColdPannel fireColdKitchen;
        private FireHotPannel fireHotKitchen;
        private FireColdPannel fireColdSaloon;
        private FireHotPannel fireHotSaloon;

    }
}


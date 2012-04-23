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
            this.BtWindowKitchen = new System.Windows.Forms.Button();
            this.BtWindowBedroom = new System.Windows.Forms.Button();
            this.BtWindowSaloonL = new System.Windows.Forms.Button();
            this.BtWindowSaloonR = new System.Windows.Forms.Button();
            this.BtDoorKitchen = new System.Windows.Forms.Button();
            this.BtDoorBedroom = new System.Windows.Forms.Button();
            this.BtDoorEnter = new System.Windows.Forms.Button();
            this.tBKitchenTempAct = new System.Windows.Forms.TextBox();
            this.tBKitchenTempRef = new System.Windows.Forms.TextBox();
            this.GroupKitchen = new System.Windows.Forms.GroupBox();
            this.labelKitchenSubtitleHot = new System.Windows.Forms.Label();
            this.BtKitchenHot = new System.Windows.Forms.Button();
            this.labelKitchenSubtitleAsk = new System.Windows.Forms.Label();
            this.labelKitchenSubtitleAct = new System.Windows.Forms.Label();
            this.GroupBedroom = new System.Windows.Forms.GroupBox();
            this.labelBedRoomSubtitleHot = new System.Windows.Forms.Label();
            this.BtBedRoomHot = new System.Windows.Forms.Button();
            this.labelBedRoomSubtitleAsk = new System.Windows.Forms.Label();
            this.labelBedRoomSubtitleAct = new System.Windows.Forms.Label();
            this.tBBedRoomTempAct = new System.Windows.Forms.TextBox();
            this.tBBedRoomTempRef = new System.Windows.Forms.TextBox();
            this.GroupSaloon = new System.Windows.Forms.GroupBox();
            this.labelSaloonSubtitleHot = new System.Windows.Forms.Label();
            this.BtSaloonHot = new System.Windows.Forms.Button();
            this.labelSaloonSubtitleAsk = new System.Windows.Forms.Label();
            this.labelSaloonSubtitleAct = new System.Windows.Forms.Label();
            this.tBSaloonTempAct = new System.Windows.Forms.TextBox();
            this.tBSaloonTempRef = new System.Windows.Forms.TextBox();
            this.GroupOutdoor = new System.Windows.Forms.GroupBox();
            this.labelOutdoorLamp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelOutdoorSubtitleAct = new System.Windows.Forms.Label();
            this.tBOutdoorTempAct = new System.Windows.Forms.TextBox();
            this.PictureFont = new System.Windows.Forms.PictureBox();
            this.lighInactivePanel = new LighInactivePannel();
            this.lighActivePanel = new LighActivePannel();
            this.ProgressBarOutdoor = new MyhouseDomotique.VertcicalProgressBar();
            this.ProgressBarSaloon = new MyhouseDomotique.VertcicalProgressBar();
            this.ProgressBarBedRoom = new MyhouseDomotique.VertcicalProgressBar();
            this.fireHotBedRoom = new FireHotPannel();
            this.fireHotKitchen = new FireHotPannel();
            this.ProgressBarKitchen = new MyhouseDomotique.VertcicalProgressBar();
            this.fireHotSaloon = new FireHotPannel();
            this.fireColdSaloon = new FireColdPannel();
            this.fireColdKitchen = new FireColdPannel();
            this.fireColdPannelBedRoom = new FireColdPannel();
            this.StatusBar.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.GroupKitchen.SuspendLayout();
            this.GroupBedroom.SuspendLayout();
            this.GroupSaloon.SuspendLayout();
            this.GroupOutdoor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFont)).BeginInit();
            this.lighInactivePanel.SuspendLayout();
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
            // tBKitchenTempAct
            // 
            resources.ApplyResources(this.tBKitchenTempAct, "tBKitchenTempAct");
            this.tBKitchenTempAct.Name = "tBKitchenTempAct";
            // 
            // tBKitchenTempRef
            // 
            resources.ApplyResources(this.tBKitchenTempRef, "tBKitchenTempRef");
            this.tBKitchenTempRef.Name = "tBKitchenTempRef";
            // 
            // GroupKitchen
            // 
            resources.ApplyResources(this.GroupKitchen, "GroupKitchen");
            this.GroupKitchen.Controls.Add(this.labelKitchenSubtitleHot);
            this.GroupKitchen.Controls.Add(this.BtKitchenHot);
            this.GroupKitchen.Controls.Add(this.labelKitchenSubtitleAsk);
            this.GroupKitchen.Controls.Add(this.labelKitchenSubtitleAct);
            this.GroupKitchen.Controls.Add(this.tBKitchenTempAct);
            this.GroupKitchen.Controls.Add(this.tBKitchenTempRef);
            this.GroupKitchen.Controls.Add(this.ProgressBarKitchen);
            this.GroupKitchen.Name = "GroupKitchen";
            this.GroupKitchen.TabStop = false;
            // 
            // labelKitchenSubtitleHot
            // 
            resources.ApplyResources(this.labelKitchenSubtitleHot, "labelKitchenSubtitleHot");
            this.labelKitchenSubtitleHot.Name = "labelKitchenSubtitleHot";
            // 
            // BtKitchenHot
            // 
            resources.ApplyResources(this.BtKitchenHot, "BtKitchenHot");
            this.BtKitchenHot.Name = "BtKitchenHot";
            this.BtKitchenHot.UseVisualStyleBackColor = true;
            // 
            // labelKitchenSubtitleAsk
            // 
            resources.ApplyResources(this.labelKitchenSubtitleAsk, "labelKitchenSubtitleAsk");
            this.labelKitchenSubtitleAsk.Name = "labelKitchenSubtitleAsk";
            // 
            // labelKitchenSubtitleAct
            // 
            resources.ApplyResources(this.labelKitchenSubtitleAct, "labelKitchenSubtitleAct");
            this.labelKitchenSubtitleAct.Name = "labelKitchenSubtitleAct";
            // 
            // GroupBedroom
            // 
            resources.ApplyResources(this.GroupBedroom, "GroupBedroom");
            this.GroupBedroom.Controls.Add(this.ProgressBarBedRoom);
            this.GroupBedroom.Controls.Add(this.labelBedRoomSubtitleHot);
            this.GroupBedroom.Controls.Add(this.BtBedRoomHot);
            this.GroupBedroom.Controls.Add(this.labelBedRoomSubtitleAsk);
            this.GroupBedroom.Controls.Add(this.labelBedRoomSubtitleAct);
            this.GroupBedroom.Controls.Add(this.tBBedRoomTempAct);
            this.GroupBedroom.Controls.Add(this.tBBedRoomTempRef);
            this.GroupBedroom.Name = "GroupBedroom";
            this.GroupBedroom.TabStop = false;
            // 
            // labelBedRoomSubtitleHot
            // 
            resources.ApplyResources(this.labelBedRoomSubtitleHot, "labelBedRoomSubtitleHot");
            this.labelBedRoomSubtitleHot.Name = "labelBedRoomSubtitleHot";
            // 
            // BtBedRoomHot
            // 
            resources.ApplyResources(this.BtBedRoomHot, "BtBedRoomHot");
            this.BtBedRoomHot.Name = "BtBedRoomHot";
            this.BtBedRoomHot.UseVisualStyleBackColor = true;
            // 
            // labelBedRoomSubtitleAsk
            // 
            resources.ApplyResources(this.labelBedRoomSubtitleAsk, "labelBedRoomSubtitleAsk");
            this.labelBedRoomSubtitleAsk.Name = "labelBedRoomSubtitleAsk";
            // 
            // labelBedRoomSubtitleAct
            // 
            resources.ApplyResources(this.labelBedRoomSubtitleAct, "labelBedRoomSubtitleAct");
            this.labelBedRoomSubtitleAct.Name = "labelBedRoomSubtitleAct";
            // 
            // tBBedRoomTempAct
            // 
            resources.ApplyResources(this.tBBedRoomTempAct, "tBBedRoomTempAct");
            this.tBBedRoomTempAct.Name = "tBBedRoomTempAct";
            // 
            // tBBedRoomTempRef
            // 
            resources.ApplyResources(this.tBBedRoomTempRef, "tBBedRoomTempRef");
            this.tBBedRoomTempRef.Name = "tBBedRoomTempRef";
            // 
            // GroupSaloon
            // 
            resources.ApplyResources(this.GroupSaloon, "GroupSaloon");
            this.GroupSaloon.Controls.Add(this.ProgressBarSaloon);
            this.GroupSaloon.Controls.Add(this.labelSaloonSubtitleHot);
            this.GroupSaloon.Controls.Add(this.BtSaloonHot);
            this.GroupSaloon.Controls.Add(this.labelSaloonSubtitleAsk);
            this.GroupSaloon.Controls.Add(this.labelSaloonSubtitleAct);
            this.GroupSaloon.Controls.Add(this.tBSaloonTempAct);
            this.GroupSaloon.Controls.Add(this.tBSaloonTempRef);
            this.GroupSaloon.Name = "GroupSaloon";
            this.GroupSaloon.TabStop = false;
            // 
            // labelSaloonSubtitleHot
            // 
            resources.ApplyResources(this.labelSaloonSubtitleHot, "labelSaloonSubtitleHot");
            this.labelSaloonSubtitleHot.Name = "labelSaloonSubtitleHot";
            // 
            // BtSaloonHot
            // 
            resources.ApplyResources(this.BtSaloonHot, "BtSaloonHot");
            this.BtSaloonHot.Name = "BtSaloonHot";
            this.BtSaloonHot.UseVisualStyleBackColor = true;
            // 
            // labelSaloonSubtitleAsk
            // 
            resources.ApplyResources(this.labelSaloonSubtitleAsk, "labelSaloonSubtitleAsk");
            this.labelSaloonSubtitleAsk.Name = "labelSaloonSubtitleAsk";
            // 
            // labelSaloonSubtitleAct
            // 
            resources.ApplyResources(this.labelSaloonSubtitleAct, "labelSaloonSubtitleAct");
            this.labelSaloonSubtitleAct.Name = "labelSaloonSubtitleAct";
            // 
            // tBSaloonTempAct
            // 
            resources.ApplyResources(this.tBSaloonTempAct, "tBSaloonTempAct");
            this.tBSaloonTempAct.Name = "tBSaloonTempAct";
            // 
            // tBSaloonTempRef
            // 
            resources.ApplyResources(this.tBSaloonTempRef, "tBSaloonTempRef");
            this.tBSaloonTempRef.Name = "tBSaloonTempRef";
            // 
            // GroupOutdoor
            // 
            resources.ApplyResources(this.GroupOutdoor, "GroupOutdoor");
            this.GroupOutdoor.Controls.Add(this.labelOutdoorLamp);
            this.GroupOutdoor.Controls.Add(this.button1);
            this.GroupOutdoor.Controls.Add(this.labelOutdoorSubtitleAct);
            this.GroupOutdoor.Controls.Add(this.tBOutdoorTempAct);
            this.GroupOutdoor.Controls.Add(this.ProgressBarOutdoor);
            this.GroupOutdoor.Name = "GroupOutdoor";
            this.GroupOutdoor.TabStop = false;
            // 
            // labelOutdoorLamp
            // 
            resources.ApplyResources(this.labelOutdoorLamp, "labelOutdoorLamp");
            this.labelOutdoorLamp.Name = "labelOutdoorLamp";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelOutdoorSubtitleAct
            // 
            resources.ApplyResources(this.labelOutdoorSubtitleAct, "labelOutdoorSubtitleAct");
            this.labelOutdoorSubtitleAct.Name = "labelOutdoorSubtitleAct";
            // 
            // tBOutdoorTempAct
            // 
            resources.ApplyResources(this.tBOutdoorTempAct, "tBOutdoorTempAct");
            this.tBOutdoorTempAct.Name = "tBOutdoorTempAct";
            // 
            // PictureFont
            // 
            this.PictureFont.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.PictureFont, "PictureFont");
            this.PictureFont.Image = global::MyhouseDomotique.Properties.Resources.ImageMaison1;
            this.PictureFont.Name = "PictureFont";
            this.PictureFont.TabStop = false;
            // 
            // lighInactivePanel
            // 
            resources.ApplyResources(this.lighInactivePanel, "lighInactivePanel");
            this.lighInactivePanel.Controls.Add(this.lighActivePanel);
            this.lighInactivePanel.Name = "lighInactivePanel";
            // 
            // lighActivePanel
            // 
            resources.ApplyResources(this.lighActivePanel, "lighActivePanel");
            this.lighActivePanel.Name = "lighActivePanel";
            // 
            // ProgressBarOutdoor
            // 
            this.ProgressBarOutdoor.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.ProgressBarOutdoor, "ProgressBarOutdoor");
            this.ProgressBarOutdoor.Name = "ProgressBarOutdoor";
            this.ProgressBarOutdoor.Value = 50;
            // 
            // ProgressBarSaloon
            // 
            this.ProgressBarSaloon.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.ProgressBarSaloon, "ProgressBarSaloon");
            this.ProgressBarSaloon.Name = "ProgressBarSaloon";
            this.ProgressBarSaloon.Value = 50;
            // 
            // ProgressBarBedRoom
            // 
            this.ProgressBarBedRoom.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.ProgressBarBedRoom, "ProgressBarBedRoom");
            this.ProgressBarBedRoom.Name = "ProgressBarBedRoom";
            this.ProgressBarBedRoom.Value = 50;
            // 
            // fireHotBedRoom
            // 
            resources.ApplyResources(this.fireHotBedRoom, "fireHotBedRoom");
            this.fireHotBedRoom.Name = "fireHotBedRoom";
            // 
            // fireHotKitchen
            // 
            resources.ApplyResources(this.fireHotKitchen, "fireHotKitchen");
            this.fireHotKitchen.Name = "fireHotKitchen";
            // 
            // ProgressBarKitchen
            // 
            this.ProgressBarKitchen.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.ProgressBarKitchen, "ProgressBarKitchen");
            this.ProgressBarKitchen.Name = "ProgressBarKitchen";
            this.ProgressBarKitchen.Value = 50;
            // 
            // fireHotSaloon
            // 
            resources.ApplyResources(this.fireHotSaloon, "fireHotSaloon");
            this.fireHotSaloon.Name = "fireHotSaloon";
            // 
            // fireColdSaloon
            // 
            resources.ApplyResources(this.fireColdSaloon, "fireColdSaloon");
            this.fireColdSaloon.Name = "fireColdSaloon";
            // 
            // fireColdKitchen
            // 
            resources.ApplyResources(this.fireColdKitchen, "fireColdKitchen");
            this.fireColdKitchen.Name = "fireColdKitchen";
            // 
            // fireColdPannelBedRoom
            // 
            resources.ApplyResources(this.fireColdPannelBedRoom, "fireColdPannelBedRoom");
            this.fireColdPannelBedRoom.Name = "fireColdPannelBedRoom";
            // 
            // MainControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lighInactivePanel);
            this.Controls.Add(this.GroupOutdoor);
            this.Controls.Add(this.GroupSaloon);
            this.Controls.Add(this.GroupBedroom);
            this.Controls.Add(this.fireHotBedRoom);
            this.Controls.Add(this.fireHotKitchen);
            this.Controls.Add(this.GroupKitchen);
            this.Controls.Add(this.fireHotSaloon);
            this.Controls.Add(this.fireColdSaloon);
            this.Controls.Add(this.fireColdKitchen);
            this.Controls.Add(this.fireColdPannelBedRoom);
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
            this.GroupKitchen.ResumeLayout(false);
            this.GroupKitchen.PerformLayout();
            this.GroupBedroom.ResumeLayout(false);
            this.GroupBedroom.PerformLayout();
            this.GroupSaloon.ResumeLayout(false);
            this.GroupSaloon.PerformLayout();
            this.GroupOutdoor.ResumeLayout(false);
            this.GroupOutdoor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFont)).EndInit();
            this.lighInactivePanel.ResumeLayout(false);
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
        public System.Windows.Forms.TextBox tBKitchenTempAct;
        public System.Windows.Forms.TextBox tBKitchenTempRef;
        private System.Windows.Forms.GroupBox GroupKitchen;
        private System.Windows.Forms.Label labelKitchenSubtitleAct;
        private System.Windows.Forms.Label labelKitchenSubtitleHot;
        private System.Windows.Forms.Button BtKitchenHot;
        private System.Windows.Forms.Label labelKitchenSubtitleAsk;
        private System.Windows.Forms.GroupBox GroupBedroom;
        private System.Windows.Forms.Label labelBedRoomSubtitleHot;
        private System.Windows.Forms.Button BtBedRoomHot;
        private System.Windows.Forms.Label labelBedRoomSubtitleAsk;
        private System.Windows.Forms.Label labelBedRoomSubtitleAct;
        public System.Windows.Forms.TextBox tBBedRoomTempAct;
        public System.Windows.Forms.TextBox tBBedRoomTempRef;
        private System.Windows.Forms.GroupBox GroupSaloon;
        private System.Windows.Forms.Label labelSaloonSubtitleHot;
        private System.Windows.Forms.Button BtSaloonHot;
        private System.Windows.Forms.Label labelSaloonSubtitleAsk;
        private System.Windows.Forms.Label labelSaloonSubtitleAct;
        public System.Windows.Forms.TextBox tBSaloonTempAct;
        public System.Windows.Forms.TextBox tBSaloonTempRef;
        private System.Windows.Forms.GroupBox GroupOutdoor;
        private System.Windows.Forms.Label labelOutdoorLamp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelOutdoorSubtitleAct;
        public System.Windows.Forms.TextBox tBOutdoorTempAct;
        private LighInactivePannel lighInactivePanel;
        private LighActivePannel lighActivePanel;

    }
}


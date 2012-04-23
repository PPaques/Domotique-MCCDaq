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
            this.StatusMode = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.vertcicalProgressBar1 = new MyhouseDomotique.VertcicalProgressBar();
            this.vertcicalProgressBar2 = new MyhouseDomotique.VertcicalProgressBar();
            this.vertcicalProgressBar3 = new MyhouseDomotique.VertcicalProgressBar();
            this.vertcicalProgressBar4 = new MyhouseDomotique.VertcicalProgressBar();
            this.StatusBar.SuspendLayout();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFont)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusMode,
            this.StatusBarMode});
            resources.ApplyResources(this.StatusBar, "StatusBar");
            this.StatusBar.Name = "StatusBar";
            // 
            // StatusMode
            // 
            this.StatusMode.Name = "StatusMode";
            resources.ApplyResources(this.StatusMode, "StatusMode");
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
            // vertcicalProgressBar1
            // 
            resources.ApplyResources(this.vertcicalProgressBar1, "vertcicalProgressBar1");
            this.vertcicalProgressBar1.BackColor = System.Drawing.Color.LightGray;
            this.vertcicalProgressBar1.Name = "vertcicalProgressBar1";
            this.vertcicalProgressBar1.Value = 50;
            // 
            // vertcicalProgressBar2
            // 
            resources.ApplyResources(this.vertcicalProgressBar2, "vertcicalProgressBar2");
            this.vertcicalProgressBar2.BackColor = System.Drawing.Color.LightGray;
            this.vertcicalProgressBar2.Name = "vertcicalProgressBar2";
            this.vertcicalProgressBar2.Value = 50;
            // 
            // vertcicalProgressBar3
            // 
            resources.ApplyResources(this.vertcicalProgressBar3, "vertcicalProgressBar3");
            this.vertcicalProgressBar3.BackColor = System.Drawing.Color.LightGray;
            this.vertcicalProgressBar3.Name = "vertcicalProgressBar3";
            this.vertcicalProgressBar3.Value = 50;
            this.vertcicalProgressBar3.Click += new System.EventHandler(this.vertcicalProgressBar3_Click);
            // 
            // vertcicalProgressBar4
            // 
            resources.ApplyResources(this.vertcicalProgressBar4, "vertcicalProgressBar4");
            this.vertcicalProgressBar4.BackColor = System.Drawing.Color.LightGray;
            this.vertcicalProgressBar4.Name = "vertcicalProgressBar4";
            this.vertcicalProgressBar4.Value = 50;
            // 
            // MainControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vertcicalProgressBar4);
            this.Controls.Add(this.vertcicalProgressBar3);
            this.Controls.Add(this.vertcicalProgressBar2);
            this.Controls.Add(this.vertcicalProgressBar1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusMode;
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
        private VertcicalProgressBar vertcicalProgressBar1;
        private VertcicalProgressBar vertcicalProgressBar2;
        private VertcicalProgressBar vertcicalProgressBar3;
        private VertcicalProgressBar vertcicalProgressBar4;
        
    }
}


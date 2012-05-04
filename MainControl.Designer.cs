namespace MyhouseDomotique
{
    public partial class MainControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusBarMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.MenuBarTitleProgramme = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarRegulation = new System.Windows.Forms.ToolStripMenuItem();
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
            this.labelKitchenSubtitleAsk = new System.Windows.Forms.Label();
            this.labelKitchenSubtitleHot = new System.Windows.Forms.Label();
            this.BtKitchenHot = new System.Windows.Forms.Button();
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
            this.BtOutdoorLight = new System.Windows.Forms.Button();
            this.labelOutdoorSubtitleAct = new System.Windows.Forms.Label();
            this.tBOutdoorTempAct = new System.Windows.Forms.TextBox();
            this.TimerMainRoutine = new System.Windows.Forms.Timer(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Clock = new System.Windows.Forms.Label();
            this.TimerClock = new System.Windows.Forms.Timer(this.components);
            this.fireHotKitchen = new FireHotPannel();
            this.lighInactivePanel = new LighInactivePannel();
            this.lighActivePanel = new LighActivePannel();
            this.ProgressBarKitchen = new MyhouseDomotique.VertcicalProgressBar();
            this.fireColdKitchen = new FireColdPannel();
            this.ProgressBarOutdoor = new MyhouseDomotique.VertcicalProgressBar();
            this.ProgressBarSaloon = new MyhouseDomotique.VertcicalProgressBar();
            this.ProgressBarBedRoom = new MyhouseDomotique.VertcicalProgressBar();
            this.fireColdPannelBedRoom = new FireColdPannel();
            this.fireHotBedRoom = new FireHotPannel();
            this.fireHotSaloon = new FireHotPannel();
            this.fireColdSaloon = new FireColdPannel();
            this.StatusBar.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.GroupKitchen.SuspendLayout();
            this.GroupBedroom.SuspendLayout();
            this.GroupSaloon.SuspendLayout();
            this.GroupOutdoor.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.lighInactivePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarMode});
            this.StatusBar.Location = new System.Drawing.Point(0, 862);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.StatusBar.Size = new System.Drawing.Size(1110, 22);
            this.StatusBar.TabIndex = 0;
            this.StatusBar.Text = "StatusBar";
            // 
            // StatusBarMode
            // 
            this.StatusBarMode.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.StatusBarMode.Name = "StatusBarMode";
            this.StatusBarMode.Size = new System.Drawing.Size(38, 17);
            this.StatusBarMode.Text = "Mode";
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBarTitleProgramme,
            this.MenuBarTitleInt});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1110, 24);
            this.MenuBar.TabIndex = 83;
            this.MenuBar.Text = "MenuBar";
            // 
            // MenuBarTitleProgramme
            // 
            this.MenuBarTitleProgramme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBarRegulation,
            this.MenuBarClose});
            this.MenuBarTitleProgramme.Name = "MenuBarTitleProgramme";
            this.MenuBarTitleProgramme.Size = new System.Drawing.Size(82, 20);
            this.MenuBarTitleProgramme.Text = "Programme";
            // 
            // MenuBarRegulation
            // 
            this.MenuBarRegulation.Name = "MenuBarRegulation";
            this.MenuBarRegulation.Size = new System.Drawing.Size(178, 22);
            this.MenuBarRegulation.Text = "Lancer la régulation";
            this.MenuBarRegulation.Click += new System.EventHandler(this.StartTimerMainRoutine);
            // 
            // MenuBarClose
            // 
            this.MenuBarClose.Name = "MenuBarClose";
            this.MenuBarClose.Size = new System.Drawing.Size(178, 22);
            this.MenuBarClose.Text = "Fermer";
            this.MenuBarClose.Click += new System.EventHandler(this.MenuBarClose_Click);
            // 
            // MenuBarTitleInt
            // 
            this.MenuBarTitleInt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBarCredit});
            this.MenuBarTitleInt.Name = "MenuBarTitleInt";
            this.MenuBarTitleInt.Size = new System.Drawing.Size(24, 20);
            this.MenuBarTitleInt.Text = "?";
            // 
            // MenuBarCredit
            // 
            this.MenuBarCredit.Name = "MenuBarCredit";
            this.MenuBarCredit.Size = new System.Drawing.Size(111, 22);
            this.MenuBarCredit.Text = "Crédits";
            // 
            // BtWindowKitchen
            // 
            this.BtWindowKitchen.BackColor = System.Drawing.Color.Black;
            this.BtWindowKitchen.Enabled = false;
            this.BtWindowKitchen.ForeColor = System.Drawing.Color.White;
            this.BtWindowKitchen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtWindowKitchen.Location = new System.Drawing.Point(130, 5);
            this.BtWindowKitchen.Margin = new System.Windows.Forms.Padding(2);
            this.BtWindowKitchen.Name = "BtWindowKitchen";
            this.BtWindowKitchen.Size = new System.Drawing.Size(164, 31);
            this.BtWindowKitchen.TabIndex = 85;
            this.BtWindowKitchen.Tag = "10";
            this.BtWindowKitchen.Text = "Fenêtre Cuisine";
            this.BtWindowKitchen.UseVisualStyleBackColor = false;
            this.BtWindowKitchen.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // BtWindowBedroom
            // 
            this.BtWindowBedroom.BackColor = System.Drawing.Color.Black;
            this.BtWindowBedroom.Enabled = false;
            this.BtWindowBedroom.ForeColor = System.Drawing.Color.White;
            this.BtWindowBedroom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtWindowBedroom.Location = new System.Drawing.Point(557, 5);
            this.BtWindowBedroom.Margin = new System.Windows.Forms.Padding(2);
            this.BtWindowBedroom.Name = "BtWindowBedroom";
            this.BtWindowBedroom.Size = new System.Drawing.Size(174, 31);
            this.BtWindowBedroom.TabIndex = 86;
            this.BtWindowBedroom.Tag = "20";
            this.BtWindowBedroom.Text = "Fenêtre Chambre";
            this.BtWindowBedroom.UseVisualStyleBackColor = false;
            this.BtWindowBedroom.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // BtWindowSaloonL
            // 
            this.BtWindowSaloonL.BackColor = System.Drawing.Color.Black;
            this.BtWindowSaloonL.Enabled = false;
            this.BtWindowSaloonL.ForeColor = System.Drawing.Color.White;
            this.BtWindowSaloonL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtWindowSaloonL.Location = new System.Drawing.Point(112, 606);
            this.BtWindowSaloonL.Margin = new System.Windows.Forms.Padding(2);
            this.BtWindowSaloonL.Name = "BtWindowSaloonL";
            this.BtWindowSaloonL.Size = new System.Drawing.Size(170, 32);
            this.BtWindowSaloonL.TabIndex = 87;
            this.BtWindowSaloonL.Tag = "01";
            this.BtWindowSaloonL.Text = "Fenêtre Salon";
            this.BtWindowSaloonL.UseVisualStyleBackColor = false;
            this.BtWindowSaloonL.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // BtWindowSaloonR
            // 
            this.BtWindowSaloonR.BackColor = System.Drawing.Color.Black;
            this.BtWindowSaloonR.Enabled = false;
            this.BtWindowSaloonR.ForeColor = System.Drawing.Color.White;
            this.BtWindowSaloonR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtWindowSaloonR.Location = new System.Drawing.Point(701, 606);
            this.BtWindowSaloonR.Margin = new System.Windows.Forms.Padding(2);
            this.BtWindowSaloonR.Name = "BtWindowSaloonR";
            this.BtWindowSaloonR.Size = new System.Drawing.Size(166, 32);
            this.BtWindowSaloonR.TabIndex = 88;
            this.BtWindowSaloonR.Tag = "02";
            this.BtWindowSaloonR.Text = "Fenêtre Salon";
            this.BtWindowSaloonR.UseVisualStyleBackColor = false;
            this.BtWindowSaloonR.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // BtDoorKitchen
            // 
            this.BtDoorKitchen.BackColor = System.Drawing.Color.Black;
            this.BtDoorKitchen.Enabled = false;
            this.BtDoorKitchen.ForeColor = System.Drawing.Color.White;
            this.BtDoorKitchen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtDoorKitchen.Location = new System.Drawing.Point(169, 303);
            this.BtDoorKitchen.Margin = new System.Windows.Forms.Padding(2);
            this.BtDoorKitchen.Name = "BtDoorKitchen";
            this.BtDoorKitchen.Size = new System.Drawing.Size(149, 34);
            this.BtDoorKitchen.TabIndex = 89;
            this.BtDoorKitchen.Tag = "30";
            this.BtDoorKitchen.Text = "Porte Cuisine";
            this.BtDoorKitchen.UseVisualStyleBackColor = false;
            this.BtDoorKitchen.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // BtDoorBedroom
            // 
            this.BtDoorBedroom.BackColor = System.Drawing.Color.Black;
            this.BtDoorBedroom.Enabled = false;
            this.BtDoorBedroom.ForeColor = System.Drawing.Color.White;
            this.BtDoorBedroom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtDoorBedroom.Location = new System.Drawing.Point(716, 303);
            this.BtDoorBedroom.Margin = new System.Windows.Forms.Padding(2);
            this.BtDoorBedroom.Name = "BtDoorBedroom";
            this.BtDoorBedroom.Size = new System.Drawing.Size(137, 34);
            this.BtDoorBedroom.TabIndex = 90;
            this.BtDoorBedroom.Tag = "40";
            this.BtDoorBedroom.Text = "Porte Chambre";
            this.BtDoorBedroom.UseVisualStyleBackColor = false;
            this.BtDoorBedroom.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // BtDoorEnter
            // 
            this.BtDoorEnter.BackColor = System.Drawing.Color.Black;
            this.BtDoorEnter.Enabled = false;
            this.BtDoorEnter.ForeColor = System.Drawing.Color.White;
            this.BtDoorEnter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtDoorEnter.Location = new System.Drawing.Point(417, 606);
            this.BtDoorEnter.Margin = new System.Windows.Forms.Padding(2);
            this.BtDoorEnter.Name = "BtDoorEnter";
            this.BtDoorEnter.Size = new System.Drawing.Size(138, 32);
            this.BtDoorEnter.TabIndex = 91;
            this.BtDoorEnter.Tag = "00";
            this.BtDoorEnter.Text = "Porte Entrée";
            this.BtDoorEnter.UseVisualStyleBackColor = false;
            this.BtDoorEnter.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // tBKitchenTempAct
            // 
            this.tBKitchenTempAct.Enabled = false;
            this.tBKitchenTempAct.Location = new System.Drawing.Point(83, 23);
            this.tBKitchenTempAct.Name = "tBKitchenTempAct";
            this.tBKitchenTempAct.Size = new System.Drawing.Size(29, 23);
            this.tBKitchenTempAct.TabIndex = 71;
            this.tBKitchenTempAct.Tag = "2";
            this.tBKitchenTempAct.Text = "20";
            this.tBKitchenTempAct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForceChangeTempSim);
            // 
            // tBKitchenTempRef
            // 
            this.tBKitchenTempRef.Location = new System.Drawing.Point(83, 52);
            this.tBKitchenTempRef.Name = "tBKitchenTempRef";
            this.tBKitchenTempRef.Size = new System.Drawing.Size(29, 23);
            this.tBKitchenTempRef.TabIndex = 77;
            this.tBKitchenTempRef.Text = "20";
            // 
            // GroupKitchen
            // 
            this.GroupKitchen.BackColor = System.Drawing.SystemColors.Control;
            this.GroupKitchen.Controls.Add(this.labelKitchenSubtitleAsk);
            this.GroupKitchen.Controls.Add(this.labelKitchenSubtitleHot);
            this.GroupKitchen.Controls.Add(this.BtKitchenHot);
            this.GroupKitchen.Controls.Add(this.labelKitchenSubtitleAct);
            this.GroupKitchen.Controls.Add(this.tBKitchenTempAct);
            this.GroupKitchen.Controls.Add(this.tBKitchenTempRef);
            this.GroupKitchen.Controls.Add(this.ProgressBarKitchen);
            this.GroupKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.GroupKitchen.Location = new System.Drawing.Point(13, 100);
            this.GroupKitchen.Margin = new System.Windows.Forms.Padding(2);
            this.GroupKitchen.Name = "GroupKitchen";
            this.GroupKitchen.Padding = new System.Windows.Forms.Padding(2);
            this.GroupKitchen.Size = new System.Drawing.Size(144, 162);
            this.GroupKitchen.TabIndex = 102;
            this.GroupKitchen.TabStop = false;
            this.GroupKitchen.Text = "Cuisine";
            // 
            // labelKitchenSubtitleAsk
            // 
            this.labelKitchenSubtitleAsk.AutoSize = true;
            this.labelKitchenSubtitleAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelKitchenSubtitleAsk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelKitchenSubtitleAsk.Location = new System.Drawing.Point(1, 56);
            this.labelKitchenSubtitleAsk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKitchenSubtitleAsk.Name = "labelKitchenSubtitleAsk";
            this.labelKitchenSubtitleAsk.Size = new System.Drawing.Size(70, 15);
            this.labelKitchenSubtitleAsk.TabIndex = 95;
            this.labelKitchenSubtitleAsk.Text = "T. consigne";
            // 
            // labelKitchenSubtitleHot
            // 
            this.labelKitchenSubtitleHot.AutoSize = true;
            this.labelKitchenSubtitleHot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelKitchenSubtitleHot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelKitchenSubtitleHot.Location = new System.Drawing.Point(4, 91);
            this.labelKitchenSubtitleHot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKitchenSubtitleHot.Name = "labelKitchenSubtitleHot";
            this.labelKitchenSubtitleHot.Size = new System.Drawing.Size(63, 15);
            this.labelKitchenSubtitleHot.TabIndex = 98;
            this.labelKitchenSubtitleHot.Text = "Chauffage";
            // 
            // BtKitchenHot
            // 
            this.BtKitchenHot.Enabled = false;
            this.BtKitchenHot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtKitchenHot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtKitchenHot.Location = new System.Drawing.Point(19, 117);
            this.BtKitchenHot.Margin = new System.Windows.Forms.Padding(2);
            this.BtKitchenHot.Name = "BtKitchenHot";
            this.BtKitchenHot.Size = new System.Drawing.Size(76, 38);
            this.BtKitchenHot.TabIndex = 97;
            this.BtKitchenHot.Tag = "2";
            this.BtKitchenHot.Text = "Off";
            this.BtKitchenHot.UseVisualStyleBackColor = true;
            this.BtKitchenHot.Click += new System.EventHandler(this.ChangeHotState);
            // 
            // labelKitchenSubtitleAct
            // 
            this.labelKitchenSubtitleAct.AutoSize = true;
            this.labelKitchenSubtitleAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelKitchenSubtitleAct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelKitchenSubtitleAct.Location = new System.Drawing.Point(4, 26);
            this.labelKitchenSubtitleAct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKitchenSubtitleAct.Name = "labelKitchenSubtitleAct";
            this.labelKitchenSubtitleAct.Size = new System.Drawing.Size(63, 15);
            this.labelKitchenSubtitleAct.TabIndex = 94;
            this.labelKitchenSubtitleAct.Text = "T. actuelle";
            // 
            // GroupBedroom
            // 
            this.GroupBedroom.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBedroom.Controls.Add(this.ProgressBarBedRoom);
            this.GroupBedroom.Controls.Add(this.labelBedRoomSubtitleHot);
            this.GroupBedroom.Controls.Add(this.BtBedRoomHot);
            this.GroupBedroom.Controls.Add(this.labelBedRoomSubtitleAsk);
            this.GroupBedroom.Controls.Add(this.labelBedRoomSubtitleAct);
            this.GroupBedroom.Controls.Add(this.tBBedRoomTempAct);
            this.GroupBedroom.Controls.Add(this.tBBedRoomTempRef);
            this.GroupBedroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.GroupBedroom.Location = new System.Drawing.Point(830, 100);
            this.GroupBedroom.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBedroom.Name = "GroupBedroom";
            this.GroupBedroom.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBedroom.Size = new System.Drawing.Size(144, 162);
            this.GroupBedroom.TabIndex = 103;
            this.GroupBedroom.TabStop = false;
            this.GroupBedroom.Text = "Chambre";
            // 
            // labelBedRoomSubtitleHot
            // 
            this.labelBedRoomSubtitleHot.AutoSize = true;
            this.labelBedRoomSubtitleHot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelBedRoomSubtitleHot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelBedRoomSubtitleHot.Location = new System.Drawing.Point(8, 91);
            this.labelBedRoomSubtitleHot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBedRoomSubtitleHot.Name = "labelBedRoomSubtitleHot";
            this.labelBedRoomSubtitleHot.Size = new System.Drawing.Size(63, 15);
            this.labelBedRoomSubtitleHot.TabIndex = 98;
            this.labelBedRoomSubtitleHot.Text = "Chauffage";
            // 
            // BtBedRoomHot
            // 
            this.BtBedRoomHot.Enabled = false;
            this.BtBedRoomHot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtBedRoomHot.Location = new System.Drawing.Point(17, 117);
            this.BtBedRoomHot.Margin = new System.Windows.Forms.Padding(2);
            this.BtBedRoomHot.Name = "BtBedRoomHot";
            this.BtBedRoomHot.Size = new System.Drawing.Size(76, 40);
            this.BtBedRoomHot.TabIndex = 97;
            this.BtBedRoomHot.Tag = "3";
            this.BtBedRoomHot.Text = "Off";
            this.BtBedRoomHot.UseVisualStyleBackColor = true;
            this.BtBedRoomHot.Click += new System.EventHandler(this.ChangeHotState);
            // 
            // labelBedRoomSubtitleAsk
            // 
            this.labelBedRoomSubtitleAsk.AutoSize = true;
            this.labelBedRoomSubtitleAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelBedRoomSubtitleAsk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelBedRoomSubtitleAsk.Location = new System.Drawing.Point(4, 51);
            this.labelBedRoomSubtitleAsk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBedRoomSubtitleAsk.Name = "labelBedRoomSubtitleAsk";
            this.labelBedRoomSubtitleAsk.Size = new System.Drawing.Size(70, 15);
            this.labelBedRoomSubtitleAsk.TabIndex = 95;
            this.labelBedRoomSubtitleAsk.Text = "T. consigne";
            // 
            // labelBedRoomSubtitleAct
            // 
            this.labelBedRoomSubtitleAct.AutoSize = true;
            this.labelBedRoomSubtitleAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelBedRoomSubtitleAct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelBedRoomSubtitleAct.Location = new System.Drawing.Point(4, 26);
            this.labelBedRoomSubtitleAct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBedRoomSubtitleAct.Name = "labelBedRoomSubtitleAct";
            this.labelBedRoomSubtitleAct.Size = new System.Drawing.Size(63, 15);
            this.labelBedRoomSubtitleAct.TabIndex = 94;
            this.labelBedRoomSubtitleAct.Text = "T. actuelle";
            // 
            // tBBedRoomTempAct
            // 
            this.tBBedRoomTempAct.Enabled = false;
            this.tBBedRoomTempAct.Location = new System.Drawing.Point(83, 22);
            this.tBBedRoomTempAct.Name = "tBBedRoomTempAct";
            this.tBBedRoomTempAct.Size = new System.Drawing.Size(29, 23);
            this.tBBedRoomTempAct.TabIndex = 71;
            this.tBBedRoomTempAct.Tag = "3";
            this.tBBedRoomTempAct.Text = "20";
            this.tBBedRoomTempAct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForceChangeTempSim);
            // 
            // tBBedRoomTempRef
            // 
            this.tBBedRoomTempRef.Location = new System.Drawing.Point(83, 51);
            this.tBBedRoomTempRef.Name = "tBBedRoomTempRef";
            this.tBBedRoomTempRef.Size = new System.Drawing.Size(29, 23);
            this.tBBedRoomTempRef.TabIndex = 77;
            this.tBBedRoomTempRef.Text = "20";
            // 
            // GroupSaloon
            // 
            this.GroupSaloon.BackColor = System.Drawing.SystemColors.Control;
            this.GroupSaloon.Controls.Add(this.ProgressBarSaloon);
            this.GroupSaloon.Controls.Add(this.labelSaloonSubtitleHot);
            this.GroupSaloon.Controls.Add(this.BtSaloonHot);
            this.GroupSaloon.Controls.Add(this.labelSaloonSubtitleAsk);
            this.GroupSaloon.Controls.Add(this.labelSaloonSubtitleAct);
            this.GroupSaloon.Controls.Add(this.tBSaloonTempAct);
            this.GroupSaloon.Controls.Add(this.tBSaloonTempRef);
            this.GroupSaloon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.GroupSaloon.Location = new System.Drawing.Point(830, 392);
            this.GroupSaloon.Margin = new System.Windows.Forms.Padding(2);
            this.GroupSaloon.Name = "GroupSaloon";
            this.GroupSaloon.Padding = new System.Windows.Forms.Padding(2);
            this.GroupSaloon.Size = new System.Drawing.Size(144, 162);
            this.GroupSaloon.TabIndex = 104;
            this.GroupSaloon.TabStop = false;
            this.GroupSaloon.Text = "Salon";
            // 
            // labelSaloonSubtitleHot
            // 
            this.labelSaloonSubtitleHot.AutoSize = true;
            this.labelSaloonSubtitleHot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelSaloonSubtitleHot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSaloonSubtitleHot.Location = new System.Drawing.Point(8, 82);
            this.labelSaloonSubtitleHot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSaloonSubtitleHot.Name = "labelSaloonSubtitleHot";
            this.labelSaloonSubtitleHot.Size = new System.Drawing.Size(63, 15);
            this.labelSaloonSubtitleHot.TabIndex = 98;
            this.labelSaloonSubtitleHot.Text = "Chauffage";
            // 
            // BtSaloonHot
            // 
            this.BtSaloonHot.Enabled = false;
            this.BtSaloonHot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtSaloonHot.Location = new System.Drawing.Point(17, 109);
            this.BtSaloonHot.Margin = new System.Windows.Forms.Padding(2);
            this.BtSaloonHot.Name = "BtSaloonHot";
            this.BtSaloonHot.Size = new System.Drawing.Size(76, 46);
            this.BtSaloonHot.TabIndex = 97;
            this.BtSaloonHot.Tag = "1";
            this.BtSaloonHot.Text = "Off";
            this.BtSaloonHot.UseVisualStyleBackColor = true;
            this.BtSaloonHot.Click += new System.EventHandler(this.ChangeHotState);
            // 
            // labelSaloonSubtitleAsk
            // 
            this.labelSaloonSubtitleAsk.AutoSize = true;
            this.labelSaloonSubtitleAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelSaloonSubtitleAsk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSaloonSubtitleAsk.Location = new System.Drawing.Point(4, 51);
            this.labelSaloonSubtitleAsk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSaloonSubtitleAsk.Name = "labelSaloonSubtitleAsk";
            this.labelSaloonSubtitleAsk.Size = new System.Drawing.Size(70, 15);
            this.labelSaloonSubtitleAsk.TabIndex = 95;
            this.labelSaloonSubtitleAsk.Text = "T. consigne";
            // 
            // labelSaloonSubtitleAct
            // 
            this.labelSaloonSubtitleAct.AutoSize = true;
            this.labelSaloonSubtitleAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelSaloonSubtitleAct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSaloonSubtitleAct.Location = new System.Drawing.Point(4, 26);
            this.labelSaloonSubtitleAct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSaloonSubtitleAct.Name = "labelSaloonSubtitleAct";
            this.labelSaloonSubtitleAct.Size = new System.Drawing.Size(63, 15);
            this.labelSaloonSubtitleAct.TabIndex = 94;
            this.labelSaloonSubtitleAct.Text = "T. actuelle";
            // 
            // tBSaloonTempAct
            // 
            this.tBSaloonTempAct.Enabled = false;
            this.tBSaloonTempAct.Location = new System.Drawing.Point(83, 22);
            this.tBSaloonTempAct.Name = "tBSaloonTempAct";
            this.tBSaloonTempAct.Size = new System.Drawing.Size(29, 23);
            this.tBSaloonTempAct.TabIndex = 71;
            this.tBSaloonTempAct.Tag = "1";
            this.tBSaloonTempAct.Text = "20";
            this.tBSaloonTempAct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForceChangeTempSim);
            // 
            // tBSaloonTempRef
            // 
            this.tBSaloonTempRef.Location = new System.Drawing.Point(83, 52);
            this.tBSaloonTempRef.Name = "tBSaloonTempRef";
            this.tBSaloonTempRef.Size = new System.Drawing.Size(29, 23);
            this.tBSaloonTempRef.TabIndex = 77;
            this.tBSaloonTempRef.Text = "20";
            // 
            // GroupOutdoor
            // 
            this.GroupOutdoor.BackColor = System.Drawing.SystemColors.Control;
            this.GroupOutdoor.Controls.Add(this.labelOutdoorLamp);
            this.GroupOutdoor.Controls.Add(this.BtOutdoorLight);
            this.GroupOutdoor.Controls.Add(this.labelOutdoorSubtitleAct);
            this.GroupOutdoor.Controls.Add(this.tBOutdoorTempAct);
            this.GroupOutdoor.Controls.Add(this.ProgressBarOutdoor);
            this.GroupOutdoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.GroupOutdoor.Location = new System.Drawing.Point(830, 642);
            this.GroupOutdoor.Margin = new System.Windows.Forms.Padding(2);
            this.GroupOutdoor.Name = "GroupOutdoor";
            this.GroupOutdoor.Padding = new System.Windows.Forms.Padding(2);
            this.GroupOutdoor.Size = new System.Drawing.Size(144, 134);
            this.GroupOutdoor.TabIndex = 105;
            this.GroupOutdoor.TabStop = false;
            this.GroupOutdoor.Text = "Extérieur";
            // 
            // labelOutdoorLamp
            // 
            this.labelOutdoorLamp.AutoSize = true;
            this.labelOutdoorLamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelOutdoorLamp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelOutdoorLamp.Location = new System.Drawing.Point(4, 64);
            this.labelOutdoorLamp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOutdoorLamp.Name = "labelOutdoorLamp";
            this.labelOutdoorLamp.Size = new System.Drawing.Size(53, 15);
            this.labelOutdoorLamp.TabIndex = 98;
            this.labelOutdoorLamp.Text = "Lumière";
            // 
            // BtOutdoorLight
            // 
            this.BtOutdoorLight.Enabled = false;
            this.BtOutdoorLight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtOutdoorLight.Location = new System.Drawing.Point(17, 81);
            this.BtOutdoorLight.Margin = new System.Windows.Forms.Padding(2);
            this.BtOutdoorLight.Name = "BtOutdoorLight";
            this.BtOutdoorLight.Size = new System.Drawing.Size(76, 44);
            this.BtOutdoorLight.TabIndex = 97;
            this.BtOutdoorLight.Text = "Off";
            this.BtOutdoorLight.UseVisualStyleBackColor = true;
            this.BtOutdoorLight.Click += new System.EventHandler(this.ChangeLightState);
            // 
            // labelOutdoorSubtitleAct
            // 
            this.labelOutdoorSubtitleAct.AutoSize = true;
            this.labelOutdoorSubtitleAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelOutdoorSubtitleAct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelOutdoorSubtitleAct.Location = new System.Drawing.Point(4, 34);
            this.labelOutdoorSubtitleAct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOutdoorSubtitleAct.Name = "labelOutdoorSubtitleAct";
            this.labelOutdoorSubtitleAct.Size = new System.Drawing.Size(63, 15);
            this.labelOutdoorSubtitleAct.TabIndex = 94;
            this.labelOutdoorSubtitleAct.Text = "T. actuelle";
            // 
            // tBOutdoorTempAct
            // 
            this.tBOutdoorTempAct.Enabled = false;
            this.tBOutdoorTempAct.Location = new System.Drawing.Point(83, 30);
            this.tBOutdoorTempAct.Name = "tBOutdoorTempAct";
            this.tBOutdoorTempAct.Size = new System.Drawing.Size(29, 23);
            this.tBOutdoorTempAct.TabIndex = 71;
            this.tBOutdoorTempAct.Tag = "0";
            this.tBOutdoorTempAct.Text = "20";
            this.tBOutdoorTempAct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForceChangeTempSim);
            // 
            // TimerMainRoutine
            // 
            this.TimerMainRoutine.Interval = 1000;
            this.TimerMainRoutine.Tick += new System.EventHandler(this.TMainRoutine_Tick);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BackgroundImage = global::MyhouseDomotique.Properties.Resources.ImageMaison1;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainPanel.Controls.Add(this.fireHotBedRoom);
            this.MainPanel.Controls.Add(this.Clock);
            this.MainPanel.Controls.Add(this.fireHotKitchen);
            this.MainPanel.Controls.Add(this.lighInactivePanel);
            this.MainPanel.Controls.Add(this.BtWindowBedroom);
            this.MainPanel.Controls.Add(this.GroupKitchen);
            this.MainPanel.Controls.Add(this.BtWindowKitchen);
            this.MainPanel.Controls.Add(this.fireColdKitchen);
            this.MainPanel.Controls.Add(this.GroupOutdoor);
            this.MainPanel.Controls.Add(this.BtWindowSaloonL);
            this.MainPanel.Controls.Add(this.GroupSaloon);
            this.MainPanel.Controls.Add(this.BtWindowSaloonR);
            this.MainPanel.Controls.Add(this.GroupBedroom);
            this.MainPanel.Controls.Add(this.BtDoorKitchen);
            this.MainPanel.Controls.Add(this.BtDoorBedroom);
            this.MainPanel.Controls.Add(this.BtDoorEnter);
            this.MainPanel.Controls.Add(this.fireColdPannelBedRoom);
            this.MainPanel.Controls.Add(this.fireHotSaloon);
            this.MainPanel.Controls.Add(this.fireColdSaloon);
            this.MainPanel.Location = new System.Drawing.Point(68, 47);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(980, 795);
            this.MainPanel.TabIndex = 107;
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Clock.Location = new System.Drawing.Point(402, 10);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(56, 18);
            this.Clock.TabIndex = 107;
            this.Clock.Text = "00H00";
            // 
            // TimerClock
            // 
            this.TimerClock.Enabled = true;
            this.TimerClock.Tick += new System.EventHandler(this.TimerClock_Tick);
            // 
            // fireHotKitchen
            // 
            this.fireHotKitchen.Location = new System.Drawing.Point(168, 140);
            this.fireHotKitchen.Margin = new System.Windows.Forms.Padding(2);
            this.fireHotKitchen.Name = "fireHotKitchen";
            this.fireHotKitchen.Size = new System.Drawing.Size(124, 131);
            this.fireHotKitchen.TabIndex = 100;
            this.fireHotKitchen.Visible = false;
            // 
            // lighInactivePanel
            // 
            this.lighInactivePanel.Controls.Add(this.lighActivePanel);
            this.lighInactivePanel.Location = new System.Drawing.Point(527, 639);
            this.lighInactivePanel.Margin = new System.Windows.Forms.Padding(2);
            this.lighInactivePanel.Name = "lighInactivePanel";
            this.lighInactivePanel.Size = new System.Drawing.Size(135, 153);
            this.lighInactivePanel.TabIndex = 106;
            // 
            // lighActivePanel
            // 
            this.lighActivePanel.Location = new System.Drawing.Point(0, 2);
            this.lighActivePanel.Margin = new System.Windows.Forms.Padding(2);
            this.lighActivePanel.Name = "lighActivePanel";
            this.lighActivePanel.Size = new System.Drawing.Size(160, 152);
            this.lighActivePanel.TabIndex = 107;
            this.lighActivePanel.Visible = false;
            // 
            // ProgressBarKitchen
            // 
            this.ProgressBarKitchen.BackColor = System.Drawing.Color.LightGray;
            this.ProgressBarKitchen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProgressBarKitchen.Location = new System.Drawing.Point(117, 23);
            this.ProgressBarKitchen.Margin = new System.Windows.Forms.Padding(2);
            this.ProgressBarKitchen.Name = "ProgressBarKitchen";
            this.ProgressBarKitchen.Size = new System.Drawing.Size(21, 138);
            this.ProgressBarKitchen.TabIndex = 93;
            this.ProgressBarKitchen.Value = 50;
            // 
            // fireColdKitchen
            // 
            this.fireColdKitchen.Location = new System.Drawing.Point(170, 140);
            this.fireColdKitchen.Margin = new System.Windows.Forms.Padding(2);
            this.fireColdKitchen.Name = "fireColdKitchen";
            this.fireColdKitchen.Size = new System.Drawing.Size(124, 121);
            this.fireColdKitchen.TabIndex = 97;
            // 
            // ProgressBarOutdoor
            // 
            this.ProgressBarOutdoor.BackColor = System.Drawing.Color.LightGray;
            this.ProgressBarOutdoor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProgressBarOutdoor.Location = new System.Drawing.Point(117, 21);
            this.ProgressBarOutdoor.Margin = new System.Windows.Forms.Padding(2);
            this.ProgressBarOutdoor.Name = "ProgressBarOutdoor";
            this.ProgressBarOutdoor.Size = new System.Drawing.Size(21, 104);
            this.ProgressBarOutdoor.TabIndex = 95;
            this.ProgressBarOutdoor.Value = 50;
            // 
            // ProgressBarSaloon
            // 
            this.ProgressBarSaloon.BackColor = System.Drawing.Color.LightGray;
            this.ProgressBarSaloon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProgressBarSaloon.Location = new System.Drawing.Point(117, 19);
            this.ProgressBarSaloon.Margin = new System.Windows.Forms.Padding(2);
            this.ProgressBarSaloon.Name = "ProgressBarSaloon";
            this.ProgressBarSaloon.Size = new System.Drawing.Size(21, 136);
            this.ProgressBarSaloon.TabIndex = 94;
            this.ProgressBarSaloon.Value = 50;
            // 
            // ProgressBarBedRoom
            // 
            this.ProgressBarBedRoom.BackColor = System.Drawing.Color.LightGray;
            this.ProgressBarBedRoom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProgressBarBedRoom.Location = new System.Drawing.Point(117, 20);
            this.ProgressBarBedRoom.Margin = new System.Windows.Forms.Padding(2);
            this.ProgressBarBedRoom.Name = "ProgressBarBedRoom";
            this.ProgressBarBedRoom.Size = new System.Drawing.Size(21, 137);
            this.ProgressBarBedRoom.TabIndex = 92;
            this.ProgressBarBedRoom.Value = 50;
            // 
            // fireColdPannelBedRoom
            // 
            this.fireColdPannelBedRoom.Location = new System.Drawing.Point(641, 126);
            this.fireColdPannelBedRoom.Margin = new System.Windows.Forms.Padding(2);
            this.fireColdPannelBedRoom.Name = "fireColdPannelBedRoom";
            this.fireColdPannelBedRoom.Size = new System.Drawing.Size(130, 159);
            this.fireColdPannelBedRoom.TabIndex = 96;
            // 
            // fireHotBedRoom
            // 
            this.fireHotBedRoom.Location = new System.Drawing.Point(641, 128);
            this.fireHotBedRoom.Margin = new System.Windows.Forms.Padding(2);
            this.fireHotBedRoom.Name = "fireHotBedRoom";
            this.fireHotBedRoom.Size = new System.Drawing.Size(144, 131);
            this.fireHotBedRoom.TabIndex = 99;
            this.fireHotBedRoom.Visible = false;
            // 
            // fireHotSaloon
            // 
            this.fireHotSaloon.Location = new System.Drawing.Point(394, 411);
            this.fireHotSaloon.Margin = new System.Windows.Forms.Padding(2);
            this.fireHotSaloon.Name = "fireHotSaloon";
            this.fireHotSaloon.Size = new System.Drawing.Size(144, 143);
            this.fireHotSaloon.TabIndex = 100;
            this.fireHotSaloon.Visible = false;
            // 
            // fireColdSaloon
            // 
            this.fireColdSaloon.Location = new System.Drawing.Point(394, 411);
            this.fireColdSaloon.Margin = new System.Windows.Forms.Padding(2);
            this.fireColdSaloon.Name = "fireColdSaloon";
            this.fireColdSaloon.Size = new System.Drawing.Size(142, 143);
            this.fireColdSaloon.TabIndex = 98;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 884);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.StatusBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainControl";
            this.Text = "Controle Principaux ";
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
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.lighInactivePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.StatusStrip StatusBar;
        public System.Windows.Forms.ToolStripStatusLabel StatusBarMode;
        public System.Windows.Forms.MenuStrip MenuBar;
        public System.Windows.Forms.ToolStripMenuItem MenuBarTitleProgramme;
        public System.Windows.Forms.ToolStripMenuItem MenuBarClose;
        public System.Windows.Forms.ToolStripMenuItem MenuBarTitleInt;
        public System.Windows.Forms.ToolStripMenuItem MenuBarCredit;
        public System.Windows.Forms.Button BtWindowKitchen;
        public System.Windows.Forms.Button BtWindowBedroom;
        public System.Windows.Forms.Button BtWindowSaloonL;
        public System.Windows.Forms.Button BtWindowSaloonR;
        public System.Windows.Forms.Button BtDoorKitchen;
        public System.Windows.Forms.Button BtDoorBedroom;
        public System.Windows.Forms.Button BtDoorEnter;
        public VertcicalProgressBar ProgressBarBedRoom;
        public VertcicalProgressBar ProgressBarKitchen;
        public VertcicalProgressBar ProgressBarSaloon;
        public VertcicalProgressBar ProgressBarOutdoor;
        public FireColdPannel fireColdPannelBedRoom;
        public FireHotPannel fireHotBedRoom;
        public FireColdPannel fireColdKitchen;
        public FireHotPannel fireHotKitchen;
        public FireColdPannel fireColdSaloon;
        public FireHotPannel fireHotSaloon;
        public System.Windows.Forms.TextBox tBKitchenTempAct;
        public System.Windows.Forms.TextBox tBKitchenTempRef;
        public System.Windows.Forms.GroupBox GroupKitchen;
        public System.Windows.Forms.Label labelKitchenSubtitleAct;
        public System.Windows.Forms.Label labelKitchenSubtitleHot;
        public System.Windows.Forms.Button BtKitchenHot;
        public System.Windows.Forms.Label labelKitchenSubtitleAsk;
        public System.Windows.Forms.GroupBox GroupBedroom;
        public System.Windows.Forms.Label labelBedRoomSubtitleHot;
        public System.Windows.Forms.Button BtBedRoomHot;
        public System.Windows.Forms.Label labelBedRoomSubtitleAsk;
        public System.Windows.Forms.Label labelBedRoomSubtitleAct;
        public System.Windows.Forms.TextBox tBBedRoomTempAct;
        public System.Windows.Forms.TextBox tBBedRoomTempRef;
        public System.Windows.Forms.GroupBox GroupSaloon;
        public System.Windows.Forms.Label labelSaloonSubtitleHot;
        public System.Windows.Forms.Button BtSaloonHot;
        public System.Windows.Forms.Label labelSaloonSubtitleAsk;
        public System.Windows.Forms.Label labelSaloonSubtitleAct;
        public System.Windows.Forms.TextBox tBSaloonTempAct;
        public System.Windows.Forms.TextBox tBSaloonTempRef;
        public System.Windows.Forms.GroupBox GroupOutdoor;
        public System.Windows.Forms.Label labelOutdoorLamp;
        public System.Windows.Forms.Button BtOutdoorLight;
        public System.Windows.Forms.Label labelOutdoorSubtitleAct;
        public System.Windows.Forms.TextBox tBOutdoorTempAct;
        public LighInactivePannel lighInactivePanel;
        public LighActivePannel lighActivePanel;
        public System.Windows.Forms.Timer TimerMainRoutine;
        public System.Windows.Forms.ToolStripMenuItem MenuBarRegulation;
        public System.Windows.Forms.Panel MainPanel;
        public System.Windows.Forms.Label Clock;
        public System.Windows.Forms.Timer TimerClock;
    }
}


namespace MyhouseDomotique
{
    public partial class MainControl
    {

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.TimerMainRoutine = new System.Windows.Forms.Timer(this.components);
            this.TimerClock = new System.Windows.Forms.Timer(this.components);
            this.TabCredits = new System.Windows.Forms.TabPage();
            this.tabConfiguration = new System.Windows.Forms.TabPage();
            this.GbConfLight = new System.Windows.Forms.GroupBox();
            this.PanelLightConf = new System.Windows.Forms.Panel();
            this.LbConfSensibility = new System.Windows.Forms.Label();
            this.ScrollSensibility = new System.Windows.Forms.TrackBar();
            this.CbConfLightAuto = new System.Windows.Forms.CheckBox();
            this.GbConfigMain = new System.Windows.Forms.GroupBox();
            this.CbConfGodMode = new System.Windows.Forms.CheckBox();
            this.CbConfRegulation = new System.Windows.Forms.CheckBox();
            this.TabOverview = new System.Windows.Forms.TabPage();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusBarMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtDoorEnter = new System.Windows.Forms.Button();
            this.GroupBedroom = new System.Windows.Forms.GroupBox();
            this.labelBedRoomSubtitleHot = new System.Windows.Forms.Label();
            this.BtBedRoomHot = new System.Windows.Forms.Button();
            this.labelBedRoomSubtitleAsk = new System.Windows.Forms.Label();
            this.labelBedRoomSubtitleAct = new System.Windows.Forms.Label();
            this.tBBedRoomTempAct = new System.Windows.Forms.TextBox();
            this.tBBedRoomTempRef = new System.Windows.Forms.TextBox();
            this.Clock = new System.Windows.Forms.Label();
            this.BtWindowBedroom = new System.Windows.Forms.Button();
            this.GroupKitchen = new System.Windows.Forms.GroupBox();
            this.labelKitchenSubtitleAsk = new System.Windows.Forms.Label();
            this.labelKitchenSubtitleHot = new System.Windows.Forms.Label();
            this.BtKitchenHot = new System.Windows.Forms.Button();
            this.labelKitchenSubtitleAct = new System.Windows.Forms.Label();
            this.tBKitchenTempAct = new System.Windows.Forms.TextBox();
            this.tBKitchenTempRef = new System.Windows.Forms.TextBox();
            this.BtWindowKitchen = new System.Windows.Forms.Button();
            this.GroupOutdoor = new System.Windows.Forms.GroupBox();
            this.labelOutdoorLamp = new System.Windows.Forms.Label();
            this.BtOutdoorLight = new System.Windows.Forms.Button();
            this.labelOutdoorSubtitleAct = new System.Windows.Forms.Label();
            this.tBOutdoorTempAct = new System.Windows.Forms.TextBox();
            this.BtWindowSaloonL = new System.Windows.Forms.Button();
            this.GroupSaloon = new System.Windows.Forms.GroupBox();
            this.labelSaloonSubtitleHot = new System.Windows.Forms.Label();
            this.BtSaloonHot = new System.Windows.Forms.Button();
            this.labelSaloonSubtitleAsk = new System.Windows.Forms.Label();
            this.labelSaloonSubtitleAct = new System.Windows.Forms.Label();
            this.tBSaloonTempAct = new System.Windows.Forms.TextBox();
            this.tBSaloonTempRef = new System.Windows.Forms.TextBox();
            this.BtWindowSaloonR = new System.Windows.Forms.Button();
            this.BtDoorKitchen = new System.Windows.Forms.Button();
            this.BtDoorBedroom = new System.Windows.Forms.Button();
            this.TabCredit = new System.Windows.Forms.TabControl();
            this.StatusBarRecord = new System.Windows.Forms.ToolStripStatusLabel();
            this.lighInactivePanel = new LighInactivePannel();
            this.lighActivePanel = new LighActivePannel();
            this.fireHotSaloon = new FireHotPannel();
            this.fireHotKitchen = new FireHotPannel();
            this.fireHotBedRoom = new FireHotPannel();
            this.ProgressBarBedRoom = new MyhouseDomotique.VertcicalProgressBar();
            this.ProgressBarKitchen = new MyhouseDomotique.VertcicalProgressBar();
            this.fireColdKitchen = new FireColdPannel();
            this.ProgressBarOutdoor = new MyhouseDomotique.VertcicalProgressBar();
            this.ProgressBarSaloon = new MyhouseDomotique.VertcicalProgressBar();
            this.fireColdPannelBedRoom = new FireColdPannel();
            this.fireColdSaloon = new FireColdPannel();
            this.LightConfProgress = new MyhouseDomotique.VertcicalProgressBar();
            this.tabConfiguration.SuspendLayout();
            this.GbConfLight.SuspendLayout();
            this.PanelLightConf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollSensibility)).BeginInit();
            this.GbConfigMain.SuspendLayout();
            this.TabOverview.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.GroupBedroom.SuspendLayout();
            this.GroupKitchen.SuspendLayout();
            this.GroupOutdoor.SuspendLayout();
            this.GroupSaloon.SuspendLayout();
            this.TabCredit.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerMainRoutine
            // 
            this.TimerMainRoutine.Interval = 1000;
            this.TimerMainRoutine.Tick += new System.EventHandler(this.TMainRoutine_Tick);
            // 
            // TimerClock
            // 
            this.TimerClock.Enabled = true;
            this.TimerClock.Tick += new System.EventHandler(this.TimerClock_Tick);
            // 
            // TabCredits
            // 
            this.TabCredits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(37)))));
            this.TabCredits.BackgroundImage = global::MyhouseDomotique.Properties.Resources.credits;
            this.TabCredits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TabCredits.Location = new System.Drawing.Point(4, 22);
            this.TabCredits.Name = "TabCredits";
            this.TabCredits.Padding = new System.Windows.Forms.Padding(3);
            this.TabCredits.Size = new System.Drawing.Size(1102, 858);
            this.TabCredits.TabIndex = 3;
            this.TabCredits.Text = "Crédits";
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.Controls.Add(this.GbConfLight);
            this.tabConfiguration.Controls.Add(this.GbConfigMain);
            this.tabConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfiguration.Size = new System.Drawing.Size(1102, 858);
            this.tabConfiguration.TabIndex = 2;
            this.tabConfiguration.Text = "Configuration";
            this.tabConfiguration.UseVisualStyleBackColor = true;
            // 
            // GbConfLight
            // 
            this.GbConfLight.Controls.Add(this.PanelLightConf);
            this.GbConfLight.Controls.Add(this.CbConfLightAuto);
            this.GbConfLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbConfLight.Location = new System.Drawing.Point(282, 28);
            this.GbConfLight.Name = "GbConfLight";
            this.GbConfLight.Size = new System.Drawing.Size(199, 199);
            this.GbConfLight.TabIndex = 1;
            this.GbConfLight.TabStop = false;
            this.GbConfLight.Text = "Lumière extérieure";
            // 
            // PanelLightConf
            // 
            this.PanelLightConf.Controls.Add(this.LbConfSensibility);
            this.PanelLightConf.Controls.Add(this.LightConfProgress);
            this.PanelLightConf.Controls.Add(this.ScrollSensibility);
            this.PanelLightConf.Location = new System.Drawing.Point(16, 57);
            this.PanelLightConf.Name = "PanelLightConf";
            this.PanelLightConf.Size = new System.Drawing.Size(131, 136);
            this.PanelLightConf.TabIndex = 3;
            // 
            // LbConfSensibility
            // 
            this.LbConfSensibility.AutoSize = true;
            this.LbConfSensibility.Location = new System.Drawing.Point(3, 4);
            this.LbConfSensibility.Name = "LbConfSensibility";
            this.LbConfSensibility.Size = new System.Drawing.Size(81, 16);
            this.LbConfSensibility.TabIndex = 4;
            this.LbConfSensibility.Text = "Sensibilité";
            // 
            // ScrollSensibility
            // 
            this.ScrollSensibility.BackColor = System.Drawing.Color.White;
            this.ScrollSensibility.Location = new System.Drawing.Point(18, 20);
            this.ScrollSensibility.Maximum = 100;
            this.ScrollSensibility.Name = "ScrollSensibility";
            this.ScrollSensibility.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ScrollSensibility.Size = new System.Drawing.Size(45, 110);
            this.ScrollSensibility.SmallChange = 5;
            this.ScrollSensibility.TabIndex = 6;
            this.ScrollSensibility.Value = 50;
            // 
            // CbConfLightAuto
            // 
            this.CbConfLightAuto.AutoSize = true;
            this.CbConfLightAuto.Checked = true;
            this.CbConfLightAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbConfLightAuto.Location = new System.Drawing.Point(16, 32);
            this.CbConfLightAuto.Name = "CbConfLightAuto";
            this.CbConfLightAuto.Size = new System.Drawing.Size(113, 20);
            this.CbConfLightAuto.TabIndex = 5;
            this.CbConfLightAuto.Text = "Automatique";
            this.CbConfLightAuto.UseVisualStyleBackColor = true;
            this.CbConfLightAuto.CheckedChanged += new System.EventHandler(this.ChangeLightAuto);
            // 
            // GbConfigMain
            // 
            this.GbConfigMain.Controls.Add(this.CbConfGodMode);
            this.GbConfigMain.Controls.Add(this.CbConfRegulation);
            this.GbConfigMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbConfigMain.Location = new System.Drawing.Point(26, 27);
            this.GbConfigMain.Name = "GbConfigMain";
            this.GbConfigMain.Size = new System.Drawing.Size(239, 200);
            this.GbConfigMain.TabIndex = 0;
            this.GbConfigMain.TabStop = false;
            this.GbConfigMain.Text = "Configuration principale";
            // 
            // CbConfGodMode
            // 
            this.CbConfGodMode.AutoSize = true;
            this.CbConfGodMode.Location = new System.Drawing.Point(28, 58);
            this.CbConfGodMode.Name = "CbConfGodMode";
            this.CbConfGodMode.Size = new System.Drawing.Size(99, 20);
            this.CbConfGodMode.TabIndex = 2;
            this.CbConfGodMode.Text = "God Mode";
            this.CbConfGodMode.UseVisualStyleBackColor = true;
            this.CbConfGodMode.CheckedChanged += new System.EventHandler(this.ChangeGodMode);
            // 
            // CbConfRegulation
            // 
            this.CbConfRegulation.AutoSize = true;
            this.CbConfRegulation.Checked = true;
            this.CbConfRegulation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbConfRegulation.Location = new System.Drawing.Point(28, 31);
            this.CbConfRegulation.Name = "CbConfRegulation";
            this.CbConfRegulation.Size = new System.Drawing.Size(102, 20);
            this.CbConfRegulation.TabIndex = 1;
            this.CbConfRegulation.Text = "Régulation";
            this.CbConfRegulation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CbConfRegulation.UseVisualStyleBackColor = true;
            this.CbConfRegulation.CheckedChanged += new System.EventHandler(this.ChangeRegulation);
            // 
            // TabOverview
            // 
            this.TabOverview.Controls.Add(this.MainPanel);
            this.TabOverview.Location = new System.Drawing.Point(4, 22);
            this.TabOverview.Name = "TabOverview";
            this.TabOverview.Padding = new System.Windows.Forms.Padding(3);
            this.TabOverview.Size = new System.Drawing.Size(1102, 858);
            this.TabOverview.TabIndex = 0;
            this.TabOverview.Text = "Vue principale";
            this.TabOverview.UseVisualStyleBackColor = true;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BackgroundImage = global::MyhouseDomotique.Properties.Resources.House_HD;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainPanel.Controls.Add(this.StatusBar);
            this.MainPanel.Controls.Add(this.lighInactivePanel);
            this.MainPanel.Controls.Add(this.lighActivePanel);
            this.MainPanel.Controls.Add(this.fireHotSaloon);
            this.MainPanel.Controls.Add(this.fireHotKitchen);
            this.MainPanel.Controls.Add(this.fireHotBedRoom);
            this.MainPanel.Controls.Add(this.BtDoorEnter);
            this.MainPanel.Controls.Add(this.GroupBedroom);
            this.MainPanel.Controls.Add(this.Clock);
            this.MainPanel.Controls.Add(this.BtWindowBedroom);
            this.MainPanel.Controls.Add(this.GroupKitchen);
            this.MainPanel.Controls.Add(this.BtWindowKitchen);
            this.MainPanel.Controls.Add(this.fireColdKitchen);
            this.MainPanel.Controls.Add(this.GroupOutdoor);
            this.MainPanel.Controls.Add(this.BtWindowSaloonL);
            this.MainPanel.Controls.Add(this.GroupSaloon);
            this.MainPanel.Controls.Add(this.BtWindowSaloonR);
            this.MainPanel.Controls.Add(this.BtDoorKitchen);
            this.MainPanel.Controls.Add(this.BtDoorBedroom);
            this.MainPanel.Controls.Add(this.fireColdPannelBedRoom);
            this.MainPanel.Controls.Add(this.fireColdSaloon);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(3, 3);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1096, 852);
            this.MainPanel.TabIndex = 107;
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarMode,
            this.StatusBarRecord});
            this.StatusBar.Location = new System.Drawing.Point(0, 830);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1096, 22);
            this.StatusBar.TabIndex = 108;
            this.StatusBar.Text = "statusStrip1";
            // 
            // StatusBarMode
            // 
            this.StatusBarMode.Name = "StatusBarMode";
            this.StatusBarMode.Size = new System.Drawing.Size(38, 17);
            this.StatusBarMode.Text = "Mode";
            // 
            // BtDoorEnter
            // 
            this.BtDoorEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtDoorEnter.BackColor = System.Drawing.Color.Black;
            this.BtDoorEnter.Enabled = false;
            this.BtDoorEnter.ForeColor = System.Drawing.Color.White;
            this.BtDoorEnter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtDoorEnter.Location = new System.Drawing.Point(470, 654);
            this.BtDoorEnter.Margin = new System.Windows.Forms.Padding(2);
            this.BtDoorEnter.Name = "BtDoorEnter";
            this.BtDoorEnter.Size = new System.Drawing.Size(138, 32);
            this.BtDoorEnter.TabIndex = 91;
            this.BtDoorEnter.Tag = "close";
            this.BtDoorEnter.Text = "Porte Entrée";
            this.BtDoorEnter.UseVisualStyleBackColor = false;
            this.BtDoorEnter.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // GroupBedroom
            // 
            this.GroupBedroom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupBedroom.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBedroom.Controls.Add(this.ProgressBarBedRoom);
            this.GroupBedroom.Controls.Add(this.labelBedRoomSubtitleHot);
            this.GroupBedroom.Controls.Add(this.BtBedRoomHot);
            this.GroupBedroom.Controls.Add(this.labelBedRoomSubtitleAsk);
            this.GroupBedroom.Controls.Add(this.labelBedRoomSubtitleAct);
            this.GroupBedroom.Controls.Add(this.tBBedRoomTempAct);
            this.GroupBedroom.Controls.Add(this.tBBedRoomTempRef);
            this.GroupBedroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.GroupBedroom.Location = new System.Drawing.Point(948, 174);
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
            this.tBBedRoomTempAct.Location = new System.Drawing.Point(72, 22);
            this.tBBedRoomTempAct.Name = "tBBedRoomTempAct";
            this.tBBedRoomTempAct.Size = new System.Drawing.Size(40, 23);
            this.tBBedRoomTempAct.TabIndex = 71;
            this.tBBedRoomTempAct.Tag = "3";
            this.tBBedRoomTempAct.Text = "20,0";
            // 
            // tBBedRoomTempRef
            // 
            this.tBBedRoomTempRef.Location = new System.Drawing.Point(72, 51);
            this.tBBedRoomTempRef.Name = "tBBedRoomTempRef";
            this.tBBedRoomTempRef.Size = new System.Drawing.Size(40, 23);
            this.tBBedRoomTempRef.TabIndex = 77;
            this.tBBedRoomTempRef.Text = "20";
            // 
            // Clock
            // 
            this.Clock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clock.AutoSize = true;
            this.Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Clock.Location = new System.Drawing.Point(438, 79);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(56, 18);
            this.Clock.TabIndex = 107;
            this.Clock.Text = "00H00";
            // 
            // BtWindowBedroom
            // 
            this.BtWindowBedroom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtWindowBedroom.BackColor = System.Drawing.Color.Black;
            this.BtWindowBedroom.Enabled = false;
            this.BtWindowBedroom.ForeColor = System.Drawing.Color.White;
            this.BtWindowBedroom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtWindowBedroom.Location = new System.Drawing.Point(604, 74);
            this.BtWindowBedroom.Margin = new System.Windows.Forms.Padding(2);
            this.BtWindowBedroom.Name = "BtWindowBedroom";
            this.BtWindowBedroom.Size = new System.Drawing.Size(174, 31);
            this.BtWindowBedroom.TabIndex = 86;
            this.BtWindowBedroom.Tag = "close";
            this.BtWindowBedroom.Text = "Fenêtre Chambre";
            this.BtWindowBedroom.UseVisualStyleBackColor = false;
            this.BtWindowBedroom.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // GroupKitchen
            // 
            this.GroupKitchen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupKitchen.BackColor = System.Drawing.SystemColors.Control;
            this.GroupKitchen.Controls.Add(this.labelKitchenSubtitleAsk);
            this.GroupKitchen.Controls.Add(this.labelKitchenSubtitleHot);
            this.GroupKitchen.Controls.Add(this.BtKitchenHot);
            this.GroupKitchen.Controls.Add(this.labelKitchenSubtitleAct);
            this.GroupKitchen.Controls.Add(this.tBKitchenTempAct);
            this.GroupKitchen.Controls.Add(this.tBKitchenTempRef);
            this.GroupKitchen.Controls.Add(this.ProgressBarKitchen);
            this.GroupKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.GroupKitchen.Location = new System.Drawing.Point(23, 174);
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
            // tBKitchenTempAct
            // 
            this.tBKitchenTempAct.Enabled = false;
            this.tBKitchenTempAct.Location = new System.Drawing.Point(72, 23);
            this.tBKitchenTempAct.Name = "tBKitchenTempAct";
            this.tBKitchenTempAct.Size = new System.Drawing.Size(40, 23);
            this.tBKitchenTempAct.TabIndex = 71;
            this.tBKitchenTempAct.Tag = "2";
            this.tBKitchenTempAct.Text = "20,0";
            // 
            // tBKitchenTempRef
            // 
            this.tBKitchenTempRef.Location = new System.Drawing.Point(72, 52);
            this.tBKitchenTempRef.Name = "tBKitchenTempRef";
            this.tBKitchenTempRef.Size = new System.Drawing.Size(40, 23);
            this.tBKitchenTempRef.TabIndex = 77;
            this.tBKitchenTempRef.Text = "20";
            // 
            // BtWindowKitchen
            // 
            this.BtWindowKitchen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtWindowKitchen.BackColor = System.Drawing.Color.Black;
            this.BtWindowKitchen.Enabled = false;
            this.BtWindowKitchen.ForeColor = System.Drawing.Color.White;
            this.BtWindowKitchen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtWindowKitchen.Location = new System.Drawing.Point(214, 74);
            this.BtWindowKitchen.Margin = new System.Windows.Forms.Padding(2);
            this.BtWindowKitchen.Name = "BtWindowKitchen";
            this.BtWindowKitchen.Size = new System.Drawing.Size(164, 31);
            this.BtWindowKitchen.TabIndex = 85;
            this.BtWindowKitchen.Tag = "close";
            this.BtWindowKitchen.Text = "Fenêtre Cuisine";
            this.BtWindowKitchen.UseVisualStyleBackColor = false;
            this.BtWindowKitchen.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // GroupOutdoor
            // 
            this.GroupOutdoor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupOutdoor.BackColor = System.Drawing.SystemColors.Control;
            this.GroupOutdoor.Controls.Add(this.labelOutdoorLamp);
            this.GroupOutdoor.Controls.Add(this.BtOutdoorLight);
            this.GroupOutdoor.Controls.Add(this.labelOutdoorSubtitleAct);
            this.GroupOutdoor.Controls.Add(this.tBOutdoorTempAct);
            this.GroupOutdoor.Controls.Add(this.ProgressBarOutdoor);
            this.GroupOutdoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.GroupOutdoor.Location = new System.Drawing.Point(23, 678);
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
            this.tBOutdoorTempAct.Location = new System.Drawing.Point(71, 30);
            this.tBOutdoorTempAct.Name = "tBOutdoorTempAct";
            this.tBOutdoorTempAct.Size = new System.Drawing.Size(41, 23);
            this.tBOutdoorTempAct.TabIndex = 71;
            this.tBOutdoorTempAct.Tag = "0";
            this.tBOutdoorTempAct.Text = "20,0";
            // 
            // BtWindowSaloonL
            // 
            this.BtWindowSaloonL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtWindowSaloonL.BackColor = System.Drawing.Color.Black;
            this.BtWindowSaloonL.Enabled = false;
            this.BtWindowSaloonL.ForeColor = System.Drawing.Color.White;
            this.BtWindowSaloonL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtWindowSaloonL.Location = new System.Drawing.Point(197, 655);
            this.BtWindowSaloonL.Margin = new System.Windows.Forms.Padding(2);
            this.BtWindowSaloonL.Name = "BtWindowSaloonL";
            this.BtWindowSaloonL.Size = new System.Drawing.Size(170, 32);
            this.BtWindowSaloonL.TabIndex = 87;
            this.BtWindowSaloonL.Tag = "close";
            this.BtWindowSaloonL.Text = "Fenêtre Salon";
            this.BtWindowSaloonL.UseVisualStyleBackColor = false;
            this.BtWindowSaloonL.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // GroupSaloon
            // 
            this.GroupSaloon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupSaloon.BackColor = System.Drawing.SystemColors.Control;
            this.GroupSaloon.Controls.Add(this.ProgressBarSaloon);
            this.GroupSaloon.Controls.Add(this.labelSaloonSubtitleHot);
            this.GroupSaloon.Controls.Add(this.BtSaloonHot);
            this.GroupSaloon.Controls.Add(this.labelSaloonSubtitleAsk);
            this.GroupSaloon.Controls.Add(this.labelSaloonSubtitleAct);
            this.GroupSaloon.Controls.Add(this.tBSaloonTempAct);
            this.GroupSaloon.Controls.Add(this.tBSaloonTempRef);
            this.GroupSaloon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.GroupSaloon.Location = new System.Drawing.Point(942, 453);
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
            this.tBSaloonTempAct.Location = new System.Drawing.Point(72, 22);
            this.tBSaloonTempAct.Name = "tBSaloonTempAct";
            this.tBSaloonTempAct.Size = new System.Drawing.Size(40, 23);
            this.tBSaloonTempAct.TabIndex = 71;
            this.tBSaloonTempAct.Tag = "1";
            this.tBSaloonTempAct.Text = "20,0";
            // 
            // tBSaloonTempRef
            // 
            this.tBSaloonTempRef.Location = new System.Drawing.Point(72, 52);
            this.tBSaloonTempRef.Name = "tBSaloonTempRef";
            this.tBSaloonTempRef.Size = new System.Drawing.Size(40, 23);
            this.tBSaloonTempRef.TabIndex = 77;
            this.tBSaloonTempRef.Text = "20";
            // 
            // BtWindowSaloonR
            // 
            this.BtWindowSaloonR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtWindowSaloonR.BackColor = System.Drawing.Color.Black;
            this.BtWindowSaloonR.Enabled = false;
            this.BtWindowSaloonR.ForeColor = System.Drawing.Color.White;
            this.BtWindowSaloonR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtWindowSaloonR.Location = new System.Drawing.Point(731, 655);
            this.BtWindowSaloonR.Margin = new System.Windows.Forms.Padding(2);
            this.BtWindowSaloonR.Name = "BtWindowSaloonR";
            this.BtWindowSaloonR.Size = new System.Drawing.Size(166, 32);
            this.BtWindowSaloonR.TabIndex = 88;
            this.BtWindowSaloonR.Tag = "close";
            this.BtWindowSaloonR.Text = "Fenêtre Salon";
            this.BtWindowSaloonR.UseVisualStyleBackColor = false;
            this.BtWindowSaloonR.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // BtDoorKitchen
            // 
            this.BtDoorKitchen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtDoorKitchen.BackColor = System.Drawing.Color.Black;
            this.BtDoorKitchen.Enabled = false;
            this.BtDoorKitchen.ForeColor = System.Drawing.Color.White;
            this.BtDoorKitchen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtDoorKitchen.Location = new System.Drawing.Point(250, 360);
            this.BtDoorKitchen.Margin = new System.Windows.Forms.Padding(2);
            this.BtDoorKitchen.Name = "BtDoorKitchen";
            this.BtDoorKitchen.Size = new System.Drawing.Size(149, 34);
            this.BtDoorKitchen.TabIndex = 89;
            this.BtDoorKitchen.Tag = "close";
            this.BtDoorKitchen.Text = "Porte Cuisine";
            this.BtDoorKitchen.UseVisualStyleBackColor = false;
            this.BtDoorKitchen.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // BtDoorBedroom
            // 
            this.BtDoorBedroom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtDoorBedroom.BackColor = System.Drawing.Color.Black;
            this.BtDoorBedroom.Enabled = false;
            this.BtDoorBedroom.ForeColor = System.Drawing.Color.White;
            this.BtDoorBedroom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtDoorBedroom.Location = new System.Drawing.Point(746, 360);
            this.BtDoorBedroom.Margin = new System.Windows.Forms.Padding(2);
            this.BtDoorBedroom.Name = "BtDoorBedroom";
            this.BtDoorBedroom.Size = new System.Drawing.Size(137, 34);
            this.BtDoorBedroom.TabIndex = 90;
            this.BtDoorBedroom.Tag = "close";
            this.BtDoorBedroom.Text = "Porte Chambre";
            this.BtDoorBedroom.UseVisualStyleBackColor = false;
            this.BtDoorBedroom.Click += new System.EventHandler(this.ChangeOpeningState);
            // 
            // TabCredit
            // 
            this.TabCredit.Controls.Add(this.TabOverview);
            this.TabCredit.Controls.Add(this.tabConfiguration);
            this.TabCredit.Controls.Add(this.TabCredits);
            this.TabCredit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCredit.Location = new System.Drawing.Point(0, 0);
            this.TabCredit.Name = "TabCredit";
            this.TabCredit.SelectedIndex = 0;
            this.TabCredit.Size = new System.Drawing.Size(1110, 884);
            this.TabCredit.TabIndex = 108;
            // 
            // StatusBarRecord
            // 
            this.StatusBarRecord.Name = "StatusBarRecord";
            this.StatusBarRecord.Size = new System.Drawing.Size(12, 17);
            this.StatusBarRecord.Text = "‌•‌";
            // 
            // lighInactivePanel
            // 
            this.lighInactivePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lighInactivePanel.Location = new System.Drawing.Point(197, 689);
            this.lighInactivePanel.Margin = new System.Windows.Forms.Padding(2);
            this.lighInactivePanel.Name = "lighInactivePanel";
            this.lighInactivePanel.Size = new System.Drawing.Size(115, 124);
            this.lighInactivePanel.TabIndex = 106;
            // 
            // lighActivePanel
            // 
            this.lighActivePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lighActivePanel.Location = new System.Drawing.Point(197, 691);
            this.lighActivePanel.Margin = new System.Windows.Forms.Padding(2);
            this.lighActivePanel.Name = "lighActivePanel";
            this.lighActivePanel.Size = new System.Drawing.Size(113, 122);
            this.lighActivePanel.TabIndex = 107;
            this.lighActivePanel.Visible = false;
            // 
            // fireHotSaloon
            // 
            this.fireHotSaloon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fireHotSaloon.Location = new System.Drawing.Point(422, 493);
            this.fireHotSaloon.Margin = new System.Windows.Forms.Padding(2);
            this.fireHotSaloon.Name = "fireHotSaloon";
            this.fireHotSaloon.Size = new System.Drawing.Size(144, 143);
            this.fireHotSaloon.TabIndex = 100;
            this.fireHotSaloon.Visible = false;
            // 
            // fireHotKitchen
            // 
            this.fireHotKitchen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fireHotKitchen.Location = new System.Drawing.Point(188, 202);
            this.fireHotKitchen.Margin = new System.Windows.Forms.Padding(2);
            this.fireHotKitchen.Name = "fireHotKitchen";
            this.fireHotKitchen.Size = new System.Drawing.Size(124, 131);
            this.fireHotKitchen.TabIndex = 100;
            this.fireHotKitchen.Visible = false;
            // 
            // fireHotBedRoom
            // 
            this.fireHotBedRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fireHotBedRoom.Location = new System.Drawing.Point(648, 202);
            this.fireHotBedRoom.Margin = new System.Windows.Forms.Padding(2);
            this.fireHotBedRoom.Name = "fireHotBedRoom";
            this.fireHotBedRoom.Size = new System.Drawing.Size(130, 131);
            this.fireHotBedRoom.TabIndex = 99;
            this.fireHotBedRoom.Visible = false;
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
            this.fireColdKitchen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fireColdKitchen.Location = new System.Drawing.Point(188, 202);
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
            // fireColdPannelBedRoom
            // 
            this.fireColdPannelBedRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fireColdPannelBedRoom.Location = new System.Drawing.Point(648, 202);
            this.fireColdPannelBedRoom.Margin = new System.Windows.Forms.Padding(2);
            this.fireColdPannelBedRoom.Name = "fireColdPannelBedRoom";
            this.fireColdPannelBedRoom.Size = new System.Drawing.Size(130, 159);
            this.fireColdPannelBedRoom.TabIndex = 96;
            // 
            // fireColdSaloon
            // 
            this.fireColdSaloon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fireColdSaloon.Location = new System.Drawing.Point(422, 493);
            this.fireColdSaloon.Margin = new System.Windows.Forms.Padding(2);
            this.fireColdSaloon.Name = "fireColdSaloon";
            this.fireColdSaloon.Size = new System.Drawing.Size(142, 143);
            this.fireColdSaloon.TabIndex = 98;
            // 
            // LightConfProgress
            // 
            this.LightConfProgress.Location = new System.Drawing.Point(69, 23);
            this.LightConfProgress.Name = "LightConfProgress";
            this.LightConfProgress.Size = new System.Drawing.Size(26, 104);
            this.LightConfProgress.TabIndex = 7;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 884);
            this.Controls.Add(this.TabCredit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainControl";
            this.Text = "Controle Principaux ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit);
            this.Load += new System.EventHandler(this.Initialisation);
            this.tabConfiguration.ResumeLayout(false);
            this.GbConfLight.ResumeLayout(false);
            this.GbConfLight.PerformLayout();
            this.PanelLightConf.ResumeLayout(false);
            this.PanelLightConf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollSensibility)).EndInit();
            this.GbConfigMain.ResumeLayout(false);
            this.GbConfigMain.PerformLayout();
            this.TabOverview.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.GroupBedroom.ResumeLayout(false);
            this.GroupBedroom.PerformLayout();
            this.GroupKitchen.ResumeLayout(false);
            this.GroupKitchen.PerformLayout();
            this.GroupOutdoor.ResumeLayout(false);
            this.GroupOutdoor.PerformLayout();
            this.GroupSaloon.ResumeLayout(false);
            this.GroupSaloon.PerformLayout();
            this.TabCredit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer TimerMainRoutine;
        public System.Windows.Forms.Timer TimerClock;
        public System.Windows.Forms.TabPage TabCredits;
        public System.Windows.Forms.TabPage tabConfiguration;
        public System.Windows.Forms.GroupBox GbConfLight;
        public System.Windows.Forms.CheckBox CbConfLightAuto;
        public System.Windows.Forms.Label LbConfSensibility;
        public System.Windows.Forms.GroupBox GbConfigMain;
        public System.Windows.Forms.CheckBox CbConfGodMode;
        public System.Windows.Forms.CheckBox CbConfRegulation;
        public System.Windows.Forms.TabPage TabOverview;
        public System.Windows.Forms.Panel MainPanel;
        public LighInactivePannel lighInactivePanel;
        public LighActivePannel lighActivePanel;
        public FireHotPannel fireHotSaloon;
        public FireHotPannel fireHotKitchen;
        public FireHotPannel fireHotBedRoom;
        public System.Windows.Forms.Button BtDoorEnter;
        public System.Windows.Forms.GroupBox GroupBedroom;
        public VertcicalProgressBar ProgressBarBedRoom;
        public System.Windows.Forms.Label labelBedRoomSubtitleHot;
        public System.Windows.Forms.Button BtBedRoomHot;
        public System.Windows.Forms.Label labelBedRoomSubtitleAsk;
        public System.Windows.Forms.Label labelBedRoomSubtitleAct;
        public System.Windows.Forms.TextBox tBBedRoomTempAct;
        public System.Windows.Forms.TextBox tBBedRoomTempRef;
        public System.Windows.Forms.Label Clock;
        public System.Windows.Forms.Button BtWindowBedroom;
        public System.Windows.Forms.GroupBox GroupKitchen;
        public System.Windows.Forms.Label labelKitchenSubtitleAsk;
        public System.Windows.Forms.Label labelKitchenSubtitleHot;
        public System.Windows.Forms.Button BtKitchenHot;
        public System.Windows.Forms.Label labelKitchenSubtitleAct;
        public System.Windows.Forms.TextBox tBKitchenTempAct;
        public System.Windows.Forms.TextBox tBKitchenTempRef;
        public VertcicalProgressBar ProgressBarKitchen;
        public System.Windows.Forms.Button BtWindowKitchen;
        public FireColdPannel fireColdKitchen;
        public System.Windows.Forms.GroupBox GroupOutdoor;
        public System.Windows.Forms.Label labelOutdoorLamp;
        public System.Windows.Forms.Button BtOutdoorLight;
        public System.Windows.Forms.Label labelOutdoorSubtitleAct;
        public System.Windows.Forms.TextBox tBOutdoorTempAct;
        public VertcicalProgressBar ProgressBarOutdoor;
        public System.Windows.Forms.Button BtWindowSaloonL;
        public System.Windows.Forms.GroupBox GroupSaloon;
        public VertcicalProgressBar ProgressBarSaloon;
        public System.Windows.Forms.Label labelSaloonSubtitleHot;
        public System.Windows.Forms.Button BtSaloonHot;
        public System.Windows.Forms.Label labelSaloonSubtitleAsk;
        public System.Windows.Forms.Label labelSaloonSubtitleAct;
        public System.Windows.Forms.TextBox tBSaloonTempAct;
        public System.Windows.Forms.TextBox tBSaloonTempRef;
        public System.Windows.Forms.Button BtWindowSaloonR;
        public System.Windows.Forms.Button BtDoorKitchen;
        public System.Windows.Forms.Button BtDoorBedroom;
        public FireColdPannel fireColdPannelBedRoom;
        public FireColdPannel fireColdSaloon;
        public System.Windows.Forms.TabControl TabCredit;
        public System.Windows.Forms.TrackBar ScrollSensibility;
        public VertcicalProgressBar LightConfProgress;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Panel PanelLightConf;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarMode;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarRecord;
    }
}


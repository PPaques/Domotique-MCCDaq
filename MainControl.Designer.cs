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
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBarMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusMode,
            this.StatusBarMode});
            this.StatusBar.Location = new System.Drawing.Point(0, 476);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(934, 25);
            this.StatusBar.TabIndex = 0;
            this.StatusBar.Text = "StatusBar";
            // 
            // StatusMode
            // 
            this.StatusMode.Name = "StatusMode";
            this.StatusMode.Size = new System.Drawing.Size(0, 20);
            // 
            // StatusBarMode
            // 
            this.StatusBarMode.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.StatusBarMode.Name = "StatusBarMode";
            this.StatusBarMode.Size = new System.Drawing.Size(48, 20);
            this.StatusBarMode.Text = "Mode";
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 501);
            this.Controls.Add(this.StatusBar);
            this.Name = "MainControl";
            this.Text = "Controle Principaux ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit);
            this.Load += new System.EventHandler(this.Initialisation);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusMode;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarMode;
    }
}


namespace Tracking
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trackOurDeviceByGmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findLocationByIPAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trackOurDeviceByGmailToolStripMenuItem,
            this.findLocationByIPAddressToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trackOurDeviceByGmailToolStripMenuItem
            // 
            this.trackOurDeviceByGmailToolStripMenuItem.Name = "trackOurDeviceByGmailToolStripMenuItem";
            this.trackOurDeviceByGmailToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.trackOurDeviceByGmailToolStripMenuItem.Text = "Track Our Device By Gmail";
            this.trackOurDeviceByGmailToolStripMenuItem.Click += new System.EventHandler(this.trackOurDeviceByGmailToolStripMenuItem_Click);
            // 
            // findLocationByIPAddressToolStripMenuItem
            // 
            this.findLocationByIPAddressToolStripMenuItem.Name = "findLocationByIPAddressToolStripMenuItem";
            this.findLocationByIPAddressToolStripMenuItem.Size = new System.Drawing.Size(165, 20);
            this.findLocationByIPAddressToolStripMenuItem.Text = "Find Location By IP Address";
            this.findLocationByIPAddressToolStripMenuItem.Click += new System.EventHandler(this.findLocationByIPAddressToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 501);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trackOurDeviceByGmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findLocationByIPAddressToolStripMenuItem;
    }
}
namespace Purchase_Register
{
    partial class Home
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
            this.distributorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.distributorToolStripMenuItem,
            this.purchaseRegisterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(118, 471);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // distributorToolStripMenuItem
            // 
            this.distributorToolStripMenuItem.Name = "distributorToolStripMenuItem";
            this.distributorToolStripMenuItem.Size = new System.Drawing.Size(105, 19);
            this.distributorToolStripMenuItem.Text = "Distributor";
            this.distributorToolStripMenuItem.Click += new System.EventHandler(this.distributorToolStripMenuItem_Click);
            // 
            // purchaseRegisterToolStripMenuItem
            // 
            this.purchaseRegisterToolStripMenuItem.Name = "purchaseRegisterToolStripMenuItem";
            this.purchaseRegisterToolStripMenuItem.Size = new System.Drawing.Size(105, 19);
            this.purchaseRegisterToolStripMenuItem.Text = "Purchase Register";
            this.purchaseRegisterToolStripMenuItem.Click += new System.EventHandler(this.purchaseRegisterToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 471);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem purchaseRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distributorToolStripMenuItem;
    }
}
namespace CARRENTALBUSINESS
{
    partial class MDIadmin
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
			this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bOOKINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vEHICLESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aBOUTUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cONTACTUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mYACCOUNTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.bOOKINGToolStripMenuItem,
            this.vEHICLESToolStripMenuItem,
            this.aBOUTUSToolStripMenuItem,
            this.cONTACTUSToolStripMenuItem,
            this.mYACCOUNTToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// hOMEToolStripMenuItem
			// 
			this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
			this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.hOMEToolStripMenuItem.Text = "HOME";
			this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
			// 
			// bOOKINGToolStripMenuItem
			// 
			this.bOOKINGToolStripMenuItem.Name = "bOOKINGToolStripMenuItem";
			this.bOOKINGToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.bOOKINGToolStripMenuItem.Text = "BOOKING";
			this.bOOKINGToolStripMenuItem.Click += new System.EventHandler(this.bOOKINGToolStripMenuItem_Click);
			// 
			// vEHICLESToolStripMenuItem
			// 
			this.vEHICLESToolStripMenuItem.Name = "vEHICLESToolStripMenuItem";
			this.vEHICLESToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.vEHICLESToolStripMenuItem.Text = "VEHICLES";
			// 
			// aBOUTUSToolStripMenuItem
			// 
			this.aBOUTUSToolStripMenuItem.Name = "aBOUTUSToolStripMenuItem";
			this.aBOUTUSToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
			this.aBOUTUSToolStripMenuItem.Text = "ABOUT US";
			// 
			// cONTACTUSToolStripMenuItem
			// 
			this.cONTACTUSToolStripMenuItem.Name = "cONTACTUSToolStripMenuItem";
			this.cONTACTUSToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
			this.cONTACTUSToolStripMenuItem.Text = "CONTACT US";
			// 
			// mYACCOUNTToolStripMenuItem
			// 
			this.mYACCOUNTToolStripMenuItem.Name = "mYACCOUNTToolStripMenuItem";
			this.mYACCOUNTToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
			this.mYACCOUNTToolStripMenuItem.Text = "MY ACCOUNT";
			// 
			// MDIMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MDIMain";
			this.Text = "MDIMain";
			this.MouseHover += new System.EventHandler(this.bOOKINGToolStripMenuItem_Click);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOOKINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vEHICLESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBOUTUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONTACTUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mYACCOUNTToolStripMenuItem;
    }
}
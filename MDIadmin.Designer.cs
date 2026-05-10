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
            components = new System.ComponentModel.Container();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            bOOKINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            bOOKINGLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            vEHICLESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mYACCOUNTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            lblUserInfo = new System.Windows.Forms.ToolStripStatusLabel();
            lblSeparator1 = new System.Windows.Forms.ToolStripStatusLabel();
            lblUserRole = new System.Windows.Forms.ToolStripStatusLabel();
            lblSeparator2 = new System.Windows.Forms.ToolStripStatusLabel();
            lblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuFile, hOMEToolStripMenuItem, bOOKINGToolStripMenuItem, vEHICLESToolStripMenuItem, mYACCOUNTToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1067, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuLogout, exitToolStripMenuItem, toolStripMenuItem1, mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new System.Drawing.Size(49, 24);
            mnuFile.Text = "FILE";
            // 
            // mnuLogout
            // 
            mnuLogout.Name = "mnuLogout";
            mnuLogout.Size = new System.Drawing.Size(139, 26);
            mnuLogout.Text = "Logout";
            mnuLogout.Click += mnuLogout_Click_1;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(136, 6);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(136, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new System.Drawing.Size(139, 26);
            mnuExit.Text = "Exit";
            mnuExit.Click += mnuExit_Click_1;
            // 
            // hOMEToolStripMenuItem
            // 
            hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            hOMEToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            hOMEToolStripMenuItem.Text = "HOME";
            hOMEToolStripMenuItem.Click += hOMEToolStripMenuItem_Click;
            // 
            // bOOKINGToolStripMenuItem
            // 
            bOOKINGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { bOOKINGLISTToolStripMenuItem });
            bOOKINGToolStripMenuItem.Name = "bOOKINGToolStripMenuItem";
            bOOKINGToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            bOOKINGToolStripMenuItem.Text = "BOOKING";
            // 
            // bOOKINGLISTToolStripMenuItem
            // 
            bOOKINGLISTToolStripMenuItem.Name = "bOOKINGLISTToolStripMenuItem";
            bOOKINGLISTToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            bOOKINGLISTToolStripMenuItem.Text = "Booking List";
            bOOKINGLISTToolStripMenuItem.Click += bOOKINGLISTToolStripMenuItem_Click;
            // 
            // vEHICLESToolStripMenuItem
            // 
            vEHICLESToolStripMenuItem.Name = "vEHICLESToolStripMenuItem";
            vEHICLESToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            vEHICLESToolStripMenuItem.Text = "VEHICLES";
            vEHICLESToolStripMenuItem.Click += vEHICLESToolStripMenuItem_Click;
            // 
            // mYACCOUNTToolStripMenuItem
            // 
            mYACCOUNTToolStripMenuItem.Name = "mYACCOUNTToolStripMenuItem";
            mYACCOUNTToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            mYACCOUNTToolStripMenuItem.Text = "MY ACCOUNT";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblUserInfo, lblSeparator1, lblUserRole, lblSeparator2, lblDateTime });
            statusStrip1.Location = new System.Drawing.Point(0, 666);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(1067, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUserInfo
            // 
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new System.Drawing.Size(899, 20);
            lblUserInfo.Spring = true;
            lblUserInfo.Text = "Logged in as:";
            lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSeparator1
            // 
            lblSeparator1.Name = "lblSeparator1";
            lblSeparator1.Size = new System.Drawing.Size(13, 20);
            lblSeparator1.Text = "|";
            // 
            // lblUserRole
            // 
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new System.Drawing.Size(42, 20);
            lblUserRole.Text = "Role:";
            // 
            // lblSeparator2
            // 
            lblSeparator2.Name = "lblSeparator2";
            lblSeparator2.Size = new System.Drawing.Size(13, 20);
            lblSeparator2.Text = "|";
            // 
            // lblDateTime
            // 
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new System.Drawing.Size(85, 20);
            lblDateTime.Text = "2026-04-23";
            lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // MDIadmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1067, 692);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "MDIadmin";
            Text = "MDIMain";
            MouseHover += bOOKINGToolStripMenuItem_Click;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOOKINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOOKINGLISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vEHICLESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mYACCOUNTToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUserInfo;
        private System.Windows.Forms.ToolStripStatusLabel lblSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel lblUserRole;
        private System.Windows.Forms.ToolStripStatusLabel lblSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel lblDateTime;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripSeparator exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}
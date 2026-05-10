using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace TRAJJ_Company
{
    partial class FrmLogin
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
        /// do not trouble code here after
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            btnLogin = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnRegister = new System.Windows.Forms.Button();
            lblUsername = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            lblTrajRentalsJa = new System.Windows.Forms.Label();
            btnExit = new System.Windows.Forms.Button();
            lblResgiteringnotice = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Arial Black", 9F);
            btnLogin.Location = new Point(384, 328);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(118, 39);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Black", 9F);
            btnClear.Location = new Point(629, 328);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 39);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Arial Black", 9F);
            btnRegister.Location = new Point(486, 425);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(118, 39);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial Black", 9F);
            lblUsername.Location = new Point(252, 205);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(95, 22);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial Black", 9F);
            lblPassword.Location = new Point(257, 284);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(90, 22);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(353, 200);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(422, 27);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(353, 282);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(422, 27);
            txtPassword.TabIndex = 6;
            // 
            // lblTrajRentalsJa
            // 
            lblTrajRentalsJa.AutoSize = true;
            lblTrajRentalsJa.Font = new Font("Rockwell Extra Bold", 9F);
            lblTrajRentalsJa.Location = new Point(452, 40);
            lblTrajRentalsJa.Name = "lblTrajRentalsJa";
            lblTrajRentalsJa.Size = new Size(252, 17);
            lblTrajRentalsJa.TabIndex = 7;
            lblTrajRentalsJa.Text = "Welcome to Traj Rentals Ja!";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(966, 460);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblResgiteringnotice
            // 
            lblResgiteringnotice.AutoSize = true;
            lblResgiteringnotice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResgiteringnotice.Location = new Point(384, 390);
            lblResgiteringnotice.Name = "lblResgiteringnotice";
            lblResgiteringnotice.Size = new Size(306, 20);
            lblResgiteringnotice.TabIndex = 9;
            lblResgiteringnotice.Text = "Don't have an account? Click register below";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new Size(1072, 492);
            Controls.Add(lblResgiteringnotice);
            Controls.Add(btnExit);
            Controls.Add(lblTrajRentalsJa);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(btnRegister);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblTrajRentalsJa;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResgiteringnotice;
    }
}
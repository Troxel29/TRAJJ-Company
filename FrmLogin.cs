using CARRENTALBUSINESS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrajjRentalFrm;

namespace TRAJJ_Company
{
    public partial class FrmLogin : Form
    {
        private Timer animationTimer;
        private int direction = 1;

        public FrmLogin()
        {
            InitializeComponent();
            animationTimer = new Timer();
            animationTimer.Interval = 50;
            animationTimer.Tick += AnimationTimer_Tick;
            this.Load += FrmLogin_Load;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;


            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Login successful!");
                
                MDIadmin MDIadmin = new MDIadmin();
                MDIadmin.Show();

                this.Hide();


            }
            else
            {
                MessageBox.Show("Please enter both username and password.");

                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

            txtUsername.Focus();
        }

        // Animation: Starts the timer when the form loads to begin the label movement
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            animationTimer.Start();
        }

        // Animation: Moves the welcome label left and right across the screen
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            lblTrajRentalsJa.Left += 5 * direction;
            if (lblTrajRentalsJa.Right >= this.ClientSize.Width || lblTrajRentalsJa.Left <= 0)
            {
                direction = -direction;
            }
        }
    }
}

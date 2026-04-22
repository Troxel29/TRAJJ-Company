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
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;


            if (txtUsername.Text == "trajrentals" && txtPassword.Text == "trajisthebest")
            {
                MessageBox.Show("Login successful!");
                
                MDIadmin MDIadmin = new MDIadmin();
                MDIadmin.Show();

                this.Hide();


            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");

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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TRAJJ_Company
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please enter your first name");
                txtFirstName.Focus();
                return;
            }

            
            if (txtLastName.Text == "")
            {
                MessageBox.Show("Please enter your last name");
                txtLastName.Focus();
                return;
            }

            
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter your email");
                txtEmail.Focus();
                return;
            }

            
            if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Please enter your phone number");
                txtPhoneNumber.Focus();
                return;
            }

            
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please choose a username");
                txtUsername.Focus();
                return;
            }

            
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter a password");
                txtPassword.Focus();
                return;
            }

            
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }

            
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please enter your address");
                txtAddress.Focus();
                return;
            }

          
            if (dtpDOB.Value > DateTime.Today.AddYears(-18))
            {
                MessageBox.Show("You must be at least 18 years old to register");
                dtpDOB.Focus();
                return;
            }

           
            MessageBox.Show("Registration Successful! You can now login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            DialogResult answer = MessageBox.Show("Cancel registration?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
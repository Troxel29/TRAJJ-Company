using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp1
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["User"] != null)
                {
                    Response.Redirect("~/");
                }
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            // Validate passwords match
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lblError.Text = "Passwords do not match. Please try again.";
                lblError.Visible = true;
                txtConfirmPassword.Text = string.Empty;
                return;
            }

            // Validate minimum age (18)
            DateTime dob;
            if (!DateTime.TryParse(txtDateOfBirth.Text, out dob) || dob > DateTime.Today.AddYears(-18))
            {
                lblError.Text = "You must be at least 18 years old to register.";
                lblError.Visible = true;
                return;
            }

            try
            {
                bool success = WebDatabase.RegisterUser(
                    txtFirstName.Text.Trim(),
                    txtLastName.Text.Trim(),
                    txtUsername.Text.Trim(),
                    txtPassword.Text,
                    txtEmail.Text.Trim(),
                    txtPhoneNumber.Text.Trim(),
                    txtAddress.Text.Trim(),
                    dob
                );

                if (success)
                {
                    lblError.Visible = false;
                    lblSuccess.Text = "Registration successful! You can now <a href='Login'>login</a>.";
                    lblSuccess.Visible = true;
                    ClearForm();
                }
                else
                {
                    lblError.Text = "Username or email is already in use. Please choose a different one.";
                    lblError.Visible = true;
                }
            }
            catch (SqlException)
            {
                lblError.Text = "Unable to connect to the database. Please try again later.";
                lblError.Visible = true;
            }
        }

        private void ClearForm()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtDateOfBirth.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }
    }
}

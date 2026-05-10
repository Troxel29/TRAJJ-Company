using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserAppLibrary;

namespace WebApp1
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Redirect already-logged-in users to home
                if (Session["User"] != null)
                {
                    Response.Redirect("~/");
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            try
            {
                User user = WebDatabase.ValidateUser(username, password);
                if (user != null)
                {
                    Session["User"] = user;
                    Response.Redirect("~/");
                }
                else
                {
                    lblError.Text = "Invalid username or password. Please try again.";
                    lblError.Visible = true;
                    txtPassword.Text = string.Empty;
                }
            }
            catch (SqlException)
            {
                lblError.Text = "Unable to connect to the database. Please try again later.";
                lblError.Visible = true;
            }
        }
    }
}

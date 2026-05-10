using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserAppLibrary;

namespace WebApp1
{
    public partial class Services : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                User user = Session["User"] as User;
                if (user != null)
                {
                    lblinfo.Text = "Welcome, " + HttpUtility.HtmlEncode(user.FirstName + " " + user.LastName) + "! Browse our services below.";
                    lblinfo.Visible = true;
                }
            }
        }
    }
}
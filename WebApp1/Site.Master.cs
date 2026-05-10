using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserAppLibrary;

namespace WebApp1
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = Session["User"] as User;
            if (user != null)
            {
                phGuest.Visible = false;
                phUser.Visible = true;
                litUsername.Text = HttpUtility.HtmlEncode(user.FirstName);
            }
            else
            {
                phGuest.Visible = true;
                phUser.Visible = false;
            }
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            Session.Remove("User");
            Response.Redirect("~/");
        }
    }
}
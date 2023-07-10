using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomePage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string username = (string)Session["Username"];
        session_username.Text = "WelCome, " + username;
    }

    protected void session_logout_Click(object sender, EventArgs e)
    {
        if (Session["Username"] == null)
        {
            Response.Redirect("UserLogin.aspx");
        }
        else
        {
            Session.Abandon();
            Response.Redirect("UserLogin.aspx");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeManagement.Model;

public partial class UserLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void RadButton1_Click(object sender, EventArgs e)
    {
        string username = lg_txtemail.Text;
        string password = lg_txtpassword.Text;

        UserModel userData = new UserModel
        {
            Email = username,
            Password = password
        };


        if (IsUserValid(userData))
        {
            Session["Username"] = username;
            Response.Redirect("EmployeeDetails.aspx");
        }
        else
        {
            RadLabel3.Text = "Invalid Credentials, Login Failed!";
        }
    }

    private bool IsUserValid(UserModel userModel)
    {
        var response = RequestResponse.Post("User/UserLogin", userModel);
        var content = response.Content;

        if (int.Parse(content) > 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
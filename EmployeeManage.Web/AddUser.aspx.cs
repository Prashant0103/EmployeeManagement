using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeManagement.Model;
public partial class AddUser : System.Web.UI.Page
{
    string username;
    protected void Page_Load(object sender, EventArgs e)
    {
        username = (string)Session["Username"];
        if (username == null)
        {
            Page.Title = "Register Form";
            heading.Text = "Add User";
        }
        else
        {
            heading.Text = "Update User";
        }
    }

    protected void RegisterUser()
    {
        UserModel users = new UserModel
        {
            FirstName = rg_txtfirstname.Text,
            LastName = rg_txtlastname.Text,
            Email = rg_txtemail.Text,
            Password = rg_txtpassword.Text,
            Gender = rg_txtgender.Text,
        };

        var response = RequestResponse.Post("User/SaveUser", users);
        var content = response.Content;
        if (response.IsSuccessful)
        {
            Response.Redirect("UserLogin.aspx");
        }
    }


    private bool IsUserExists(UserModel userModel)
    {
        var response = RequestResponse.Post("User/UserExists", userModel);
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

    protected void RadButton3_Click(object sender, EventArgs e)
    {
        string email = rg_txtemail.Text;
        UserModel user = new UserModel
        {
            Email = email
        };

        if (IsUserExists(user))
        {
            RadLabel7.Text = "Email already exists...";
        }
        else
        {
            RegisterUser();
        }
        
    }
}
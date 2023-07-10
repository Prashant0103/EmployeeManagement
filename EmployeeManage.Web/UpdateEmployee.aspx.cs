using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeManagement.Model;
using Newtonsoft.Json;

public partial class UpdateEmployee : System.Web.UI.Page
{
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.QueryString["id"];
        if (!IsPostBack)
        {
            if (id == null)
            {
                Page.Title = "Add Employee - Employee Management";
                heading.Text = "Add Employee";
                RadButton3.Text = "Save";
            }
            else
            {
                Page.Title = "Update Employee - Employee Management";
                heading.Text = "Update Employee";
                RadButton3.Text = "Update";
                AddDataToUpdate(int.Parse(id));
            }

        }
    }

    protected void AddDataToUpdate(int empId)
    {
        var response = RequestResponse.GetById("Employee/GetEmployeeById/{id}", empId);
        var content = response.Content;

        EmployeeModel employee = JsonConvert.DeserializeObject<EmployeeModel>(content);

        rg_txtfirstname.Text = employee.FirstName;
        rg_txtmiddlename.Text = employee.MiddleName;
        rg_txtlastname.Text = employee.LastName;
        rg_txtdob.SelectedDate = employee.DOB;
        rg_txtaddress1.Text = employee.Address1;
        rg_txtaddress2.Text = employee.Address2;
        rg_txtcity.Text = employee.City;
        rg_txtstate.Text = employee.State;
        rg_txtxzip.Text = employee.ZipCode.ToString();
        rg_txtcountry.SelectedValue = employee.Country;
        rg_txtdesignation.SelectedValue = employee.Designation;
        rg_txttechnology.SelectedValue = employee.Technology;
        rg_txtmobileno.Text = employee.MobileNo;

    }

    protected void SaveEmployee()
    {
        DateTime date = (DateTime)rg_txtdob.SelectedDate;
        string selectedDate = date.ToString("dd-MM-yyyy");
        //int userid = GetUserId();
        EmployeeModel employeeData = new EmployeeModel
        {
            FirstName = rg_txtfirstname.Text,
            MiddleName = rg_txtmiddlename.Text,
            LastName = rg_txtlastname.Text,
            DOB = DateTime.Parse(selectedDate),
            Address1 = rg_txtaddress1.Text,
            Address2 = rg_txtaddress2.Text,
            City = rg_txtcity.Text,
            State = rg_txtstate.Text,
            ZipCode = int.Parse(rg_txtxzip.Text),
            Country = rg_txtcountry.SelectedValue,
            Designation = rg_txtdesignation.SelectedValue,
            Technology = rg_txttechnology.SelectedValue,
            MobileNo = rg_txtmobileno.Text,
            isActive = Convert.ToBoolean(1),
            UserId = 1
        };

        var response = RequestResponse.Post("Employee/SaveEmployee", employeeData);
        if (response.IsSuccessful)
        {
            Response.Redirect("EmployeeDetails.aspx");
        }
    }

    protected void UpdateEmployee1(int empId)
    {
        DateTime date = (DateTime)rg_txtdob.SelectedDate;
        string selectedDate = date.ToString("dd-MM-yyyy");
        EmployeeModel employeeData = new EmployeeModel
        {
            FirstName = rg_txtfirstname.Text,
            MiddleName = rg_txtmiddlename.Text,
            LastName = rg_txtlastname.Text,
            DOB = DateTime.Parse(selectedDate),
            Address1 = rg_txtaddress1.Text,
            Address2 = rg_txtaddress2.Text,
            City = rg_txtcity.Text,
            State = rg_txtstate.Text,
            ZipCode = int.Parse(rg_txtxzip.Text),
            Country = rg_txtcountry.SelectedValue,
            Designation = rg_txtdesignation.SelectedValue,
            Technology = rg_txttechnology.SelectedValue,
            MobileNo = rg_txtmobileno.Text,
        };

        var response = RequestResponse.Put("Employee/UpdateEmployee/{id}", empId, employeeData);
        if (response.IsSuccessful)
        {
            Response.Redirect("EmployeeDetails.aspx");
        }
    }

    protected void RadButton3_Click(object sender, EventArgs e)
    {
        if (id == null)
        {
            SaveEmployee();
        }
        else
        {
            UpdateEmployee1(int.Parse(id));
        }
    }

}
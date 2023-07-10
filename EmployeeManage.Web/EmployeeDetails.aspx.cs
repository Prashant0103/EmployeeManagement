using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeManagement.Model;
using System.Data;
using RestSharp;
using Telerik.Web.UI;
using System.Configuration;
using Newtonsoft.Json;


public partial class EmployeeDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void AddNewUser_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateEmployee.aspx");
    }


    protected List<EmployeeModel> GetData(int pageNumber, int pageSize)
    {
        
        var response = RequestResponse.GetEmployeePageData("Employee/GetEmployeePageData/{pageNumber}/{pageSize}", pageNumber, pageSize);
        var content = response.Content;
        return JsonConvert.DeserializeObject<List<EmployeeModel>>(content);

    }

    

    protected void employeeTable_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        int pageNumber = employeeTable.CurrentPageIndex + 1;
        int pageSize = employeeTable.PageSize;
        List<EmployeeModel> employeeList = GetData(pageNumber, pageSize);
        var count = employeeList.Count;
        employeeTable.VirtualItemCount = count;
        employeeTable.DataSource = employeeList;
    }

    protected void employeeTable_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
    {
        if (e.CommandName == "UpdateRow")
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;
            int id = Int32.Parse(editedItem["Id"].Text);
            Response.Redirect("UpdateEmployee.aspx?id=" + id);
        }

        else if (e.CommandName == "DeleteRow")
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;
            int id = Convert.ToInt32(editedItem["Id"].Text);
            var response = RequestResponse.Delete("Employee/DeleteEmployee/{id}", id);
            if (response.IsSuccessful)
            {
                Response.Redirect("EmployeeDetails.aspx");
            }
        }
    }

    protected void GetSearched(string search)
    {
        var response = RequestResponse.Search("Employee/GetSearchedEmployee", search);
        var content = response.Content;

        List<EmployeeModel> employee = JsonConvert.DeserializeObject<List<EmployeeModel>>(content);
        employeeTable.DataSource = employee;
        employeeTable.DataBind();
    }

    protected void btnSearchName_Click(object sender, EventArgs e)
    {
        string search = txt_searchName.Text;
        if (search.Equals(""))
        {
            Response.Redirect("EmployeeDetails.aspx");
        }
        else
        {
            GetSearched(search);
        }
        
    }

    protected List<EmployeeModel> GetAllData()
    {

        var response = RequestResponse.GetAll("Employee/GetAllEmployees");
        var content = response.Content;
        return JsonConvert.DeserializeObject<List<EmployeeModel>>(content);

    }
    protected void employeeTable_PageIndexChanged(object sender, GridPageChangedEventArgs e)
    {
        employeeTable.CurrentPageIndex = e.NewPageIndex;
        employeeTable.DataSource = GetAllData();
        employeeTable.DataBind();

    }
}
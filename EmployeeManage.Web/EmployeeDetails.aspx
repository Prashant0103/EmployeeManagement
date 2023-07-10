<%@ Page Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="EmployeeDetails.aspx.cs" Inherits="EmployeeDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Employee Details - Employee Management</title>
    <link href="assets/bootstrap/css/style.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    
    <telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server">
    <br />
    <center><h2 style="color:white">Employee Details</h2></center>
    <div class="mx-5 mb-7 mt-4 float-lg-right">
        <telerik:RadTextBox ID="txt_searchName" runat="server" style="margin-left:10px"></telerik:RadTextBox>
        <telerik:RadButton ID="btnSearchName" runat="server" Icon-PrimaryIconCssClass="rbSearch" ValidationGroup="searchName" OnClick="btnSearchName_Click"  CssClass="bg-primary text-white" Width="50px"></telerik:RadButton>
    </div>
    <div class="mt-4 ml-5">
        <telerik:RadButton ID="AddNewUser" runat="server" Text="Add Employee" CssClass="ml-5 mt-3 bg-primary text-white" OnClick="AddNewUser_Click" Icon-PrimaryIconCssClass="rbAdd"></telerik:RadButton>
    </div>
    

    <div class="mx-5 mb-5 mt-4">
        <telerik:RadGrid ID="employeeTable" runat="server" AllowPaging="true" OnNeedDataSource="employeeTable_NeedDataSource" OnItemCommand="employeeTable_ItemCommand" OnPageIndexChanged="employeeTable_PageIndexChanged" PageSize="5" AllowCustomPaging="false" AllowSorting="true"   CssClass="mx-5" HeaderStyle-Font-Bold="true" AutoGenerateColumns="false">
            <MasterTableView AllowCustomSorting="true" AllowSorting="true">
                <Columns>
                    <telerik:GridBoundColumn DataField="EmpId" HeaderText="Id" UniqueName="Id" />
                        <telerik:GridBoundColumn DataField="FirstName" HeaderText="FirstName"/>
                        <telerik:GridBoundColumn DataField="LastName" HeaderText="LastName" />
                        <telerik:GridBoundColumn DataField="City" HeaderText="Email" />
                        <telerik:GridBoundColumn DataField="Designation" HeaderText="Designation" UniqueName="Designation"/>
                        <telerik:GridBoundColumn DataField="Technology" HeaderText="Technology" UniqueName="Technology"/>
                         <telerik:GridButtonColumn Text="Update" UniqueName="Update" ButtonType="PushButton" CommandName="UpdateRow" ButtonCssClass="btn btn-warning" >
                             <ItemStyle Font-Bold="True" ForeColor="Blue" />
                        </telerik:GridButtonColumn>
                        <telerik:GridButtonColumn Text="Delete" UniqueName="Delete" ButtonType="PushButton" CommandName="DeleteRow" ButtonCssClass="btn btn-danger" ConfirmText="Are you sure ?" ConfirmTitle="Warning">
                            <ItemStyle ForeColor="Red" />
                        </telerik:GridButtonColumn>
                </Columns>
            </MasterTableView>
             <PagerStyle Mode="NextPrevAndNumeric" AlwaysVisible="true" />
        </telerik:RadGrid>
    </div>
</telerik:RadAjaxPanel>
</asp:Content>
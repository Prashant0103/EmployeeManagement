<%@ Page Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Index - Employee Management</title>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    
    <telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server">

    <center><h2 style="color:white">Welcome</h2></center>

</telerik:RadAjaxPanel>
</asp:Content>
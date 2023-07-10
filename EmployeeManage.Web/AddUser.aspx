<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="AddUser" %>


<! DOCTYPE html>  
<html lang="en" >  
<head runat="server">  
  <meta charset="UTF-8">  
  <title>Update Form
 </title>  
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.3/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">  
<style>
    body {
        height: 100%;
    }

    .global-container {
        height: 100%;
        display: flex;
        align-items: center;
        justify-content: center;
        background-image:url('backview.png')
       
    }

    form {
        padding-top: 10px;
        font-size: 14px;
        margin-top: 30px;
    }

    .login-form {
        width: 450px;
        margin: 20px;
         border-radius:20px;
         border-color: gray;
         background-color:darkslategray;
         background-image:url('registerpage.jpg')
    }

    .sign-up {
        text-align: center;
        padding: 20px 0 0;
    }
</style>  
</head>
<body>    

  <div class="global-container">  
    <div class="card login-form">  
    <div class="card-body">  
        <h1 class="text-center text-primary" >
            <telerik:RadLabel ID="heading" runat="server" ForeColor="SkyBlue"></telerik:RadLabel>
        </h1>  
        <div class="card-text">  
            <form id="form1" runat="server">
                 <telerik:RadScriptManager runat="server" ID="RadScriptManager1" />
                <div class="form-group">  
                    <div class="row">
        <div class="col-md-6">
            <telerik:RadLabel runat="server" ID="RadLabel1" Text="First Name" Font-Bold="false" Font-Size="Large" Width="100%" ForeColor="white"></telerik:RadLabel>
            <br />
            <telerik:RadTextBox DataField="ID" ID="rg_txtfirstname" Text="" InputType="Text" MaxLength="100" Width="100%" runat="server" TextMode="SingleLine" oninput="restrictNumericInput(this);"></telerik:RadTextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="rg_txtfirstname" ErrorMessage="First Name Required" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="col-md-6">
            <telerik:RadLabel runat="server" ID="RadLabel5" Text="Last Name" Font-Bold="false" Font-Size="Large" ForeColor="white"></telerik:RadLabel>
            <br />
            <telerik:RadTextBox ID="rg_txtlastname" InputType="Text" Width="100%" runat="server" MaxLength="100" TextMode="SingleLine" oninput="restrictNumericInput(this);"></telerik:RadTextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="rg_txtlastname" ErrorMessage="Last Name Required" Display="Dynamic" ForeColor="Red" ></asp:RequiredFieldValidator>
        </div>
    </div>
                </div>  
                <div class="form-group">  
                    <telerik:RadLabel runat="server" ID="RadLabel3" Text="Email" Font-Bold="false" Font-Size="Large" ForeColor="white"></telerik:RadLabel>
         <br />
                      <telerik:RadTextBox ID="rg_txtemail" InputType="Text" Width="99%" Rows="1" runat="server" TextMode="SingleLine"></telerik:RadTextBox>
                    <telerik:RadLabel runat="server" ID="RadLabel7" Font-Bold="false" Font-Size="Medium" ForeColor="Red" ></telerik:RadLabel>
                    <asp:RegularExpressionValidator ID="emailValidator" runat="server" Display="Dynamic"
                                ErrorMessage="Please enter valid e-mail address" ValidationExpression="^[\w\.\-]+@[a-zA-Z0-9\-]+(\.[a-zA-Z0-9\-]{1,})*(\.[a-zA-Z]{2,3}){1,2}$"
                                ControlToValidate="rg_txtemail" ForeColor="Red"></asp:RegularExpressionValidator>

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="rg_txtemail" ErrorMessage="Email Required" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>  
                <div class="form-group">  
                    <div class="row">
        <div class="col-md-6">
            <telerik:RadLabel runat="server" ID="RadLabel4" Text="Password" Font-Bold="false" Font-Size="Large" ForeColor="white" Width="100%"></telerik:RadLabel>
            <br />
            <telerik:RadTextBox ID="rg_txtpassword" InputType="Text" Width="100%" Rows="1" runat="server" TextMode="Password" MinLength="8" MaxLength="16" ></telerik:RadTextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="rg_txtpassword" ErrorMessage="Password Required" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter a strong password" ValidationExpression="^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$" ControlToValidate="rg_txtpassword" ForeColor="Red"></asp:RegularExpressionValidator>
        </div>
        <div class="col-md-6">
            <telerik:RadLabel runat="server" ID="RadLabel6" Text="Confirm Password" Font-Bold="false" Font-Size="Large" ForeColor="white" Width="100%"></telerik:RadLabel>
            <br />
            <telerik:RadTextBox ID="rg_txtcpassword" InputType="Text" Width="100%" Rows="1" runat="server" TextMode="Password" MinLength="8" MaxLength="16"></telerik:RadTextBox>
            <asp:CompareValidator runat="server" ControlToCompare="rg_txtcpassword" ControlToValidate="rg_txtpassword" ErrorMessage="Passwords do not match." ForeColor="Red" Display="Dynamic"></asp:CompareValidator>
        </div>
    </div>
                </div>  
                 
                <div class="form-group">  
                    <telerik:RadLabel runat="server" ID="RadLabel2" Text="Gender" ont-Bold="false" Font-Size="Large" ForeColor="white" Width="23%"></telerik:RadLabel>
     
                      <telerik:RadComboBox ID="rg_txtgender"  Rows="1" runat="server" TextMode="MultiLine"  Width="49%" Filter="StartsWith">
                           <Items>
                                    <telerik:RadComboBoxItem runat="server" Text="Male" Value="Male" />
                                    <telerik:RadComboBoxItem runat="server" Text="Female" Value="Female"></telerik:RadComboBoxItem>
                            </Items>
                      </telerik:RadComboBox>
                </div>  
                 
                      
                <telerik:RadButton ID="RadButton3" runat="server" Text="Add" ButtonType="LinkButton" Font-Bold="true"  Height="35px" style="top: 3px; left: 130px; width: 80px" CssClass="mt-1 text-white bg-success" OnClick="RadButton3_Click"></telerik:RadButton>
                <telerik:RadButton ID="RadButton1" runat="server" Text="Cancel" ButtonType="LinkButton" Font-Bold="true" Height="35px" style="top: 3px; left: 150px; width: 80px" CssClass="mt-1 text-white bg-danger" NavigateUrl="UserLogin.aspx"></telerik:RadButton>
                
            </form>
        </div>  
    </div>  
</div>    
</div>
    <script type="text/javascript">
        function restrictNumericInput(input) {
            input.value = input.value.replace(/[0-9]/g, '');
        }
    </script>
</body>  
</html>

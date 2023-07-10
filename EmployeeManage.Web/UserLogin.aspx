<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserLogin.aspx.cs" Inherits="UserLogin" %>

<! DOCTYPE html>  
<html lang="en" >  
<head runat="server">  
  <meta charset="UTF-8">  
  <title>Login Screen
 </title>  
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.3/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">  
    <link rel="stylesheet" href="assets/css/loginstyle.css" />
<style>
    body {
        height: 100%;
    }

    .global-container {
        height: 100%;
        display: flex;
        align-items: center;
        justify-content: center;
        background-image:url('backview.png');
       
    }

    form {
        padding-top: 10px;
        font-size: 14px;
        margin-top: 30px;
    }

    .login-form {
        width: 500px;
        margin: 20px;
        border-radius:25px;
        background-color:transparent;
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
        <h1 class="text-center text-primary">LOGIN</h1><br />
        <div class="card-text">  
            <form runat="server">  
                 <telerik:RadScriptManager runat="server" ID="RadScriptManager1" />
             
                <div class="form-group">  
                    <telerik:RadLabel runat="server" ID="RadLabel1" Text="EMAIL" Font-Bold="false" Font-Size="Large" ForeColor="Blue"></telerik:RadLabel>
         <br />
                      <telerik:RadTextBox ID="lg_txtemail" InputType="Text" Width="100%" Rows="1" runat="server" TextMode="SingleLine" Skin="Bootstrap"></telerik:RadTextBox>
                    <asp:RegularExpressionValidator ID="emailValidator" runat="server" Display="Dynamic"
                                ErrorMessage="Please enter valid e-mail address" ValidationExpression="^[\w\.\-]+@[a-zA-Z0-9\-]+(\.[a-zA-Z0-9\-]{1,})*(\.[a-zA-Z]{2,3}){1,2}$"
                                ControlToValidate="lg_txtemail" ForeColor="Purple"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lg_txtemail" ErrorMessage="Email Required" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator><br />

                </div>  
                <div class="form-group">  
                    <telerik:RadLabel runat="server" ID="RadLabel2" Text="PASSWORD" ont-Bold="false" Font-Size="Large" ForeColor="Blue"></telerik:RadLabel>
                    <br />
                      <telerik:RadTextBox ID="lg_txtpassword" InputType="Text" Width="100%" Rows="1" runat="server" TextMode="Password" Skin="Bootstrap"></telerik:RadTextBox>
                    <asp:RequiredFieldValidator ID="RequiredField1" runat="server" ControlToValidate="lg_txtpassword" ErrorMessage="Password Required" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator><br />
                    
                    
                </div>  
                <center><telerik:RadButton ID="RadButton1" runat="server" Width="30%" Text="SIGN IN" ButtonType="LinkButton" Font-Bold="true" BackColor="SkyBlue" OnClick="RadButton1_Click" Height="35px" ></telerik:RadButton></center>
                <telerik:RadLabel runat="server" ID="RadLabel3" Font-Size="X-Small" Skin="Bootstrap" Font-Bold="True" ForeColor="Tomato" ></telerik:RadLabel>
                <div class="sign-up" style="color:skyblue" >  
                    Don't have an account? <a style="color:orangered" href="AddUser.aspx"> Create One </a>  
                </div>  
            </form>  
        </div>  
    </div>  
</div>  
</div>   
</body>  
</html>  
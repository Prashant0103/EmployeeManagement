<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateEmployee.aspx.cs" Inherits="UpdateEmployee" %>

<! DOCTYPE html>  
<html lang="en" >  
<head runat="server">  
  <meta charset="UTF-8">  
  <title>Registration Form
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
        width: 632px;
        margin: 20px 3px 0px 20px;
         border-color: gray;
         background-color:dimgray;
        top: -11px;
        left: 22px;
        height: 607px;
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
        <h1 class="text-center text-primary">
            <telerik:RadLabel ID="heading" runat="server"></telerik:RadLabel>
        </h1>  
        <div class="card-text">  
            <form id="form1" runat="server">
                 <telerik:RadScriptManager runat="server" ID="RadScriptManager1" />
                <div class="form-group">  
                    <div class="row">
        <div class="col-md-4">
            <telerik:RadLabel runat="server" ID="RadLabel1" Text="First Name" Font-Bold="false" Font-Size="Large" Width="100%" ForeColor="white"></telerik:RadLabel>
            <br />
            <telerik:RadTextBox ID="rg_txtfirstname" InputType="Text" Width="100%" Rows="1" runat="server" TextMode="SingleLine" oninput="restrictNumericInput(this);"></telerik:RadTextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="rg_txtfirstname" ErrorMessage="First Name Required" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="col-md-4">
            <telerik:RadLabel ID="RadLabel7" runat="server" Text="Middle Name" Font-Bold="false" Font-Size="Large" Width="100%" ForeColor="white"></telerik:RadLabel>
            <br />
            <telerik:RadTextBox ID="rg_txtmiddlename" runat="server" InputType="Text" Width="100%" Rows="1" TextMode="SingleLine" oninput="restrictNumericInput(this);"></telerik:RadTextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="rg_txtmiddlename" ErrorMessage="Middle Name Required" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="col-md-4">
            <telerik:RadLabel runat="server" ID="RadLabel5" Text="Last Name" Font-Bold="false" Font-Size="Large" Width="100%" ForeColor="white"></telerik:RadLabel>
            <br />
            <telerik:RadTextBox ID="rg_txtlastname" InputType="Text" Width="100%" Rows="1" runat="server" TextMode="SingleLine" oninput="restrictNumericInput(this);"></telerik:RadTextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="rg_txtlastname" ErrorMessage="Last Name Required" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    </div>

                </div>  
                <div class="form-group">  
                    <br />
                    <telerik:RadLabel runat="server" ID="RadLabel2" Text="Address1" ont-Bold="false" Font-Size="Large" Width="49%" ForeColor="white" style="margin-left: 6px" ></telerik:RadLabel>
                    <telerik:RadLabel runat="server" ID="RadLabel4" Text="Address2" ont-Bold="false" Font-Size="Large" ForeColor="white" style="margin-left: 15px"></telerik:RadLabel>
                      <br />
                    <telerik:RadTextBox ID="rg_txtaddress1" InputType="Text" Width="48%" Rows="1" runat="server"  ></telerik:RadTextBox>
                      <telerik:RadTextBox ID="rg_txtaddress2" InputType="Text" Width="47%" Rows="1" runat="server" style="margin-left:25px"></telerik:RadTextBox>
                    <asp:RequiredFieldValidator ID="RequiredField1" runat="server" ControlToValidate="rg_txtaddress1" ErrorMessage="Address1 Required" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                     
                </div>
                <div class="form-group">  
                    <div class="row">
        <div class="col-md-6">
            <telerik:RadLabel runat="server" ID="RadLabel14" Text="Designation" Width="100%" Font-Bold="false" Font-Size="Large" ForeColor="white"></telerik:RadLabel>
            <br />
            <telerik:RadComboBox ID="rg_txtdesignation" Width="100%" Rows="1" runat="server" TextMode="MultiLine" Filter="StartsWith">
                <Items>
                    <telerik:RadComboBoxItem Text="Developer" Value="Developer" />
                    <telerik:RadComboBoxItem Text="Lead Developer" Value="Lead Developer"></telerik:RadComboBoxItem>
                    <telerik:RadComboBoxItem Text="QA" Value="QA"></telerik:RadComboBoxItem>
                    <telerik:RadComboBoxItem Text="HR" Value="HR"></telerik:RadComboBoxItem>
                </Items>
            </telerik:RadComboBox>
        </div>
        <div class="col-md-6">
            <telerik:RadLabel runat="server" ID="RadLabel12" Text="Date Of Birth" Font-Bold="false" Font-Size="Large" ForeColor="white" Width="100%"></telerik:RadLabel>
            <br />
            <telerik:RadDatePicker ID="rg_txtdob" runat="server" DateInput-DateFormat="MMM d yyyy" DateInput-DisplayDateFormat=" MM/d/yyyy" MinDate="01-Jan-1970" MaxDate="31-Dec-2005" Width="100%"></telerik:RadDatePicker>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="rg_txtdob" Width="100%" ErrorMessage="Date Of Birth Required" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    </div>
                </div>  
                  
                    
                 <div class="form-group">  
                    <telerik:RadLabel runat="server" ID="RadLabel9" Text="City" Font-Bold="false" Font-Size="Large" Width="33%" ForeColor="white"></telerik:RadLabel>
                    <telerik:RadLabel ID="RadLabel10" runat="server"  Text="State" Font-Bold="false" Font-Size="Large" Width="33%" ForeColor="white" style="margin-left: 8px"></telerik:RadLabel>
                    <telerik:RadLabel runat="server" ID="RadLabel8" Text="Country" Font-Bold="false" Font-Size="Large" ForeColor="white" style="margin-left: 8px"></telerik:RadLabel>
                     <telerik:RadTextBox ID="rg_txtcity" InputType="Text" Width="30%" Rows="1" runat="server" TextMode="SingleLine"></telerik:RadTextBox>
                     <telerik:RadComboBox ID="rg_txtstate"  Rows="1" runat="server" TextMode="MultiLine"  Width="30%" Filter="StartsWith" style="margin-left: 25px">
                           <Items>
                                    <telerik:RadComboBoxItem Text="Maharashtra" Value="mst" ></telerik:RadComboBoxItem>
                                    <telerik:RadComboBoxItem Text="Kerla" Value="Ker"></telerik:RadComboBoxItem>
                                    <telerik:RadComboBoxItem Text="Madhya Pradesh" Value="mp"></telerik:RadComboBoxItem>
                                    <telerik:RadComboBoxItem Text="Uttar Pradesh" Value="up"></telerik:RadComboBoxItem>
                            </Items>
                      </telerik:RadComboBox>
                    <telerik:RadComboBox ID="rg_txtcountry"  Rows="1" runat="server" TextMode="MultiLine"  Width="30%" Filter="StartsWith" style="margin-left: 25px">
                           <Items>
                                    <telerik:RadComboBoxItem Text="india" Value="india" ></telerik:RadComboBoxItem>
                                    <telerik:RadComboBoxItem Text="USA" Value="USA"></telerik:RadComboBoxItem>
                                    <telerik:RadComboBoxItem Text="Russia" Value="Russia"></telerik:RadComboBoxItem>
                                    <telerik:RadComboBoxItem Text="Japan" Value="Japan"></telerik:RadComboBoxItem>
                            </Items>
                      </telerik:RadComboBox>
                </div>
                  <div class="form-group">  
                      
                    <telerik:RadLabel runat="server" ID="RadLabel11" Text="Mobile No." Font-Bold="false" Font-Size="Large" Width="43%" ForeColor="white"></telerik:RadLabel>
                    
                    <telerik:RadLabel runat="server" ID="RadLabel13" Text="Technology" Font-Bold="false" Font-Size="Large" Width="30%"  ForeColor="white" style="margin-left: 8px"></telerik:RadLabel>
                    <telerik:RadLabel runat="server" ID="RadLabel6" Text="Zip Code" Font-Bold="false" Font-Size="Large"  ForeColor="white" style="margin-left: 8px"></telerik:RadLabel>
                    <br />
                      <telerik:RadComboBox ID="RadTextBox5" Width="12%" Rows="1" runat="server" TextMode="MultiLine" Filter="StartsWith">
                           <Items>
                                    <telerik:RadComboBoxItem Text="+91" Value="+91" />
                                    <telerik:RadComboBoxItem Text="+01" Value="+01"></telerik:RadComboBoxItem>
                                    <telerik:RadComboBoxItem Text="+99" Value="+99"></telerik:RadComboBoxItem>
                                    <telerik:RadComboBoxItem Text="+111" Value="+111"></telerik:RadComboBoxItem>
                            </Items>
                      </telerik:RadComboBox>
                      
                      <telerik:RadTextBox ID="rg_txtmobileno" Width="30%" Rows="1" runat="server" TextMode="SingleLine" onkeypress="return validateNumericInput(event)"></telerik:RadTextBox>
                      
                      <telerik:RadComboBox ID="rg_txttechnology" Width="30%" Rows="1" runat="server" TextMode="MultiLine" Filter="StartsWith">
                           <Items>
                                    <telerik:RadComboBoxItem Text="Python" Value="Python" />
                                    <telerik:RadComboBoxItem Text="Java" Value="Java"></telerik:RadComboBoxItem>
                                    <telerik:RadComboBoxItem Text="C#" Value="C#"></telerik:RadComboBoxItem>
                                    <telerik:RadComboBoxItem Text="Ruby" Value="Ruby"></telerik:RadComboBoxItem>
                            </Items>
                      </telerik:RadComboBox>
                       <telerik:RadComboBox ID="rg_txtxzip" Width="25%" Rows="1" runat="server" TextMode="MultiLine" Filter="StartsWith">
                           <Items>
                                    <telerik:RadComboBoxItem Text="444605" Value="444605" />
                                    <telerik:RadComboBoxItem Text="444601" Value="444601"></telerik:RadComboBoxItem>
                                    <telerik:RadComboBoxItem Text="444602" Value="444602"></telerik:RadComboBoxItem>
                                    <telerik:RadComboBoxItem Text="444607" Value="444607"></telerik:RadComboBoxItem>
                            </Items>
                      </telerik:RadComboBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="rg_txtmobileno" ErrorMessage="Mobile No Required" Display="Dynamic" ForeColor="Red" ></asp:RequiredFieldValidator>
                      <asp:RegularExpressionValidator ID="revMobNo" runat="server" ErrorMessage="Invalid Mobile Number." ValidationExpression="^([0-9]{10})" ControlToValidate="rg_txtmobileno" ForeColor="Red"></asp:RegularExpressionValidator>
                      
                      
                </div> 
                <telerik:RadButton ID="RadButton3" runat="server"  ButtonType="LinkButton" style="margin-left:160px" Font-Bold="true" Width="20%" CssClass="mt-1 text-white bg-success" OnClick="RadButton3_Click"></telerik:RadButton>
                <telerik:RadButton ID="RadButton1" runat="server" Text="Cancel" ButtonType="LinkButton" Font-Bold="true" Width="20%" CssClass="mt-1 text-white bg-danger" NavigateUrl="EmployeeDetails.aspx"></telerik:RadButton> 
            </form>
        </div>  
    </div>  
</div>    
</div>
    <script type="text/javascript">
        function restrictNumericInput(input) {
            input.value = input.value.replace(/[0-9]/g, '');
        }

        function validateNumericInput(event) {
            var keyCode = event.keyCode ? event.keyCode : event.which;
            if (keyCode < 48 || keyCode > 57) {
                event.preventDefault();
                return false;
            }
        }

    </script>
</body>  
    
</html>
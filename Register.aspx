<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Height="651px" Width="1305px">
          <table>
              <tr>
                   
                  <td> <asp:label ID="User_Name"  text="Name" runat="server"/></td>
                   <td><asp:TextBox ID="UserName" runat="server"  placeholder="Name" required="true" ></asp:TextBox></td>
                  <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName" 
                    ErrorMessage="User name:Value Required" Display="Dynamic"
                   SetFocusOnError="true" />--%>
          
              </tr>
              <tr>
                   <td> <asp:label ID="UserPass"  text="Password" runat="server"/></td>
                   <td><asp:TextBox ID="User_Pass" runat="server" minlength="8" maxlength="12" type="Password" required="true"></asp:TextBox></td>
          
              </tr>
              <tr>
                   <td> <asp:label ID="UserEmail" text="Email" runat="server"/></td>
                   <td><asp:TextBox ID="User_Email" type="email"  minlength="8"  runat ="server" required="true"></asp:TextBox></td>
          
              </tr>
              <tr>
                   <td> <asp:label ID="UserPhone" text="Phone"  runat="server"/></td>
                   <td><asp:TextBox ID="User_Phone"  runat="server" minlength="11" maxlength="11" ng-pattern="phoneNumbr" ng-model="phone" required="true"></asp:TextBox></td>
          
              </tr>
              <tr>
                   <td> <asp:label ID="UserAddress" text="Address" runat="server"/></td>
                   <td><asp:TextBox ID="User_Address" runat="server" required="true"></asp:TextBox></td>
          
              </tr>
          </table>
            <asp:Button runat="server" OnClick="Unnamed1_Click"  ID="_register" Height="29px" Text="register" Width="224px"/>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>

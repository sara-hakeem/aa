<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="469px" Width="1282px">
            <table>
                <tr>
           <td> <asp:TextBox ID="User_Name" runat="server" required="true"  OnTextChanged="User_Name_TextChanged"></asp:TextBox></td>
            <td><asp:Label ID="UserName" runat="server" Text="Name" required="true"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="User_Pass" runat="server" required="true"></asp:TextBox>
                    </td>
                    <td><asp:Label ID="UserPass" runat="server" Text="Password"></asp:Label> </td>
                </tr>
            
           
             </table>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LogIn" Height="24px" Width="194px" />
        </asp:Panel>
    </form>
</body>
</html>

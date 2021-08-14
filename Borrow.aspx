<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Borrow.aspx.cs" Inherits="Borrow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 274px;
            width: 1310px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="Grid_Details" runat="server" Height="174px" Width="1092px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>

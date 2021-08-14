<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Books.aspx.cs" Inherits="Books" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script>


        function Details(Book_Id)
        {

            window.location = "Book_Detail.aspx?id=" + Book_Id;
        }
        function Delete(Row_Id) {
            alert("Are You Sure You Need TO dELETE this Item?");
            $.ajax({
                url: '<%=ResolveUrl("~/WebService.asmx/Delete_Item")%>',
                data: "{'Row_Id':'" + Row_Id + "'}",
                dataType: "json",
                type: "post",
                contentType: "application/json;charset=utf-8",
                success: function (data) {
                    alert(data.d)
                    window.location = "Books.aspx";
                },
                error: function (response) { },
                failure: function (response) { }
            });
        }
        function Edit(ID) {

            window.location = "AddNewBook.aspx?id=" + ID;
        }
    </script>

    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <div>

            <telerik:RadGrid RenderMode="Lightweight" ID="Book_Grid" runat="server" AutoGenerateColumns="False" GroupPanelPosition="Top" Height="121px">

                <MasterTableView TableLayout="Auto">
                    <Columns>
                        <telerik:GridBoundColumn DataField="Book_Name" HeaderText="Book_Name"
                            SortExpression="Book_Name" UniqueName="Book_Name">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="Book_Current_Amount" HeaderText="Book_Current_Amount"
                            SortExpression="Book_Current_Amount" UniqueName="Book_Current_Amount">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="Book_Base_Amount" HeaderText="Book_Base_Amount"
                            SortExpression="Book_Base_Amount" UniqueName="Book_Base_Amount">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="Department_Id" HeaderText="Department_Id"
                            SortExpression="Department_Id" UniqueName="Department_Id">
                        </telerik:GridBoundColumn>
                         <telerik:GridTemplateColumn DataField="Details" HeaderText="Details"
                            SortExpression="Details" UniqueName="Details">
                            <ItemTemplate>
                                <a onclick='<%#"Details(" + Eval("Book_Id") + ");" %>' class='icon pencil icon-blue icon-size2'>Details</a>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>
                       
                        

                        <telerik:GridBoundColumn DataField="Department_Name" HeaderText="Department_Name"
                            SortExpression="Department_Name" UniqueName="Department_Name">
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn DataField="Author_Name" HeaderText="Author_Name"
                            SortExpression="Author_Name" UniqueName="Author_Name">
                        </telerik:GridBoundColumn>

                        <telerik:GridTemplateColumn DataField="Delete" HeaderText="Delete"
                            SortExpression="Delete" UniqueName="Delete">
                            <ItemTemplate>
                                <a onclick='<%#"Delete(" + Eval("Book_Id") + ");" %>' class='icon pencil icon-blue icon-size2'>Delete</a>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn DataField="Edit" HeaderText="Edit"
                            SortExpression="Edit" UniqueName="Edit">
                            <ItemTemplate>
                                <a onclick='<%#"Edit(" + Eval("Book_Id") + ");" %>' class='icon pencil icon-blue icon-size2'>Edit</a>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>

                    </Columns>

                </MasterTableView>
                <FilterMenu RenderMode="Lightweight">
                </FilterMenu>
                <HeaderContextMenu RenderMode="Lightweight">
                </HeaderContextMenu>
            </telerik:RadGrid>
        </div>
        <telerik:RadButton runat="server" ID="Btn_AddNew" Text="AddNew" OnClick="Btn_AddNew_Click"></telerik:RadButton>


    </form>
</body>
</html>

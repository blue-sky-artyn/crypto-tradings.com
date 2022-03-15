<%@ Page Language="C#" AutoEventWireup="true" CodeFile="connect.aspx.cs" Inherits="connect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        


        <asp:GridView ID="GridView1" runat="server" OnPageIndexChanging="GridView1_PageIndexChanging" >
            <Columns>
                <asp:TemplateField HeaderText="No 1">
                    <ItemTemplate>
                        <%#Eval("ID_Admin") %>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        
        <hr />
        
        <asp:DataGrid ID="DataGrid1" runat="server"></asp:DataGrid>

    </form>
</body>
</html>
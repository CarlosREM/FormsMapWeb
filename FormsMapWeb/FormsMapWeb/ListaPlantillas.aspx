<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="ListaPlantillas.aspx.cs" Inherits="FormsMapWeb.ListaPlantillas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 552px;
        }
    </style>
    <style type="text/css">
       .inlineBlock { display: inline-block;  position: relative; width : 100%;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" BackColor="#81C784" Height="59px" HorizontalAlign="Center">
            <asp:Label ID="Label1" runat="server" Text="Plantillas" Font-Names="Bell MT" Font-Size="35pt" ForeColor="White"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" HorizontalAlign="Left">
            <br />
            <asp:Label ID="Label2" runat="server" Font-Size="X-Large" Text="Seleccione una plantilla para ver detalles"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" style="margin-top: 20px">
            <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem>Text1</asp:ListItem>
                <asp:ListItem>Text2</asp:ListItem>
            </asp:ListBox>
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server" HorizontalAlign="Right">
            <asp:Button ID="btnRegresar" runat="server" Font-Names="Bahnschrift" Text="Regresar" />
        </asp:Panel>
    </form>
</body>
</html>

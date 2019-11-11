<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PlacePanelView.ascx.cs" Inherits="FormsMapWeb.CustomControls.PlacePanelView" %>

<style>
    .panel {
        border-radius: 20px;
        margin-bottom: 15px;
        padding:15px;
    }
    .infopanel {
        padding:15px;
    }
    .button {
        border-radius: 20px;
        margin-right: 10px;
    }
</style>
<asp:Panel ID="MainPanel" runat="server" BorderColor="#FFC367" BorderStyle="Solid" CssClass="panel" Width="720px">
    <asp:Button ID="btnInfo" runat="server" BorderStyle="None" CssClass="button" Font-Bold="False" Font-Names="Lato" Text="+" OnClick="btnInfo_Click" />
    <asp:Label ID="lblKey" runat="server" Text="Place Key" Font-Bold="True" Font-Names="Lato" Width="510px"></asp:Label>
    <asp:Button ID="btnEditar" runat="server" BorderStyle="None" Font-Bold="False" Font-Names="Lato" Text="Editar" CssClass="button" />
    <asp:Button ID="btnEliminar" runat="server" BorderStyle="None" Font-Bold="False" Font-Names="Lato" Text="Eliminar" CssClass="button" />
    <asp:Panel ID="InfoPanel" runat="server" CssClass="infopanel">
        <asp:Label ID="lblName" runat="server" Font-Bold="True" Font-Names="Lato" Text="Nombre:"></asp:Label>
        &nbsp;
        <asp:Label ID="lblNameField" runat="server" Font-Bold="False" Font-Names="Lato" Text="Place name"></asp:Label>
        <br />
        <asp:Label ID="lblImg" runat="server" Font-Bold="True" Font-Names="Lato" Text="URL Imagen:"></asp:Label>
        &nbsp;&nbsp;<asp:Label ID="lblImgField" runat="server" Font-Bold="False" Font-Names="Lato" Text="url url url"></asp:Label>
        <br />
        <asp:Label ID="lblLat" runat="server" Font-Bold="True" Font-Names="Lato" Text="Latitud:"></asp:Label>
        &nbsp;&nbsp;<asp:Label ID="lblLatField" runat="server" Font-Bold="False" Font-Names="Lato" Text="12341234" Width="200px"></asp:Label>
        &nbsp;&nbsp;<asp:Label ID="lblLong" runat="server" Font-Bold="True" Font-Names="Lato" Text="Latitud:"></asp:Label>
        &nbsp;
        <asp:Label ID="lblLonField" runat="server" Font-Bold="False" Font-Names="Lato" Text="12341324" Width="200px"></asp:Label>
        <br />
        <asp:Label ID="lblInfo" runat="server" Font-Bold="True" Font-Names="Lato" Text="Informacion:"></asp:Label>
        &nbsp;
        <asp:Label ID="lblInfoField" runat="server" Font-Bold="False" Font-Names="Lato" Text="innnnformacion"></asp:Label>
    </asp:Panel>
</asp:Panel>
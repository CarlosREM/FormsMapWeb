<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SlatePanelView.ascx.cs" Inherits="FormsMapWeb.CustomControls.SlatePanelView" %>

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
    <asp:Label ID="lblKey" runat="server" Text="Slate Key" Font-Bold="True" Font-Names="Lato" Width="510px"></asp:Label>
    <asp:Button ID="btnEditar" runat="server" BorderStyle="None" Font-Bold="False" Font-Names="Lato" Text="Editar" CssClass="button" />
    <asp:Button ID="btnEliminar" runat="server" BorderStyle="None" Font-Bold="False" Font-Names="Lato" Text="Eliminar" CssClass="button" />
    <asp:Panel ID="InfoPanel" runat="server" CssClass="infopanel">
        <asp:Label ID="lblName" runat="server" Font-Bold="True" Font-Names="Lato" Text="Nombre:"></asp:Label>
        &nbsp;
        <asp:Label ID="lblNameField" runat="server" Font-Bold="False" Font-Names="Lato" Text="plantilla"></asp:Label>
        <br />
        <asp:Label ID="lblId" runat="server" Font-Bold="True" Font-Names="Lato" Text="Campo ID:"></asp:Label>
        &nbsp;
        <asp:Label ID="lblIdField" runat="server" Font-Bold="False" Font-Names="Lato" Text="identificador"></asp:Label>
        <br />
        <asp:Label ID="lblQuestions" runat="server" Font-Bold="True" Font-Names="Lato" Text="Preguntas:"></asp:Label>
        <asp:Panel ID="PanelPreguntas" runat="server" CssClass="button" Width="680px">
        </asp:Panel>
    </asp:Panel>
</asp:Panel>


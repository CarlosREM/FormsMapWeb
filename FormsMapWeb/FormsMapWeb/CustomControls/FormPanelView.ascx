<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FormPanelView.ascx.cs" Inherits="FormsMapWeb.CustomControls.FormPanelView" %>

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
    <asp:Label ID="lblKey" runat="server" Text="Form Key" Font-Bold="True" Font-Names="Lato" Width="510px"></asp:Label>
    <asp:Button ID="btnEditar" runat="server" BorderStyle="None" Font-Bold="False" Font-Names="Lato" Text="Editar" CssClass="button" />
    <asp:Button ID="btnEliminar" runat="server" BorderStyle="None" Font-Bold="False" Font-Names="Lato" Text="Eliminar" CssClass="button" />
    <asp:Panel ID="InfoPanel" runat="server" CssClass="infopanel">
        <asp:Label ID="lblSlate" runat="server" Font-Bold="True" Font-Names="Lato" Text="Nombre Plantilla:"></asp:Label>
        &nbsp;
        <asp:Label ID="lblSlateField" runat="server" Font-Bold="False" Font-Names="Lato" Text="plantilla"></asp:Label>
        <br />
        <asp:Label ID="lblPlace" runat="server" Font-Bold="True" Font-Names="Lato" Text="Nombre Lugar:"></asp:Label>
        &nbsp;
        <asp:Label ID="lblPlaceField" runat="server" Font-Bold="False" Font-Names="Lato" Text="lugar"></asp:Label>
        <br />
        <asp:Label ID="lblQuestions" runat="server" Font-Bold="True" Font-Names="Lato" Text="Preguntas:"></asp:Label>
        <asp:Panel ID="PanelPreguntas" runat="server" CssClass="button" Width="680px">
        </asp:Panel>
    </asp:Panel>
</asp:Panel>


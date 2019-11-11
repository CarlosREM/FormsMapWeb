<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FormQuestionView.ascx.cs" Inherits="FormsMapWeb.CustomControls.FormQuestionView" %>
<style>
    .question {
        margin-top: 10px;
        padding: 5px;
    }
    .label {
        margin-right: 10px;
    }
    .hintPanel {
        margin-top: 5px;
        margin-left: 50px;
    }
</style>
<asp:Panel ID="MainPanel" runat="server" Width="800px" CssClass="question" Direction="LeftToRight" HorizontalAlign="Left">
    <table>
    <tr><td>
    <asp:Panel ID="QuestionPanel" runat="server" Width="240px">
        <asp:Label ID="LblQuestion" runat="server" CssClass="label" Font-Bold="True" Font-Names="Lato" Text="P:"></asp:Label>
        <asp:Label ID="LblQuestionField" runat="server" CssClass="label" Font-Bold="False" Font-Names="Lato" Text="Lorem Ipsum dolor sit amet"></asp:Label>
    </asp:Panel>
    </td><td>
    <asp:Panel ID="AnswerPanel" runat="server" Width="240px">
        <asp:Label ID="LblAnswer" runat="server" CssClass="label" Font-Bold="True" Font-Names="Lato" Text="R:"></asp:Label>
        <asp:Label ID="LblAnswerField" runat="server" CssClass="label" Font-Bold="False" Font-Names="Lato" Text="Lorem Ipsum dolor sit amet"></asp:Label>
    </asp:Panel>
    </td><td>
    <asp:Panel ID="TypePanel" runat="server" Width="240px">
        <asp:Label ID="LblType" runat="server" CssClass="label" Font-Bold="True" Font-Names="Lato" Text="Tipo:"></asp:Label>
        <asp:Label ID="LblTypeField" runat="server" CssClass="label" Font-Bold="False" Font-Names="Lato" Text="Seleccion multiple"></asp:Label>
    </asp:Panel>
    </table>
    <asp:Label ID="LblHints" runat="server" CssClass="label" Font-Bold="True" Font-Names="Lato" Text="Respuesta(s):"></asp:Label>
    <asp:Panel ID="HintsPanel" runat="server" Width="600px" CssClass="hintPanel" BorderColor="#CCCCCC" BorderStyle="Dotted">

    </asp:Panel>

</asp:Panel>


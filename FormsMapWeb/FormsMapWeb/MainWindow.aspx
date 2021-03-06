﻿<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="MainWindow.aspx.cs" Inherits="FormsMapWeb.MainWindow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        .sidepanel {
            border-radius: 20px;
            margin-top: 30px;
        }
        .sidebutton {
            margin-top:30px;
            padding-top: 10px;
            padding-bottom: 10px;
            border-radius: 15px;
        }
    </style>
    <title>
        Manejo de Datos - FormsMap Web Companion
    </title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="pnHeader" runat="server" HorizontalAlign="Justify">
            <asp:Image ID="imgLogo" runat="server" ImageAlign="Middle" ImageUrl="~/FormsMapWeb_logo.png" Height="90px" Width="240px" />
            <br />
            <asp:Label ID="lblSeparator1" runat="server" BackColor="#81C784" BorderColor="#81C784" BorderStyle="None" Height="3px" Width="1200px"></asp:Label>
        </asp:Panel>
        <table>
        <tr><td>
        <style>
            td { vertical-align:top; }
        </style>
        <asp:Panel ID="pnSidebar" runat="server" Height="575px" HorizontalAlign="Center" Width="200px" BorderColor="#1C98AA" BorderStyle="Solid" BorderWidth="3px" CssClass="sidepanel">
            <asp:Button ID="btnFormularios" runat="server" Text="Formularios" BorderStyle="None" Font-Size="Medium" Width="180px" CssClass="sidebutton" Font-Names="Lato" OnClick="btnFormularios_Click" />
            <asp:Button ID="btnPlantillas" runat="server" BorderStyle="None" Font-Size="Medium" Text="Plantillas" Width="180px" CssClass="sidebutton" Font-Names="Lato" OnClick="btnPlantillas_Click" />
            <asp:Button ID="btnLugares" runat="server" BorderStyle="None" Font-Size="Medium" Text="Lugares" Width="180px" CssClass="sidebutton" Font-Names="Lato" OnClick="btnLugares_Click" />
            <asp:Button ID="btnRefresh" runat="server" BorderStyle="None" CssClass="sidebutton" Enabled="False" Font-Names="Lato" Font-Size="Medium" Text="Refrescar" Width="180px" OnClick="btnRefresh_Click" />
        </asp:Panel>
        </td><td>
        <style>
            td { vertical-align:top; }
        </style>
        <asp:Panel ID="ContentPanel" runat="server" Height="580px" Width="860px" CssClass="sidepanel" ScrollBars="Vertical" Style="margin-left:15px">
        </asp:Panel>
        </td></tr>
        </table>
    </form>
</body>
</html>

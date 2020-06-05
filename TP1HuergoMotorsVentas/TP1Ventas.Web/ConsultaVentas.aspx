<%@ Page Title="" Language="C#" MasterPageFile="~/MDI.Master" AutoEventWireup="true" CodeBehind="ConsultaVentas.aspx.cs" Inherits="TP1Ventas.Web.ConsultaVentas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem>Vendedor</asp:ListItem>
        <asp:ListItem>Vehiculo</asp:ListItem>
        <asp:ListItem>Cliente</asp:ListItem>
    </asp:RadioButtonList>
    <br />
    <br />
    <asp:TextBox ID="txFiltro" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Inicio"></asp:Label>
    <asp:TextBox ID="dtpInicio" runat="server" type="date"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Fin"></asp:Label>
    <asp:TextBox ID="dtpFin" runat="server" type="date"></asp:TextBox>

    <br />
    <br />
    <asp:Button ID="btBuscar" runat="server" Text="Buscar" OnClick="btBuscar_Click1" style="height: 26px; width: 61px" />
    <br />
    <asp:Button ID="btncsv" runat="server" Text="Exportar a CSV" AutoPostBack="False" OnClick="btncsv_Click1"/>

    <br />
    <br />
    <asp:GridView ID="dtgVentas" runat="server"></asp:GridView>
    <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
</asp:Content>


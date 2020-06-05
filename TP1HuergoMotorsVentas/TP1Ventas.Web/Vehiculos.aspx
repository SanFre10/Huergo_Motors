<%@ Page Title="" Language="C#" MasterPageFile="~/MDI.Master" AutoEventWireup="true" CodeBehind="Vehiculos.aspx.cs" Inherits="TP1Ventas.Web.Vehiculos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Label ID="Label2" runat="server" Text="Filtro"></asp:Label>    
    <asp:TextBox ID="txFiltro" runat="server"></asp:TextBox>
    <asp:Button ID="btBuscar" runat="server" Text="Buscar" OnClick="btBuscar_Click" />

    <asp:GridView ID="gvVehiculos" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="gvVehiculos_RowCommand">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
            <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
            <asp:BoundField DataField="PrecioVenta" HeaderText="PrecioVenta" />
            <asp:BoundField DataField="StockDisponible" HeaderText="StockDisponible" />
            <asp:ButtonField ButtonType="Button" CommandName="eliminar" Text="Eliminar" />
            <asp:ButtonField ButtonType="Button" CommandName="editar" Text="Editar" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>

    <asp:Button ID="btNuevo" runat="server" Text="Nuevo" OnClick="btNuevo_Click" />
    <asp:Label ID="lbMensaje" runat="server"></asp:Label>

</asp:Content>
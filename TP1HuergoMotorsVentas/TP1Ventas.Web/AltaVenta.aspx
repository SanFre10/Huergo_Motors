<%@ Page Title="" Language="C#" MasterPageFile="~/MDI.Master" AutoEventWireup="true" CodeBehind="AltaVenta.aspx.cs" Inherits="TP1Ventas.Web.AltaVenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="lblId" runat="server" Text="Id"></asp:Label>
    <asp:TextBox ID="txId" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblFecha" runat="server" Text="Fecha"></asp:Label>
    <asp:TextBox ID="txFecha" type="date" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblVendedor" runat="server" Text="Vendedor"></asp:Label>
    <asp:DropDownList ID="ddVendedores" runat="server" OnSelectedIndexChanged="ddVendedores_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
    <br />
    <asp:Label ID="lblSucursal" runat="server" Text="Sucursal"></asp:Label>
    <asp:TextBox ID="txSucursal" runat="server"></asp:TextBox>
    <br />
    <br />

    <asp:Label ID="Label1" runat="server" Text="Vehiculos"></asp:Label>
    <br />
    <asp:Label ID="lblModelo" runat="server" Text="Modelo"></asp:Label>
    <asp:DropDownList ID="ddModelo" runat="server" OnSelectedIndexChanged="ddModelo_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Tipo"></asp:Label>
    <asp:Label ID="lblTipo" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Precio"></asp:Label>
    <asp:Label ID="lblPrecio" runat="server" Text=""></asp:Label>
    <br />

    <asp:Label ID="Label4" runat="server" Text="Accesorios Disponibles"></asp:Label>
    <asp:CheckBoxList ID="cbAccesorios" runat="server" OnSelectedIndexChanged="cbAccesorios_SelectedIndexChanged" AutoPostBack="True">
        <asp:ListItem>Hola</asp:ListItem>
        <asp:ListItem>Chau</asp:ListItem>
        <asp:ListItem></asp:ListItem>
        <asp:ListItem></asp:ListItem>
    </asp:CheckBoxList>

    <br />
    <br />

    <asp:Label ID="Label10" runat="server" Text="Clientes"></asp:Label>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Filtro"></asp:Label>
    <asp:TextBox ID="txFiltro" runat="server"></asp:TextBox>
    <asp:Button ID="btnFiltro" runat="server" Text="Ok" OnClick="btnFiltro_Click" />
    <br />
    <asp:Label ID="Label6" runat="server" Text="Nombre"></asp:Label>
    <asp:DropDownList ID="ddClientes" runat="server" OnSelectedIndexChanged="ddClientes_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Telefono"></asp:Label>
    <asp:Label ID="lblTelefono" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label9" runat="server" Text="Email"></asp:Label>
    <asp:Label ID="txEmail" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label8" runat="server" Text="Observaciones"></asp:Label>
    <asp:TextBox ID="txObservaciones" type="textarea" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label11" runat="server" Text="Total"></asp:Label>
    <asp:TextBox ID="txTotal" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar venta" AutoPostBack="False" OnClick="btnConfirmar_Click1"/>
    <br />
    <br />
    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
</asp:Content>

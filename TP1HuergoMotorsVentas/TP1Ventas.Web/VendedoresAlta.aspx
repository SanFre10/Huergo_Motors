<%@ Page Title="" Language="C#" MasterPageFile="~/MDI.Master" AutoEventWireup="true" CodeBehind="VendedoresAlta.aspx.cs" Inherits="TP1Ventas.Web.VendedoresAlta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
    <asp:TextBox ID="txId" runat="server" ReadOnly="True"></asp:TextBox>
    <br />

    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txNombre" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Label3" runat="server" Text="Apellido"></asp:Label>
    <asp:TextBox ID="txApellido" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Label4" runat="server" Text="Sucursal"></asp:Label>
    <asp:TextBox ID="txSucursal" runat="server"></asp:TextBox>
    <br />
    
    <asp:Label ID="Label5" runat="server" Text="Usuario"></asp:Label>
    <asp:TextBox ID="txUsuario" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Label6" runat="server" Text="Contraseña"></asp:Label>
    <asp:TextBox ID="txContraseña" runat="server"></asp:TextBox>
    <br />

    <asp:Button ID="btVolver" runat="server" Text="Volver" OnClick="btVolver_Click" />

    <asp:Button ID="btGuardar" runat="server" Text="Guardar" OnClick="btGuardar_Click" />
    <br />

    <asp:Label ID="lbMensaje" runat="server"></asp:Label>

</asp:Content>
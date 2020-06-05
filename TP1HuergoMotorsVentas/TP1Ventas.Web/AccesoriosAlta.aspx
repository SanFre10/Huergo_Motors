<%@ Page Title="" Language="C#" MasterPageFile="~/MDI.Master" AutoEventWireup="true" CodeBehind="AccesoriosAlta.aspx.cs" Inherits="TP1Ventas.Web.AccesoriosAlta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
    <asp:TextBox ID="txId" runat="server" ReadOnly="True"></asp:TextBox>
    <br />

    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txNombre" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Label3" runat="server" Text="Modelo"></asp:Label>
    <asp:TextBox ID="txModelo" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Label4" runat="server" Text="Precio Venta"></asp:Label>
    <asp:TextBox ID="txPrecioVenta" runat="server"></asp:TextBox>
    <br />

    <asp:Button ID="btVolver" runat="server" Text="Volver" OnClick="btVolver_Click" />

    <asp:Button ID="btGuardar" runat="server" Text="Guardar" OnClick="btGuardar_Click" />
    <br />

    <asp:Label ID="lbMensaje" runat="server"></asp:Label>

</asp:Content>
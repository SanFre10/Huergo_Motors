﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Mis_datos.aspx.cs" Inherits="HuergoMotorsEcommerce.Mis_datos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="form-group">
        <asp:Label runat="server" Text="Nombre" for="form-group"></asp:Label>
        <asp:TextBox runat="server" ID="txNombre" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label runat="server" Text="Email" for="form-group"></asp:Label>
        <asp:TextBox runat="server" ID="txEmail" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label runat="server" Text="Direccion" for="form-group"></asp:Label>
        <asp:TextBox runat="server" ID="txDireccion" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label runat="server" Text="Telefono" for="form-group"></asp:Label>
        <asp:TextBox runat="server" ID="txTelefono" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label runat="server" Text="Usuario" for="form-group"></asp:Label>
        <asp:TextBox runat="server" ID="txUsuario" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label runat="server" Text="Contraseña" for="form-group"></asp:Label>
        <asp:TextBox runat="server" ID="txContraseña" CssClass="form-control"></asp:TextBox>
    </div>

    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar cambios" CssClass="btn btn-danger" OnClick="btnAceptar_Click" />

</asp:Content>
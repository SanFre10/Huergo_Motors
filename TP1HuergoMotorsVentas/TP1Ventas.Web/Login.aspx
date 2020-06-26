<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TP1Ventas.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>TP2 - Login</title>
    <link href="Style/Style.css" rel="stylesheet" />
</head>

<body id="index-body">
    <div class="login-container">
        <h2 class="h2">Login</h2>
        <div class="form-container">
            <form id="form1" runat="server">
                <p id="user-label" class="p">Username</p>
                <asp:TextBox ID="txNombreUsuario" runat="server" CssClass="login-input"></asp:TextBox>
                <p id="pass-label" class="p">Password</p>
                <asp:TextBox ID="txContraseña" runat="server" CssClass="login-input"></asp:TextBox>
                <asp:Label ID="lbMsg" class="error" runat="server"></asp:Label>
                <br>
            </div>
                <asp:Button ID="btIniciarSesion" runat="server" OnClick="btIniciarSesion_Click" Text="Iniciar Sesión" CssClass="button1" />
        </form>
    </div>
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TP1Ventas.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>TP2 - Login</title>
</head>
<body>
    <form id="form1" runat="server">

        <br />
        <br />
        <h4>Iniciar Sesión</h4>

        <asp:Label ID="Label1" runat="server" Text="Nombre de Usuario"></asp:Label>
        <asp:TextBox ID="txNombreUsuario" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
        <asp:TextBox ID="txContraseña" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btIniciarSesion" runat="server" OnClick="btIniciarSesion_Click" Text="Iniciar Sesión" />
        <br />
        <asp:Label ID="lbMsg" runat="server"></asp:Label>

    </form>
</body>
</html>

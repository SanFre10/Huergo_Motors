<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HuergoMotorsEcommerce.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label3" runat="server" Text="Iniciar Sesion"></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="txUser" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="txPass" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="btnAceptar" runat="server" Text="Iniciar Sesion" OnClick="btnAceptar_Click" />
            <br />
            <asp:Button ID="btnRegistrar" runat="server" OnClick="btnRegistrar_Click" Text="Registrarse" />
            <br />
            <asp:Button ID="btnOlvide" runat="server" Text="Olvide mi contraseña" />
        </div>
        <asp:Label ID="lblMsg" runat="server" Text="mensaje"></asp:Label>
    </form>
</body>
</html>

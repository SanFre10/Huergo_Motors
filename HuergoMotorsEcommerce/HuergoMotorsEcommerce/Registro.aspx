<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="HuergoMotorsEcommerce.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txNombre" runat="server"></asp:TextBox>

            <asp:Label ID="Label2" runat="server" Text="Direccion"></asp:Label>
            <asp:TextBox ID="txDireccion" runat="server"></asp:TextBox>

            <asp:Label ID="Label3" runat="server" Text="Telefono"></asp:Label>
            <asp:TextBox ID="txTelefono" runat="server"></asp:TextBox>

            <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txEmail" runat="server"></asp:TextBox>


            <asp:Label ID="Label5" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="txUsuario" runat="server"></asp:TextBox>

            <asp:Label ID="Label6" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="txContraseña" runat="server" TextMode="Password"></asp:TextBox>

            <asp:Label ID="Label7" runat="server" Text="Confirmar contraseña"></asp:Label>
            <asp:TextBox ID="txConfirmar" runat="server" TextMode="Password"></asp:TextBox>


            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />

            <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
            <asp:Label ID="lblMsg" runat="server" Text="mensaje"></asp:Label>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="HuergoMotorsEcommerce.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:Label ID="lblUser" runat="server" Text="Sesion iniciada como: "></asp:Label>
                <asp:Button ID="btnVehiculos" runat="server" Text="Vehiculos" OnClick="btnVehiculos_Click" />
                <asp:Button ID="btnCarrito" runat="server" Text="Carrito" />
                <asp:Button ID="btnHistorial" runat="server" Text="Historial e compras" OnClick="btnHistorial_Click" />
                <asp:Button ID="btnDatos" runat="server" Text="Mis datos" />
                <asp:Button ID="btnCerrar" runat="server" Text="Cerrar Sesion" OnClick="btnCerrar_Click" />
            </div>
        </form>

    </body>
</html>

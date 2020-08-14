<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vehiculos.aspx.cs" Inherits="HuergoMotorsEcommerce.Vehiculos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Vehiculos disponibles"></asp:Label>
            <asp:Button ID="btnMenu" runat="server" Text="Menu" OnClick="btnMenu_Click" />

            <asp:Label ID="Label2" runat="server" Text="Filtrar Por: "></asp:Label>
            <asp:DropDownList ID="ddlBusqueda" runat="server"></asp:DropDownList>
            <asp:TextBox ID="txFiltro" runat="server"></asp:TextBox>
            <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />





            <asp:PlaceHolder ID="divVehiculos" runat="server"/>
        </div>
    </form>
</body>
</html>

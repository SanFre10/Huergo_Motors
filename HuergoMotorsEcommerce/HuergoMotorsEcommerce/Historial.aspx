<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Historial.aspx.cs" Inherits="HuergoMotorsEcommerce.Historial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Historial de compras"></asp:Label>
            <asp:Button ID="btnMenu" runat="server" Text="Menu" />

            <asp:PlaceHolder ID="Compras" runat="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>

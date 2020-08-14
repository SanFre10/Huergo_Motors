<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalles.aspx.cs" Inherits="HuergoMotorsEcommerce.Detalles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
            <asp:Label ID="lblModelo" runat="server" Text="Label"></asp:Label>

            <asp:Label ID="Label4" runat="server" Text="Fotos"></asp:Label>
            <div class="fotos">

            </div>

            <asp:Label ID="lblstock" runat="server" Text="Label"></asp:Label>


            <asp:Label ID="Label2" runat="server" Text="Accesorios disponibles"></asp:Label>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server"></asp:CheckBoxList>

            <asp:Label ID="Label3" runat="server" Text="Agregar al carrito"></asp:Label>
            <asp:Button ID="btnAgregar" runat="server" Text="+" />


        </div>
        
    </form>
</body>
</html>

<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Historial.aspx.cs" Inherits="HuergoMotorsEcommerce.Historial1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div>
        <asp:Label ID="Label1" runat="server" Text="Historial de compras"></asp:Label>
        <asp:Button ID="btnMenu" runat="server" Text="Menu" />

        <asp:PlaceHolder ID="Compras" runat="server"></asp:PlaceHolder>
    </div>


</asp:Content>

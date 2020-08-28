<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Detalles.aspx.cs" Inherits="HuergoMotorsEcommerce.Detalles1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mx-auto w-75 mt-5" >
        <div class="row p-5 rounded-top"  style="background-color:#cb8589;">
            <asp:Image ID="Imagen" runat="server" class="col-lg-7 col-12 rounded" src="car-icon.png"/>
            <div class="col-lg-5 col-12">
                 <div style="background-color:#ca8080;">
                    <asp:Label ID="lblModelo" runat="server" Text="Label" CssClass="d-block text-center font-weight-bold h1"></asp:Label>
                    <asp:Label ID="lblPrecio" runat="server" CssClass="d-block h2 text-center pt-3"></asp:Label>
                    <asp:Label ID="lblstock" runat="server" Text="Label" CssClass="d-block h3 text-center"></asp:Label>
                </div>
                <asp:Label ID="Label2" runat="server" Text="Accesorios disponibles" CssClass="d-block text-center pt-3 h4"></asp:Label>
                <div class="pt-2 pb-5">
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server" CssClass="mx-auto h5"></asp:CheckBoxList>
                </div>
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar al carrito" CssClass="btn btn-danger mx-auto d-block w-50" />

            </div>

        </div>
        <div class="row p-5 rounded-bottom" style="background-color:#ca8080;">
            <div class="col-lg-7 col-12">
                <p>"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."</p>
            </div>
        </div>
    </div>
</asp:Content>

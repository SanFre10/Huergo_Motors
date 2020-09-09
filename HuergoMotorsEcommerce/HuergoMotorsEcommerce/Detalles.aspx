<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Detalles.aspx.cs" Inherits="HuergoMotorsEcommerce.Detalles1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mx-auto w-75 mt-5" >
        <div class="row p-5 rounded-top"  style="background-color:lightgray;">
            <div id="carouselExampleIndicators" class="carousel slide col-lg-7 col-12 rounded" data-ride="carousel">
                <div class="carousel-inner" id="fotos">
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                </div>
                <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
                </a>
                <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
                </a>
            </div>
            <div class="col-lg-5 col-12">
                 <div style="background-color:lightgray;">
                    <asp:Label ID="lblModelo" runat="server" Text="Label" CssClass="d-block text-center font-weight-bold h1"></asp:Label>
                    <asp:Label ID="lblPrecio" runat="server" CssClass="d-block h2 text-center pt-3"></asp:Label>
                    <asp:Label ID="lblstock" runat="server" Text="Label" CssClass="d-block h3 text-center"></asp:Label>
                </div>
                <asp:Label ID="lblAccesorios" runat="server" Text="" CssClass="d-block text-center pt-3 h4"></asp:Label>
                <div class="pt-2 pb-5">
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server" CssClass="mx-auto h5"></asp:CheckBoxList>
                </div>
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar al carrito" CssClass="btn btn-danger mx-auto d-block w-50" />

            </div>

        </div>
        <div class="row p-5 rounded-bottom" style="background-color:lightgray;">
            <div class="col-lg-7 col-12">
                <asp:Label ID="lblDescripcion" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>

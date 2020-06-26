<%@ Page Title="" Language="C#" MasterPageFile="~/MDI.Master" AutoEventWireup="true" CodeBehind="AltaVenta.aspx.cs" Inherits="TP1Ventas.Web.AltaVenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" class="body" runat="server">
    <div id="body">
        <div id="container">
            <div class="grid-item">
                <ul class="ul">
                    <li class="li">
                        <asp:Label ID="lblId" runat="server" Text="Id:"></asp:Label>
                        <asp:TextBox ID="txId" runat="server" CssClass="textbox1 readonly"></asp:TextBox>
                    </li>
                    <li class="li">
                        <asp:Label ID="lblFecha" runat="server" Text="Fecha:"></asp:Label>
                        <asp:TextBox ID="txFecha" type="date" runat="server" CssClass="textbox1"></asp:TextBox>
                    </li>
                    <li class="li">
                        <asp:Label ID="lblVendedor" runat="server" Text="Vendedor:"></asp:Label>
                        <asp:DropDownList ID="ddVendedores" runat="server"
                            OnSelectedIndexChanged="ddVendedores_SelectedIndexChanged" AutoPostBack="True"
                            CssClass="dropdown textbox1"></asp:DropDownList>
                    </li>
                    <li class="li">
                        <asp:Label ID="lblSucursal" runat="server" Text="Sucursal:"></asp:Label>
                        <asp:TextBox ID="txSucursal" runat="server" CssClass="textbox1" ReadOnly="True"></asp:TextBox>
                    </li>
                </ul>
            </div>
            <div class="grid-item">
                <h3 class="h3">Vehiculos</h3>
                <hr class="hr">
                <ul class="ul">
                    <li class="li2">
                        <asp:Label ID="lblModelo" runat="server" Text="Modelo"></asp:Label>
                        <asp:DropDownList ID="ddModelo" runat="server"
                            OnSelectedIndexChanged="ddModelo_SelectedIndexChanged" AutoPostBack="True"
                            CssClass="textbox1"></asp:DropDownList>
                    </li>
                    <li class="li2">
                        <asp:Label ID="Label2" runat="server" Text="Tipo:"></asp:Label>
                        <asp:Label ID="lblTipo" runat="server" Text=""></asp:Label>
                    </li>
                    <li class="li2">
                        <asp:Label ID="Label3" runat="server" Text="Precio:"></asp:Label>
                        <asp:Label ID="lblPrecio" runat="server" Text=""></asp:Label>
                    </li>

                    <!-- <div style="display:grid;"> -->
                    <li class="li2">
                        <asp:Label ID="Label4" runat="server" Text="Accesorios Disponibles"></asp:Label>
                        <asp:CheckBoxList ID="cbAccesorios" runat="server"
                            OnSelectedIndexChanged="cbAccesorios_SelectedIndexChanged" AutoPostBack="True"
                            CssClass="ul3"></asp:CheckBoxList>
                    </li>
                    <!-- </div> -->
                </ul>
            </div>
            <div class="grid-item">
                <h3 class="h3">Clientes</h3>
                <hr class="hr">

                <ul class="ul4">
                    <li class="li4">
                        <asp:Label ID="Label5" runat="server" Text="Filtro:"></asp:Label>
                        <asp:TextBox ID="txFiltro" runat="server" CssClass="textbox1 autosize"></asp:TextBox>
                        <asp:Button ID="btnFiltro" runat="server" Text="Ok" OnClick="btnFiltro_Click"
                            CssClass="button2" />
                    </li>
                    <li class="li4">
                        <asp:Label ID="Label6" runat="server" Text="Nombre:"></asp:Label>
                        <asp:DropDownList ID="ddClientes" runat="server"
                            OnSelectedIndexChanged="ddClientes_SelectedIndexChanged" AutoPostBack="True"
                            CssClass="textbox1"></asp:DropDownList>
                        <br />
                    </li>
                    <li class="li4">
                        <asp:Label ID="Label7" runat="server" Text="Telefono:"></asp:Label>
                        <asp:Label ID="lblTelefono" runat="server" Text=""></asp:Label>
                        <br />
                    </li>
                    <li class="li4">
                        <asp:Label ID="Label9" runat="server" Text="Email:"></asp:Label>
                        <asp:Label ID="txEmail" runat="server" Text=""></asp:Label>
                    </li>
                </ul>
            </div>
            <div class="grid-item">
                <ul class="ul5">
                    <li class="li1">
                        <asp:Label ID="Label8" runat="server" Text="Observaciones:"></asp:Label>
                        <asp:TextBox ID="txObservaciones" type="textarea" runat="server" CssClass="textbox1 multiline">
                        </asp:TextBox>

                    </li>
                    <li class="li1">
                        <ul class="ul">
                            <li class="li2">
                                <asp:Label ID="Label11" runat="server" Text="Total"></asp:Label>
                                <br />
                                <asp:TextBox ID="txTotal" runat="server" CssClass="textbox1 readonly" ReadOnly="True">
                                </asp:TextBox>
                            </li>
                            <li class="li2">
                                <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar venta" AutoPostBack="False"
                                    OnClick="btnConfirmar_Click1" CssClass="button" />
                            </li>
                        </ul>
                        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</asp:Content>
<%@ Page Title="" Language="C#" MasterPageFile="~/MDI.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="TP1Ventas.Web.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="body">
        <div id="container1">
            <asp:Label ID="Label2" runat="server" Text="Filtro"></asp:Label>    
            <asp:TextBox ID="txFiltro" runat="server" CssClass="textbox"></asp:TextBox>
            <asp:Button ID="btBuscar" runat="server" Text="Buscar" OnClick="btBuscar_Click" CssClass="button" />
            <br />
            <br />
            <asp:GridView ID="gvClientes" runat="server" AutoGenerateColumns="False" CellPadding="10" ForeColor="Black" GridLines="Vertical" OnRowCommand="gvClientes_RowCommand" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellSpacing="1" HorizontalAlign="Center">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" />
                    <asp:BoundField DataField="Nombre" HeaderText=" Nombre" />
                    <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                    <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:ButtonField ButtonType="Button" CommandName="eliminar" Text="Eliminar" >
                        <ControlStyle CssClass="button1" />
                    </asp:ButtonField>
                    <asp:ButtonField ButtonType="Button" CommandName="editar" Text="Editar" >
                        <ControlStyle CssClass="button1" />
                    </asp:ButtonField>
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="btNuevo" runat="server" Text="Nuevo" OnClick="btNuevo_Click" CssClass="button"/>
            <br />
            <asp:Label ID="lbMensaje" runat="server"></asp:Label>
        </div>
    </div>

</asp:Content>
<%@ Page Title="" Language="C#" MasterPageFile="~/MDI.Master" AutoEventWireup="true" CodeBehind="ConsultaVentas.aspx.cs" Inherits="TP1Ventas.Web.ConsultaVentas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="body">
        <asp:RadioButtonList ID="RadioButtonList1" class="rdul" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Cssclass="radioitem">Vendedor</asp:ListItem>
            <asp:ListItem Cssclass="radioitem">Vehiculo</asp:ListItem>
            <asp:ListItem Cssclass="radioitem">Cliente</asp:ListItem>
        </asp:RadioButtonList>
        <div class="filtros">
            <asp:TextBox ID="txFiltro" runat="server" class="textbox" aria-placeholder="Criterio de busqueda"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="Desde"></asp:Label>
            <asp:TextBox ID="dtpInicio" runat="server" type="date" CssClass="date"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Hasta"></asp:Label>
            <asp:TextBox ID="dtpFin" runat="server" type="date" CssClass="date"></asp:TextBox>
            <asp:Button ID="btBuscar" runat="server" Text="Buscar" OnClick="btBuscar_Click1" Cssclass="button" />
            <asp:Button ID="btncsv" runat="server" Text="Exportar a CSV" AutoPostBack="False" OnClick="btncsv_Click1"
            Cssclass="button" />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>
        <asp:GridView ID="dtgVentas" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid"
            BorderWidth="1px" CellPadding="10" CellSpacing="1" ForeColor="Black" GridLines="Vertical"
            HorizontalAlign="Center" CssClass="Tabla">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>

    </div>
</asp:Content>
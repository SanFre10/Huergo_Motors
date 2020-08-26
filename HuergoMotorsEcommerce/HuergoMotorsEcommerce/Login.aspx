<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HuergoMotorsEcommerce.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="justify-content-center">
            <div class="w-50 mx-auto text-center border border-primary rounded-sm ">
                <asp:Label ID="Label3" runat="server" Text="Iniciar Sesion" CssClass="mx-auto text-center"></asp:Label>
                <br />
                <div class="form-group m-5">
                    <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
                    <asp:TextBox ID="txUser" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>
                <div class="form-group m-5">
                    <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
                    <asp:TextBox ID="txPass" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                </div>
            
                <asp:Button ID="btnAceptar" CssClass="btn btn-primary btn-lg mx-auto" runat="server" Text="Iniciar Sesion" OnClick="btnAceptar_Click"/>
                <br />
                <asp:Button ID="btnRegistrar" runat="server" OnClick="btnRegistrar_Click" Text="Registrarse" CssClass="btn btn-outline-secondary m-5"/>
                <br />
                <asp:LinkButton ID="btnOlvid" runat="server">Olvide mi contraseña</asp:LinkButton>
                <br />
                <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
            </div>
        </div>

    </form>

    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js" integrity="sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV" crossorigin="anonymous"></script>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="HuergoMotorsEcommerce.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">

</head>
<body style="background: url(car-dealer1.jpg) no-repeat fixed center;background-size:cover;">
    <div class="d-flex align-items-center min-vh-100">
        <div class="container ">
            <form id="form2" runat="server" class="mx-auto text-center rounded w-50" style="background-color:#A2192D;color:white;">
                <div>
                    <img src="Logo.png" class="d-block mx-auto p-3 rounded" width="200" height="150"/>
                    <asp:Label ID="Label1" runat="server" Text="Registrarse" CssClass="mx-auto text-center h4 font-weight-bold p-2"></asp:Label>

                    <div class="mx-5 my-3">
                        <asp:TextBox ID="txNombre" runat="server" placeholder="Nombre" CssClass="form-control"></asp:TextBox>

                        <asp:TextBox ID="txDireccion" runat="server" placeholder="Direccion" CssClass="form-control"></asp:TextBox>

                        <asp:TextBox ID="txTelefono" runat="server" placeholder="Telefono" CssClass="form-control"></asp:TextBox>

                        <asp:TextBox ID="txEmail" runat="server" placeholder="Email" CssClass="form-control"></asp:TextBox>

                        <asp:TextBox ID="txUsuario" runat="server" placeholder="Usuario" CssClass="form-control"></asp:TextBox>

                        <asp:TextBox ID="txContraseña" runat="server" TextMode="Password" placeholder="Contraseña" CssClass="form-control"></asp:TextBox>

                        <asp:TextBox ID="txConfirmar" runat="server" TextMode="Password" placeholder="Confirmar contraseña" CssClass="form-control"></asp:TextBox>
                    </div>
                    


                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" CssClass="btn btn-light btn-lg mx-auto d-block w-50"/>

                    <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" CssClass="btn btn-outline-light mx-auto d-block m-3 w-50"/>
                    <asp:Label ID="lblMsg" runat="server" Text="" CssClass="h3"></asp:Label>
                </div>
            </form>
        </div>
    </div>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js" integrity="sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV" crossorigin="anonymous"></script>
</body>
</html>

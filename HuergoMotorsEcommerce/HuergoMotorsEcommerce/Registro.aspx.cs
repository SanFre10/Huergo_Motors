using HuergoMotorsEcommerce.WebService;
using System;

namespace HuergoMotorsEcommerce
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txContraseña.Text == txConfirmar.Text)
                {
                    if (txNombre.Text != "" && txTelefono.Text != "" && txDireccion.Text != "" && txEmail.Text != "" && txUsuario.Text != "" && txContraseña.Text != "")
                    {
                        WebService.WebService ws = new WebService.WebService();

                        ClientesDTO dto = new ClientesDTO();

                        dto.Nombre = txNombre.Text;
                        dto.Telefono = txTelefono.Text;
                        dto.Direccion = txDireccion.Text;
                        dto.Email = txEmail.Text;
                        dto.Usuario = txUsuario.Text;
                        dto.Contraseña = txContraseña.Text;

                        ws.RegistrarUsuario(dto);

                        lblMsg.Text = "Usuario registrado con exito";
                        Response.Redirect("login.aspx");

                    }
                    else
                    {
                        lblMsg.Text = "Faltan datos por completar";
                    }
                }
                else
                {
                    lblMsg.Text = "Las contraseñas no son iguales";
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP1VentasDTOs;
using TP1VentasNegocio;

namespace TP1Ventas.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btIniciarSesion_Click(object sender, EventArgs e)
        {

            VendedoresNegocio negocio = new VendedoresNegocio();

            VendedoresDTO usuario = negocio.IniciarSesion(txNombreUsuario.Text, txContraseña.Text);

            if (usuario != null)
            {
                lbMsg.Text = "Sesión iniciada correctamente.";


                Session.Add("usuario", usuario);
                Response.Redirect("Home.aspx");
            }
            else
            {
                lbMsg.Text = "Usuario o contraseña incorrecta.";
            }


            

        }
    }
}
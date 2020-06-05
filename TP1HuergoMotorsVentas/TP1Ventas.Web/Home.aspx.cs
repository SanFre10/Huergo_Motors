using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP1VentasDTOs;

namespace TP1Ventas.Web
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VendedoresDTO vendedor = (VendedoresDTO)Session["usuario"];
            lbMensaje.Text = "Bienvenido: " + vendedor.Nombre + " " +  vendedor.Apellido;
        }
    }
}
using HuergoMotorsEcommerce.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HuergoMotorsEcommerce
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClientesDTO dto = (ClientesDTO)Session["usuario"];
            if (dto != null)
            {
                lblUser.Text = "Sesión iniciada como: " + dto.Nombre;
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            Session["usuario"] = null;
            Response.Redirect("Login.aspx");
        }

        protected void btnVehiculos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Vehiculos.aspx");
        }

        protected void btnHistorial_Click(object sender, EventArgs e)
        {
            Response.Redirect("Historial.aspx");
        }
    }
}
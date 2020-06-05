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
    public partial class Vehiculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        protected void gvVehiculos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                int id = Convert.ToInt32(gvVehiculos.Rows[indice].Cells[0].Text);

                if (e.CommandName == "eliminar")
                {
                    VehiculosNegocio negocio = new VehiculosNegocio();
                    VehiculosNegocio.EliminarVehiculos(id);
                    RecargarGrilla();
                    lbMensaje.Text = "Eliminado correctamente.";
                }
                else if (e.CommandName == "editar")
                {
                    Response.Redirect("VehiculosAlta.aspx?id=" + id.ToString());
                }
            }
            catch (Exception ex)
            {
                lbMensaje.Text = "Error: " + ex.Message;
            }
        }

        protected void btBuscar_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            VehiculosNegocio negocio = new VehiculosNegocio();
            List<VehiculosDTO> vehiculos = VehiculosNegocio.MostrarVehiculos(txFiltro.Text);

            gvVehiculos.DataSource = vehiculos;
            gvVehiculos.DataBind();
        }

        protected void btNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("VehiculosAlta.aspx");
        }
    }
}
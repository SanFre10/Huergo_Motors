using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP1VentasNegocio;
using TP1VentasDTOs;
namespace TP1Ventas.Web
{
    public partial class Vendedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }
        protected void gvVendedores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                int id = Convert.ToInt32(gvVendedores.Rows[indice].Cells[0].Text);

                if (e.CommandName == "eliminar")
                {
                    VendedoresNegocio negocio = new VendedoresNegocio();
                    VendedoresNegocio.EliminarVendedores(id);
                    RecargarGrilla();
                    lbMensaje.Text = "Eliminado correctamente.";
                }
                else if (e.CommandName == "editar")
                {
                    Response.Redirect("VendedoresAlta.aspx?id=" + id.ToString());
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
            List<VendedoresDTO> vendedores = VendedoresNegocio.MostrarVendedores(txFiltro.Text);

            gvVendedores.DataSource = vendedores;
            gvVendedores.DataBind();
        }

        protected void btNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("VendedoresAlta.aspx");
        }
    }
}
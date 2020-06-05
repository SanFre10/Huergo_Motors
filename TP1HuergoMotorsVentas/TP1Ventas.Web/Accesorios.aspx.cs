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
    public partial class Accesorios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        protected void btBuscar_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            
            List<AccesoriosDTO> accesorios = AccesoriosNegocio.MostrarAccesorios(txFiltro.Text);

            gvAccesorios.DataSource = accesorios;
            gvAccesorios.DataBind();
        }

        protected void btNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccesoriosAlta.aspx");
        }

        protected void gvAccesorios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                int id = Convert.ToInt32(gvAccesorios.Rows[indice].Cells[0].Text);

                if (e.CommandName == "eliminar")
                {
                    AccesoriosNegocio negocio = new AccesoriosNegocio();
                    AccesoriosNegocio.EliminarAccesorios(id);
                    RecargarGrilla();
                    lbMensaje.Text = "Eliminado correctamente.";
                }
                else if (e.CommandName == "editar")
                {
                    Response.Redirect("AccesoriosAlta.aspx?id=" + id.ToString());
                }
            }
            catch (Exception ex)
            {
                lbMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}
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
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }
        protected void gvClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                int id = Convert.ToInt32(gvClientes.Rows[indice].Cells[0].Text);

                if (e.CommandName == "eliminar")
                {
                    ClientesNegocio negocio = new ClientesNegocio();
                    ClientesNegocio.EliminarClientes(id);
                    RecargarGrilla();
                    lbMensaje.Text = "Eliminado correctamente.";
                }
                else if (e.CommandName == "editar")
                {
                    Response.Redirect("ClientesAlta.aspx?id=" + id.ToString());
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
            ClientesNegocio negocio = new ClientesNegocio();
            List<ClientesDTO> clientes = ClientesNegocio.MostrarClientes(txFiltro.Text);

            gvClientes.DataSource = clientes;
            gvClientes.DataBind();
        }

        protected void btNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("ClientesAlta.aspx");
        }
    }
}
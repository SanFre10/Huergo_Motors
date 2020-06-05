using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP1VentasDTOs;
using TP1VentasNegocio;

namespace TP1Ventas.Web
{
    public partial class ConsultaVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTablaEntera();
            }
            
        }

        private void CargarTablaEntera()
        {
            List<VentasDTO> dtoVentas = TP1VentasNegocio.VentasNegocio.MostrarVentas();

            dtgVentas.DataSource = dtoVentas;
            dtgVentas.DataBind();
        }

        protected void btBuscar_Click1(object sender, EventArgs e)
        {
            try
            {

                List<VentasDTO> dtoVentas = VentasNegocio.ObtenerConFiltro(txFiltro.Text, RadioButtonList1.SelectedItem.Text, dtpInicio.Text, dtpFin.Text);
                if (dtoVentas.Count > 0)
                {
                    dtgVentas.DataSource = dtoVentas;
                    dtgVentas.DataBind();
                }
                else
                {
                    CargarTablaEntera();
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        protected void btncsv_Click1(object sender, EventArgs e)
        {

        }

    }
}
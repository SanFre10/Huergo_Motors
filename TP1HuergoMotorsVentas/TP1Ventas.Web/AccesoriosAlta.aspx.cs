using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP1VentasDTOs;
using TP1VentasNegocio;

namespace TP1Ventas.Web
{
    public partial class AccesoriosAlta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    if (Request.QueryString["id"] != null)
                    {
                        int id = Convert.ToInt32(Request.QueryString["id"]);
                        AccesoriosNegocio negocio = new AccesoriosNegocio();

                        AccesoriosDTO dto = AccesoriosNegocio.MostrarAccesoriosPorId(id);

                        if (dto != null)
                        {
                            txId.Text = dto.Id.ToString();
                            txNombre.Text = dto.Nombre;
                            txModelo.Text = dto.Modelo.ToString();
                            txPrecioVenta.Text = dto.PrecioVenta.ToString();

                        }
                        else
                        {
                            lbMensaje.Text = "Error: El accesorio no existe.";
                        }
                    }
                    else
                    {
                        LimpiarCampos();
                        txId.Text = AccesoriosNegocio.ProximoIdAccesorios().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                lbMensaje.Text = "Error: " + ex.Message;
            }
        }

        protected void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                AccesoriosDTO dto = new AccesoriosDTO();
                if (Request.QueryString["id"] != null)
                {
                    
                    dto.Id = Convert.ToInt32(Request.QueryString["id"]);
                    dto.Nombre = txNombre.Text;
                    dto.Modelo = txModelo.Text;
                    dto.PrecioVenta = Convert.ToDecimal(txPrecioVenta.Text);

                    AccesoriosNegocio.ModificarAccesoriosPorDTO(dto);

                    lbMensaje.Text = "Accesorio actualizado correctamente.";
                    Response.Redirect("Accesorios.aspx");
                }
                else
                {
                    dto.Id = 0;
                    dto.Nombre = txNombre.Text;
                    dto.Modelo = txModelo.Text;
                    dto.PrecioVenta = Convert.ToDecimal(txPrecioVenta.Text);

                    AccesoriosNegocio.AgregarAccesoriosPorDTO(dto);

                    lbMensaje.Text = "Accesorio creado correctamente.";
                    Response.Redirect("Accesorios.aspx");
                }

                LimpiarCampos();

            }
            catch (Exception ex)
            {
                lbMensaje.Text = "Error: " + ex.Message;
            }
        }

        private void LimpiarCampos()
        {
            txId.Text = string.Empty;
            txNombre.Text = string.Empty;
            txModelo.Text = string.Empty;
            txPrecioVenta.Text = string.Empty;
        }

        protected void btVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Accesorios.aspx");
        }
    }
}
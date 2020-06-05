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
    public partial class VehiculosAlta : System.Web.UI.Page
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
                        VehiculosNegocio negocio = new VehiculosNegocio();

                        List <VehiculosDTO> dto = VehiculosNegocio.MostrarVehiculosPorId(id);

                        if (dto != null)
                        {
                            txId.Text = dto[0].Id.ToString();
                            txModelo.Text = dto[0].Modelo;
                            txPrecioVenta.Text = dto[0].PrecioVenta.ToString();
                            txStockDisponible.Text = dto[0].StockDisponible.ToString();
                            txTipo.Text = dto[0].Tipo;

                        }
                        else
                        {
                            lbMensaje.Text = "Error: El vehículo no existe.";
                        }
                    }
                    else
                    {
                        LimpiarCampos();
                        txId.Text = VehiculosNegocio.ProximoIdVehiculos().ToString();
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
                VehiculosDTO dto = new VehiculosDTO();

                if (Request.QueryString["id"] != null)
                {
                    dto.Id = Convert.ToInt32(Request.QueryString["id"]);
                    dto.Tipo = txTipo.Text;
                    dto.Modelo = txModelo.Text;
                    dto.PrecioVenta = Convert.ToDecimal(txPrecioVenta.Text);
                    dto.StockDisponible = Convert.ToInt32(txStockDisponible.Text);
                    

                    VehiculosNegocio.ModificarVehiculosPorDTO(dto);

                    lbMensaje.Text = "Vehículo actualizado correctamente.";
                    Response.Redirect("Vehiculos.aspx");
                }
                else
                {
                    dto.Id = 0;
                    dto.Tipo = txTipo.Text;
                    dto.Modelo = txModelo.Text;
                    dto.PrecioVenta = Convert.ToDecimal(txPrecioVenta.Text); 
                    dto.StockDisponible = Convert.ToInt32(txStockDisponible.Text);

                    VehiculosNegocio.AgregarVehiculosPorDTO(dto);

                    lbMensaje.Text = "Vehículo creado correctamente.";
                    Response.Redirect("Vehiculos.aspx");
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
            txId.Text = "";
            txModelo.Text = "";
            txPrecioVenta.Text = "";
            txStockDisponible.Text = "";
            txTipo.Text = "";
        }

        protected void btVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Vehiculos.aspx");
        }
    }
}
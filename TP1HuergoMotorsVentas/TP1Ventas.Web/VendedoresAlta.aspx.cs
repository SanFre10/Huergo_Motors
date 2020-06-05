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
    public partial class VendedoresAlta : System.Web.UI.Page
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
                        VendedoresNegocio negocio = new VendedoresNegocio();

                        List<VendedoresDTO> dto = VendedoresNegocio.MostrarVendedoresPorId(id);

                        if (dto != null)
                        {
                            txId.Text = dto[0].Id.ToString();
                            txNombre.Text = dto[0].Nombre;
                            txApellido.Text = dto[0].Apellido.ToString();
                            txSucursal.Text = dto[0].Sucursal.ToString();
                            txUsuario.Text = dto[0].Usuario.ToString();
                            txContraseña.Text = dto[0].Contraseña.ToString();
                        }
                        else
                        {
                            lbMensaje.Text = "Error: El vendedor no existe.";
                        }
                    }
                    else
                    {
                        LimpiarCampos();
                        txId.Text = VendedoresNegocio.ProximoIdVendedores().ToString();
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
                VendedoresDTO dto = new VendedoresDTO();

                if (Request.QueryString["id"] != null)
                {
                    dto.Id = Convert.ToInt32(Request.QueryString["id"]);
                    dto.Nombre = txNombre.Text;
                    dto.Apellido = txApellido.Text;
                    dto.Sucursal = txSucursal.Text;
                    dto.Usuario = txUsuario.Text;
                    dto.Contraseña = txContraseña.Text;

                    VendedoresNegocio.ModificarVendedoresPorDTO(dto);

                    lbMensaje.Text = "Vendedores actualizado correctamente.";
                    Response.Redirect("Vendedores.aspx");
                }
                else
                {
                    dto.Id = 0;
                    dto.Nombre = txNombre.Text;
                    dto.Apellido = txApellido.Text;
                    dto.Sucursal = txSucursal.Text;
                    dto.Usuario = txUsuario.Text;
                    dto.Contraseña = txContraseña.Text;

                    VendedoresNegocio.AgregarVendedoresPorDTO(dto);

                    lbMensaje.Text = "Vendedores creado correctamente.";
                    Response.Redirect("Vendedores.aspx");
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
            txNombre.Text = "";
            txApellido.Text = "";
            txSucursal.Text = "";
        }

        protected void btVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Vendedores.aspx");
        }
    }
}
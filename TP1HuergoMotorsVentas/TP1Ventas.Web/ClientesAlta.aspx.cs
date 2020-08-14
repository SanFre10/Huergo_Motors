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
    public partial class ClientesAlta : System.Web.UI.Page
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
                        ClientesNegocio negocio = new ClientesNegocio();

                        ClientesDTO dto = ClientesNegocio.MostrarClientesPorId(id);


                        if (dto != null)
                        {
                            txId.Text = dto.Id.ToString();
                            txNombre.Text = dto.Nombre;
                            txDireccion.Text = dto.Direccion.ToString();
                            txTelefono.Text = dto.Telefono.ToString();
                            txEmail.Text = dto.Email;

                        }
                        else
                        {
                            lbMensaje.Text = "Error: El Cliente no existe.";
                        }
                    }
                    else
                    {
                        LimpiarCampos();
                        txId.Text = ClientesNegocio.ProximoIdClientes().ToString();
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
                ClientesDTO dto = new ClientesDTO();


                if (Request.QueryString["id"] != null)
                {
                    dto.Id = Convert.ToInt32(Request.QueryString["id"]);
                    dto.Nombre = txNombre.Text;
                    dto.Direccion = txDireccion.Text;
                    dto.Telefono = txTelefono.Text;
                    dto.Email = txEmail.Text;

                    ClientesNegocio.ModificarClientesPorDTO(dto);

                    lbMensaje.Text = "Cliente actualizado correctamente.";
                    Response.Redirect("Clientes.aspx");
                }
                else
                {
                    dto.Id = 0;
                    dto.Nombre = txNombre.Text;
                    dto.Direccion = txDireccion.Text;
                    dto.Telefono = txTelefono.Text;
                    dto.Email = txEmail.Text;

                    ClientesNegocio.AgregarClientesPorDTO(dto);

                    lbMensaje.Text = "Cliente creado correctamente.";
                    Response.Redirect("Clientes.aspx");
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
            txDireccion.Text = string.Empty;
            txTelefono.Text = string.Empty;
            txEmail.Text = string.Empty;
        }

        protected void btVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Clientes.aspx");
        }
    }
}
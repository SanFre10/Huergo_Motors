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
    public partial class AltaVenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            try
            { 
                if (!IsPostBack)
                {
                    List<VendedoresDTO> dtosVendedores = TP1VentasNegocio.VendedoresNegocio.MostrarVendedores("%");
                    List<VehiculosDTO> dtosVehiculos = TP1VentasNegocio.VehiculosNegocio.MostrarVehiculos("%");


                    Session.Add("dtosVendedores", dtosVendedores);
                    Session.Add("dtosVehiculos", dtosVehiculos);


                    txId.Text = TP1VentasNegocio.VentasNegocio.ProximoIdVentas().ToString();

                    ddVendedores.DataSource = TP1VentasNegocio.VendedoresNegocio.MostrarNombreVendedores(dtosVendedores);
                    ddVendedores.DataBind();

                    ddModelo.DataSource = TP1VentasNegocio.VehiculosNegocio.MostrarModeloVehiculos(dtosVehiculos);
                    ddModelo.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        protected void ddVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<VendedoresDTO> dtosVendedores = (List<VendedoresDTO>)Session["dtosVendedores"];
            txSucursal.Text = Convert.ToString(dtosVendedores[ddVendedores.SelectedIndex].Sucursal);
            txSucursal.DataBind();
        }

        protected void ddModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<VehiculosDTO> dtosVehiculos = (List<VehiculosDTO>)Session["dtosVehiculos"];
                List<AccesoriosDTO> dtosAccesorios = TP1VentasNegocio.AccesoriosNegocio.MostrarAccesorios(ddModelo.Text);
                Session.Add("dtosAccesorios", dtosAccesorios);

                lblTipo.Text = Convert.ToString(dtosVehiculos[ddModelo.SelectedIndex].Tipo);
                lblTipo.DataBind();

                ddModelo.Text = Convert.ToString(dtosVehiculos[ddModelo.SelectedIndex].Modelo);
                ddModelo.DataBind();

                lblPrecio.Text = Convert.ToString(dtosVehiculos[ddModelo.SelectedIndex].PrecioVenta);
                lblPrecio.DataBind();

                
                if (!(dtosAccesorios.Count == 0))
                {
                    cbAccesorios.Enabled = true;
                    cbAccesorios.DataSource = TP1VentasNegocio.AccesoriosNegocio.MostrarNombreYPrecioAccesorios(dtosAccesorios);
                    cbAccesorios.DataBind();
                }
                else
                {
                    cbAccesorios.DataSource = null;
                    cbAccesorios.Items.Clear();
                    cbAccesorios.Items.Add("No hay accesorios disponibles");
                }

                Total();    
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }



        private void Total()
        {
            //Calcula el lblTotal
            decimal a = 0;
            decimal precio;
            string nombre;
            List<string> nombres = new List<string>();

            foreach (ListItem item in cbAccesorios.Items)
            {
                if (item.Selected)
                {   
                    precio = Convert.ToDecimal(item.Value.Substring(item.Value.IndexOf("-")+1));
                    nombre = item.Value.Substring(0,item.Value.IndexOf("-"));

                    a += precio;
                    nombres.Add(nombre);
                }
            }
            Session.Add("Nombres", nombres);

            txTotal.Text = Convert.ToString(Convert.ToDecimal(lblPrecio.Text) + a);
        }

        protected void btnFiltro_Click(object sender, EventArgs e)
        {

            try
            {
                List<ClientesDTO> dtosCliente = TP1VentasNegocio.ClientesNegocio.MostrarClientes(txFiltro.Text);
                Session.Add("dtosClientes", dtosCliente);

                if (!(dtosCliente is null))
                {
                    ddClientes.DataSource = TP1VentasNegocio.ClientesNegocio.MostrarNombreClientes(dtosCliente);
                    ddClientes.DataBind();
                    ddClientes.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        protected void ddClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ClientesDTO> dtosCliente = (List<ClientesDTO>)Session["dtosClientes"];

            lblTelefono.Text = Convert.ToString(dtosCliente[ddClientes.SelectedIndex].Telefono);
            lblTelefono.DataBind();

            txEmail.Text = Convert.ToString(dtosCliente[ddClientes.SelectedIndex].Email);
            txEmail.DataBind();

        }

        protected void cbAccesorios_SelectedIndexChanged(object sender, EventArgs e)
        {
           Total();      
        }
        protected void btnConfirmar_Click1(object sender, EventArgs e)
        {
            try
            {
                List<string> nombres = new List<string>();
                nombres = (List<string>)Session["Nombres"];

                List<ClientesDTO> dtosCliente = (List<ClientesDTO>)Session["dtosClientes"];
                
                List<AccesoriosDTO> dtosAccesorios = AccesoriosNegocio.BuscarPorNombre(nombres);
                List<VehiculosDTO> dtosVehiculos = (List<VehiculosDTO>)Session["dtosVehiculos"];
                List<VendedoresDTO> dtosVendedores = (List<VendedoresDTO>)Session["dtosVendedores"];
                List<int> IDs = new List<int>();

                IDs.Add(VentasNegocio.ProximoIdVentas());
                IDs.Add(dtosVehiculos[ddModelo.SelectedIndex].Id);
                IDs.Add(dtosCliente[ddClientes.SelectedIndex].Id);
                IDs.Add(dtosVendedores[ddVendedores.SelectedIndex].Id);
                IDs.Add(VentaAccesorioNegocio.ProximoIdVentaAccesorios());

                int stock = dtosVehiculos[ddModelo.SelectedIndex].StockDisponible - 1;
                string obs = txObservaciones.Text;
                decimal tot = Convert.ToDecimal(txTotal.Text);

                lblError.Text = (VentasNegocio.ExecTransaction(IDs, dtosAccesorios, obs, tot, stock));


            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}
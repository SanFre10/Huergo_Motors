using TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TP1Ventas
{
    public partial class frmVentas : Form
    {
        List<VendedoresDTO> dtosVendedores;
        List<VehiculosDTO> dtosVehiculos;
        List<ClientesDTO> dtosCliente;
        List<AccesoriosDTO> dtosAccesorios;
        bool total = false;
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            try
            {
                dtosVendedores = TP1VentasNegocio.VendedoresNegocio.MostrarVendedores("%");
                dtosVehiculos = TP1VentasNegocio.VehiculosNegocio.MostrarVehiculos("%");

                txtIdVenta.Text = TP1VentasNegocio.VentasNegocio.ProximoIdVentas().ToString();

                dtpFecha.Value = DateTime.Now;

                cbVendedor.DataSource = TP1VentasNegocio.VendedoresNegocio.MostrarNombreVendedores(dtosVendedores);

                cbVehiculos.DataSource = TP1VentasNegocio.VehiculosNegocio.MostrarModeloVehiculos(dtosVehiculos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSucursal.Text = Convert.ToString(dtosVendedores[cbVendedor.SelectedIndex].Sucursal);
        }

        private void cbVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblTipo.Text = Convert.ToString(dtosVehiculos[cbVehiculos.SelectedIndex].Tipo);

                cbVehiculos.Text = Convert.ToString(dtosVehiculos[cbVehiculos.SelectedIndex].Modelo);

                lblPrecio.Text = Convert.ToString(dtosVehiculos[cbVehiculos.SelectedIndex].PrecioVenta);

                dtosAccesorios = TP1VentasNegocio.AccesoriosNegocio.MostrarAccesorios(cbVehiculos.Text);
                if (!(dtosAccesorios.Count==0))
                {
                    clbAccesorios.Enabled = true;
                    clbAccesorios.DataSource = TP1VentasNegocio.AccesoriosNegocio.MostrarNombreYPrecioAccesorios(dtosAccesorios);
                }
                else
                {
                    clbAccesorios.DataSource = null;
                    clbAccesorios.Items.Clear();
                    clbAccesorios.Items.Add("No hay accesorios disponibles");
                    clbAccesorios.Enabled = false;
                }


                if (total == true)
                {
                    Total();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnfiltro_Click(object sender, EventArgs e)
        {
            try
            {
                dtosCliente = TP1VentasNegocio.ClientesNegocio.MostrarClientes(txtfiltro.Text);
                
                if (!(dtosCliente is null))
                {
                    cbClientes.DataSource = TP1VentasNegocio.ClientesNegocio.MostrarNombreClientes(dtosCliente);
                    cbClientes.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbltelefono.Text = Convert.ToString(dtosCliente[cbClientes.SelectedIndex].Telefono);
            lbltelefono.Visible = true;

            lblmail.Text = Convert.ToString(dtosCliente[cbClientes.SelectedIndex].Email);
            lblmail.Visible = true;

            lblmail1.Visible = true;
            lblnombre1.Visible = true;
            lbltelefono1.Visible = true;

            btnConfirmar.Visible = true;

            total = true;
            Total();
        }

        private void Total()
        {
            //Calcula el lblTotal
            decimal a = 0;
            for (int i = 0; i < clbAccesorios.CheckedItems.Count; i++)
            {
                a += dtosAccesorios[i].PrecioVenta;
            }

            lblTotal.Text = Convert.ToString(Convert.ToDecimal(lblPrecio.Text) + a);
        }

        private void clbAccesorios_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (total == true)
            {
                Total();
            }
        }

        private void txtfiltro_Click(object sender, EventArgs e)
        {
            txtfiltro.Text = "";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {


                int IdVehiculo = dtosVehiculos[cbVehiculos.SelectedIndex].Id;
                int IdCliente = dtosCliente[cbClientes.SelectedIndex].Id;
                int IdVendedor = dtosVendedores[cbVendedor.SelectedIndex].Id;
                int stock = dtosVehiculos[cbVehiculos.SelectedIndex].StockDisponible - 1;
                string obs = txtObservaciones.Text;
                decimal tot = Convert.ToDecimal(lblTotal.Text);

                MessageBox.Show(TP1VentasNegocio.VentasNegocio.ExecTransaction(
                    IdVehiculo, IdCliente, IdVendedor, dtosAccesorios, obs, tot, stock)
                    , "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

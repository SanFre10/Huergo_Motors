using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using TP1VentasDTOs;

namespace TP1Ventas
{
    public partial class frmConsultaVentas : Form
    {
        public frmConsultaVentas()
        {
            InitializeComponent();
        }

        private void frmConsultaVentas_Load(object sender, EventArgs e)
        {
            CargarTablaEntera();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string selected = "";
               
                if (rbCliente.Checked)
                {
                    selected = "Cliente";
                }
                else if (rbVehiculo.Checked)
                {
                    selected = "Vehiculo";
                }
                else if (rbVendedor.Checked)
                {
                    selected = "Vendedor";
                }
                
                List<VentasDTO> dtoVentas = TP1VentasNegocio.VentasNegocio.ObtenerConFiltro(txFiltro.Text, selected, dtpInicio.Value.ToString("yyyy-MM-dd"), dtpFin.Value.ToString("yyyy-MM-dd"));
                if (dtoVentas.Count > 0)
                {
                    this.dtgVentas.DataSource = dtoVentas;
                }
                else
                {
                    CargarTablaEntera();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTablaEntera()
        {
            List<VentasDTO> dtoVentas = TP1VentasNegocio.VentasNegocio.MostrarVentas();

            dtgVentas.DataSource = dtoVentas;
        }

        private void btncsv_Click(object sender, EventArgs e)
        {
            try
            {
                //Configura el SaveFileDialog
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
                SaveFileDialog1.DefaultExt = "csv";
                SaveFileDialog1.Filter = "Archivo csv (*.csv)|*.csv";
                SaveFileDialog1.Title = "Exportar Ventas";
                SaveFileDialog1.CheckPathExists = true;

                if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Recupera los datos el DataGrid
                    List<VentasDTO> source = (List<VentasDTO>)dtgVentas.DataSource;
                    //Instancia el Writer en el filename del SaveFileDialog
                    using (var Sw = new StreamWriter(SaveFileDialog1.FileName))
                    {
                        foreach (VentasDTO tmp in source)
                        {
                            string fecha = tmp.Fecha.ToString("d/M/yyyy");
                            Sw.WriteLine("'" + tmp.Id.ToString(CultureInfo.InvariantCulture) + "','" + fecha + "','" + tmp.Vehiculo.ToString(CultureInfo.InvariantCulture) + "','" +
                           tmp.Cliente.ToString(CultureInfo.InvariantCulture) + "','" + tmp.Vendedor.ToString(CultureInfo.InvariantCulture) + "','" +
                           tmp.Observaciones.ToString(CultureInfo.InvariantCulture) + "','" + tmp.Total.ToString(CultureInfo.InvariantCulture) + "'");
                        }
                        //Cierra el Writer
                        Sw.Close();
                        //Mensaje de exito
                        MessageBox.Show("Csv Exportado con exito!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCliente.Checked || rbVehiculo.Checked || rbVendedor.Checked)
            {
                txFiltro.Visible = true;
            }
        }
    }
}


using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TP1VentasDTOs;
using System.Reflection;

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
                string query = $"SELECT Ventas.Id,Ventas.Fecha,Clientes.Nombre as Cliente,Vehiculos.Modelo as Vehiculo,Vendedores.Nombre + ' ' + Vendedores.Apellido as Vendedor, Ventas.Observaciones,Ventas.Total FROM VENTAS LEFT JOIN Clientes ON Ventas.IdCliente = Clientes.Id " +
                    $"LEFT JOIN Vehiculos ON Ventas.IdVehiculo = Vehiculos.Id " +
                    $"LEFT JOIN Vendedores ON Ventas.IdVendedor = Vendedores.Id WHERE ";
                if (rbCliente.Checked)
                {
                    query += $" Clientes.Nombre LIKE '%{txFiltro.Text}%' OR ";
                }
                else if (rbVehiculo.Checked)
                {
                    query += $" Vehiculos.Modelo LIKE '%{txFiltro.Text}%' OR ";
                }
                else if (rbVendedor.Checked)
                {
                    query += $" Vendedores.Nombre LIKE '%{txFiltro.Text}%' OR Vendedores.Apellido LIKE '%{txFiltro.Text}%' OR";
                }
                query += $" Fecha between '{dtpInicio.Value:yyyy-MM-dd}' and '{dtpFin.Value:yyyy-MM-dd}' ";
                List<VentasDTO> dtoVentas = TP1VentasNegocio.VentasNegocio.MostrarVentas(query);
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
            List<VentasDTO> dtoVentas = TP1VentasNegocio.VentasNegocio.MostrarVentas($"SELECT Ventas.Id,Ventas.Fecha,Clientes.Nombre as Cliente,Vehiculos.Modelo as Vehiculo,Vendedores.Nombre + ' ' + Vendedores.Apellido as Vendedor, Ventas.Observaciones,Ventas.Total FROM VENTAS LEFT JOIN Clientes ON Ventas.IdCliente = Clientes.Id " +
                    $"LEFT JOIN Vehiculos ON Ventas.IdVehiculo = Vehiculos.Id " +
                    $"LEFT JOIN Vendedores ON Ventas.IdVendedor = Vendedores.Id");

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
                            Sw.WriteLine(Convert.ToString(tmp.Id) + ", " + fecha + ", " + Convert.ToString(tmp.Vehiculo) + ", " +
                                Convert.ToString(tmp.Cliente) + ", " + Convert.ToString(tmp.Vendedor) + ", " +
                                Convert.ToString(tmp.Observaciones) + ", " + Convert.ToString(tmp.Total));
                        }
                        //Cierra el Writer
                        Sw.Close();
                        //Mensaje de exito
                        MessageBox.Show("Csv Exportado con exito!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                List<ConsultaDTO> dt = (List<ConsultaDTO>)Session["dt"]; 

                List<string> lineas = new List<string>(); 
                string header = ""; 
                string row = ""; 
                string row = ""; 
                foreach (PropertyInfo prop in dt[0].GetType().GetProperties()) 
                { 
                    header += """ + prop.Name + """ + ","; 
                }
                lineas.Add(header); 
                foreach (ConsultaDTO dr in dt)
                {
                    foreach (PropertyInfo prop in dr.GetType().GetProperties())
                    {
                        if (prop.GetValue(dr, null) is string){       
                            row += """ + prop.GetValue(dr, null) + """ + ","; 
                        }                
                        else           
                        {                      
                            row += prop.GetValue(dr, null) + ",";       
                        }                    
                    }                    
                    lineas.Add(row);           
                    row = "";                
                }                 
                string result = string.Join("\n", lineas.ToArray());    
                Response.Clear();            
                Response.ContentType = "text/csv";            
                Response.AddHeader("Content-Disposition", "attachment;filename=ventas.csv");            
                Response.Write(result);                
                Response.End();
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


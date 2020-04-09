using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP1Ventas
{
    public partial class frmVehiculoAlta: Form
    {
        public int IdVehiculo { get; set; }

        public frmVehiculoAlta()
        {
            InitializeComponent();
        }

        private void frmVehiculoAlta_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();

                dt = SQLHelper.ObtenerDataTable("SELECT * FROM Vehiculos WHERE Id=" + IdVehiculo);

                if (dt.Rows.Count == 1)
                {
                    txId.Text = Convert.ToString(dt.Rows[0]["Id"]);
                    txModelo.Text = Convert.ToString(dt.Rows[0]["Modelo"]);
                    txTipo.Text = Convert.ToString(dt.Rows[0]["Tipo"]);
                    nuPrecioVenta.Value = Convert.ToDecimal(dt.Rows[0]["PrecioVenta"]);
                    nuStockDisponible.Value = Convert.ToDecimal(dt.Rows[0]["StockDisponible"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string modelo =             txModelo.Text;
                string tipo =               txTipo.Text;

                //Siempre usar "System.Globalization.CultureInfo.InvariantCulture" al convertir números a "String".
                //Esto garantiza que el "separador de decimales" siempre se convierta como PUNTO en lugar de COMA, lo que rompería el SQL.
                string precioVenta =        nuPrecioVenta.Value.ToString(System.Globalization.CultureInfo.InvariantCulture);
                string stockDisponible =    nuStockDisponible.Value.ToString(System.Globalization.CultureInfo.InvariantCulture);


                if (IdVehiculo > 0) //Es una modificacion.
                {
                    string update = $"UPDATE Vehiculos SET Modelo='{modelo}', Tipo='{tipo}', PrecioVenta={precioVenta}, StockDisponible={stockDisponible} WHERE Id={IdVehiculo}";
                    SQLHelper.EjecutarComando(update);
                    this.Close();
                }
                else
                {
                    int id = SQLHelper.ObtenerProximoId("Vehiculos");
                    string insert = $"INSERT INTO Vehiculos (Id, Modelo, Tipo, PrecioVenta, StockDisponible) VALUES ({id},'{modelo}','{tipo}',{precioVenta},{stockDisponible})";
                    SQLHelper.EjecutarComando(insert);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

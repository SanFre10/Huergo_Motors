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
    public partial class frmTablas : Form
    {
        public string Table { get; set; }
        Dictionary<string, string[]> totaldata = new Dictionary<string, string[]>(){
            {"vehiculos", new string[] {"Id","Tipo","Modelo","PrecioVenta","StockDisponible"} },
            {"accesorios", new string[] {"Id","Nombre","Modelo","PrecioVenta"} },
            {"clientes", new string[] {"Id","Nombre","Direccion","Telefono","Email"} },
            {"vendedores", new string[] {"Id","Nombre","Apellido","Sucursal"} }
        };
        public frmTablas()
        {
            InitializeComponent();
        }

        private void frmVehiculos_Load(object sender, EventArgs e)
        {
            lbltabla.Text = Table;
            Buscar();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            //Este método se ejecutará cuando alguien haga click en el botón.
            //-----------------------------
            Buscar();
        }

        private void Buscar()
        {
            Table = Table.Replace('í', 'i').ToLower();
 
            DataTable dt = new DataTable();

            string query = $"SELECT * FROM {Table} WHERE ";
            foreach (string text in totaldata[Table])
            {
                query += $"{text} LIKE '%{txFiltro.Text}%' OR ";
            }
            query = query.Remove(query.Length - 4);

            dt = SQLHelper.ObtenerDataTable(query);

            gvArticulos.AutoGenerateColumns = true;
            gvArticulos.DataSource = dt;
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (gvArticulos.SelectedRows != null && gvArticulos.SelectedRows.Count > 0)
            {
                //Obtengo la informacion del item seleccionado
                DataRowView dr = (DataRowView)gvArticulos.SelectedRows[0].DataBoundItem;

                int SelectedID = (int)dr["Id"];
                using (frmAlta form = new frmAlta())
                {
                    //Paso al formulario el Id del registro a modificar.
                    form.SelectedID = SelectedID;
                    form.currenttable = Table;
                    form.totaldata = totaldata;
                    form.ShowDialog();

                    //Una vez cerrado el formulario, vuelvo a buscar para actualizar los cambios en la grilla.
                    Buscar();
                }
            }
        }

        private void btAlta_Click(object sender, EventArgs e)
        {
            using (frmAlta form = new frmAlta())
            {
                //Con Id=0 voy a identificar que es un nuevo registro.
                form.SelectedID = 0;
                form.currenttable = Table;
                form.totaldata = totaldata;
                form.ShowDialog();
                Buscar();
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Realmente quiere eliminar el registro?","Sr.usuario",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (gvArticulos.SelectedRows != null && gvArticulos.SelectedRows.Count > 0)
                {
                    //Obtengo la informacion del item seleccionado
                    DataRowView dr = (DataRowView)gvArticulos.SelectedRows[0].DataBoundItem;

                    int SelectedID = (int)dr["Id"];
                    SQLHelper.EjecutarComando($"DELETE from {Table} WHERE id = {SelectedID}");

                    Buscar();
                }
            }
        }
    }
}

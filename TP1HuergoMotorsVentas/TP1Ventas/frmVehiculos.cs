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
    public partial class frmVehiculos : Form
    {
        public string Table { get; set; }
        Dictionary<string, string[]> Campo = new Dictionary<string, string[]>(){
            {"Vehiculos", new string[] {"Id","Tipo","Modelo","PrecioVenta"} },
            {"Accesorios", new string[] {"Id","Nombre","Modelo","PrecioVenta"} },
            {"Clientes", new string[] {"Id","Nombre","Direccion","Telefono","Email"} },
            {"Vendedores", new string[] {"Id","Nombre","Apellido","Sucursal"} }
        };
        public frmVehiculos()
        {
            InitializeComponent();
        }

        private void frmVehiculos_Load(object sender, EventArgs e)
        {
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
            DataTable dt = new DataTable();

            //foreach (ref readonly var item in Campo[Table]{
            //    query += item
            //}
            string query = $"SELECT * FROM {Table.Replace('í', 'i')}";


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

                int idVehiculo = (int)dr["Id"];
                using (frmVehiculoAlta form = new frmVehiculoAlta())
                {
                    //Paso al formulario el Id del registro a modificar.
                    form.IdVehiculo = idVehiculo;
                    form.ShowDialog();

                    //Una vez cerrado el formulario, vuelvo a buscar para actualizar los cambios en la grilla.
                    Buscar();
                }
            }
        }

        private void btAlta_Click(object sender, EventArgs e)
        {
            using (frmVehiculoAlta form = new frmVehiculoAlta())
            {
                //Con Id=0 voy a identificar que es un nuevo registro.
                form.IdVehiculo = 0;
                form.ShowDialog();
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            //ToDo: Próximamente.
        }
    }
}

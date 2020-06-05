using TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TP1VentasNegocio;


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
            try
            {
                Table = Table.ToLower().Replace("í", "i");

                if (Table == "vehiculos")
                {
                    gvArticulos.DataSource = VehiculosNegocio.MostrarVehiculos(txFiltro.Text);
                }
                if (Table == "accesorios")
                {
                    gvArticulos.DataSource = AccesoriosNegocio.MostrarAccesorios(txFiltro.Text);
                }
                if (Table == "vendedores")
                {
                    gvArticulos.DataSource = VendedoresNegocio.MostrarVendedores(txFiltro.Text);
                }
                if (Table == "clientes")
                {
                    gvArticulos.DataSource = ClientesNegocio.MostrarClientes(txFiltro.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvArticulos.SelectedRows != null && gvArticulos.SelectedRows.Count > 0)
                {
                    int SelectedID = 0;
                    //Obtengo la informacion del item seleccionado
                    if (Table == "vehiculos")
                    {
                        VehiculosDTO v = (VehiculosDTO)gvArticulos.SelectedRows[0].DataBoundItem;
                        SelectedID = (int)v.Id;
                    }
                    if (Table == "accesorios")
                    {
                        AccesoriosDTO v = (AccesoriosDTO)gvArticulos.SelectedRows[0].DataBoundItem;
                        SelectedID = (int)v.Id;
                    }
                    if (Table == "vendedores")
                    {
                        VendedoresDTO v = (VendedoresDTO)gvArticulos.SelectedRows[0].DataBoundItem;
                        SelectedID = (int)v.Id;
                    }
                    if (Table == "clientes")
                    {
                        ClientesDTO v = (ClientesDTO)gvArticulos.SelectedRows[0].DataBoundItem;
                        SelectedID = (int)v.Id;
                    }


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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAlta_Click(object sender, EventArgs e) { 
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
            try
            {
                if (MessageBox.Show("Realmente quiere eliminar el registro?", "Sr.usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (gvArticulos.SelectedRows != null && gvArticulos.SelectedRows.Count > 0)
                    {
                        //Obtengo la informacion del item 
                        if (Table == "vehiculos")
                        {
                            VehiculosDTO v = (VehiculosDTO)gvArticulos.SelectedRows[0].DataBoundItem;
                            int SelectedID = (int)v.Id;
                            VehiculosNegocio.EliminarVehiculos(SelectedID);
                        }
                        else if (Table == "clientes")
                        {
                            ClientesDTO c = (ClientesDTO)gvArticulos.SelectedRows[0].DataBoundItem;
                            int SelectedID = (int)c.Id;
                            ClientesNegocio.EliminarClientes(SelectedID);
                        }
                        else if (Table == "accesorios")
                        {
                            AccesoriosDTO a = (AccesoriosDTO)gvArticulos.SelectedRows[0].DataBoundItem;
                            int SelectedID = (int)a.Id;
                            AccesoriosNegocio.EliminarAccesorios(SelectedID);
                        }
                        else if (Table == "vendedores")
                        {
                            VendedoresDTO v = (VendedoresDTO)gvArticulos.SelectedRows[0].DataBoundItem;
                            int SelectedID = (int)v.Id;
                            VendedoresNegocio.EliminarVendedores(SelectedID);
                        }

                        Buscar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

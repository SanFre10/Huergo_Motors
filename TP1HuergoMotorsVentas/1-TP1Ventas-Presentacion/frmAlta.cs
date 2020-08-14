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
using System.Reflection;
using _4_TP1VentasDTOs;

namespace TP1Ventas
{
    public partial class frmAlta : Form
    {
        public int SelectedID { get; set; }
        public string Currenttable { get; set; }
        public Dictionary<string,string[]> Totaldata { get; set; }

        public VehiculosDTO Vehiculos;
        public ClientesDTO Clientes;
        public AccesoriosDTO Accesorios;
        public VendedoresDTO Vendedores;


        public frmAlta()
        {
            InitializeComponent();
        }

        private void FrmVehiculoAlta_Load(object sender, EventArgs e)
        {
            try
            {
                //Muestra los textbox y NumericUpDown segun corresponda
                int actual = 0;
                foreach (Control ctrl in TLPLabels.Controls)
                {
                    if (ctrl.GetType() == typeof(Label) & actual != Totaldata[Currenttable].Length)
                    {
                        ctrl.Text = Totaldata[Currenttable][actual];
                        if (ctrl.Text.Contains("Precio") || ctrl.Text.Contains("Stock"))
                        { ctrl.Tag += "n"; }
                        else { ctrl.Tag += "t"; }
                        ctrl.Visible = true;
                        actual++;
                    }
                }

                if (Currenttable == "vehiculos")
                {
                    Vehiculos = VehiculosNegocio.MostrarVehiculosPorId(SelectedID);
                    if (SelectedID == 0)
                    {
                        txt1.Text = Convert.ToString(VehiculosNegocio.ProximoIdVehiculos());
                    }
                }
                else if (Currenttable == "accesorios")
                {
                    Accesorios = AccesoriosNegocio.MostrarAccesoriosPorId(SelectedID);
                    if (SelectedID == 0)
                    {
                        txt1.Text = Convert.ToString(AccesoriosNegocio.ProximoIdAccesorios());
                    }
                }
                else if (Currenttable == "clientes")
                {
                    Clientes = ClientesNegocio.MostrarClientesPorId(SelectedID);
                    if (SelectedID == 0)
                    {
                        txt1.Text = Convert.ToString(ClientesNegocio.ProximoIdClientes());
                    }
                }
                else if (Currenttable == "vendedores")
                {
                    Vendedores = VendedoresNegocio.MostrarVendedoresPorId(SelectedID);
                    if (SelectedID == 0)
                    {
                        txt1.Text = Convert.ToString(VendedoresNegocio.ProximoIdVendedores());
                    }
                }


                //Llena los textbox y NumericUpDown
                if (SelectedID != 0)
                {
                    int index = 0;
                    foreach (Control ctrl in Controls)
                    {
                        if ((ctrl.GetType() == typeof(TextBox) | ctrl.GetType() == typeof(NumericUpDown)) & ctrl.Visible == true)
                        {
                            //Consigue los datos del DTO
                            if(Currenttable == "vehiculos")
                            {
                                ctrl.Text = Convert.ToString(Vehiculos.GetType().GetProperty(Totaldata[Currenttable][index]).GetValue(Vehiculos, null));
                            }
                            else if (Currenttable == "accesorios")
                            {
                                ctrl.Text = Convert.ToString(Accesorios.GetType().GetProperty(Totaldata[Currenttable][index]).GetValue(Accesorios, null));
                            }
                            else if (Currenttable == "clientes")
                            {
                                ctrl.Text = Convert.ToString(Clientes.GetType().GetProperty(Totaldata[Currenttable][index]).GetValue(Clientes, null));
                            }
                            else if (Currenttable == "vendedores")
                            {
                                ctrl.Text = Convert.ToString(Vendedores.GetType().GetProperty(Totaldata[Currenttable][index]).GetValue(Vendedores, null));
                            }
                            index++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lables_ToggleVisible(object sender, EventArgs e)
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl.Tag.ToString() == (sender as Label).Tag.ToString() & ctrl.GetType() != typeof(Label)) { ctrl.Visible = true; }

            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedID > 0) //Es una modificacion.
                {
                    if (Currenttable == "vehiculos")
                    {
                        VehiculosDTO dto = LlenarDTO<VehiculosDTO>(SelectedID);
                        VehiculosNegocio.ModificarVehiculosPorDTO(dto);
                    }
                    else if (Currenttable == "accesorios")
                    {
                        AccesoriosDTO dto = LlenarDTO<AccesoriosDTO>(SelectedID);
                        AccesoriosNegocio.ModificarAccesoriosPorDTO(dto);
                    }
                    else if (Currenttable == "clientes")
                    {
                        ClientesDTO dto = LlenarDTO<ClientesDTO>(SelectedID);
                        ClientesNegocio.ModificarClientesPorDTO(dto);
                    }
                    else if (Currenttable == "vendedores")
                    {
                        VendedoresDTO dto = LlenarDTO<VendedoresDTO>(SelectedID);
                        VendedoresNegocio.ModificarVendedoresPorDTO(dto);
                    }

                    this.Close();
                }
                else
                {
                    if (Currenttable == "vehiculos")
                    {
                        VehiculosDTO dto = LlenarDTO<VehiculosDTO>(SelectedID);
                        VehiculosNegocio.AgregarVehiculosPorDTO(dto);
                    }
                    else if (Currenttable == "accesorios")
                    {
                        AccesoriosDTO dto = LlenarDTO<AccesoriosDTO>(SelectedID);
                        AccesoriosNegocio.AgregarAccesoriosPorDTO(dto);
                    }
                    else if (Currenttable == "clientes")
                    {
                        ClientesDTO dto = LlenarDTO<ClientesDTO>(SelectedID);
                        ClientesNegocio.AgregarClientesPorDTO(dto);
                    }
                    else if (Currenttable == "vendedores")
                    {
                        VendedoresDTO dto = LlenarDTO<VendedoresDTO>(SelectedID);
                        VendedoresNegocio.AgregarVendedoresPorDTO(dto);
                    }
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


        private T LlenarDTO<T>(int id) where T : DTOBase, new()
        {
            string[] valores = { "", "", "", "", ""};
            int index = 0;
            foreach (Control ctrl in Controls) //Guarda los valores de los controls en una lista
            {
                if (ctrl.Visible == true & ctrl.GetType() == typeof(TextBox))
                {
                    valores[index] = ctrl.Text;
                    index++;
                }
                else if (ctrl.Visible == true & ctrl.GetType() == typeof(NumericUpDown))
                {
                    valores[index] = ctrl.Text.ToString(System.Globalization.CultureInfo.InvariantCulture);
                    index++;
                }
            }

            T dto = new T();
            PropertyInfo[] props = dto.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            dto.Id = id;
            foreach (Control ctrl in TLPLabels.Controls)
            {
                index = 0;
                while (index <= valores.Length)
                {
                    if (ctrl.Visible == true && ctrl.Text != "Id" && ctrl.Text == props[index].Name)
                    {
                        if (props[index].PropertyType == typeof(string))
                        {
                            props[index].SetValue(dto, valores[index]);
                        }
                        else if(props[index].PropertyType == typeof(decimal))
                        {
                            props[index].SetValue(dto, Convert.ToDecimal(valores[index]));
                        }
                        else if (props[index].PropertyType == typeof(int))
                        {
                            props[index].SetValue(dto, Convert.ToInt32(valores[index]));
                        }
                    }
                    index++;
                    
                }

            }
            return dto;
        }
    }
}

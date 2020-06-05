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
    public partial class frmAlta : Form
    {
        public int SelectedID { get; set; }
        public string currenttable { get; set; }
        public Dictionary<string,string[]> totaldata { get; set; }

        public List<VehiculosDTO> Vehiculos;
        public List<ClientesDTO> Clientes;
        public List<AccesoriosDTO> Accesorios;
        public List<VendedoresDTO> Vendedores;


        public frmAlta()
        {
            InitializeComponent();
        }

        private void frmVehiculoAlta_Load(object sender, EventArgs e)
        {
            try
            {
                //Muestra los textbox y NumericUpDown segun corresponda
                int actual = 0;
                foreach (Control ctrl in TLPLabels.Controls)
                {
                    if (ctrl.GetType() == typeof(Label) & actual != totaldata[currenttable].Length)
                    {
                        ctrl.Text = totaldata[currenttable][actual];
                        if (ctrl.Text.Contains("Precio") || ctrl.Text.Contains("Stock"))
                        { ctrl.Tag += "n"; }
                        else { ctrl.Tag += "t"; }
                        ctrl.Visible = true;
                        actual++;
                    }
                }

                if (currenttable == "vehiculos")
                {
                    Vehiculos = VehiculosNegocio.MostrarVehiculosPorId(SelectedID);
                    if (SelectedID == 0)
                    {
                        txt1.Text = Convert.ToString(VehiculosNegocio.ProximoIdVehiculos());
                    }
                }
                else if (currenttable == "accesorios")
                {
                    Accesorios = AccesoriosNegocio.MostrarAccesoriosPorId(SelectedID);
                    if (SelectedID == 0)
                    {
                        txt1.Text = Convert.ToString(AccesoriosNegocio.ProximoIdAccesorios());
                    }
                }
                else if (currenttable == "clientes")
                {
                    Clientes = ClientesNegocio.MostrarClientesPorId(SelectedID);
                    if (SelectedID == 0)
                    {
                        txt1.Text = Convert.ToString(ClientesNegocio.ProximoIdClientes());
                    }
                }
                else if (currenttable == "vendedores")
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
                            if(currenttable == "vehiculos")
                            {
                                ctrl.Text = Convert.ToString(Vehiculos[0].GetType().GetProperty(totaldata[currenttable][index]).GetValue(Vehiculos[0], null));
                            }
                            else if (currenttable == "accesorios")
                            {
                                ctrl.Text = Convert.ToString(Accesorios[0].GetType().GetProperty(totaldata[currenttable][index]).GetValue(Accesorios[0], null));
                            }
                            else if (currenttable == "clientes")
                            {
                                ctrl.Text = Convert.ToString(Clientes[0].GetType().GetProperty(totaldata[currenttable][index]).GetValue(Clientes[0], null));
                            }
                            else if (currenttable == "vendedores")
                            {
                                ctrl.Text = Convert.ToString(Vendedores[0].GetType().GetProperty(totaldata[currenttable][index]).GetValue(Vendedores[0], null));
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
                string[] valores = { "", "", "", "", "" };
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

                index = 0;
                if (SelectedID > 0) //Es una modificacion.
                {
                    index = 1;
                    //Arma el query UPDATE
                    string update = $"UPDATE {currenttable} SET ";
                    foreach (Control ctrl in TLPLabels.Controls)
                    {
                        if (ctrl.Visible == true && ctrl.Text != "Id")
                        {
                            update += $" {ctrl.Text} = '{valores[index].ToString(System.Globalization.CultureInfo.InvariantCulture)}' ,";
                            index++;
                        }
                    }
                    update = update.Remove(update.Length - 2);
                    update += $" WHERE Id = {SelectedID}";

                    if (currenttable == "vehiculos")
                    {
                        VehiculosNegocio.ModificarVehiculos(update);
                    }
                    else if (currenttable == "accesorios")
                    {
                        AccesoriosNegocio.ModificarAccesorios(update);
                    }
                    else if (currenttable == "clientes")
                    {
                        ClientesNegocio.ModificarClientes(update);
                    }
                    else if (currenttable == "vendedores")
                    {
                        VendedoresNegocio.ModificarVendedores(update);
                    }

                    this.Close();
                }
                else
                {
                    //Arma el query INSERT
                    string insert = $"INSERT INTO {currenttable} ( ";
                    foreach (Control ctrl in TLPLabels.Controls)
                    {
                        if (ctrl.Visible == true)
                        {
                            insert += $" {ctrl.Text} ,";
                            index++;
                        }
                    }
                    insert = insert.Remove(insert.Length - 2);
                    insert += " ) VALUES (";
                    index = 0;
                    foreach (string valor in valores)
                    {
                        if (valores[index] != "")
                        {
                            insert += $" '{valores[index].ToString(System.Globalization.CultureInfo.InvariantCulture)}' ,";
                            index++;
                        }

                    }
                    insert = insert.Remove(insert.Length - 2);
                    insert += " )";

                    if (currenttable == "vehiculos")
                    {
                        VehiculosNegocio.AgregarVehiculos(insert);
                    }
                    else if (currenttable == "accesorios")
                    {
                        AccesoriosNegocio.AgregarAccesoriosPorDTO(insert);
                    }
                    else if (currenttable == "clientes")
                    {
                        ClientesNegocio.AgregarClientes(insert);
                    }
                    else if (currenttable == "vendedores")
                    {
                        VendedoresNegocio.AgregarVendedores(insert);
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
    }
}

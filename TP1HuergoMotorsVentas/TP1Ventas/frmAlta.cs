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
    public partial class frmAlta : Form
    {
        public int SelectedID { get; set; }
        public string currenttable { get; set; }
        public Dictionary<string,string[]> totaldata { get; set; }
        public frmAlta()
        {
            InitializeComponent();
        }

        private void frmVehiculoAlta_Load(object sender, EventArgs e)
        {
            try
            {
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


                DataTable dt = new DataTable();

                    dt = SQLHelper.ObtenerDataTable($"SELECT * FROM {currenttable} WHERE Id=" + SelectedID);

                    if (dt.Rows.Count == 1)
                    {
                    int index = 0;
                    foreach(Control ctrl in Controls)
                    {
                        if((ctrl.GetType()==typeof(TextBox) | ctrl.GetType() == typeof(NumericUpDown)) & ctrl.Visible==true)
                        {
                            ctrl.Text = Convert.ToString(dt.Rows[0][totaldata[currenttable][index]]);
                            index++;
                        }
                    }
                    }
                    if(SelectedID == 0)
                    {
                        txt1.Text = SQLHelper.ObtenerProximoId(currenttable).ToString();
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
                string[] valores = {"","","","","" };
                int index = 0;
                foreach(Control ctrl in Controls) //Guarda los valores de los controls en una lista
                {
                    if (ctrl.Visible == true & ctrl.GetType() == typeof(TextBox))
                    {
                        valores[index] = ctrl.Text;
                        index++;
                    }
                    else if(ctrl.Visible == true & ctrl.GetType() == typeof(NumericUpDown))
                    {
                        valores[index] = ctrl.Text.ToString(System.Globalization.CultureInfo.InvariantCulture);
                        index++;
                    }
                }

                index = 0;
                if (SelectedID > 0) //Es una modificacion.
                {
                    index = 1;
                    //Arma el query
                    string update = $"UPDATE {currenttable} SET ";
                    foreach (Control ctrl in TLPLabels.Controls)
                    {
                        if(ctrl.Visible == true && ctrl.Text != "Id")
                        {
                            update += $" {ctrl.Text} = '{valores[index]}' ,";
                            index++;
                        }
                    }
                    update = update.Remove(update.Length - 2);
                    update += $"WHERE Id = {SelectedID}";
                    SQLHelper.EjecutarComando(update);
                    this.Close();
                }
                else
                {
                    //Arma el query, anda pero seguro se puede mejorar
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
                        if(valores[index] != "")
                        {
                            insert += $" '{valores[index]}' ,";
                            index++;
                        }
                       
                    }
                    insert = insert.Remove(insert.Length - 2);
                    insert += " )";
                    
                    //INSERT INTO table (campo1,campo2,campo3,campo4) VALUES (valor1,valor2,valor3,valor4)
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

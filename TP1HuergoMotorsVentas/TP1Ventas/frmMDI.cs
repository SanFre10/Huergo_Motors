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
    public partial class frmMDI : Form
    {
        
        public frmMDI()
        {
            InitializeComponent();
        }

        //Se ejecuta cuando se hace click en cualquier ABM
        private void commonButtons_Click(object sender, EventArgs e)
        {
            using (frmTablas form = new frmTablas())
            {
                //Cambia la variable que se usa para definir la tabla que se muestra 
                form.Table = (sender as ToolStripItem).Text;
                form.ShowDialog();
            }
            

        }


        private void frmMDI_Load(object sender, EventArgs e)
        {

        }
    }
}

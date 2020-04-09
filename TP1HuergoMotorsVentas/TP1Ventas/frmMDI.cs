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

        private void commonButtons_Click(object sender, EventArgs e)
        {
            
            using (frmVehiculos form = new frmVehiculos())
            {
                
                form.Table = (sender as ToolStripItem).Text;
                form.ShowDialog();
            }
            

        }


        private void frmMDI_Load(object sender, EventArgs e)
        {

        }
    }
}

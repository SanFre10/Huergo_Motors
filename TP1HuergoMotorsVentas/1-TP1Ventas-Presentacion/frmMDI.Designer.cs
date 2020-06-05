namespace TP1Ventas
{
    partial class frmMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.btAccesorios = new System.Windows.Forms.ToolStripMenuItem();
            this.btClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.btVendedores = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ventasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 45);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btVehiculos,
            this.btAccesorios,
            this.btClientes,
            this.btVendedores});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 41);
            this.toolStripMenuItem1.Text = "ABMs";
            // 
            // btVehiculos
            // 
            this.btVehiculos.Image = ((System.Drawing.Image)(resources.GetObject("btVehiculos.Image")));
            this.btVehiculos.Name = "btVehiculos";
            this.btVehiculos.Size = new System.Drawing.Size(237, 42);
            this.btVehiculos.Text = "Vehículos";
            // 
            // btAccesorios
            // 
            this.btAccesorios.Image = ((System.Drawing.Image)(resources.GetObject("btAccesorios.Image")));
            this.btAccesorios.Name = "btAccesorios";
            this.btAccesorios.Size = new System.Drawing.Size(237, 42);
            this.btAccesorios.Text = "Accesorios";
            // 
            // btClientes
            // 
            this.btClientes.Image = ((System.Drawing.Image)(resources.GetObject("btClientes.Image")));
            this.btClientes.Name = "btClientes";
            this.btClientes.Size = new System.Drawing.Size(237, 42);
            this.btClientes.Text = "Clientes";
            // 
            // btVendedores
            // 
            this.btVendedores.Image = ((System.Drawing.Image)(resources.GetObject("btVendedores.Image")));
            this.btVendedores.Name = "btVendedores";
            this.btVendedores.Size = new System.Drawing.Size(237, 42);
            this.btVendedores.Text = "Vendedores";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.nuevaVentaToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(110, 41);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaToolStripMenuItem.Image")));
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(249, 42);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevaVentaToolStripMenuItem.Image")));
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(249, 42);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva Venta";
            this.nuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaVentaToolStripMenuItem_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huergo Motors ";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.btAccesorios.Click += commonButtons_Click;
            this.btVendedores.Click += commonButtons_Click;
            this.btVehiculos.Click += commonButtons_Click;
            this.btClientes.Click += commonButtons_Click;

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btVendedores;
        private System.Windows.Forms.ToolStripMenuItem btClientes;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem btVehiculos;
        private System.Windows.Forms.ToolStripMenuItem btAccesorios;
    }
}
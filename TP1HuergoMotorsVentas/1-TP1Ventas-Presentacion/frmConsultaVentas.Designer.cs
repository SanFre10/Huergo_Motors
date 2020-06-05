namespace TP1Ventas
{
    partial class frmConsultaVentas
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
            this.dtgVentas = new System.Windows.Forms.DataGridView();
            this.btBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncsv = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbVendedor = new System.Windows.Forms.RadioButton();
            this.rbVehiculo = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txFiltro = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgVentas
            // 
            this.dtgVentas.AllowUserToAddRows = false;
            this.dtgVentas.AllowUserToDeleteRows = false;
            this.dtgVentas.AllowUserToOrderColumns = true;
            this.dtgVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentas.Location = new System.Drawing.Point(12, 168);
            this.dtgVentas.Name = "dtgVentas";
            this.dtgVentas.ReadOnly = true;
            this.dtgVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVentas.Size = new System.Drawing.Size(708, 253);
            this.dtgVentas.TabIndex = 15;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(517, 25);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(171, 54);
            this.btBuscar.TabIndex = 14;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncsv);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btBuscar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 150);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // btncsv
            // 
            this.btncsv.Location = new System.Drawing.Point(517, 108);
            this.btncsv.Name = "btncsv";
            this.btncsv.Size = new System.Drawing.Size(171, 31);
            this.btncsv.TabIndex = 20;
            this.btncsv.Text = "Exportar a CSV";
            this.btncsv.UseVisualStyleBackColor = true;
            this.btncsv.Click += new System.EventHandler(this.btncsv_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtpFin);
            this.groupBox3.Controls.Add(this.dtpInicio);
            this.groupBox3.Location = new System.Drawing.Point(240, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 120);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Por Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Incio";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(79, 72);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(151, 20);
            this.dtpFin.TabIndex = 1;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(79, 30);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(151, 20);
            this.dtpInicio.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txFiltro);
            this.groupBox2.Controls.Add(this.rbCliente);
            this.groupBox2.Controls.Add(this.rbVendedor);
            this.groupBox2.Controls.Add(this.rbVehiculo);
            this.groupBox2.Location = new System.Drawing.Point(16, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 120);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Por IDs:";
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(6, 67);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(57, 17);
            this.rbCliente.TabIndex = 23;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbVendedor
            // 
            this.rbVendedor.AutoSize = true;
            this.rbVendedor.Location = new System.Drawing.Point(6, 23);
            this.rbVendedor.Name = "rbVendedor";
            this.rbVendedor.Size = new System.Drawing.Size(71, 17);
            this.rbVendedor.TabIndex = 21;
            this.rbVendedor.TabStop = true;
            this.rbVendedor.Text = "Vendedor";
            this.rbVendedor.UseVisualStyleBackColor = true;
            this.rbVendedor.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbVehiculo
            // 
            this.rbVehiculo.AutoSize = true;
            this.rbVehiculo.Location = new System.Drawing.Point(6, 44);
            this.rbVehiculo.Name = "rbVehiculo";
            this.rbVehiculo.Size = new System.Drawing.Size(66, 17);
            this.rbVehiculo.TabIndex = 22;
            this.rbVehiculo.TabStop = true;
            this.rbVehiculo.Text = "Vehiculo";
            this.rbVehiculo.UseVisualStyleBackColor = true;
            this.rbVehiculo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txFiltro
            // 
            this.txFiltro.Location = new System.Drawing.Point(34, 90);
            this.txFiltro.Name = "txFiltro";
            this.txFiltro.Size = new System.Drawing.Size(134, 20);
            this.txFiltro.TabIndex = 24;
            this.txFiltro.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 444);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgVentas);
            this.MaximizeBox = false;
            this.Name = "frmConsultaVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta - Ventas";
            this.Load += new System.EventHandler(this.frmConsultaVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgVentas;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btncsv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbVendedor;
        private System.Windows.Forms.RadioButton rbVehiculo;
        private System.Windows.Forms.TextBox txFiltro;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
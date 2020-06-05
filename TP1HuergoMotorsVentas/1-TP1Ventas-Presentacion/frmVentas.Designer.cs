namespace TP1Ventas
{
    partial class frmVentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbVendedor = new System.Windows.Forms.ComboBox();
            this.lblprecio1 = new System.Windows.Forms.Label();
            this.lblmodelo1 = new System.Windows.Forms.Label();
            this.lbltipo1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbVehiculos = new System.Windows.Forms.ComboBox();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblmail1 = new System.Windows.Forms.Label();
            this.lbltelefono1 = new System.Windows.Forms.Label();
            this.lblnombre1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.btnfiltro = new System.Windows.Forms.Button();
            this.clbAccesorios = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos de venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sucursal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Vendedor";
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Location = new System.Drawing.Point(206, 39);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.ReadOnly = true;
            this.txtIdVenta.Size = new System.Drawing.Size(125, 20);
            this.txtIdVenta.TabIndex = 5;
            // 
            // txtSucursal
            // 
            this.txtSucursal.Location = new System.Drawing.Point(206, 108);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.ReadOnly = true;
            this.txtSucursal.Size = new System.Drawing.Size(125, 20);
            this.txtSucursal.TabIndex = 8;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(206, 63);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(125, 20);
            this.dtpFecha.TabIndex = 9;
            // 
            // cbVendedor
            // 
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Location = new System.Drawing.Point(206, 84);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(125, 21);
            this.cbVendedor.TabIndex = 10;
            this.cbVendedor.SelectedIndexChanged += new System.EventHandler(this.cbVendedor_SelectedIndexChanged);
            // 
            // lblprecio1
            // 
            this.lblprecio1.AutoSize = true;
            this.lblprecio1.Location = new System.Drawing.Point(29, 71);
            this.lblprecio1.Name = "lblprecio1";
            this.lblprecio1.Size = new System.Drawing.Size(37, 13);
            this.lblprecio1.TabIndex = 14;
            this.lblprecio1.Text = "Precio";
            // 
            // lblmodelo1
            // 
            this.lblmodelo1.AutoSize = true;
            this.lblmodelo1.Location = new System.Drawing.Point(29, 27);
            this.lblmodelo1.Name = "lblmodelo1";
            this.lblmodelo1.Size = new System.Drawing.Size(42, 13);
            this.lblmodelo1.TabIndex = 13;
            this.lblmodelo1.Text = "Modelo";
            // 
            // lbltipo1
            // 
            this.lbltipo1.AutoSize = true;
            this.lbltipo1.Location = new System.Drawing.Point(29, 51);
            this.lbltipo1.Name = "lbltipo1";
            this.lbltipo1.Size = new System.Drawing.Size(28, 13);
            this.lbltipo1.TabIndex = 12;
            this.lbltipo1.Text = "Tipo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(78, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Vehiculo";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(78, 71);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(13, 13);
            this.lblPrecio.TabIndex = 17;
            this.lblPrecio.Text = "a";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(79, 51);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(13, 13);
            this.lblTipo.TabIndex = 15;
            this.lblTipo.Text = "a";
            // 
            // cbVehiculos
            // 
            this.cbVehiculos.FormattingEnabled = true;
            this.cbVehiculos.Location = new System.Drawing.Point(81, 24);
            this.cbVehiculos.Name = "cbVehiculos";
            this.cbVehiculos.Size = new System.Drawing.Size(98, 21);
            this.cbVehiculos.TabIndex = 18;
            this.cbVehiculos.SelectedIndexChanged += new System.EventHandler(this.cbVehiculos_SelectedIndexChanged);
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(62, 77);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(137, 21);
            this.cbClientes.TabIndex = 26;
            this.cbClientes.Visible = false;
            this.cbClientes.SelectedIndexChanged += new System.EventHandler(this.cbClientes_SelectedIndexChanged);
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(59, 133);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(13, 13);
            this.lblmail.TabIndex = 25;
            this.lblmail.Text = "a";
            this.lblmail.Visible = false;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(59, 109);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(13, 13);
            this.lbltelefono.TabIndex = 24;
            this.lbltelefono.Text = "a";
            this.lbltelefono.Visible = false;
            // 
            // lblmail1
            // 
            this.lblmail1.AutoSize = true;
            this.lblmail1.Location = new System.Drawing.Point(6, 133);
            this.lblmail1.Name = "lblmail1";
            this.lblmail1.Size = new System.Drawing.Size(32, 13);
            this.lblmail1.TabIndex = 22;
            this.lblmail1.Text = "Email";
            this.lblmail1.Visible = false;
            // 
            // lbltelefono1
            // 
            this.lbltelefono1.AutoSize = true;
            this.lbltelefono1.Location = new System.Drawing.Point(6, 109);
            this.lbltelefono1.Name = "lbltelefono1";
            this.lbltelefono1.Size = new System.Drawing.Size(49, 13);
            this.lbltelefono1.TabIndex = 21;
            this.lbltelefono1.Text = "Telefono";
            this.lbltelefono1.Visible = false;
            // 
            // lblnombre1
            // 
            this.lblnombre1.AutoSize = true;
            this.lblnombre1.Location = new System.Drawing.Point(6, 80);
            this.lblnombre1.Name = "lblnombre1";
            this.lblnombre1.Size = new System.Drawing.Size(44, 13);
            this.lblnombre1.TabIndex = 20;
            this.lblnombre1.Text = "Nombre";
            this.lblnombre1.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(79, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Filtro";
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(62, 33);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(97, 20);
            this.txtfiltro.TabIndex = 28;
            this.txtfiltro.Text = "Nombre o email";
            this.txtfiltro.Click += new System.EventHandler(this.txtfiltro_Click);
            // 
            // btnfiltro
            // 
            this.btnfiltro.Location = new System.Drawing.Point(165, 33);
            this.btnfiltro.Name = "btnfiltro";
            this.btnfiltro.Size = new System.Drawing.Size(34, 20);
            this.btnfiltro.TabIndex = 29;
            this.btnfiltro.Text = "Ok";
            this.btnfiltro.UseVisualStyleBackColor = true;
            this.btnfiltro.Click += new System.EventHandler(this.btnfiltro_Click);
            // 
            // clbAccesorios
            // 
            this.clbAccesorios.CheckOnClick = true;
            this.clbAccesorios.FormattingEnabled = true;
            this.clbAccesorios.IntegralHeight = false;
            this.clbAccesorios.Location = new System.Drawing.Point(6, 125);
            this.clbAccesorios.Name = "clbAccesorios";
            this.clbAccesorios.Size = new System.Drawing.Size(193, 64);
            this.clbAccesorios.TabIndex = 30;
            this.clbAccesorios.Click += new System.EventHandler(this.clbAccesorios_SelectedIndexChanged_1);
            this.clbAccesorios.SelectedIndexChanged += new System.EventHandler(this.clbAccesorios_SelectedIndexChanged_1);
            this.clbAccesorios.DoubleClick += new System.EventHandler(this.clbAccesorios_SelectedIndexChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Accesorios Disponibles";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(327, 372);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(129, 15);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "Seleccione cliente!";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(273, 372);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 16);
            this.label14.TabIndex = 32;
            this.label14.Text = "Total:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(276, 400);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(147, 40);
            this.btnConfirmar.TabIndex = 34;
            this.btnConfirmar.Text = "Confirmar Venta";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbltipo1);
            this.groupBox1.Controls.Add(this.lblmodelo1);
            this.groupBox1.Controls.Add(this.lblprecio1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.clbAccesorios);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.cbVehiculos);
            this.groupBox1.Location = new System.Drawing.Point(12, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 196);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblnombre1);
            this.groupBox2.Controls.Add(this.lbltelefono1);
            this.groupBox2.Controls.Add(this.lblmail1);
            this.groupBox2.Controls.Add(this.lbltelefono);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnfiltro);
            this.groupBox2.Controls.Add(this.lblmail);
            this.groupBox2.Controls.Add(this.txtfiltro);
            this.groupBox2.Controls.Add(this.cbClientes);
            this.groupBox2.Location = new System.Drawing.Point(249, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 196);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(108, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 145);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(18, 385);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(193, 55);
            this.txtObservaciones.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Observaciones";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 456);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbVendedor);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtSucursal);
            this.Controls.Add(this.txtIdVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(483, 495);
            this.MinimumSize = new System.Drawing.Size(483, 495);
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Venta";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbVendedor;
        private System.Windows.Forms.Label lblprecio1;
        private System.Windows.Forms.Label lblmodelo1;
        private System.Windows.Forms.Label lbltipo1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbVehiculos;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblmail1;
        private System.Windows.Forms.Label lbltelefono1;
        private System.Windows.Forms.Label lblnombre1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Button btnfiltro;
        private System.Windows.Forms.CheckedListBox clbAccesorios;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label6;
    }
}
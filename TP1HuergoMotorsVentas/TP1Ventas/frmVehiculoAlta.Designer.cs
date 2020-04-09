namespace TP1Ventas
{
    partial class frmVehiculoAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehiculoAlta));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txTipo = new System.Windows.Forms.TextBox();
            this.txId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txModelo = new System.Windows.Forms.TextBox();
            this.nuPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.nuStockDisponible = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuStockDisponible)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id";
            // 
            // txTipo
            // 
            this.txTipo.Location = new System.Drawing.Point(119, 48);
            this.txTipo.MaxLength = 100;
            this.txTipo.Name = "txTipo";
            this.txTipo.Size = new System.Drawing.Size(215, 20);
            this.txTipo.TabIndex = 9;
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(119, 22);
            this.txId.Name = "txId";
            this.txId.ReadOnly = true;
            this.txId.Size = new System.Drawing.Size(100, 20);
            this.txId.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Modelo";
            // 
            // txModelo
            // 
            this.txModelo.Location = new System.Drawing.Point(119, 74);
            this.txModelo.MaxLength = 100;
            this.txModelo.Name = "txModelo";
            this.txModelo.Size = new System.Drawing.Size(215, 20);
            this.txModelo.TabIndex = 14;
            // 
            // nuPrecioVenta
            // 
            this.nuPrecioVenta.DecimalPlaces = 2;
            this.nuPrecioVenta.Location = new System.Drawing.Point(119, 100);
            this.nuPrecioVenta.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nuPrecioVenta.Name = "nuPrecioVenta";
            this.nuPrecioVenta.Size = new System.Drawing.Size(120, 20);
            this.nuPrecioVenta.TabIndex = 16;
            // 
            // nuStockDisponible
            // 
            this.nuStockDisponible.Location = new System.Drawing.Point(119, 126);
            this.nuStockDisponible.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nuStockDisponible.Name = "nuStockDisponible";
            this.nuStockDisponible.Size = new System.Drawing.Size(120, 20);
            this.nuStockDisponible.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Stock Disponible";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(219, 172);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 20;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(300, 172);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 19;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // frmVehiculoAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 209);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.nuStockDisponible);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nuPrecioVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txTipo);
            this.Controls.Add(this.txId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVehiculoAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehículo - Alta o Modificación";
            this.Load += new System.EventHandler(this.frmVehiculoAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuStockDisponible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txTipo;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txModelo;
        private System.Windows.Forms.NumericUpDown nuPrecioVenta;
        private System.Windows.Forms.NumericUpDown nuStockDisponible;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGuardar;
    }
}
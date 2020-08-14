namespace TP1Ventas
{
    partial class frmAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.NUD3 = new System.Windows.Forms.NumericUpDown();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.NUD4 = new System.Windows.Forms.NumericUpDown();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.NUD5 = new System.Windows.Forms.NumericUpDown();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.TLPLabels = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.NUD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD5)).BeginInit();
            this.TLPLabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 11;
            this.label1.Tag = "1";
            this.label1.Text = "Id";
            this.label1.Visible = false;
            this.label1.VisibleChanged += new System.EventHandler(this.lables_ToggleVisible);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 12;
            this.label2.Tag = "2";
            this.label2.Text = "Tipo";
            this.label2.Visible = false;
            this.label2.VisibleChanged += new System.EventHandler(this.lables_ToggleVisible);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 15;
            this.label4.Tag = "4";
            this.label4.Text = "Precio Venta";
            this.label4.Visible = false;
            this.label4.VisibleChanged += new System.EventHandler(this.lables_ToggleVisible);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 13;
            this.label3.Tag = "3";
            this.label3.Text = "Modelo";
            this.label3.Visible = false;
            this.label3.VisibleChanged += new System.EventHandler(this.lables_ToggleVisible);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 17;
            this.label5.Tag = "5";
            this.label5.Text = "Stock Disponible";
            this.label5.Visible = false;
            this.label5.VisibleChanged += new System.EventHandler(this.lables_ToggleVisible);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(119, 22);
            this.txt1.Name = "txt1";
            this.txt1.ReadOnly = true;
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 8;
            this.txt1.Tag = "1t";
            this.txt1.Visible = false;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(119, 48);
            this.txt2.MaxLength = 100;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(215, 20);
            this.txt2.TabIndex = 9;
            this.txt2.Tag = "2t";
            this.txt2.Visible = false;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(119, 74);
            this.txt3.MaxLength = 100;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(215, 20);
            this.txt3.TabIndex = 14;
            this.txt3.Tag = "3t";
            this.txt3.Visible = false;
            // 
            // NUD3
            // 
            this.NUD3.DecimalPlaces = 2;
            this.NUD3.Location = new System.Drawing.Point(119, 75);
            this.NUD3.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUD3.Name = "NUD3";
            this.NUD3.Size = new System.Drawing.Size(120, 20);
            this.NUD3.TabIndex = 21;
            this.NUD3.Tag = "3n";
            this.NUD3.Visible = false;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(119, 100);
            this.txt4.MaxLength = 100;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(215, 20);
            this.txt4.TabIndex = 23;
            this.txt4.Tag = "4t";
            this.txt4.Visible = false;
            // 
            // NUD4
            // 
            this.NUD4.DecimalPlaces = 2;
            this.NUD4.Location = new System.Drawing.Point(119, 100);
            this.NUD4.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUD4.Name = "NUD4";
            this.NUD4.Size = new System.Drawing.Size(120, 20);
            this.NUD4.TabIndex = 16;
            this.NUD4.Tag = "4n";
            this.NUD4.Visible = false;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(119, 126);
            this.txt5.MaxLength = 100;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(215, 20);
            this.txt5.TabIndex = 22;
            this.txt5.Tag = "5t";
            this.txt5.Visible = false;
            // 
            // NUD5
            // 
            this.NUD5.Location = new System.Drawing.Point(119, 126);
            this.NUD5.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUD5.Name = "NUD5";
            this.NUD5.Size = new System.Drawing.Size(120, 20);
            this.NUD5.TabIndex = 18;
            this.NUD5.Tag = "5n";
            this.NUD5.Visible = false;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(71, 172);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 20;
            this.btCancelar.Tag = " ";
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(200, 172);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 19;
            this.btGuardar.Tag = " ";
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // TLPLabels
            // 
            this.TLPLabels.ColumnCount = 1;
            this.TLPLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPLabels.Controls.Add(this.label1, 0, 0);
            this.TLPLabels.Controls.Add(this.label2, 0, 1);
            this.TLPLabels.Controls.Add(this.label3, 0, 2);
            this.TLPLabels.Controls.Add(this.label4, 0, 3);
            this.TLPLabels.Controls.Add(this.label5, 0, 4);
            this.TLPLabels.Location = new System.Drawing.Point(12, 23);
            this.TLPLabels.Name = "TLPLabels";
            this.TLPLabels.RowCount = 5;
            this.TLPLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPLabels.Size = new System.Drawing.Size(101, 123);
            this.TLPLabels.TabIndex = 24;
            this.TLPLabels.Tag = " ";
            // 
            // frmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 212);
            this.Controls.Add(this.NUD3);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.NUD5);
            this.Controls.Add(this.NUD4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.TLPLabels);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(371, 251);
            this.MinimumSize = new System.Drawing.Size(371, 251);
            this.Name = "frmAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta o Modificación";
            this.Load += new System.EventHandler(this.FrmVehiculoAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD5)).EndInit();
            this.TLPLabels.ResumeLayout(false);
            this.TLPLabels.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.NumericUpDown NUD4;
        private System.Windows.Forms.NumericUpDown NUD5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.NumericUpDown NUD3;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TableLayoutPanel TLPLabels;
    }
}
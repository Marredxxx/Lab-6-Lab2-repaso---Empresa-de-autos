namespace Lab_6_Lab2_repaso___Empresa_de_autos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.labelPrecioxKilometro = new System.Windows.Forms.Label();
            this.textBoxPrecioxKilometro = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDatosVehiculo = new System.Windows.Forms.DataGridView();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewAlquiler = new System.Windows.Forms.DataGridView();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonMostrarDatosVehiculo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.buttonMostrarDatosReporte = new System.Windows.Forms.Button();
            this.buttonMostrarAlquilerTop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(469, 33);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(129, 22);
            this.textBoxPlaca.TabIndex = 24;
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Location = new System.Drawing.Point(466, 14);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(42, 16);
            this.labelPlaca.TabIndex = 23;
            this.labelPlaca.Text = "Placa";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(923, 24);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(74, 31);
            this.buttonAgregar.TabIndex = 22;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // labelPrecioxKilometro
            // 
            this.labelPrecioxKilometro.AutoSize = true;
            this.labelPrecioxKilometro.Location = new System.Drawing.Point(772, 14);
            this.labelPrecioxKilometro.Name = "labelPrecioxKilometro";
            this.labelPrecioxKilometro.Size = new System.Drawing.Size(127, 16);
            this.labelPrecioxKilometro.TabIndex = 21;
            this.labelPrecioxKilometro.Text = "Precio por kilómetro";
            // 
            // textBoxPrecioxKilometro
            // 
            this.textBoxPrecioxKilometro.Location = new System.Drawing.Point(770, 33);
            this.textBoxPrecioxKilometro.Name = "textBoxPrecioxKilometro";
            this.textBoxPrecioxKilometro.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrecioxKilometro.TabIndex = 20;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(305, 33);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(129, 22);
            this.textBoxModelo.TabIndex = 19;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(302, 14);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(53, 16);
            this.labelModelo.TabIndex = 18;
            this.labelModelo.Text = "Modelo";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(619, 33);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(129, 22);
            this.textBoxMarca.TabIndex = 17;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(616, 14);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(45, 16);
            this.labelMarca.TabIndex = 16;
            this.labelMarca.Text = "Marca";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(151, 14);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(39, 16);
            this.labelColor.TabIndex = 15;
            this.labelColor.Text = "Color";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(155, 33);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(129, 22);
            this.textBoxColor.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 48);
            this.label1.TabIndex = 13;
            this.label1.Text = "Por favor ingrese \r\nlos datos que se \r\nle solicita: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewDatosVehiculo
            // 
            this.dataGridViewDatosVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatosVehiculo.Location = new System.Drawing.Point(588, 105);
            this.dataGridViewDatosVehiculo.Name = "dataGridViewDatosVehiculo";
            this.dataGridViewDatosVehiculo.RowHeadersWidth = 51;
            this.dataGridViewDatosVehiculo.RowTemplate.Height = 24;
            this.dataGridViewDatosVehiculo.Size = new System.Drawing.Size(536, 143);
            this.dataGridViewDatosVehiculo.TabIndex = 25;
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Location = new System.Drawing.Point(16, 105);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.RowHeadersWidth = 51;
            this.dataGridViewCliente.RowTemplate.Height = 24;
            this.dataGridViewCliente.Size = new System.Drawing.Size(515, 143);
            this.dataGridViewCliente.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(17, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(585, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Datos del Vehículo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(17, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Alquiler";
            // 
            // dataGridViewAlquiler
            // 
            this.dataGridViewAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlquiler.Location = new System.Drawing.Point(16, 286);
            this.dataGridViewAlquiler.Name = "dataGridViewAlquiler";
            this.dataGridViewAlquiler.RowHeadersWidth = 51;
            this.dataGridViewAlquiler.RowTemplate.Height = 24;
            this.dataGridViewAlquiler.Size = new System.Drawing.Size(515, 150);
            this.dataGridViewAlquiler.TabIndex = 30;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(1027, 24);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(88, 31);
            this.buttonGuardar.TabIndex = 31;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonMostrarDatosVehiculo
            // 
            this.buttonMostrarDatosVehiculo.Location = new System.Drawing.Point(1001, 75);
            this.buttonMostrarDatosVehiculo.Name = "buttonMostrarDatosVehiculo";
            this.buttonMostrarDatosVehiculo.Size = new System.Drawing.Size(123, 27);
            this.buttonMostrarDatosVehiculo.TabIndex = 32;
            this.buttonMostrarDatosVehiculo.Text = "Mostrar datos ";
            this.buttonMostrarDatosVehiculo.UseVisualStyleBackColor = true;
            this.buttonMostrarDatosVehiculo.Click += new System.EventHandler(this.buttonMostrarDatosVehiculo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(585, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Reporte";
            // 
            // dataGridViewReporte
            // 
            this.dataGridViewReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReporte.Location = new System.Drawing.Point(588, 286);
            this.dataGridViewReporte.Name = "dataGridViewReporte";
            this.dataGridViewReporte.RowHeadersWidth = 51;
            this.dataGridViewReporte.RowTemplate.Height = 24;
            this.dataGridViewReporte.Size = new System.Drawing.Size(536, 150);
            this.dataGridViewReporte.TabIndex = 34;
            // 
            // buttonMostrarDatosReporte
            // 
            this.buttonMostrarDatosReporte.Location = new System.Drawing.Point(1001, 254);
            this.buttonMostrarDatosReporte.Name = "buttonMostrarDatosReporte";
            this.buttonMostrarDatosReporte.Size = new System.Drawing.Size(123, 27);
            this.buttonMostrarDatosReporte.TabIndex = 35;
            this.buttonMostrarDatosReporte.Text = "Mostrar datos ";
            this.buttonMostrarDatosReporte.UseVisualStyleBackColor = true;
            this.buttonMostrarDatosReporte.Click += new System.EventHandler(this.buttonMostrarDatosReporte_Click);
            // 
            // buttonMostrarAlquilerTop
            // 
            this.buttonMostrarAlquilerTop.BackColor = System.Drawing.SystemColors.Info;
            this.buttonMostrarAlquilerTop.Location = new System.Drawing.Point(368, 469);
            this.buttonMostrarAlquilerTop.Name = "buttonMostrarAlquilerTop";
            this.buttonMostrarAlquilerTop.Size = new System.Drawing.Size(363, 44);
            this.buttonMostrarAlquilerTop.TabIndex = 36;
            this.buttonMostrarAlquilerTop.Text = "Mostrar alquiler que ha recorrido más kilómetros";
            this.buttonMostrarAlquilerTop.UseVisualStyleBackColor = false;
            this.buttonMostrarAlquilerTop.Click += new System.EventHandler(this.buttonMostrarAlquilerTop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 607);
            this.Controls.Add(this.buttonMostrarAlquilerTop);
            this.Controls.Add(this.buttonMostrarDatosReporte);
            this.Controls.Add(this.dataGridViewReporte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonMostrarDatosVehiculo);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.dataGridViewAlquiler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewCliente);
            this.Controls.Add(this.dataGridViewDatosVehiculo);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.labelPlaca);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.labelPrecioxKilometro);
            this.Controls.Add(this.textBoxPrecioxKilometro);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Alquiler de Autos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label labelPrecioxKilometro;
        private System.Windows.Forms.TextBox textBoxPrecioxKilometro;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDatosVehiculo;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewAlquiler;
        private System.Windows.Forms.Button buttonGuardar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonMostrarDatosVehiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewReporte;
        private System.Windows.Forms.Button buttonMostrarDatosReporte;
        private System.Windows.Forms.Button buttonMostrarAlquilerTop;
    }
}


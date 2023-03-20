
namespace Laboratorio6
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
            this.Placa = new System.Windows.Forms.Label();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKms = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGuardarV = new System.Windows.Forms.Button();
            this.dataGridViewVehiculos = new System.Windows.Forms.DataGridView();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewAlquiler = new System.Windows.Forms.DataGridView();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelMasKm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // Placa
            // 
            this.Placa.AutoSize = true;
            this.Placa.Location = new System.Drawing.Point(33, 36);
            this.Placa.Name = "Placa";
            this.Placa.Size = new System.Drawing.Size(34, 13);
            this.Placa.TabIndex = 0;
            this.Placa.Text = "Placa";
            this.Placa.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(125, 36);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(219, 20);
            this.textBoxPlaca.TabIndex = 1;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(125, 66);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(219, 20);
            this.textBoxMarca.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marca";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(125, 98);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(219, 20);
            this.textBoxModelo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modelo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(125, 132);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(219, 20);
            this.textBoxColor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Color";
            // 
            // textBoxKms
            // 
            this.textBoxKms.Location = new System.Drawing.Point(125, 168);
            this.textBoxKms.Name = "textBoxKms";
            this.textBoxKms.Size = new System.Drawing.Size(219, 20);
            this.textBoxKms.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio po km";
            // 
            // buttonGuardarV
            // 
            this.buttonGuardarV.Location = new System.Drawing.Point(73, 227);
            this.buttonGuardarV.Name = "buttonGuardarV";
            this.buttonGuardarV.Size = new System.Drawing.Size(120, 62);
            this.buttonGuardarV.TabIndex = 10;
            this.buttonGuardarV.Text = "Guardar";
            this.buttonGuardarV.UseVisualStyleBackColor = true;
            this.buttonGuardarV.Click += new System.EventHandler(this.buttonGuardarV_Click);
            // 
            // dataGridViewVehiculos
            // 
            this.dataGridViewVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehiculos.Location = new System.Drawing.Point(403, 66);
            this.dataGridViewVehiculos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewVehiculos.Name = "dataGridViewVehiculos";
            this.dataGridViewVehiculos.RowHeadersWidth = 62;
            this.dataGridViewVehiculos.RowTemplate.Height = 28;
            this.dataGridViewVehiculos.Size = new System.Drawing.Size(396, 186);
            this.dataGridViewVehiculos.TabIndex = 11;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(841, 66);
            this.dataGridViewClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowHeadersWidth = 62;
            this.dataGridViewClientes.RowTemplate.Height = 28;
            this.dataGridViewClientes.Size = new System.Drawing.Size(347, 186);
            this.dataGridViewClientes.TabIndex = 12;
            // 
            // dataGridViewAlquiler
            // 
            this.dataGridViewAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlquiler.Location = new System.Drawing.Point(36, 347);
            this.dataGridViewAlquiler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewAlquiler.Name = "dataGridViewAlquiler";
            this.dataGridViewAlquiler.RowHeadersWidth = 62;
            this.dataGridViewAlquiler.RowTemplate.Height = 28;
            this.dataGridViewAlquiler.Size = new System.Drawing.Size(1152, 307);
            this.dataGridViewAlquiler.TabIndex = 13;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(36, 698);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(157, 55);
            this.buttonCalcular.TabIndex = 14;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelMasKm
            // 
            this.labelMasKm.AutoSize = true;
            this.labelMasKm.Location = new System.Drawing.Point(354, 718);
            this.labelMasKm.Name = "labelMasKm";
            this.labelMasKm.Size = new System.Drawing.Size(35, 13);
            this.labelMasKm.TabIndex = 15;
            this.labelMasKm.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 765);
            this.Controls.Add(this.labelMasKm);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.dataGridViewAlquiler);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.dataGridViewVehiculos);
            this.Controls.Add(this.buttonGuardarV);
            this.Controls.Add(this.textBoxKms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.Placa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Placa;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonGuardarV;
        private System.Windows.Forms.DataGridView dataGridViewVehiculos;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.DataGridView dataGridViewAlquiler;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelMasKm;
    }
}


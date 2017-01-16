namespace CARMETRO.Presentacion.estacionamiento
{
    partial class frmEstacionamiento
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.codigotxt = new System.Windows.Forms.TextBox();
            this.posiciontxt = new System.Windows.Forms.TextBox();
            this.horaentradatxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.minutoentrada = new System.Windows.Forms.TextBox();
            this.minutosalidatxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.horasalidatxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pisocmb = new System.Windows.Forms.ComboBox();
            this.vehiculocmb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.valortotallbl = new System.Windows.Forms.Label();
            this.valortxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.descripcioncmb = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DescripcionPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorFacturado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestiónDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Posición :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora Entrada :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora Salida :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // codigotxt
            // 
            this.codigotxt.Location = new System.Drawing.Point(121, 90);
            this.codigotxt.Name = "codigotxt";
            this.codigotxt.Size = new System.Drawing.Size(100, 20);
            this.codigotxt.TabIndex = 7;
            // 
            // posiciontxt
            // 
            this.posiciontxt.Location = new System.Drawing.Point(121, 119);
            this.posiciontxt.Name = "posiciontxt";
            this.posiciontxt.Size = new System.Drawing.Size(100, 20);
            this.posiciontxt.TabIndex = 8;
            // 
            // horaentradatxt
            // 
            this.horaentradatxt.Location = new System.Drawing.Point(380, 126);
            this.horaentradatxt.Name = "horaentradatxt";
            this.horaentradatxt.Size = new System.Drawing.Size(32, 20);
            this.horaentradatxt.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "h";
            // 
            // minutoentrada
            // 
            this.minutoentrada.Location = new System.Drawing.Point(437, 126);
            this.minutoentrada.Name = "minutoentrada";
            this.minutoentrada.Size = new System.Drawing.Size(32, 20);
            this.minutoentrada.TabIndex = 11;
            // 
            // minutosalidatxt
            // 
            this.minutosalidatxt.Location = new System.Drawing.Point(437, 156);
            this.minutosalidatxt.Name = "minutosalidatxt";
            this.minutosalidatxt.Size = new System.Drawing.Size(32, 20);
            this.minutosalidatxt.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "h";
            // 
            // horasalidatxt
            // 
            this.horasalidatxt.Location = new System.Drawing.Point(380, 156);
            this.horasalidatxt.Name = "horasalidatxt";
            this.horasalidatxt.Size = new System.Drawing.Size(32, 20);
            this.horasalidatxt.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Piso :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(277, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Vehiculo :";
            // 
            // pisocmb
            // 
            this.pisocmb.FormattingEnabled = true;
            this.pisocmb.Location = new System.Drawing.Point(346, 56);
            this.pisocmb.Name = "pisocmb";
            this.pisocmb.Size = new System.Drawing.Size(121, 21);
            this.pisocmb.TabIndex = 18;
            // 
            // vehiculocmb
            // 
            this.vehiculocmb.FormattingEnabled = true;
            this.vehiculocmb.Location = new System.Drawing.Point(346, 90);
            this.vehiculocmb.Name = "vehiculocmb";
            this.vehiculocmb.Size = new System.Drawing.Size(121, 21);
            this.vehiculocmb.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(181, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(231, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "TOTAL (CALCULADO) :";
            // 
            // valortotallbl
            // 
            this.valortotallbl.AutoSize = true;
            this.valortotallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valortotallbl.Location = new System.Drawing.Point(424, 192);
            this.valortotallbl.Name = "valortotallbl";
            this.valortotallbl.Size = new System.Drawing.Size(43, 24);
            this.valortotallbl.TabIndex = 21;
            this.valortotallbl.Text = "$$$";
            // 
            // valortxt
            // 
            this.valortxt.Location = new System.Drawing.Point(421, 239);
            this.valortxt.Name = "valortxt";
            this.valortxt.Size = new System.Drawing.Size(78, 20);
            this.valortxt.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(62, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Descripcion del Pago : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(330, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Valor del Pago : ";
            // 
            // descripcioncmb
            // 
            this.descripcioncmb.FormattingEnabled = true;
            this.descripcioncmb.Location = new System.Drawing.Point(185, 239);
            this.descripcioncmb.Name = "descripcioncmb";
            this.descripcioncmb.Size = new System.Drawing.Size(121, 21);
            this.descripcioncmb.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescripcionPago,
            this.ValorFacturado});
            this.dataGridView1.Location = new System.Drawing.Point(65, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 114);
            this.dataGridView1.TabIndex = 26;
            // 
            // DescripcionPago
            // 
            this.DescripcionPago.HeaderText = "Descripcion Pago";
            this.DescripcionPago.Name = "DescripcionPago";
            // 
            // ValorFacturado
            // 
            this.ValorFacturado.HeaderText = "Valor Facturado";
            this.ValorFacturado.Name = "ValorFacturado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Agregar Pago";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Calcular Total y Guardar Información";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeVehiculosToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestiónDeVehiculosToolStripMenuItem
            // 
            this.gestiónDeVehiculosToolStripMenuItem.Name = "gestiónDeVehiculosToolStripMenuItem";
            this.gestiónDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.gestiónDeVehiculosToolStripMenuItem.Text = "Gestión de Vehiculos";
            this.gestiónDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeVehiculosToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            this.reporteToolStripMenuItem.Click += new System.EventHandler(this.reporteToolStripMenuItem_Click);
            // 
            // frmEstacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 476);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.descripcioncmb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.valortxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.valortotallbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.vehiculocmb);
            this.Controls.Add(this.pisocmb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.minutosalidatxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.horasalidatxt);
            this.Controls.Add(this.minutoentrada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.horaentradatxt);
            this.Controls.Add(this.posiciontxt);
            this.Controls.Add(this.codigotxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEstacionamiento";
            this.Text = "|";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox codigotxt;
        private System.Windows.Forms.TextBox posiciontxt;
        private System.Windows.Forms.TextBox horaentradatxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox minutoentrada;
        private System.Windows.Forms.TextBox minutosalidatxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox horasalidatxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox pisocmb;
        private System.Windows.Forms.ComboBox vehiculocmb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label valortotallbl;
        private System.Windows.Forms.TextBox valortxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox descripcioncmb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorFacturado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
    }
}
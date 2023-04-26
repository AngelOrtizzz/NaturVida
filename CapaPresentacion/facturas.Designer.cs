namespace CapaPresentacion
{
    partial class facturas
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFactura = new TextBox();
            txtCantidad = new TextBox();
            dgvFactura = new DataGridView();
            btnGuardar = new Button();
            txtTotal = new TextBox();
            label6 = new Label();
            btnTerminar = new Button();
            cb_cliente = new ComboBox();
            cb_producto = new ComboBox();
            groupBox1 = new GroupBox();
            dtp_FECHA = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 16);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "#FACTURA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 48);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "FECHA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 75);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "CLIENTE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 103);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 3;
            label4.Text = "PRODUCTO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(3, 132);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 4;
            label5.Text = "CANTIDAD";
            // 
            // txtFactura
            // 
            txtFactura.Enabled = false;
            txtFactura.Location = new Point(82, 25);
            txtFactura.Name = "txtFactura";
            txtFactura.Size = new Size(167, 23);
            txtFactura.TabIndex = 5;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(82, 141);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(75, 23);
            txtCantidad.TabIndex = 9;
            // 
            // dgvFactura
            // 
            dgvFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Location = new Point(255, 25);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowTemplate.Height = 25;
            dgvFactura.Size = new Size(527, 174);
            dgvFactura.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(163, 141);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 23);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(674, 197);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(576, 200);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 14;
            label6.Text = "TOTAL FACTURA";
            // 
            // btnTerminar
            // 
            btnTerminar.Location = new Point(6, 223);
            btnTerminar.Name = "btnTerminar";
            btnTerminar.Size = new Size(138, 23);
            btnTerminar.TabIndex = 15;
            btnTerminar.Text = "TERMINAR FACTURA";
            btnTerminar.UseVisualStyleBackColor = true;
            btnTerminar.Click += btnTerminar_Click;
            // 
            // cb_cliente
            // 
            cb_cliente.FormattingEnabled = true;
            cb_cliente.Location = new Point(82, 84);
            cb_cliente.Name = "cb_cliente";
            cb_cliente.Size = new Size(167, 23);
            cb_cliente.TabIndex = 16;
            // 
            // cb_producto
            // 
            cb_producto.FormattingEnabled = true;
            cb_producto.Location = new Point(82, 112);
            cb_producto.Name = "cb_producto";
            cb_producto.Size = new Size(167, 23);
            cb_producto.TabIndex = 17;
            cb_producto.SelectedIndexChanged += cb_producto_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(139, 162, 33);
            groupBox1.Controls.Add(dtp_FECHA);
            groupBox1.Controls.Add(btnTerminar);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(8, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 252);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // dtp_FECHA
            // 
            dtp_FECHA.Location = new Point(74, 42);
            dtp_FECHA.Name = "dtp_FECHA";
            dtp_FECHA.Size = new Size(167, 23);
            dtp_FECHA.TabIndex = 16;
            // 
            // facturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(83, 107, 21);
            ClientSize = new Size(800, 291);
            Controls.Add(cb_producto);
            Controls.Add(cb_cliente);
            Controls.Add(btnGuardar);
            Controls.Add(dgvFactura);
            Controls.Add(txtCantidad);
            Controls.Add(txtFactura);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "facturas";
            Text = "facturas";
            Load += facturas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFactura;
        private TextBox txtCantidad;
        private DataGridView dgvFactura;
        private Button btnGuardar;
        private TextBox txtTotal;
        private Label label6;
        private Button btnTerminar;
        private ComboBox cb_cliente;
        private ComboBox cb_producto;
        private GroupBox groupBox1;
        private DateTimePicker dtp_FECHA;
    }
}
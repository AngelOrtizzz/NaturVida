namespace CapaPresentacion
{
    partial class productos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox9 = new TextBox();
            label11 = new Label();
            tabPage2 = new TabPage();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAgregar = new Button();
            txtCantidad = new TextBox();
            txtValor = new TextBox();
            txtDesc = new TextBox();
            txtCodigo = new TextBox();
            tabPage3 = new TabPage();
            txtEditCodNuevo = new TextBox();
            btnConsultar = new Button();
            btnEditar = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtEditCantidad = new TextBox();
            txtEditValor = new TextBox();
            txtEditDesc = new TextBox();
            txtEditCod = new TextBox();
            Cb_Editar = new ComboBox();
            tabPage4 = new TabPage();
            label10 = new Label();
            btnEliminar = new Button();
            cb_Eliminar = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(756, 225);
            dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 324);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(139, 162, 33);
            tabPage1.Controls.Add(textBox9);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 296);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "CONSULTAR";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(6, 21);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(177, 23);
            textBox9.TabIndex = 3;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 3);
            label11.Name = "label11";
            label11.Size = new Size(116, 15);
            label11.TabIndex = 2;
            label11.Text = "FILTRAR PRODUCTO:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(139, 162, 33);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(btnAgregar);
            tabPage2.Controls.Add(txtCantidad);
            tabPage2.Controls.Add(txtValor);
            tabPage2.Controls.Add(txtDesc);
            tabPage2.Controls.Add(txtCodigo);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 296);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "INSERTAR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(193, 175);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 8;
            label4.Text = "CANTIDAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 137);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 7;
            label3.Text = "VALOR UNIDAD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 100);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 6;
            label2.Text = "DESCRIPCION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 65);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 5;
            label1.Text = "CODIGO";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(358, 211);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 44);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(284, 172);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(281, 23);
            txtCantidad.TabIndex = 3;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(284, 134);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(281, 23);
            txtValor.TabIndex = 2;
            txtValor.TextChanged += txtValor_TextChanged;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(284, 97);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(281, 23);
            txtDesc.TabIndex = 1;
            txtDesc.TextChanged += txtDesc_TextChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(284, 62);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(281, 23);
            txtCodigo.TabIndex = 0;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(139, 162, 33);
            tabPage3.Controls.Add(txtEditCodNuevo);
            tabPage3.Controls.Add(btnConsultar);
            tabPage3.Controls.Add(btnEditar);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(txtEditCantidad);
            tabPage3.Controls.Add(txtEditValor);
            tabPage3.Controls.Add(txtEditDesc);
            tabPage3.Controls.Add(txtEditCod);
            tabPage3.Controls.Add(Cb_Editar);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 296);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "EDITAR";
            // 
            // txtEditCodNuevo
            // 
            txtEditCodNuevo.Location = new Point(279, 59);
            txtEditCodNuevo.Name = "txtEditCodNuevo";
            txtEditCodNuevo.Size = new Size(186, 23);
            txtEditCodNuevo.TabIndex = 12;
            txtEditCodNuevo.Visible = false;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(490, 30);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(97, 23);
            btnConsultar.TabIndex = 11;
            btnConsultar.Text = "CONSULTAR";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(304, 206);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(131, 37);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "GUARDAR CAMBIOS";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(200, 148);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 9;
            label9.Text = "CANTIDAD";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(175, 119);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 8;
            label8.Text = "VALOR UNIDAD";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(184, 90);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 7;
            label7.Text = "DESCRIPCION";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 62);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 6;
            label6.Text = "CODIGO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 33);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 5;
            label5.Text = "PRODUCTO";
            // 
            // txtEditCantidad
            // 
            txtEditCantidad.Location = new Point(279, 145);
            txtEditCantidad.Name = "txtEditCantidad";
            txtEditCantidad.Size = new Size(186, 23);
            txtEditCantidad.TabIndex = 4;
            txtEditCantidad.TextChanged += txtEditCantidad_TextChanged;
            // 
            // txtEditValor
            // 
            txtEditValor.Location = new Point(279, 116);
            txtEditValor.Name = "txtEditValor";
            txtEditValor.Size = new Size(186, 23);
            txtEditValor.TabIndex = 3;
            txtEditValor.TextChanged += txtEditValor_TextChanged;
            // 
            // txtEditDesc
            // 
            txtEditDesc.Location = new Point(279, 87);
            txtEditDesc.Name = "txtEditDesc";
            txtEditDesc.Size = new Size(186, 23);
            txtEditDesc.TabIndex = 2;
            // 
            // txtEditCod
            // 
            txtEditCod.Enabled = false;
            txtEditCod.Location = new Point(279, 59);
            txtEditCod.Name = "txtEditCod";
            txtEditCod.Size = new Size(186, 23);
            txtEditCod.TabIndex = 1;
            // 
            // Cb_Editar
            // 
            Cb_Editar.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Editar.FormattingEnabled = true;
            Cb_Editar.Location = new Point(279, 30);
            Cb_Editar.Name = "Cb_Editar";
            Cb_Editar.Size = new Size(186, 23);
            Cb_Editar.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(139, 162, 33);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(btnEliminar);
            tabPage4.Controls.Add(cb_Eliminar);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(768, 296);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "ELIMINAR";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(198, 109);
            label10.Name = "label10";
            label10.Size = new Size(68, 15);
            label10.TabIndex = 2;
            label10.Text = "PRODUCTO";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(348, 146);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 29);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cb_Eliminar
            // 
            cb_Eliminar.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Eliminar.FormattingEnabled = true;
            cb_Eliminar.Location = new Point(272, 106);
            cb_Eliminar.Name = "cb_Eliminar";
            cb_Eliminar.Size = new Size(271, 23);
            cb_Eliminar.TabIndex = 0;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(83, 107, 21);
            ClientSize = new Size(800, 342);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "productos";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtCantidad;
        private TextBox txtValor;
        private TextBox txtDesc;
        private TextBox txtCodigo;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAgregar;
        private TextBox textBox9;
        private Label label11;
        private Button btnEditar;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtEditCantidad;
        private TextBox txtEditValor;
        private TextBox txtEditDesc;
        private TextBox txtEditCod;
        private ComboBox Cb_Editar;
        private Label label10;
        private Button btnEliminar;
        private ComboBox cb_Eliminar;
        private Button btnConsultar;
        private TextBox txtEditCodNuevo;
        private ErrorProvider errorProvider1;
    }
}
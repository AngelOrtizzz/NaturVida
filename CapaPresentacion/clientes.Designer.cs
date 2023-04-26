namespace CapaPresentacion
{
    partial class clientes
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtFiltro = new TextBox();
            label1 = new Label();
            dgvClientes = new DataGridView();
            tabPage2 = new TabPage();
            btnGuardar = new Button();
            txtCor = new TextBox();
            label6 = new Label();
            txtTel = new TextBox();
            label5 = new Label();
            txtDir = new TextBox();
            label4 = new Label();
            txtNom = new TextBox();
            label3 = new Label();
            txtDoc = new TextBox();
            label2 = new Label();
            tabPage3 = new TabPage();
            btnEditar = new Button();
            btnConsultar = new Button();
            cbEditar = new ComboBox();
            txtEditCor = new TextBox();
            label12 = new Label();
            txtEditTel = new TextBox();
            label11 = new Label();
            txtEditDir = new TextBox();
            label10 = new Label();
            txtEditNom = new TextBox();
            label9 = new Label();
            txtEditDoc = new TextBox();
            label8 = new Label();
            label7 = new Label();
            tabPage4 = new TabPage();
            btnEliminar = new Button();
            cbEliminar = new ComboBox();
            label13 = new Label();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
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
            tabControl1.Size = new Size(776, 318);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(139, 162, 33);
            tabPage1.Controls.Add(txtFiltro);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgvClientes);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 290);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "CONSULTAR";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(6, 21);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(166, 23);
            txtFiltro.TabIndex = 2;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "FILTRAR CLIENTE:";
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(6, 74);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(756, 216);
            dgvClientes.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(139, 162, 33);
            tabPage2.Controls.Add(btnGuardar);
            tabPage2.Controls.Add(txtCor);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txtTel);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtDir);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtNom);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtDoc);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 290);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "AGREGAR";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(340, 202);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 37);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(275, 163);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(295, 23);
            txtCor.TabIndex = 9;
            txtCor.Validating += txtCor_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(204, 166);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 8;
            label6.Text = "CORREO";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(275, 129);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(295, 23);
            txtTel.TabIndex = 7;
            txtTel.TextChanged += txtTel_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 132);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 6;
            label5.Text = "TELEFONO";
            // 
            // txtDir
            // 
            txtDir.Location = new Point(275, 98);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(295, 23);
            txtDir.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 101);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 4;
            label4.Text = "DIRECCION";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(275, 68);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(295, 23);
            txtNom.TabIndex = 3;
            txtNom.TextChanged += txtNom_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 71);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "NOMBRE";
            // 
            // txtDoc
            // 
            txtDoc.Location = new Point(275, 38);
            txtDoc.Name = "txtDoc";
            txtDoc.Size = new Size(295, 23);
            txtDoc.TabIndex = 1;
            txtDoc.TextChanged += txtDoc_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 41);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 0;
            label2.Text = "DOCUMENTO";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(139, 162, 33);
            tabPage3.Controls.Add(btnEditar);
            tabPage3.Controls.Add(btnConsultar);
            tabPage3.Controls.Add(cbEditar);
            tabPage3.Controls.Add(txtEditCor);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(txtEditTel);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(txtEditDir);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(txtEditNom);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(txtEditDoc);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(768, 290);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "EDITAR";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(344, 235);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(93, 30);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(474, 22);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(83, 23);
            btnConsultar.TabIndex = 13;
            btnConsultar.Text = "CONSULTAR";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // cbEditar
            // 
            cbEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEditar.FormattingEnabled = true;
            cbEditar.Location = new Point(324, 23);
            cbEditar.Name = "cbEditar";
            cbEditar.Size = new Size(144, 23);
            cbEditar.TabIndex = 12;
            // 
            // txtEditCor
            // 
            txtEditCor.Location = new Point(324, 196);
            txtEditCor.Name = "txtEditCor";
            txtEditCor.Size = new Size(188, 23);
            txtEditCor.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(246, 199);
            label12.Name = "label12";
            label12.Size = new Size(53, 15);
            label12.TabIndex = 10;
            label12.Text = "CORREO";
            // 
            // txtEditTel
            // 
            txtEditTel.Location = new Point(324, 162);
            txtEditTel.Name = "txtEditTel";
            txtEditTel.Size = new Size(188, 23);
            txtEditTel.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(238, 165);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 8;
            label11.Text = "TELEFONO";
            // 
            // txtEditDir
            // 
            txtEditDir.Location = new Point(324, 129);
            txtEditDir.Name = "txtEditDir";
            txtEditDir.Size = new Size(188, 23);
            txtEditDir.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(234, 132);
            label10.Name = "label10";
            label10.Size = new Size(68, 15);
            label10.TabIndex = 6;
            label10.Text = "DIRECCION";
            // 
            // txtEditNom
            // 
            txtEditNom.Location = new Point(324, 94);
            txtEditNom.Name = "txtEditNom";
            txtEditNom.Size = new Size(188, 23);
            txtEditNom.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(246, 97);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 4;
            label9.Text = "NOMBRE";
            // 
            // txtEditDoc
            // 
            txtEditDoc.Enabled = false;
            txtEditDoc.Location = new Point(324, 59);
            txtEditDoc.Name = "txtEditDoc";
            txtEditDoc.Size = new Size(144, 23);
            txtEditDoc.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(219, 62);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 2;
            label8.Text = "DOCUMENTO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(248, 26);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 0;
            label7.Text = "CLIENTE";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(139, 162, 33);
            tabPage4.Controls.Add(btnEliminar);
            tabPage4.Controls.Add(cbEliminar);
            tabPage4.Controls.Add(label13);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(768, 290);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "ELIMINAR";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(350, 151);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(95, 30);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cbEliminar
            // 
            cbEliminar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEliminar.FormattingEnabled = true;
            cbEliminar.Location = new Point(323, 103);
            cbEliminar.Name = "cbEliminar";
            cbEliminar.Size = new Size(169, 23);
            cbEliminar.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(252, 106);
            label13.Name = "label13";
            label13.Size = new Size(51, 15);
            label13.TabIndex = 0;
            label13.Text = "CLIENTE";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(83, 107, 21);
            ClientSize = new Size(800, 342);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "clientes";
            Text = "clientes";
            Load += clientes_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
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

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dgvClientes;
        private TextBox txtFiltro;
        private Label label1;
        private TextBox txtTel;
        private Label label5;
        private TextBox txtDir;
        private Label label4;
        private TextBox txtNom;
        private Label label3;
        private TextBox txtDoc;
        private Label label2;
        private TextBox txtCor;
        private Label label6;
        private Button btnGuardar;
        private Label label7;
        private TextBox txtEditTel;
        private Label label11;
        private TextBox txtEditDir;
        private Label label10;
        private TextBox txtEditNom;
        private Label label9;
        private TextBox txtEditDoc;
        private Label label8;
        private TextBox txtEditCor;
        private Label label12;
        private Button btnEditar;
        private Button btnConsultar;
        private ComboBox cbEditar;
        private Button btnEliminar;
        private ComboBox cbEliminar;
        private Label label13;
        private ErrorProvider errorProvider1;
    }
}
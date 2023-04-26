namespace CapaPresentacion
{
    partial class vendedores
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtFiltrar = new TextBox();
            label1 = new Label();
            dgvVendedor = new DataGridView();
            tabPage2 = new TabPage();
            btnGuardar = new Button();
            txtNom = new TextBox();
            label5 = new Label();
            txtCon = new TextBox();
            label4 = new Label();
            txtUsu = new TextBox();
            label3 = new Label();
            txtCod = new TextBox();
            label2 = new Label();
            tabPage3 = new TabPage();
            btnEditar = new Button();
            button1 = new Button();
            cbEditar = new ComboBox();
            label10 = new Label();
            txtEditNom = new TextBox();
            label9 = new Label();
            txtEditCon = new TextBox();
            label8 = new Label();
            txtEditUsu = new TextBox();
            label7 = new Label();
            txtEditCod = new TextBox();
            label6 = new Label();
            tabPage4 = new TabPage();
            btnEliminar = new Button();
            cbEliminar = new ComboBox();
            label11 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendedor).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
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
            tabPage1.Controls.Add(txtFiltrar);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgvVendedor);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 290);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "CONSULTAR";
            // 
            // txtFiltrar
            // 
            txtFiltrar.Location = new Point(6, 21);
            txtFiltrar.Name = "txtFiltrar";
            txtFiltrar.Size = new Size(151, 23);
            txtFiltrar.TabIndex = 2;
            txtFiltrar.TextChanged += txtFiltrar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 1;
            label1.Text = "FILTRAR VENDEDOR:";
            // 
            // dgvVendedor
            // 
            dgvVendedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVendedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendedor.Location = new Point(6, 74);
            dgvVendedor.Name = "dgvVendedor";
            dgvVendedor.RowTemplate.Height = 25;
            dgvVendedor.Size = new Size(756, 216);
            dgvVendedor.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(139, 162, 33);
            tabPage2.Controls.Add(btnGuardar);
            tabPage2.Controls.Add(txtNom);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtCon);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtUsu);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtCod);
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
            btnGuardar.Location = new Point(353, 209);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 38);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(313, 168);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(185, 23);
            txtNom.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(232, 171);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 6;
            label5.Text = "NOMBRE";
            // 
            // txtCon
            // 
            txtCon.Location = new Point(313, 126);
            txtCon.Name = "txtCon";
            txtCon.Size = new Size(185, 23);
            txtCon.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 129);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 4;
            label4.Text = "CONTRASEÑA";
            // 
            // txtUsu
            // 
            txtUsu.Location = new Point(313, 84);
            txtUsu.Name = "txtUsu";
            txtUsu.Size = new Size(185, 23);
            txtUsu.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 87);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "USUARIO";
            // 
            // txtCod
            // 
            txtCod.Location = new Point(313, 44);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(185, 23);
            txtCod.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 47);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 0;
            label2.Text = "CODIGO";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(139, 162, 33);
            tabPage3.Controls.Add(btnEditar);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(cbEditar);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(txtEditNom);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(txtEditCon);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(txtEditUsu);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(txtEditCod);
            tabPage3.Controls.Add(label6);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 290);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "EDITAR";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(325, 227);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 28);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(478, 33);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 10;
            button1.Text = "CONSULTAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbEditar
            // 
            cbEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEditar.FormattingEnabled = true;
            cbEditar.Location = new Point(308, 34);
            cbEditar.Name = "cbEditar";
            cbEditar.Size = new Size(147, 23);
            cbEditar.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(229, 37);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 8;
            label10.Text = "VENDEDOR";
            // 
            // txtEditNom
            // 
            txtEditNom.Location = new Point(308, 182);
            txtEditNom.Name = "txtEditNom";
            txtEditNom.Size = new Size(147, 23);
            txtEditNom.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(240, 185);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 6;
            label9.Text = "NOMBRE";
            // 
            // txtEditCon
            // 
            txtEditCon.Enabled = false;
            txtEditCon.Location = new Point(308, 146);
            txtEditCon.Name = "txtEditCon";
            txtEditCon.Size = new Size(147, 23);
            txtEditCon.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(213, 149);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 4;
            label8.Text = "CONTRASEÑA";
            // 
            // txtEditUsu
            // 
            txtEditUsu.Location = new Point(308, 109);
            txtEditUsu.Name = "txtEditUsu";
            txtEditUsu.Size = new Size(147, 23);
            txtEditUsu.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(244, 112);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 2;
            label7.Text = "USUARIO";
            // 
            // txtEditCod
            // 
            txtEditCod.Enabled = false;
            txtEditCod.Location = new Point(308, 73);
            txtEditCod.Name = "txtEditCod";
            txtEditCod.Size = new Size(147, 23);
            txtEditCod.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(244, 76);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 0;
            label6.Text = "CODIGO";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(139, 162, 33);
            tabPage4.Controls.Add(btnEliminar);
            tabPage4.Controls.Add(cbEliminar);
            tabPage4.Controls.Add(label11);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(768, 290);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "ELIMINAR";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(333, 147);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(107, 32);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cbEliminar
            // 
            cbEliminar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEliminar.FormattingEnabled = true;
            cbEliminar.Location = new Point(295, 100);
            cbEliminar.Name = "cbEliminar";
            cbEliminar.Size = new Size(180, 23);
            cbEliminar.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(214, 103);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 0;
            label11.Text = "VENDEDOR";
            // 
            // vendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(83, 107, 21);
            ClientSize = new Size(800, 342);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "vendedores";
            Text = "vendedores";
            Load += vendedores_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendedor).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvVendedor;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox txtFiltrar;
        private Label label1;
        private TextBox txtNom;
        private Label label5;
        private TextBox txtCon;
        private Label label4;
        private TextBox txtUsu;
        private Label label3;
        private TextBox txtCod;
        private Label label2;
        private Button btnGuardar;
        private Button btnEditar;
        private Button button1;
        private ComboBox cbEditar;
        private Label label10;
        private TextBox txtEditNom;
        private Label label9;
        private TextBox txtEditCon;
        private Label label8;
        private TextBox txtEditUsu;
        private Label label7;
        private TextBox txtEditCod;
        private Label label6;
        private Button btnEliminar;
        private ComboBox cbEliminar;
        private Label label11;
    }
}
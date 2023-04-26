namespace CapaPresentacion
{
    partial class inventario
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
            DgvInventario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvInventario).BeginInit();
            SuspendLayout();
            // 
            // DgvInventario
            // 
            DgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvInventario.Location = new Point(12, 12);
            DgvInventario.Name = "DgvInventario";
            DgvInventario.RowTemplate.Height = 25;
            DgvInventario.Size = new Size(776, 318);
            DgvInventario.TabIndex = 0;
            // 
            // inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 342);
            Controls.Add(DgvInventario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "inventario";
            Text = "inventario";
            Load += inventario_Load;
            ((System.ComponentModel.ISupportInitialize)DgvInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvInventario;
    }
}
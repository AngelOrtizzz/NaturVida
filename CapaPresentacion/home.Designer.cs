namespace CapaPresentacion
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            menuStrip1 = new MenuStrip();
            pRODUCTOSToolStripMenuItem = new ToolStripMenuItem();
            cLIENTESToolStripMenuItem = new ToolStripMenuItem();
            vENDEDORESToolStripMenuItem = new ToolStripMenuItem();
            fACTURAToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            iNVENTARIOToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { pRODUCTOSToolStripMenuItem, cLIENTESToolStripMenuItem, vENDEDORESToolStripMenuItem, fACTURAToolStripMenuItem, iNVENTARIOToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // pRODUCTOSToolStripMenuItem
            // 
            pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem";
            pRODUCTOSToolStripMenuItem.Size = new Size(86, 20);
            pRODUCTOSToolStripMenuItem.Text = "PRODUCTOS";
            pRODUCTOSToolStripMenuItem.Click += pRODUCTOSToolStripMenuItem_Click;
            // 
            // cLIENTESToolStripMenuItem
            // 
            cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            cLIENTESToolStripMenuItem.Size = new Size(69, 20);
            cLIENTESToolStripMenuItem.Text = "CLIENTES";
            cLIENTESToolStripMenuItem.Click += cLIENTESToolStripMenuItem_Click;
            // 
            // vENDEDORESToolStripMenuItem
            // 
            vENDEDORESToolStripMenuItem.Name = "vENDEDORESToolStripMenuItem";
            vENDEDORESToolStripMenuItem.Size = new Size(91, 20);
            vENDEDORESToolStripMenuItem.Text = "VENDEDORES";
            vENDEDORESToolStripMenuItem.Click += vENDEDORESToolStripMenuItem_Click;
            // 
            // fACTURAToolStripMenuItem
            // 
            fACTURAToolStripMenuItem.Name = "fACTURAToolStripMenuItem";
            fACTURAToolStripMenuItem.Size = new Size(69, 20);
            fACTURAToolStripMenuItem.Text = "FACTURA";
            fACTURAToolStripMenuItem.Click += fACTURAToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 342);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(202, 44);
            label1.Name = "label1";
            label1.Size = new Size(397, 72);
            label1.TabIndex = 2;
            label1.Text = "NATURVIDA";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(794, 336);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // iNVENTARIOToolStripMenuItem
            // 
            iNVENTARIOToolStripMenuItem.Name = "iNVENTARIOToolStripMenuItem";
            iNVENTARIOToolStripMenuItem.Size = new Size(85, 20);
            iNVENTARIOToolStripMenuItem.Text = "INVENTARIO";
            iNVENTARIOToolStripMenuItem.Click += iNVENTARIOToolStripMenuItem_Click;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 370);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NATURVIDA";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pRODUCTOSToolStripMenuItem;
        private ToolStripMenuItem fACTURAToolStripMenuItem;
        private ToolStripMenuItem cLIENTESToolStripMenuItem;
        private ToolStripMenuItem vENDEDORESToolStripMenuItem;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem iNVENTARIOToolStripMenuItem;
    }
}
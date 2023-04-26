using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        #region metodos
        private void CargarForm(Form NuevoFormulario)
        {
            this.panel1.Controls.Clear();
            NuevoFormulario.TopLevel = false;
            NuevoFormulario.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(NuevoFormulario);
            NuevoFormulario.Show();
        }
        #endregion

        public void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarForm(new productos());
        }

        private void fACTURAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarForm(new facturas());
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarForm(new clientes());
        }

        private void vENDEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarForm(new vendedores());
        }

        private void iNVENTARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarForm(new inventario());
        }
    }
}

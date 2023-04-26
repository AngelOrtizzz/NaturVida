using CapaNegocio;
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
    public partial class inventario : Form
    {
        cn_inventario ocn_inventario = new cn_inventario();
        public inventario()
        {
            InitializeComponent();
        }

        private void inventario_Load(object sender, EventArgs e)
        {
            DgvInventario.DataSource = ocn_inventario.MostrarInv();
        }
    }
}

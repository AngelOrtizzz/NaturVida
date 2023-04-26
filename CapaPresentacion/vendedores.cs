using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using Org.BouncyCastle.Crypto;
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
    public partial class vendedores : Form
    {
        cn_vendedores ocn_vendedores = new cn_vendedores();
        cn_encriptar encrypt = new cn_encriptar();
        ce_vendedores cevendedor = new ce_vendedores();
        string idpro = null;
        public vendedores()
        {
            InitializeComponent();
        }
        #region metodos
        public void Mostrar()
        {
            dgvVendedor.DataSource = ocn_vendedores.MostrarVendedores();
        }
        #endregion

        private void vendedores_Load(object sender, EventArgs e)
        {
            cbEditar.DataSource = ocn_vendedores.MostrarVendedores();
            cbEditar.ValueMember = "Codigo";
            cbEditar.DisplayMember = "Codigo";

            cbEliminar.DataSource = ocn_vendedores.MostrarVendedores();
            cbEliminar.ValueMember = "Codigo";
            cbEliminar.DisplayMember = "Usuario";

            Mostrar();
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltrar.Text;

            ((DataTable)dgvVendedor.DataSource).DefaultView.RowFilter = string.Format("Usuario LIKE '%{0}%'", filtro);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cevendedor.Codigo = Convert.ToInt32(txtCod.Text);
            cevendedor.Usuario = txtUsu.Text;
            cevendedor.Contraseña = encrypt.HashPassword(txtCon.Text);
            cevendedor.Nombre = txtNom.Text;
            ocn_vendedores.InsertarVen(cevendedor);
            Mostrar();
            MessageBox.Show("Se Guardo Correctamente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbEditar.SelectedIndex >= 0)
            {
                txtEditCod.Text = dgvVendedor.CurrentRow.Cells["Codigo"].Value.ToString();
                txtEditUsu.Text = dgvVendedor.CurrentRow.Cells["Usuario"].Value.ToString();
                txtEditCon.Text = dgvVendedor.CurrentRow.Cells["Contraseña"].Value.ToString();
                txtEditNom.Text = dgvVendedor.CurrentRow.Cells["Nombre"].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cevendedor.Codigo = Convert.ToInt32(cbEditar.Text);
            cevendedor.NuevoCodigo = Convert.ToInt32(txtEditCod.Text);
            cevendedor.Usuario = txtEditUsu.Text;
            cevendedor.Contraseña = txtEditCon.Text;
            cevendedor.Nombre = txtEditNom.Text;
            ocn_vendedores.EditarVen(cevendedor);
            Mostrar();
            MessageBox.Show("Se Edito Correctamente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbEliminar.SelectedIndex >= 0)
            {
                idpro = dgvVendedor.CurrentRow.Cells["Codigo"].Value.ToString();
                cevendedor.Codigo = Convert.ToInt32(idpro);
                ocn_vendedores.EliminarVen(cevendedor);
                Mostrar();
                MessageBox.Show("Se Elimino Correctamente");
            }
        }
    }
}

using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace CapaPresentacion
{
    public partial class clientes : Form
    {
        cn_clientes ocn_clientes = new cn_clientes();
        ce_cliente ceclientes = new ce_cliente();
        string idpro = null;
        public clientes()
        {
            InitializeComponent();
        }
        #region metodos
        public void Mostrar()
        {
            dgvClientes.DataSource = ocn_clientes.MostrarClientes();
        }
        private void SoloNumeros(object sender)//recibo un objeto llamado cosa
        {
            TextBox caja = sender as TextBox; //convierto la cosa a textbox y lo guardo en una variable llamada caja
            foreach (char x in caja.Text) //recorro el contenido de la caja que seria el textbox 
            {
                if (!char.IsDigit(x)) //si no es un digito, avisar el error
                {
                    errorProvider1.SetError(caja, "Solo números.");//muestra el error al lado del textbox
                    btnGuardar.Enabled = false;
                    break;//rompe el ciclo
                }
                else
                    errorProvider1.SetError(caja, "");//si es digito no muestra error
                    btnGuardar.Enabled = true;
            }
        }
        private void SoloCaracter(object sender)
        {
            TextBox caja = sender as TextBox;
            foreach (char x in caja.Text)
            {
                if (char.IsDigit(x))
                {
                    errorProvider1.SetError(caja, "Este campo no puede contener números.");
                    btnGuardar.Enabled = false;
                    break;
                }
                else
                {
                    errorProvider1.SetError(caja, "");
                    btnGuardar.Enabled = true;
                }
            }

        }
        #endregion

        private void clientes_Load(object sender, EventArgs e)
        {
            cbEditar.DataSource = ocn_clientes.MostrarClientes();
            cbEditar.ValueMember = "Documento";
            cbEditar.DisplayMember = "Documento";

            cbEliminar.DataSource = ocn_clientes.MostrarClientes();
            cbEliminar.ValueMember = "Documento";
            cbEliminar.DisplayMember = "Documento";

            Mostrar();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text;

            ((DataTable)dgvClientes.DataSource).DefaultView.RowFilter = string.Format("Nombre LIKE '%{0}%'", filtro);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDoc.Text == "" || txtNom.Text == "" || txtDir.Text == "" || txtTel.Text == "" || txtCor.Text == "")
            {
                MessageBox.Show("Algunos campos estan vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ceclientes.Documento = Convert.ToInt32(txtDoc.Text);
                ceclientes.Nombre = txtNom.Text;
                ceclientes.Direccion = txtDir.Text;
                ceclientes.Telefono = txtTel.Text;
                ceclientes.Correo = txtCor.Text;
                ocn_clientes.InsertarClient(ceclientes);
                Mostrar();
                MessageBox.Show("Se Guardo Correctamente");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cbEditar.SelectedIndex >= 0)
            {
                txtEditDoc.Text = dgvClientes.CurrentRow.Cells["Documento"].Value.ToString();
                txtEditNom.Text = dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtEditDir.Text = dgvClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                txtEditTel.Text = dgvClientes.CurrentRow.Cells["Telefono"].Value.ToString();
                txtEditCor.Text = dgvClientes.CurrentRow.Cells["Correo"].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtEditNom.Text == "" || txtEditDir.Text == "" || txtEditTel.Text == "" || txtEditCor.Text == "")
            {
                MessageBox.Show("Algunos campos estan vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ceclientes.Documento = Convert.ToInt32(cbEditar.Text);
                ceclientes.NuevoDocumento = Convert.ToInt32(txtEditDoc.Text);
                ceclientes.Nombre = txtEditNom.Text;
                ceclientes.Direccion = txtEditDir.Text;
                ceclientes.Telefono = txtEditTel.Text;
                ceclientes.Correo = txtEditCor.Text;
                ocn_clientes.EditarClient(ceclientes);
                Mostrar();
                MessageBox.Show("Se Edito Correctamente");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbEliminar.SelectedIndex >= 0)
            {
                idpro = dgvClientes.CurrentRow.Cells["Documento"].Value.ToString();
                ceclientes.Documento = Convert.ToInt32(idpro);
                ocn_clientes.EliminarClient(ceclientes);
                Mostrar();
                MessageBox.Show("Se Elimino Correctamente");
            }
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            SoloNumeros(sender);
        }

        private void txtDoc_TextChanged(object sender, EventArgs e)
        {
            SoloNumeros(sender);
        }

        private void txtCor_Validating(object sender, CancelEventArgs e)
        {
            string correoElectronico = txtCor.Text;
            string patronCorreo = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}$";
            bool esCorreoValido = Regex.IsMatch(correoElectronico, patronCorreo);

            if (!esCorreoValido)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCor, "El correo electrónico no es válido.");
                btnGuardar.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(txtCor, "");
                btnGuardar.Enabled = true;
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            SoloCaracter(sender);
        }
    }
}

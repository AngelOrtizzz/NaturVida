using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class productos : Form
    {
        public productos()
        {
            InitializeComponent();
        }
        cn_producto ocn_producto = new cn_producto();
        ce_producto ceproducto = new ce_producto();
        cd_conexiom conexionDB = new cd_conexiom();
        string idpro = null;
        string valorUnidad = null;
        #region metodos
        private void mostrar()
        {
            dataGridView1.DataSource = ocn_producto.MostrarProd();
        }

        private void SoloNumeros(object sender)//recibo un objeto llamado cosa
        {
            TextBox caja = sender as TextBox; //convierto la cosa a textbox y lo guardo en una variable llamada caja
            foreach (char x in caja.Text) //recorro el contenido de la caja que seria el textbox 
            {
                if (!char.IsDigit(x)) //si no es un digito, avisar el error
                {
                    errorProvider1.SetError(caja, "Solo números.");//muestra el error al lado del textbox
                    btnAgregar.Enabled = false;
                    break;//rompe el ciclo
                }
                else
                    errorProvider1.SetError(caja, "");//si es digito no muestra error
                btnAgregar.Enabled = true;
            }
        }

        private bool ValidarProducto(string descripcion)
        {
            bool productoValido = true;
            using (SqlConnection conexion = new SqlConnection("Server= (Local); DataBase= NaturVida; Integrated Security= true"))
            {
                string consulta = "SELECT Descripción FROM Productos WHERE Descripción = @descripcion";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                try
                {
                    conexion.Open();
                    SqlDataReader leer = comando.ExecuteReader();
                    if (leer.HasRows)
                    {
                        productoValido = false;
                    }
                    leer.Close();
                }
                catch (Exception ex)
                {
                    //Aquí puedes manejar el error de conexión a la base de datos como desees.
                }
            }
            return productoValido;
        }
        private bool ValidarCodigo(string codigo)
        {
            bool codigoValido = true;
            using (SqlConnection conexion = new SqlConnection("Server= (Local); DataBase= NaturVida; Integrated Security= true"))
            {
                string consulta = "SELECT Codigo FROM Productos WHERE Codigo = @codigo";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@codigo", codigo);
                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        codigoValido = false;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    //Aquí puedes manejar el error de conexión a la base de datos como desees.
                }
            }
            return codigoValido;
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {

            Cb_Editar.DataSource = ocn_producto.MostrarProd();
            Cb_Editar.ValueMember = "Codigo";
            Cb_Editar.DisplayMember = "Descripción";

            cb_Eliminar.DataSource = ocn_producto.MostrarProd();
            cb_Eliminar.ValueMember = "Codigo";
            cb_Eliminar.DisplayMember = "Descripción";
            mostrar();

            valorUnidad = dataGridView1.CurrentRow.Cells["Valor_Unidad"].Value.ToString();
            ce_global.ValorUnidad = Convert.ToInt32(valorUnidad);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtDesc.Text == "" || txtValor.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Algunos campos estan vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ceproducto.Codigo = Convert.ToInt32(txtCodigo.Text);
                ceproducto.Descripción = txtDesc.Text;
                ceproducto.Valor_Unidad = Convert.ToInt32(txtValor.Text);
                ceproducto.Cantidad = Convert.ToInt32(txtCantidad.Text);
                ocn_producto.InsertarProd(ceproducto);
                mostrar();
                MessageBox.Show("Se Guardo Correctamente");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtEditDesc.Text == "" || txtEditValor.Text == "" || txtEditCantidad.Text == "")
            {
                MessageBox.Show("Algunos campos estan vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ceproducto.Codigo = Convert.ToInt32(txtEditCod.Text);
                ceproducto.NuevoCodigo = Convert.ToInt32(txtEditCodNuevo.Text);
                ceproducto.Descripción = txtEditDesc.Text;
                ceproducto.Valor_Unidad = Convert.ToInt32(txtEditValor.Text);
                ceproducto.Cantidad = Convert.ToInt32(txtEditCantidad.Text);
                ocn_producto.EditarProd(ceproducto);
                mostrar();
                MessageBox.Show("Se Edito Correctamente");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (Cb_Editar.SelectedIndex >= 0)
            {
                txtEditCod.Text = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                txtEditCodNuevo.Text = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                txtEditDesc.Text = dataGridView1.CurrentRow.Cells["Descripción"].Value.ToString();
                txtEditValor.Text = dataGridView1.CurrentRow.Cells["Valor_Unidad"].Value.ToString();
                txtEditCantidad.Text = dataGridView1.CurrentRow.Cells["Cantidad"].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (cb_Eliminar.SelectedIndex >= 0)
            {
                idpro = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                ceproducto.Codigo = Convert.ToInt32(idpro);
                ocn_producto.EliminarProd(ceproducto);
                mostrar();
                MessageBox.Show("Se Elimino Correctamente");
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBox9.Text;

            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("Descripción LIKE '%{0}%'", filtro);
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            SoloNumeros(sender);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            SoloNumeros(sender);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            bool productoValido = ValidarCodigo(textBox.Text);
            if (!productoValido)
            {
                errorProvider1.SetError(textBox, "El Código ya existe.");
                btnAgregar.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(textBox, "");
                btnAgregar.Enabled = true;
                SoloNumeros(sender);
            }

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            bool productoValido = ValidarProducto(textBox.Text);
            if (!productoValido)
            {
                errorProvider1.SetError(textBox, "La Descripción ya existe.");
                btnAgregar.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(textBox, "");
                btnAgregar.Enabled = true;
            }
        }

        private void txtEditCantidad_TextChanged(object sender, EventArgs e)
        {
            SoloNumeros(sender);
        }

        private void txtEditValor_TextChanged(object sender, EventArgs e)
        {
            SoloNumeros(sender);
        }
    }
}
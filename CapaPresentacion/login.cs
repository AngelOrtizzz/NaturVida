using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        cn_encriptar encrypt = new cn_encriptar();
        DataTable tabla = new DataTable();
        #region metodos
        public void logins()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("Server= (Local); DataBase= NaturVida; Integrated Security= true"))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Usuario, Contraseña FROM Vendedores WHERE Usuario='" + txtUsuario.Text + "' AND Contraseña='" + encrypt.HashPassword(txtContraseña.Text) + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            CodigoVendedor();
                            home FORMHome = new home();
                            FORMHome.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contraseña incorrecta.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void CodigoVendedor()
        {
            using (SqlConnection conexion = new SqlConnection("Server= (Local); DataBase= NaturVida; Integrated Security= true"))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Vendedores WHERE Usuario='{txtUsuario.Text}'", conexion);
                {
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    ce_global.Codigo = Convert.ToInt32(tabla.Rows[0][0]);
                }
            }

        }
        #endregion

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            logins();

        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que el sonido de Windows suene al presionar Enter
                btnIngresar.PerformClick(); // Presiona el botón deseado
            }
        }
    }
}

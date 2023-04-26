using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class cd_vendedores
    {
        cd_conexiom conexion = new cd_conexiom();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        public DataTable MostrarVen()
        {
            tabla.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Vendedores";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void AGREGARVENDEDORES(ce_vendedores cevendedor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_INSERTARVENDEDOR";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cod", cevendedor.Codigo);
            comando.Parameters.AddWithValue("@Usuario", cevendedor.Usuario);
            comando.Parameters.AddWithValue("@Contrasena", cevendedor.Contraseña);
            comando.Parameters.AddWithValue("@Nombre", cevendedor.Nombre);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EDITARVENDEDORES(ce_vendedores cevendedor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ACTUALIZARVEN";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cod", cevendedor.Codigo);
            comando.Parameters.AddWithValue("@CodNew", cevendedor.NuevoCodigo);
            comando.Parameters.AddWithValue("@Usuario", cevendedor.Usuario);
            comando.Parameters.AddWithValue("@Contrasena", cevendedor.Contraseña);
            comando.Parameters.AddWithValue("@Nombre", cevendedor.Nombre);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void ELIMINARVENDEDORES(ce_vendedores cevendedor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ELIMINARVEN";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cod", cevendedor.Codigo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}

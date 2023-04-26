using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class cd_producto
    {
        cd_conexiom conexion = new cd_conexiom();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        public DataTable mostrarproducto()
        {
            comando.Parameters.Clear();
            tabla.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_MOSTRARPRODUCT";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
            
        }
        public void insertarproducto(ce_producto ceproducto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_INSERTARPRODUCT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo", ceproducto.Codigo);
            comando.Parameters.AddWithValue("@Descri", ceproducto.Descripción);
            comando.Parameters.AddWithValue("@ValUnd", ceproducto.Valor_Unidad);
            comando.Parameters.AddWithValue("@Cantida", ceproducto.Cantidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void editarproducto(ce_producto ceproducto)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ACTUALIZARPROD";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cod", ceproducto.Codigo);
            comando.Parameters.AddWithValue("@CodNew", ceproducto.NuevoCodigo);
            comando.Parameters.AddWithValue("@Descri", ceproducto.Descripción);
            comando.Parameters.AddWithValue("@ValUnd", ceproducto.Valor_Unidad);
            comando.Parameters.AddWithValue("@Cant", ceproducto.Cantidad);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
        public void eliminarproducto(ce_producto ceproducto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ELIMINARPROD";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cod", ceproducto.Codigo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}

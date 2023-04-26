using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaDatos
{
    public class cd_clientes
    {
        cd_conexiom conexion = new cd_conexiom();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        public DataTable MOSTRARCLIENTES()
        {
            tabla.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Cliente";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void AGREGARCLIENTES(ce_cliente ceclientes)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_INSERTARCLIENT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Docu", ceclientes.Documento);
            comando.Parameters.AddWithValue("@Nombre", ceclientes.Nombre);
            comando.Parameters.AddWithValue("@Direccion", ceclientes.Direccion);
            comando.Parameters.AddWithValue("@Tel", ceclientes.Telefono);
            comando.Parameters.AddWithValue("@Corr", ceclientes.Correo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EDITARCLIENTES(ce_cliente ceclientes)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ACTUALCLIENT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Docu", ceclientes.Documento);
            comando.Parameters.AddWithValue("@DocuNew", ceclientes.NuevoDocumento);
            comando.Parameters.AddWithValue("@Nombre", ceclientes.Nombre);
            comando.Parameters.AddWithValue("@Direccion", ceclientes.Direccion);
            comando.Parameters.AddWithValue("@Tel", ceclientes.Telefono);
            comando.Parameters.AddWithValue("@Corr", ceclientes.Correo);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
        public void ELIMINARCLIENTES(ce_cliente ceclientes)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ELIMINARCLIENT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Docu", ceclientes.Documento);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class cd_inventario
    {
        DataTable tabla = new DataTable();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        cd_conexiom conexion = new cd_conexiom();

        public DataTable MOSTRARINVENTARIO()
        {
            comando.Parameters.Clear();
            tabla.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_BUSCARINVENTARIOS";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

    }
}

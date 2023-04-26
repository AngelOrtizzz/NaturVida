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
    public class cd_factura
    {
        cd_conexiom conexion = new cd_conexiom();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        public void crearFactura(ce_factura ceproducto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_AGGFACT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Fech", ceproducto.Fecha);
            comando.Parameters.AddWithValue("@DoClient", ceproducto.Documento_Cliente);
            comando.Parameters.AddWithValue("@CodVende", ceproducto.Codigo_Vendedor);            
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void AggFacturaDetalle(ce_detallefac ceproducto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_AGGFACTDETA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDFac", ceproducto.Numero_Factura);
            comando.Parameters.AddWithValue("@CodProd", ceproducto.Codigo_Productos);
            comando.Parameters.AddWithValue("@Cant", ceproducto.Cantidad);
            comando.Parameters.AddWithValue("@ValUnidad", ceproducto.Valor_Unidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion(); 
        }
        public DataTable MOSTRARFACTURA()
        {
            tabla.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Factura";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void Autonumerico()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT MAX(IdFactu) FROM Factura";
            comando.CommandType = CommandType.Text;
            object resultado = comando.ExecuteScalar();
            if (resultado != DBNull.Value && resultado != null)
            {
                ce_global.AutoNUM = Convert.ToInt32(resultado) + 1;
            }
            else
            {
                ce_global.AutoNUM = 1;
            }
        }

    }
}

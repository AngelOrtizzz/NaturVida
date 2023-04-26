using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class cd_conexiom
    {
        private SqlConnection conexion = new SqlConnection("Data Source=SQL5110.site4now.net;Initial Catalog=db_a983f1_naturvida1;User Id=db_a983f1_naturvida1_admin;Password=**Liebre777");
        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
               return conexion;
        }
            
    }
}

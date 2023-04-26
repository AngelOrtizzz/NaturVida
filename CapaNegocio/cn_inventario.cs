using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class cn_inventario
    {
        cd_inventario ocd_inventario = new cd_inventario();
        public DataTable MostrarInv()
        {
            return ocd_inventario.MOSTRARINVENTARIO();
        }
    }
}

using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class cn_vendedores
    {
        cd_vendedores ocd_vendedores = new cd_vendedores();
        public DataTable MostrarVendedores()
        {
            return ocd_vendedores.MostrarVen();
        }
        public void InsertarVen(ce_vendedores cevendedor)
        {
            ocd_vendedores.AGREGARVENDEDORES(cevendedor);
        }
        public void EditarVen(ce_vendedores cevendedor)
        {
            ocd_vendedores.EDITARVENDEDORES(cevendedor);
        }
        public void EliminarVen(ce_vendedores cevendedor)
        {
            ocd_vendedores.ELIMINARVENDEDORES(cevendedor);
        }
    }
}

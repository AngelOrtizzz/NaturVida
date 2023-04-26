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
    public class cn_producto
    {
        cd_producto ocd_producto = new cd_producto();
        public DataTable MostrarProd()
        {          
            return ocd_producto.mostrarproducto();
        }
        public void InsertarProd(ce_producto ceproducto)
        {
            ocd_producto.insertarproducto(ceproducto);
        }
        public void EditarProd(ce_producto ceproducto)
        {
            ocd_producto.editarproducto(ceproducto);
        }
        public void EliminarProd(ce_producto ceproducto)
        {
            ocd_producto.eliminarproducto(ceproducto);
        }
    }
}

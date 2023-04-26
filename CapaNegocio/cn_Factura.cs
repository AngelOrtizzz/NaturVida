using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;
namespace CapaNegocio
{
    public class cn_Factura
    {
        cd_factura factura= new cd_factura(); 
        cd_clientes clientes= new cd_clientes();
        public void CrearFactura(ce_factura ce_Factura)
        {
            factura.crearFactura(ce_Factura);
        }
        public void FacturaDetalle(ce_detallefac ce_factura)
        {
            factura.AggFacturaDetalle(ce_factura);
        }
        public DataTable MostarClientes()
        {
            return clientes.MOSTRARCLIENTES();
        }
        public DataTable MostrarFactura()
        {
            return factura.MOSTRARFACTURA();
        }
        public void AutoNUMERICO()
        {
            factura.Autonumerico();
        }
    }
}

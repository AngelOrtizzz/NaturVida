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
    public class cn_clientes
    {
        cd_clientes ocd_clientes = new cd_clientes();
        public DataTable MostrarClientes()
        {
            return ocd_clientes.MOSTRARCLIENTES();
        }
        public void InsertarClient(ce_cliente ceclientes)
        {
            ocd_clientes.AGREGARCLIENTES(ceclientes);
        }
        public void EditarClient(ce_cliente ceclientes)
        {
            ocd_clientes.EDITARCLIENTES(ceclientes);
        }
        public void EliminarClient(ce_cliente ceclientes)
        {
            ocd_clientes.ELIMINARCLIENTES(ceclientes);
        }
    }
}

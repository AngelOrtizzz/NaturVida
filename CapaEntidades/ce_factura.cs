using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ce_factura
    {
        public int IdFactu {get;set;}
        public DateTime Fecha { get;set;}
        public int Documento_Cliente { get;set;}
        public int Codigo_Vendedor { get;set;}
    }
}

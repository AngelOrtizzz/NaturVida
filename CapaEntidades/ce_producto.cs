using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ce_producto
    {
        public int Codigo { get; set; }
        public int NuevoCodigo { get; set; }
        public string Descripción { get; set; }
        public int Valor_Unidad { get; set; }
        public int Cantidad { get; set; }
    }
}

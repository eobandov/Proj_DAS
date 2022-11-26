using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_DAS
{
    public class Factura
    {
        public int idFactura;
        public DateTime fechaPago;
        public int subtotal;
        public float iva;
        public float total;

        public int numMetodoPago;
        public String tipo;
    }
}

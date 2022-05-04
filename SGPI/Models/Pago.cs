using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGPI.Models
{
    public class Pago
    {
        public int IdPago { get; set; }
        public int Fecha { get; set; }
        public int Valor { get; set; }
        public int IdUsuario { get; set; }
        public string ComprobPago { get; set; }

    }
}

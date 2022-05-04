using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGPI.Models
{
    public class Homologacion
    {
        public int IdHomologa { get; set; }
        public int FechaHomo { get; set; }
        public string Universidad { get; set; }
        public int IdPrograma { get; set; }
        public int IdModulo { get; set; }
        public double Nota { get; set; }
        public int IdUsuario { get; set; }

    }
}

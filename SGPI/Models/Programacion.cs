using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGPI.Models
{
    public class Programacion
    {
        public int IdProgramacion { get; set; }
        public int FechaInicio { get; set; }
        public int FechaFin { get; set; }
        public int Bloque { get; set; }
        public string Salon { get; set; }
        public int IdModulo { get; set; }
        public string Semestre { get; set; }
        public int IdPrograma { get; set; }

    }
}

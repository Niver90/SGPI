using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGPI.Models
{
    public class Usuario
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int TipoDocumento { get; set; }
        public String Genero { get; set; }
        public String Email { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Rol { get; set; }
        public String Programa { get; set; }
    }
}

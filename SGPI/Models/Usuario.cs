using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGPI.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int TipoDoc { get; set; }
        public int NumDoc { get; set; }
        public string Genero { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Rol { get; set; }
        public string Programa { get; set; }
        public string Contraseña { get; set; }
        public string Egresado { get; set; }
    }
}

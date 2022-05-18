using System;
using System.Collections.Generic;

#nullable disable

namespace SGPI.Models
{
    public partial class TipoDocumento
    {
        public TipoDocumento()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int id_tipo_documento { get; set; }
        public string tipo_documento { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}

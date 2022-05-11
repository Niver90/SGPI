using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SGPI.Models
{
    public class SGPI_DBContext:DbContext
    {
        public SGPI_DBContext(DbContextOptions<SGPI_DBContext> options)
           : base(options)
        {
        }

        public virtual DbSet<Entrevista> Entrevistas { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<Homologacion> Homologacion { get; set; }
        public virtual DbSet<Modulo> Modulos { get; set; }
        public virtual DbSet<Pago> Pagos { get; set; }
        public virtual DbSet<Programa> Programas { get; set; }
        public virtual DbSet<ProgramaUsuario> ProgramaUsuarios { get; set; }
        public virtual DbSet<Programacion> Programacions { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }


    }
}

using Microsoft.AspNetCore.Mvc;
using SGPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGPI.Controllers
{
    public class AdminController : Controller
    {
        private SGPI_DBContext context;
        public AdminController (SGPI_DBContext contexto)
        {
            context = contexto;
        }

        public IActionResult MenuAdmin()
        {
            return View();
        }
        public IActionResult CrearUsuario()
        {
            ViewBag.genero = context.Generos.ToList();
            ViewBag.programa = context.Programas.ToList();
            ViewBag.rol = context.Rols.ToList();
            ViewBag.tipoDocumento = context.TipoDocumentos.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult CrearUsuario(Usuario usuario)
        {
            context.Add(usuario);
            context.SaveChanges();

            ViewBag.genero = context.Generos.ToList();
            ViewBag.programa = context.Programas.ToList();
            ViewBag.rol = context.Rols.ToList();
            ViewBag.tipodocumento = context.TipoDocumentos.ToList();

            string rol = "";
            if (usuario.IdRol == 1)
            {
                rol = "Admin";
            }
            else if (usuario.IdRol == 2)
            {
                rol = "Coordinador";
            }
            else if (usuario.IdRol == 3)
            {
                rol = "Estudiante";
            }
            return RedirectToAction("Administrador", rol);
            
        }
        public IActionResult BuscarUsuario()
        {
            Usuario listaUsuario = new Usuario();
            return View(listaUsuario);
        }
        [HttpPost]
                public IActionResult BuscarUsuario(Usuario usuario)
                {
            var listaUsuario = context.Usuarios
                .Where(u => u.Documento == usuario.Documento);
                    if (listaUsuario != null)
            {
                return View(listaUsuario.SingleOrDefault());
            }
            else
            {
                return View(listaUsuario);
            }
                    
                }

        public IActionResult Editar(int Idusuario)
        {
            Usuario usuario = context.Usuarios.Find(Idusuario);
            if (usuario == null)
            {
                return NotFound();
            }

            ViewBag.genero = context.Generos.ToList();
            ViewBag.programa = context.Programas.ToList();
            ViewBag.rol = context.Rols.ToList();
            ViewBag.tipodocumento = context.TipoDocumentos.ToList();
            ViewBag.idusuario = Idusuario;

            return View(usuario);
        }


        [HttpPost]
        public IActionResult Editar(Usuario usuario, int idUsuario)
        {
            usuario.IdUsuario = idUsuario;
            context.Update(usuario);
            context.SaveChanges();

            return View("Administrador");
        }


        public IActionResult Eliminar(Usuario user)
        {
            Usuario usuario = context.Usuarios.Find(user.IdUsuario);
            if (usuario == null)
            {
                return ViewBag.mensaje = "Error al eliminar usuario";
            }
            else
            {
                context.Remove(usuario);
                context.SaveChanges();
            }

            return RedirectToAction("BuscarUsuario");
        }

        public IActionResult Informes()
        {
            return View();
        }
    }
}

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
            ViewBag.rol = context.Rol.ToList();
            ViewBag.tipoDocumento = context.TipoDocumento.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult CrearUsuario(Usuario usuario)
        {
            context.Add(usuario);
            context.SaveChanges();
            return View();
        }
                [HttpPost]
                public IActionResult BuscarUsuario(Usuario usuario)
                {
            var listaUsuario = context.Usuarios
                .Where(u => u.NumDoc == usuario.NumDoc);
                        
                    return View(listaUsuario);
                }
        public IActionResult BuscarUsuario()
        {
            return View();
        }
        public IActionResult Informes()
        {
            return View();
        }
    }
}

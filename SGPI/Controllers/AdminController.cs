using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGPI.Controllers
{
    public class AdminController : Controller
    {
  /*      private SGPI_DBContext;
        public AdminController (SGPI_DBContext contexto)
        {
            context = contexto;
        }*/

        public IActionResult MenuAdmin()
        {
            return View();
        }
        public IActionResult CrearUsuario()
        {
  /*          ViewBag.genero = context.Genero.ToList();
            ViewBag.programa = context.Programa.ToList();
            ViewBag.rol = context.Rol.ToList();
            ViewBag.tipoDocumento = context.TipoDocumento.ToList();*/
            return View();
        }
 /*       [HttpPost]
        public IActionResult CrearUsuario(Usuario usuario)
        {
            context.Add(usuario);
            Context.SaveChanges();
            return View();
        }*/
        /*        [HttpPost]
                public IActionResult BuscarUsuario(Usuario user)
                {
                    var listaUsuario = context.Usuarios
                        .Where(u => u.NumDoc
                        .Contains(user.NumDoc)).ToList();
                    return View(listaUsuario);
                }*/
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

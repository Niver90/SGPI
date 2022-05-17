using Microsoft.AspNetCore.Mvc;
using SGPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGPI.Controllers
{
    public class CoordinadorController : Controller
    {
        private SGPI_DBContext context;
        public CoordinadorController(SGPI_DBContext contexto)
        {
            context = contexto;
        }
        public IActionResult Consulta()
        {
            ViewBag.genero = context.Generos.ToList();
            ViewBag.programa = context.Programas.ToList();
            ViewBag.rol = context.Rols.ToList();
            ViewBag.tipoDocumento = context.TipoDocumentos.ToList();
            return View();
        }
        public IActionResult Entrevistas()
        {
            return View();
        }
        public IActionResult Homologar()
        {
            return View();
        }
        public IActionResult ProgramarAsignaturas()
        {
            return View();
        }
        public IActionResult MenuCoordinador()
        {
            return View();
        }
    }
}

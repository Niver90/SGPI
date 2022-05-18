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
        public IActionResult Consulta(Pago pago)
        {
            
            ViewBag.valorPagado = context.Pagos
                 .Where(u => u.Valor == pago.Valor);
            ViewBag.fechaPago = context.Pagos
                 .Where(u => u.Fecha == pago.Fecha);
            
            return View();
        }
        public IActionResult Consulta(Entrevistum entry)
        {

            
            ViewBag.estado = context.Entrevista
                 .Where(u => u.Estado == entry.Estado);
            return View();
        }
        public IActionResult Entrevistas()
        {
            ViewBag.genero = context.Generos.ToList();
            ViewBag.programa = context.Programas.ToList();
            ViewBag.tipoDocumento = context.TipoDocumentos.ToList();
            return View();
        }
        public IActionResult Homologar()
        {
            return View();
        }
        public IActionResult ProgramarAsignaturas()
        {
            ViewBag.programa = context.Programas.ToList();
            return View();
        }
        public IActionResult MenuCoordinador()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGPI.Controllers
{
    public class EstudianteController : Controller
    {
        public IActionResult Perfil()
        {
            return View();
        }
        public IActionResult PagosMatricula()
        {
            return View();
        }
        public IActionResult MenuEstudiante()
        {
            return View();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGPI.Models
{
    public class Entrevista
    {
        public int IdEntrevista { get; set; }
        public int IdUsuario { get; set; }
        public int FechaEntrev { get; set; }
        public string Estado { get; set; }

    }
}
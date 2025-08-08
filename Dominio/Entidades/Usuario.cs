﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Usuario
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string ContrasenaHash { get; set; }
        public string Rol { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Estacion
    {
        public int Id { get; set; }

        public int Numero { get; set; }

        public string Nombre { get; set; }

        public bool Disponible { get; set; }

        public string Turno { get; set; }
    }
}

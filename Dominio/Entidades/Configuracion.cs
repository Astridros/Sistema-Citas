using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Configuracion
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public string Turno { get; set; }

        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFin { get; set; }

        public TimeSpan DuracionCitaMinutos { get; set; }

        public int CantidadEstaciones { get; set; }
    }
}

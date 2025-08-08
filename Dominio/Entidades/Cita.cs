using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Cita
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }

        public int SlotId { get; set; }

        public DateTime Fecha { get; set; }

        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFin { get; set; }

        public string Estado { get; set; }

        public string EstacionAsignada { get; set; }
    }
}

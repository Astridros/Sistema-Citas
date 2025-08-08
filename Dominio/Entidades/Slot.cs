using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Slot
    {
        public int Id { get; set; }
        public int ConfiguracionId { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public int CupoMaximo { get; set; }
        public int CupoDisponible { get; set; }
        public bool ESReservable { get; set; }

    }
}

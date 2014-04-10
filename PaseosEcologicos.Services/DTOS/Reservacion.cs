using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaseosEcologicos.Services.DTOS
{
    public class Reservacion
    {
        public Cliente Cliente { get; set; }
        public int CantidadDePersonas { get; set; }
        public int PaseoId { get; set; }
    }
}

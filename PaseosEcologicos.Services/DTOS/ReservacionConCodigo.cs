using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaseosEcologicos.Services.DTOS
{
    public class ReservacionConCodigo
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public string CodigoDeReservacion { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaseosEcologicos.Services.DTOS
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int AlojamientoId { get; set; }
        public int ComidaId { get; set; }
        public int DeporteId { get; set; }
        public string CodigoDeReservacion { get; set; }
    }
}

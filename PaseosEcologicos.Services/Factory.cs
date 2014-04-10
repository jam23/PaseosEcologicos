using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PaseosEcologicos.Model;
using PaseosEcologicos.Services.DTOS;

namespace PaseosEcologicos.Services
{
    public class Factory
    {
        public Reservaciones Create(Reservacion reservacion) {
            return new Reservaciones 
            { 
            };
        }
    }
}

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
                Cantidad_De_Personas = reservacion.CantidadDePersonas,
                PaseoId = reservacion.Cliente.PaseoId,
                Codigo_Verificacion = reservacion.Cliente.CodigoDeReservacion,
            };
        }

        public Clientes Create(Cliente cliente) { 
            return new Clientes{
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Celular = cliente.Telefono,
                Correo = cliente.Email 
            };
        }
    }
}

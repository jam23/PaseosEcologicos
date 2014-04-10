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

        private UnitOfWork uow = new UnitOfWork();

        public Reservaciones Create(Reservacion reservacion) {
            return new Reservaciones 
            { 
                PaseoId = reservacion.PaseoId,
                Cantidad_De_Personas = reservacion.CantidadDePersonas
            };
        }

        public Clientes Create(Cliente cliente) {
            return new Clientes { 
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Correo = cliente.Email,
                Celular = cliente.Telefono
            };
        }

        public Servicios_Consumidos Create(int clienteId, int servicioId) {
            var servicio = uow.Servicios.Get(servicioId);
            return new Servicios_Consumidos { 
                ServicioId = servicio.Id,
                ClienteId = clienteId
            };
        }
    }
}

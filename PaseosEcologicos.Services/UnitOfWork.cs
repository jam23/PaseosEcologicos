using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using PaseosEcologicos.Model;

namespace PaseosEcologicos.Services
{
    public class UnitOfWork : IDisposable
    {
        private readonly DbContext context;
     
        // list of repository fields
        private Repository<Reservaciones> reservaciones;
        private Repository<Clientes> clientes;
        private Repository<Paseos> paseos;
        private Repository<Servicios> servicios;
        private Repository<Servicios_Consumidos> serviciosConsumidos;
        private Repository<Tipos_De_Servicios> tiposDeServicios;
        private Repository<Implementos> implementos;


        // list of repository fields properties
        public Repository<Reservaciones> Reservaciones
        {
            get
            {
                if (reservaciones == null)
                {
                    reservaciones = new Repository<Reservaciones>(context);
                }

                return reservaciones;
            }
        }
        public Repository<Clientes> Clientes
        {
            get
            {
                if (clientes == null)
                {
                    clientes = new Repository<Clientes>(context);
                }

                return clientes;
            }
        }
        public Repository<Implementos> Implementos
        {
            get
            {
                if (implementos == null)
                {
                    implementos = new Repository<Implementos>(context);
                }

                return implementos;
            }
        }
        public Repository<Paseos> Paseos
        {
            get
            {
                if (paseos == null)
                {
                    paseos = new Repository<Paseos>(context);
                }

                return paseos;
            }
        }
        public Repository<Servicios> Servicios
        {
            get
            {
                if (servicios == null)
                {
                    servicios = new Repository<Servicios>(context);
                }

                return servicios;
            }
        }
        public Repository<Servicios_Consumidos> ServiciosConsumidos
        {
            get
            {
                if (serviciosConsumidos == null)
                {
                    serviciosConsumidos = new Repository<Servicios_Consumidos>(context);
                }

                return serviciosConsumidos;
            }
        }
        public Repository<Tipos_De_Servicios> TiposDeServicios
        {
            get
            {
                if (tiposDeServicios == null)
                {
                    tiposDeServicios = new Repository<Tipos_De_Servicios>(context);
                }

                return tiposDeServicios;
            }
        }
        
        public UnitOfWork(DbContext _context)
        {
            context = _context;
        }

        public UnitOfWork()
        {
            context = new PaseosEcologicosEntities();
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

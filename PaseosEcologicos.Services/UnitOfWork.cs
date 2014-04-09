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
        
        
        public UnitOfWork(DbContext _context)
        {
            context = _context;
        }

        public UnitOfWork()
        {
            context = new DbContext("PaseosEcologicosEntities");
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

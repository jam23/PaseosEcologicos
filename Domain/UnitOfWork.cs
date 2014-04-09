using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Reval.Domain.Model;

namespace Domain.Services
{
    public class UnitOfWork : IDisposable
    {
        private readonly DbContext context;
        private readonly DbContext ceridianContext = new CeridianEntities();

        // list of repository fields
        private Repository<Evaluaciones> evaluaciones;
        private Repository<Revisiones> revisiones;
        private CeridianRepository<EmployeeDataCer> empleados;


        // list of repository fields properties
        public Repository<Evaluaciones> Evaluaciones
        {
            get
            {
                if (evaluaciones == null)
                {
                    evaluaciones = new Repository<Evaluaciones>(context);
                }

                return evaluaciones;
            }
        }
        public Repository<Revisiones> Revisiones
        {
            get
            {
                if (revisiones == null)
                {
                    revisiones = new Repository<Revisiones>(context);
                }

                return revisiones;
            }
        }
        public CeridianRepository<EmployeeDataCer> Empleados
        {
            get
            {
                if (empleados == null)
                {
                    empleados = new CeridianRepository<EmployeeDataCer>(ceridianContext);
                }

                return empleados;
            }
        }
        
        public UnitOfWork(DbContext _context)
        {
            context = _context;
        }

        public UnitOfWork()
        {
            context = new RevalEntities();
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

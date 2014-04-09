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
        //private Repository<Evaluaciones> evaluaciones;


        // list of repository fields properties
        //public Repository<Evaluaciones> Evaluaciones
        //{
        //    get
        //    {
        //        if (evaluaciones == null)
        //        {
        //            evaluaciones = new Repository<Evaluaciones>(context);
        //        }

        //        return evaluaciones;
        //    }
        //}
        
        
        public UnitOfWork(DbContext _context)
        {
            context = _context;
        }

        public UnitOfWork()
        {
            context = new DbContext("");
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

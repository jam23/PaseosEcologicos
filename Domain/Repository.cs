using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;

namespace Reval.Services
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> EntitySet;
        private DbContext context;

        public Repository(DbContext _context)
        {
            context = _context;
            EntitySet = _context.Set<T>();
        }

        public virtual T Get(int Id)
        {
            return EntitySet.Find(Id);
        }

        public IEnumerable<T> GetAll()
        {
            return EntitySet;
        }

        public void Add(T entity)
        {
            try
            {
                EntitySet.Add(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Update(T entity)
        {
            try
            {
                EntitySet.Attach(entity);
                context.Entry(entity).State = EntityState.Modified;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Delete(int Id)
        {
            try
            {
                var entity = Get(Id);
                Delete(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public void Delete(T entity)
        {
            EntitySet.Remove(entity);
        }
    }
}

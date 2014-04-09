using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reval.Services
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(int Id);
        void Delete(T entity);
    }
}

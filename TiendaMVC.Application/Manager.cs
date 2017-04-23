using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using TiendaMVC.CORE.Interfaces;

namespace TiendaMVC.Application
{
    public class Manager<T> : IManager<T> 
        where T : class
    {
        public IApplicationDbContext Context { get; private set; }
        public Manager(IApplicationDbContext context)
        {
            Context = context;
        }
        public IQueryable<T> GetAll()
        {
            return Context.Set<T>().AsNoTracking();

        }
        


        public T GetById(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public T Find(object[] key)
        {
            throw new NotImplementedException();
        }

        public T Find(int key)
        {
            return Context.Set<T>().Find(key);

        }

        public int SaveChanges() 
        {
            return Context.SaveChanges();
        }



        public T Add(T entity)
        {
            return Context.Set<T>().Add(entity);
        }

        public T Remove(T entity)
        {
            Context.Entry<T>(entity).State = EntityState.Deleted;
            return null;
        }

        public T Update(T entity)
        {
            Context.Set<T>().Attach(entity);
            Context.Entry<T>(entity).State = EntityState.Modified;
            return entity;
        }
    }
}

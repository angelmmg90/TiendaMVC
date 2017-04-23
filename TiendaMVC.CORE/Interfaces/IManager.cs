using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMVC.CORE.Interfaces
{
    /// <summary>
    /// En este contrato irán solamente las declaraciones de todas las "cláusulas" comunes, en las demás interfaces o contratos irán más detallados estos métodos.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IManager<T>
        where T : class
    {
        /// <summary>
        /// Obtiene todos los elementos de la entidad sin Tracking
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll();
        T GetById(int id);
        T Find(Object[] key);
        T Find(int key);
        T Add(T entity);
        T Remove(T entity);
        T Update(T entity);
        int SaveChanges();

        //IQueriable <T> GetAll()
        //T GetByID (int id)
    }
}

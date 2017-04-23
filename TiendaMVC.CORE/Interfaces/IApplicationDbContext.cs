using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace TiendaMVC.CORE.Interfaces
{
    /// <summary>
    /// Interfaz del contexto
    /// </summary>
    public interface IApplicationDbContext
    {
        /// <summary>
        /// Obtiene la colección de una entidad
        /// </summary>
        /// <typeparam name="T">Entidad de la que queremos el contexto</typeparam>
        /// <returns></returns>
        DbSet<T> Set<T>() where T : class;
        /// <summary>
        /// Obtiene una entrada de una entidad del contexto
        /// </summary>
        /// <typeparam name="T"> Tipo de entidad de la que queremos la entrada</typeparam>
        /// <returns></returns>
        DbEntityEntry<T> Entry<T>(T entity) where T : class;
        /// <summary>
        /// Guarda cambios en el contexto
        /// </summary>
        /// <returns></returns>
        int SaveChanges();

    }
}

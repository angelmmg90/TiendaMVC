using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMVC.CORE
{
    public class Category
    {
        /// <summary>
        /// Id Categoría
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nombre de la categoría
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Categoría padre
        /// </summary>
        public Category Parent { get; set; }
        /// <summary>
        /// Id de la categoría padre
        /// </summary>
        [ForeignKey("Parent")]
        public int? Parent_Id { get; set; } ///El ? siginifica que no puede ser null

        //public virtual 

        
    }
}

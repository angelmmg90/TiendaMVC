using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMVC.CORE
{
    public class Document
    {
        /// <summary>
        /// Identificador del documento
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nombre del documento
        /// </summary>
        public string Name { get; set; }

        public Product Product { get; set; }

        public int Product_Id { get; set; }
       
        
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMVC.CORE
{
    public class Tax    
    {
        /// <summary>
        /// Id del impuesto
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nombre del impuesto
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// Valor del impuesto
        /// </summary>
        public float Value { get; set; }
    }
}

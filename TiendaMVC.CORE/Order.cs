using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMVC.CORE
{
    /// <summary>
    /// Entidad de dominio Pedido
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Identificador del pedido
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Estado del pedido
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual List<OrderLine> Lines { get; set; }

    }
}

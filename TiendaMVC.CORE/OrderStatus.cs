using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaMVC.CORE
{
    /// <summary>
    /// Enumerado con los estados de los pedidos
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// El pedido está en carrito
        /// </summary>
        ShoppingCart,
        /// <summary>
        /// El pedido está realizado
        /// </summary>
        Pending,
        /// <summary>
        /// El pedido está pagado
        /// </summary>
        Paid,
        /// <summary>
        /// El pedido está en proceso
        /// </summary>
        InProcess,
        /// <summary>
        /// El pedido se está enviando
        /// </summary>
        Sent,
        /// <summary>
        /// El pedido está entregado
        /// </summary>
        Delivered
    }
}

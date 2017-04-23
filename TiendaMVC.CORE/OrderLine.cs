using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace TiendaMVC.CORE
{
    public class OrderLine
    {
        /// <summary>
        /// Identificador del pedido
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Producto de la línea
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Identidicador del pedido
        /// </summary>
        [ForeignKey("Product")]
        public int Product_Id { get; set; }

        /// <summary>
        /// Cantidad del pedido
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Precio del pedido
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// % de tasa aplicado
        /// </summary>
        public decimal Tax { get; set; }

        /// <summary>
        /// Precio incluido tasas
        /// </summary>
        public decimal Total { get; set; }
    }
}

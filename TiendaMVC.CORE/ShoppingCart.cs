using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMVC.CORE
{
    /// <summary>
    /// Entidad de negocio que corresponde al shopping cart
    /// </summary>
    public class ShoppingCart
    {
        /// <summary>
        /// Id del carrito
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SessionId{get; set;}
        /// <summary>
        /// 
        /// </summary>
        public ApplicationUser Client{get; set;}
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey("Client")]
        public string Client_Id{get; set;}
        /// <summary>
        /// 
        /// </summary>
        public Product Product {get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey("Product")]
        public int Product_Id {get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Quantity {get; set;}
        /// <summary>
        /// 
        /// </summary>
        public DateTime Date {get; set;}


    }
}

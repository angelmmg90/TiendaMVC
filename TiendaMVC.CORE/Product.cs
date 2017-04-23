using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMVC.CORE
{
    /// <summary>
    /// Entidad de dominio de Producto
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Id del producto
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Descripción del producto
        /// </summary>
        public String Description { get; set; }
        /// <summary>
        /// Stock del producto
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// Impuestos del producto
        /// </summary>
        public Tax Tax { get; set; }
        /// <summary>
        /// Id de impuestos del producto
        /// </summary>
        [ForeignKey("Tax")]
        public int Tax_Id { get; set; }
        /// <summary>
        /// Indica si el producto está disponible
        /// </summary>
        public bool Available { get; set; }
        /// <summary>
        /// Imagen principal del producto
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Listado de documentos relacionados con el producto
        /// </summary>
        public List<Document> Documents { get; set; }

        /// <summary>
        /// Categoría a la que pertenece el producto
        /// </summary>
        public Category Category { get; set; }
        /// <summary>
        /// Id de la categoría
        /// </summary>
        [ForeignKey("Category")]
        public int Category_Id { get; set; } 

    }
}

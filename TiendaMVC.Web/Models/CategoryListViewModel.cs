using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendaMVC.Web.Models
{
    /// <summary>
    /// Modelo para el listado de categorías
    /// </summary>
    public class CategoryListViewModel : CategoryViewModel
    {
        /// <summary>
        /// Nombre de la categoría padre
        /// </summary>
        public string Parent { get; set; }

    }
}
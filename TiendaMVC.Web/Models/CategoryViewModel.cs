using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TiendaMVC.Web.Models
{
    /// <summary>
    /// Modelo de la vista de categorías
    /// </summary>
    public class CategoryViewModel
    {
        /// <summary>
        /// Id Categoría
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nombre de la categoría
        /// </summary>
        [Display(Name="Nombre")] //Nombre más estético que sale en el formulario
        [Required(ErrorMessage="El nombre es requerido")]
        public string Name { get; set; }
        /// <summary>
        /// Id de la categoría padre
        /// </summary>
        /// 
        [Display(Name="Categoria Padre")] //Nombre más estético que sale en el formulario
        public int? Parent_Id { get; set; }
        /// <summary>
        /// Lista de categorías a seleccionar
        /// </summary>
        public List<SelectListItem> Categories {get; set;}
    }
}

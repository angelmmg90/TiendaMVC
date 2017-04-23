using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMVC.CORE
{
    public class Address
    {
        /// <summary>
        /// Id de la dirección
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Teléfono de contacto de la dirección
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// País
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Provincia
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// Localidad
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// Calle
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// Más datos de la calle, número, portal, etc
        /// </summary>
        public string Street2 { get; set; }

    }
}

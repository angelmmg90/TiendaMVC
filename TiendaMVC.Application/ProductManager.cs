using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMVC.CORE;
using TiendaMVC.CORE.Interfaces;

namespace TiendaMVC.Application
{
    public class ProductManager : Manager<Product>, IProductManager
    {
        //Funciones propias
        //Calcular valor neto o bruto de un producto
        public ProductManager(IApplicationDbContext context)
            : base(context)
        {

        }
    }
}

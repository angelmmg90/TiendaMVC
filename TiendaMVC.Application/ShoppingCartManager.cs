using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMVC.CORE;
using TiendaMVC.CORE.Interfaces;

namespace TiendaMVC.Application
{
    public class ShoppingCartManager : Manager<ShoppingCart>, IShoppingCartManager
    {
        public ShoppingCartManager(IApplicationDbContext context):base(context)
        {

        }
    }
}

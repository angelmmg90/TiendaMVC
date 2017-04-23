using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMVC.CORE;
using TiendaMVC.CORE.Interfaces;

namespace TiendaMVC.Application
{
    public class AddressManager : Manager<Address>, IAddressManager
    {
        public AddressManager(IApplicationDbContext context) : base(context)
        {

        }
    }
}

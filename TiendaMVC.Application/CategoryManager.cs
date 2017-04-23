using System;
using TiendaMVC.Application;
using TiendaMVC.CORE;
using TiendaMVC.CORE.Interfaces;


namespace TiendaMVC.Application
{
    public class CategoryManager : Manager<Category>, ICategoryManager
    {
        public CategoryManager(IApplicationDbContext context)
            : base(context)
        {

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaMVC.CORE.Interfaces;
using TiendaMVC.DAL;
using TiendaMVC.IFR.IoC;

namespace TiendaMVC.Web
{
    public static class IoCConfig
    {
        public static void Configure() {

            var type = typeof(ApplicationDbContext).AssemblyQualifiedName;
            IoCContainer.Current.RegisterType(
                typeof(IApplicationDbContext),
                Type.GetType("TiendaMVC.DAL.ApplicationDbContext, TiendaMVC.DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"),
                new Microsoft.Practices.Unity.TransientLifetimeManager());

           IoCContainer.Current.RegisterType(
                typeof(IProductManager),
                Type.GetType("TiendaMVC.Application.ProductManager, TiendaMVC.Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"),
                new Microsoft.Practices.Unity.TransientLifetimeManager()
                );

           IoCContainer.Current.RegisterType(
               typeof(ICategoryManager),
               Type.GetType("TiendaMVC.Application.CategoryManager, TiendaMVC.Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"),
               new Microsoft.Practices.Unity.TransientLifetimeManager()
               );

           IoCContainer.Current.RegisterType(
               typeof(IOrderManager),
               Type.GetType("TiendaMVC.Application.OrderManager, TiendaMVC.Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"),
               new Microsoft.Practices.Unity.TransientLifetimeManager()
               );
           IoCContainer.Current.RegisterType(
              typeof(IDocumentManager),
              Type.GetType("TiendaMVC.Application.DocumentManager, TiendaMVC.Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"),
              new Microsoft.Practices.Unity.TransientLifetimeManager()
              );
           IoCContainer.Current.RegisterType(
             typeof(IShoppingCartManager),
             Type.GetType("TiendaMVC.Application.ShoppingCartManager, TiendaMVC.Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"),
             new Microsoft.Practices.Unity.TransientLifetimeManager()
             );
           IoCContainer.Current.RegisterType(
            typeof(IAddressManager),
            Type.GetType("TiendaMVC.Application.AddressManager, TiendaMVC.Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"),
            new Microsoft.Practices.Unity.TransientLifetimeManager()
            );

            //Repetir lo anterior por tantos managers que tengamos

        }
    }
}
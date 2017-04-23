using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaMVC.IFR.IoC;

namespace TiendaMVC.Web
{
    public class UnityDependencyResolver : IDependencyResolver
    {
        public object GetService(Type serviceType) {
            try
            {
                object instance = IoCContainer.Current.Resolve(serviceType);
                if (serviceType.IsAbstract || serviceType.IsInterface) {
                    return null;
                }
                return instance;
            }
            catch {
                return null;
            }
            
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return IoCContainer.Current.ResolveAll(serviceType);
        }
    }
}
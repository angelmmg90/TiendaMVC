using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMVC.IFR.IoC
{
    //Faltará comentar toda esta clase
    public class IoCContainer
    {
        #region contructor singleton
        static readonly IoCContainer current = new IoCContainer();
        #endregion
        public static IoCContainer Current {
            get {
                return current;
            }
        }
        protected IUnityContainer container;
        public IoCContainer() {
            container = new UnityContainer();

        }

        #region Métodos para registrar
        public void RegisterType(Type from, Type to, LifetimeManager lifetimemanager) {
            container.RegisterType(from, to, lifetimemanager);
        }

        public void RegisterType(Type from, Type to, string name,  LifetimeManager lifetimemanager)
        {
            container.RegisterType(from, to, lifetimemanager);
        }
        #endregion 

        #region Métodos para resolver
        public T Resolve<T>() {
            return container.Resolve<T>();
        }
        public T Resolve<T>(string name)
        {
            return container.Resolve<T>(name);
        }
        public object Resolve(Type t)
        {
            return container.Resolve(t);
        }

        public object Resolve(Type t, string name)
        {
            return container.Resolve(t, name);
        }

        public IEnumerable<T> ResolveAll<T>() {
            return container.ResolveAll<T>();
        }

        public IEnumerable<object> ResolveAll(Type type)
        {
            return container.ResolveAll(type);
        }
        #endregion
    }
}
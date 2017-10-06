using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvm.MainWindow;

namespace WpfMvvm.InversionOfControl
{
    class UnityDependencyResolver : IResolver
    {
        private IUnityContainer _container;

        public UnityDependencyResolver(IUnityContainer container)
        {
            _container = container;
        }
        public object GetInstance(Type type)
        {
            return _container.Resolve(type);
        }

        public T GetInstance<T>()
        {
            return (T)GetInstance(typeof(T));
        }

        public void RegisterTypes()
        {
            _container.RegisterType<MainWindowViewModel>(new ContainerControlledLifetimeManager());
        }
    }
}

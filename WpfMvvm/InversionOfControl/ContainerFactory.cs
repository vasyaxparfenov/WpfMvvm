using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvm.InversionOfControl
{
    class ContainerFactory
    {
        public static IUnityContainer CreateUnityContainer()
        {
            return new UnityContainer();
        }
    }
}

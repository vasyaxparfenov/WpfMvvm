using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvm.InversionOfControl
{
    public interface IResolver
    {
        T GetInstance<T>();
        object GetInstance(Type type);
        void RegisterTypes(); 
    }
}

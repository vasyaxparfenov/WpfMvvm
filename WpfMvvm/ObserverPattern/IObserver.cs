using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvm.ObserverPattern
{
    public interface IObserver
    {
        void Update();
        void Error();
    }
}

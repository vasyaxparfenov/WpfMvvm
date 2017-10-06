using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvm.ObserverPattern
{
    public interface IObservable
    {
        IDisposable Subscribe(IObserver observer);
        void Notify();
    }
}

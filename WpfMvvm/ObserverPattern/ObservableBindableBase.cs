using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvm.ObserverPattern
{
    public class ObservableBindableBase : BindableBase, IObservable
    {
        private List<IObserver> _subscribers = new List<IObserver>();
        public void Notify()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update();
            }
        }

        public IDisposable Subscribe(IObserver observer)
        {
            return new Unsubscriber(_subscribers, observer);
        }
    }

    class Unsubscriber : IDisposable
    {
        private List<IObserver> _subscribers;
        private IObserver _subscriber;

        public Unsubscriber(List<IObserver> subscribers, IObserver subscriber)
        {
            _subscribers = subscribers;
            _subscriber = subscriber;
        }

        public void Dispose()
        {
            if(_subscriber != null && _subscribers.Contains(_subscriber))
                _subscribers.Remove(_subscriber);
        }
    }
}

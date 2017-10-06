using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvm.ObserverPattern;

namespace WpfMvvm.MainWindow
{
    class MainWindowViewModel : BindableBase, IObserver
    {
        private string _text = "Pasha BOG";

        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }


        public void Error()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}

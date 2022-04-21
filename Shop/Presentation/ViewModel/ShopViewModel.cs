using System;
using System.ComponentModel;

namespace Shop.Presentation.ViewModel
{
    public class ShopViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged(string PropertyName)
        {
            this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}

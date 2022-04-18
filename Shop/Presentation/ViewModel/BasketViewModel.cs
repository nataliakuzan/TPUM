using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Shop.Presentation.ViewModel
{
    sealed class BasketViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

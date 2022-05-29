using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Shop.Presentation.Model
{
    public class TypeModel : INotifyPropertyChanged
    {
        public string TypeName { get; set; }

        public TypeModel(string Name)
        {
            TypeName = Name;
        }

        public string Name => TypeName;

        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion PropertyChanged
    }
}

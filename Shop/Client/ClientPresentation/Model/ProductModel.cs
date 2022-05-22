using Shop.ServerBusinessLogic;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Shop.Presentation.Model
{
    public class ProductModel : INotifyPropertyChanged
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public float ProductPrice { get; set; }

        public int ProductQuantity { get; set; }

        public string ProductType { get; set; }

        public ProductModel(int ID, string Name, float Price, int Qty, string Type)
        {
            ProductId = ID;
            ProductName = Name;
            ProductPrice = Price;
            ProductQuantity = Qty;
            ProductType = Type;
        }

        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion PropertyChanged
    }
}

﻿using Shop.Presentation.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace Shop.Presentation.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region public API

        public MainWindowViewModel() : this(ModelAbstractAPI.CreateAPI())
        {
        }

        public MainWindowViewModel(ModelAbstractAPI modelAbstractAPI)
        {
            ModelLayer = modelAbstractAPI;
            _Products = new ObservableCollection<ProductModel>();
            foreach (ProductModel Product in ModelLayer.Shop.GetListOfAllProducts())
            {
                _Products.Add(Product);
            }

            ButtonClickShop = new RelayCommand(() => OnClickShowShop());
            ButtonClickBasket = new RelayCommand(() => OnClickShowBasket());
        }

        public ICommand ButtonClickShop { get; set; }
        public ICommand ButtonClickBasket { get; set; }

        private void OnClickShowShop()
        {
            StartVisibility = "Hidden";
            ShopVisibility = "Visible";
        }

        private void OnClickShowBasket()
        {
            ShopVisibility = "Hidden";
            BasketVisibility = "Visible";
        }

        public string StartVisibility
        {
            get => _StartVisibility;
            set
            {
                if (value.Equals(_StartVisibility))
                    return;
                _StartVisibility = value;
                RaisePropertyChanged("StartVisibility");
            }
        }

        public string ShopVisibility
        {
            get => _ShopVisibility;
            set
            {
                if (value.Equals(_ShopVisibility))
                    return;
                _ShopVisibility = value;
                RaisePropertyChanged("ShopVisibility");
            }
        }

        public string BasketVisibility
        {
            get => _BasketVisibility;
            set
            {
                if (value.Equals(_BasketVisibility))
                    return;
                _BasketVisibility = value;
                RaisePropertyChanged("BasketVisibility");
            }
        }

        public ObservableCollection<ProductModel> Products
        {
            get
            {
                return _Products;
            }
            set
            {
                if (value.Equals(_Products))
                    return;
                _Products = value;
                RaisePropertyChanged("Products");
            }
        }

        #endregion public API

        #region private

        public string _StartVisibility = "Visible";
        public string _ShopVisibility = "Hidden";
        public string _BasketVisibility = "Hidden";
        private ObservableCollection<ProductModel> _Products;
        private ModelAbstractAPI ModelLayer;

        #endregion private
    }
}
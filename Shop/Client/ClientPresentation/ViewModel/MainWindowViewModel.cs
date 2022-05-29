using Shop.Presentation.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Threading;
using GalaSoft.MvvmLight.Command;

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
            MessageHandler = new MessageHandler();
            MessageHandler.addCommandHandler("product ListAll", HandleProductList);
            MessageHandler.addCommandHandler("type ListAll", HandleTypeList);
            MessageHandler.addCommandHandler("product ListAllByFilter", HandleProductList);

            ModelLayer = modelAbstractAPI;

            StartRequesting();

            _Products = new ObservableCollection<ProductModel>();

            _Types = new ObservableCollection<TypeModel>();

            ButtonClickShop = new RelayCommand(() => OnClickShowShop());
            ButtonClickBasket = new RelayCommand(() => OnClickShowBasket());
            ButtonFilterByType = new RelayCommand<string>(parm => OnClickFilterByType(parm));
        }

        private async void StartRequesting()
        {
            await SendCommand("product", "ListAll", null);
            await SendCommand("type", "ListAll", null);
        }

        public ICommand ButtonClickShop { get; set; }
        public ICommand ButtonClickBasket { get; set; }
        public ICommand ButtonFilterByType { get; set; }

        private void OnClickShowShop()
        {
            StartVisibility = "Hidden";
            ShopVisibility = "Visible";
            BasketVisibility = "Hidden";
        }

        private void OnClickShowBasket()
        {
            ShopVisibility = "Hidden";
            BasketVisibility = "Visible";
            StartVisibility = "Hidden";
        }

        private async void OnClickFilterByType(string type)
        {
            _Products.Clear();

            ServerPresentation.TypesListDTO typeListDTO = new ServerPresentation.TypesListDTO();
            typeListDTO.Add(new ServerPresentation.TypeDTO(type));

            ServerPresentation.TypeSerializer typeSerializer = new ServerPresentation.TypeSerializer();

            await SendCommand("product", "ListAllByFilter", typeSerializer.parseObject(typeListDTO));
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

        public ObservableCollection<TypeModel> Types
        {
            get
            {
                return _Types;
            }
            set
            {
                if (value.Equals(_Types))
                    return;
                _Types = value;
                RaisePropertyChanged("Types");
            }
        }

        private async Task ConnectToServer()
        {
            ClientBusinessLogic.ClientConnection clientConnection = new ClientBusinessLogic.ClientConnection();
            if (!clientConnection.Connected)
            {
                bool result = await clientConnection.Connect(new Uri("ws://localhost:8081/"));
                if (result)
                {
                    clientConnection.SetMessageHandler(MessageHandler.HandleMessage);
                }
            }
        }

        private async Task SendCommand(string Route, string Action, string Content)
        {
            ClientBusinessLogic.ClientConnection clientConnection = new ClientBusinessLogic.ClientConnection();
            if (!clientConnection.Connected)
            {
                await ConnectToServer();
            }

            if (Content != null)
            {
                await clientConnection.SendAsync(Route + " " + Action + " " + Content);
            } else
            {
                await clientConnection.SendAsync(Route + " " + Action);
            }
        }

        private void HandleProductList(string Content)
        {
            ServerPresentation.ProductSerializer productSerializer = new ServerPresentation.ProductSerializer();

            ServerPresentation.ProductListDTO list = (ServerPresentation.ProductListDTO) productSerializer.parseXML(Content);

            ObservableCollection<ProductModel> ProductModels = new ObservableCollection<ProductModel>();

            foreach (ServerPresentation.ProductDTO Product in list.Products)
            {
                ProductModels.Add(new ProductModel(Product.ProductId,
                                                    Product.ProductName,
                                                    Product.ProductPrice,
                                                    Product.ProductQuantity,
                                                    Product.ProductType));
            }
            Products = ProductModels;
        }

        private void HandleTypeList(string Content)
        {
            ServerPresentation.TypeSerializer TypeSerializer = new ServerPresentation.TypeSerializer();

            ServerPresentation.TypesListDTO list = (ServerPresentation.TypesListDTO)TypeSerializer.parseXML(Content);

            ObservableCollection<TypeModel> Types = new ObservableCollection<TypeModel>();

            foreach (var Type in list.Types)
            {
                Types.Add(new TypeModel(Type.Name));
            }
            this.Types = Types;
        }
        #endregion public API

        #region private

        public string _StartVisibility = "Visible";
        public string _ShopVisibility = "Hidden";
        public string _BasketVisibility = "Hidden";
        private ObservableCollection<ProductModel> _Products;
        private ObservableCollection<TypeModel> _Types;
        private ModelAbstractAPI ModelLayer;
        private MessageHandler MessageHandler;

        #endregion private
    }
}

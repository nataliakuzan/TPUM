using Shop.ServerData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.ServerBusinessLogic
{
    public interface IBusinessLogicLayer
    {
        Store Shop { get; set; }
        IProductRepository ProductRepository { get; set; }
        IOrderRepository OrderRepository { get; set; }
        ITypeRepository TypeRepository { get; set; }
        IDataLayer ShopData { get; set; }
        BusinessLogicLayer Create(IDataLayer ShopData = default(IDataLayer));
    }

    public class BusinessLogicLayer : IBusinessLogicLayer
    {
        public Store Shop { get; set; }
        public IProductRepository ProductRepository { get; set; }
        public IOrderRepository OrderRepository { get; set; }
        public ITypeRepository TypeRepository { get; set; }
        public IDataLayer ShopData { get; set; }

        public BusinessLogicLayer()
        {
            this.ShopData = default(IDataLayer);
            Shop = new Store();
            ProductRepository = new ProductRepository();
            OrderRepository = new OrderRepository();
            TypeRepository = new TypeRepository();
        }

        public BusinessLogicLayer(IDataLayer ShopData)
        {
            this.ShopData = ShopData;
            Shop = new Store();
            ProductRepository = new ProductRepository();
            OrderRepository = new OrderRepository();
            TypeRepository = new TypeRepository();
        }

        public BusinessLogicLayer Create(IDataLayer ShopData = default(IDataLayer))
        {
            return new BusinessLogicLayer(ShopData);
        }

    }
}

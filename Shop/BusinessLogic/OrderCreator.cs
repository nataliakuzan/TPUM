using System;
using System.Collections.Generic;
using System.Text;
using Shop.Data;

namespace Shop.BusinessLogic
{
    public class OrderCreator
    {
        private IProductRepository ProductRepository;

        private IOrderRepository OrderRepository;
        
        private IBasketItemFactory BasketItemFactory;
        
        private IOrderFactory OrderFactory;

        public OrderCreator(
            IProductRepository ProductRepository,
            IOrderRepository OrderRepository,
            IBasketItemFactory BasketItemFactory,
            IOrderFactory OrderFactory
        ) {
            this.ProductRepository = ProductRepository;
            this.OrderRepository = OrderRepository;
            this.BasketItemFactory = BasketItemFactory;
            this.OrderFactory = OrderFactory;
        }

        public void OrderProducts(
            Store Store,
            Dictionary<int, int> ProductIdsAndQuantities, 
            string ClientName, 
            string ClientLastName,
            string Address
        ) {
            List<BasketItem> BasketItems = new List<BasketItem>();

            foreach (KeyValuePair<int, int> ProductIdAndQuantity in ProductIdsAndQuantities)
            {
                Product Product = ProductRepository.FetchById(Store, ProductIdAndQuantity.Key);
                if (Product.Quantity >= ProductIdAndQuantity.Value)
                {
                    BasketItems.Add(BasketItemFactory.CreateBasketItem(Product, ProductIdAndQuantity.Value));
                } else
                {
                    BasketItems.Add(BasketItemFactory.CreateBasketItem(Product, Product.Quantity));
                }

                Product.DecreaseQuantity(ProductIdAndQuantity.Value);
                ProductRepository.Save(Store, Product);
            }

            Order Order = OrderFactory.CreateOrder(BasketItems, ClientName, ClientLastName, Address);
            OrderRepository.Save(Store, Order);
        }
    }
}

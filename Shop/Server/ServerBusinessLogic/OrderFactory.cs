using Shop.ServerData;
using System.Collections.Generic;

namespace Shop.ServerBusinessLogic
{
    internal class OrderFactory : IOrderFactory
    {
        public Order CreateOrder(List<BasketItem> BasketItems, string Name, string LastName, string Address)
        {
            return new Order(BasketItems, Name, LastName, Address);
        }
    }
}

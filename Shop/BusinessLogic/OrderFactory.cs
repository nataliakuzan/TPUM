using Shop.Data;
using System.Collections.Generic;

namespace Shop.BusinessLogic
{
    internal class OrderFactory : IOrderFactory
    {
        public Order CreateOrder(List<BasketItem> BasketItems, string Name, string LastName, string Address)
        {
            return new Order(BasketItems, Name, LastName, Address);
        }
    }
}

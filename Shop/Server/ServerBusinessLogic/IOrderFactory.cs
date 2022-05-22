using System.Collections.Generic;
using Shop.ServerData;

namespace Shop.ServerBusinessLogic
{
    public interface IOrderFactory
    {
        Order CreateOrder(List<BasketItem> BasketItems, string Name, string LastName, string Address);
    }
}

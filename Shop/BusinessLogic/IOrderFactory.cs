using System.Collections.Generic;
using Shop.Data;

namespace Shop.BusinessLogic
{
    public interface IOrderFactory
    {
        Order CreateOrder(List<BasketItem> BasketItems, string Name, string LastName, string Address);
    }
}

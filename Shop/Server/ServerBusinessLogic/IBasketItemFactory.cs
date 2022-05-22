using System;
using System.Collections.Generic;
using Shop.ServerData;

namespace Shop.ServerBusinessLogic
{
    public interface IBasketItemFactory
    {
        BasketItem CreateBasketItem(Product Product, int Quantity);
    }
}

using System;
using System.Collections.Generic;
using Shop.Data;

namespace Shop.BusinessLogic
{
    interface IBasketItemFactory
    {
        BasketItem CreateBasketItem(Product Product, int Quantity);
    }
}

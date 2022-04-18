using System;
using System.Collections.Generic;
using Shop.Data;

namespace Shop.BusinessLogic
{
    public class BasketItemFactory : IBasketItemFactory
    {
        public BasketItem CreateBasketItem(Product Product, int Quantity)
        {
            return new BasketItem(Product, Quantity);
        }
    }
}

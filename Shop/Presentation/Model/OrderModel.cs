using Shop.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Presentation.Model
{
    public class OrderModel
    {
        private OrderCreator OrderCreator;

        public OrderModel(OrderCreator orderCreator)
        {
            this.OrderCreator = orderCreator;
        }
    }
}

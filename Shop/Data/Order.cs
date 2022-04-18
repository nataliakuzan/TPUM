using System;
using System.Collections.Generic;

namespace Shop.Data
{
    public class Order : IEntity
    {
        private static int IdCounter = 1;

        private int OrdertId;

        private List<BasketItem> Items;

        private string ClientName;

        private string ClientLastName;

        private string ClientAddress;

        int IEntity.Id => OrdertId;

        public Order(List<BasketItem> OrderItems, string Name, string LastName, string Address)
        {
            OrdertId = IdCounter;
            IdCounter++;

            Items = OrderItems;
            ClientName = Name;
            ClientLastName = LastName;
            ClientAddress = Address;
        }

        public int GetTotalItemQuantity()
        {
            int Qty = 0;

            foreach (BasketItem Item in Items)
            {
                Qty += Item.Quantity;
            }

            return Qty;
        }

        public float GetTotalPrice()
        {
            float Price = 0;

            foreach (BasketItem Item in Items)
            {
                Price += Item.GetTotalPrice();
            }

            return Price;
        }
    }
}

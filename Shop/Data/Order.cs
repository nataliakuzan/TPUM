using System;
using System.Collections.Generic;

namespace Shop.Data
{
    class Order
    {
        private List<BasketItem> Items;
        private String ClientName;
        private String ClientLastName;
        private String ClientAddress;

        public Order(List<BasketItem> OrderItems, String Name, String LastName, String Address)
        {
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

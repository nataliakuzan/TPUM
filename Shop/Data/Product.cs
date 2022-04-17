using System;
using System.Collections.Generic;

namespace Shop.Data
{
    internal class Product
    {
        private String ProductName;
        
        private float ProductPrice;
        
        private int Quantity { get; set; }

        private List<Tag> ProductTags;

        public Product(String Name, float Price, int Qty, List<Tag> Tags)
        {
            ProductName = Name;
            ProductPrice = Price;
            Quantity = Qty;
            ProductTags = Tags;
        }

        public String Name
        {
            get
            {
                return ProductName;
            }
        }
        
        public float Price
        {
            get
            {
                return ProductPrice;
            }
        }

        public List<Tag> Tags
        {
            get
            {
                return ProductTags;
            }
        }

        public void DecreaseQuantity()
        {
            if (Quantity > 0)
            {
                Quantity--;
            }
        }

    }
}

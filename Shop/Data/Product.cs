using System.Collections.Generic;

namespace Shop.Data
{
    public class Product : IEntity
    {
        private static int IdCounter = 1;
        
        private int ProductId;

        private string ProductName;
        
        private float ProductPrice;
        
        private int ProductQuantity { get; set; }

        private List<ProductType> ProductTypes;

        int IEntity.Id => ProductId;

        public Product(string Name, float Price, int Qty, List<ProductType> Types)
        {
            ProductId = IdCounter;
            IdCounter++;

            ProductName = Name;
            ProductPrice = Price;
            ProductQuantity = Qty;
            ProductTypes = Types;
        }

        public int Id
        {
            get
            {
                return ProductId;
            }
        }

        public string Name
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

        public int Quantity
        {
            get
            {
                return ProductQuantity;
            }
        }

        public List<ProductType> Types
        {
            get
            {
                return ProductTypes;
            }
        }

        public void DecreaseQuantity()
        {
            if (ProductQuantity > 0)
            {
                ProductQuantity--;
            }
        }
    }
}

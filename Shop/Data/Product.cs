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

        public string Name => ProductName;

        public float Price => ProductPrice;

        public int Quantity => ProductQuantity;

        public List<ProductType> Types => ProductTypes;

        public void DecreaseQuantity(int Quantity)
        {
            if (ProductQuantity > 0 && Quantity <= ProductQuantity)
            {
                ProductQuantity -= Quantity;
            }
        }
    }
}

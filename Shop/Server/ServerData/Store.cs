using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.ServerData
{
    public interface IStore
    {
        void Initialize();
        void AddProduct(Product product);
        void ReplaceProduct(Product Product);
        Product GetProductById(int Id);
        Product GetProductByName(string Name);
        List<Product> GetProductByTypes(ProductType Type);
        void AddOrder(Order order);
        List<Product> GetProducts();
        List<ProductType> GetTypes();
    }

    public class Store : IStore
    {
        private List<Product> Products;

        private List<Product> Filtered;

        private List<Order> Orders;

        public Store()
        {
            Products = new List<Product>();
            Filtered = new List<Product>();
            Orders = new List<Order>();
        }

        public void Initialize()
        {
            List<ProductType> TopsList = new List<ProductType>
            {
                new ProductType("Tops")
            };
            List<ProductType> TrousersList = new List<ProductType>
            {
                new ProductType("Trousers")
            };
            List<ProductType> DressesList = new List<ProductType>
            {
                new ProductType("Dresses")
            };
            List<ProductType> CoatsList = new List<ProductType>
            {
                new ProductType("Coats")
            };
            List<ProductType> ShirtsList = new List<ProductType>
            {
                new ProductType("Shirts")
            };
            List<ProductType> SkirtsList = new List<ProductType>
            {
                new ProductType("Skirts")
            };

            Products.Add(new Product("White Top", 15, 15, TopsList));
            Products.Add(new Product("Black Top", 14.5f, 12, TopsList));
            Products.Add(new Product("Red Top", 13.4f, 10, TopsList));
            Products.Add(new Product("Blue Top", 17, 8, TopsList));
            Products.Add(new Product("Yellow Top", 12, 8, TopsList));
            Products.Add(new Product("Blue Jeans", 20.9f, 5, TrousersList));
            Products.Add(new Product("Gray Jeans", 20, 6, TrousersList));
            Products.Add(new Product("Black Trousers", 22.6f, 6, TrousersList));
            Products.Add(new Product("Pink Long Dress", 30, 10, DressesList));
            Products.Add(new Product("Flower Dress", 25, 8, DressesList));
            Products.Add(new Product("Black Coat", 40, 5, CoatsList));
            Products.Add(new Product("Caramel Coat", 38, 3, CoatsList));
            Products.Add(new Product("White Shirt", 18, 6, ShirtsList));
            Products.Add(new Product("Striped Shirt", 19, 3, ShirtsList));
            Products.Add(new Product("Blue Shirt", 18, 8, ShirtsList));
            Products.Add(new Product("Brown Skirt", 22, 4, SkirtsList));
            Products.Add(new Product("Dark Blue Skirt", 20, 5, SkirtsList));
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void ReplaceProduct(Product Product)
        {
            int Index = Products.FindIndex(x => x.Id.Equals(Product.Id));
            Products[Index] = Product;
        }

        public Product GetProductById(int Id)
        {
            return Products.Find(x => x.Id.Equals(Id));
        }

        public Product GetProductByName(string Name)
        {
            return Products.Find(x => x.Name.Contains(Name));
        }

        public List<Product> GetProductByTypes(ProductType Type)
        {
            Filtered.Clear();
            foreach(Product product in Products)
            {
                if (product.Types[0].Name.Equals(Type.Name))
                {
                    Filtered.Add(product);
                }
            }
            return Filtered;
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public List<Product> GetProducts()
        {
            return Products;
        }

        public List<ProductType> GetTypes()
        {
            List<ProductType> Types = new List<ProductType>();
            List<string> TypesName = new List<string>();
            foreach (Product Product in Products)
            {
                foreach (ProductType ProductType in Product.Types)
                {
                    if (!TypesName.Contains(ProductType.Name))
                    {
                        Types.Add(ProductType);
                        TypesName.Add(ProductType.Name);
                    }
                    
                }
            }
            return Types;
        }
    }
}

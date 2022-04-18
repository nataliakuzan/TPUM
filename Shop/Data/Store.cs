using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data
{
    public class Store
    {
        private List<Product> Products;

        private List<Order> Orders;

        public Store()
        {
            Products = new List<Product>();
            Orders = new List<Order>();
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

        public Product GetProductByTypes(ProductType Type)
        {
            return Products.Find(x => x.Types.Contains(Type));
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }
}

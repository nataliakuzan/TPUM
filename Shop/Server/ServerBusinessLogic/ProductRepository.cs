using Shop.ServerData;
using System.Collections.Generic;

namespace Shop.ServerBusinessLogic
{
    internal class ProductRepository : IProductRepository
    {
        public void Save(Store Shop, Product Product)
        {
            if (Shop.GetProductById(Product.Id) != null)
            {
                Shop.ReplaceProduct(Product);
            }
            else
            {
                Shop.AddProduct(Product);
            }
        }

        public Product FetchById(Store Shop, int Id)
        {
            return Shop.GetProductById(Id);
        }

        public Product FetchByName(Store Shop, string Name)
        {
            return Shop.GetProductByName(Name);
        }

        public List<Product> FetchByType(Store Shop, ProductType Type)
        {
            return Shop.GetProductByTypes(Type);
        }

        public List<Product> FetchAll(Store Shop)
        {
            return Shop.GetProducts();
        }

    }
}

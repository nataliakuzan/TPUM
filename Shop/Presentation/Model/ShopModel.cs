using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Presentation.Model
{
    public class ShopModel
    {
        private Data.Store Shop { get; }

        public ShopModel()
        {
            Shop = new Data.Store();
            Shop.Initialize();
        }

        public List<ProductModel> GetListOfAllProducts()
        {
            List<ProductModel> Products = new List<ProductModel>();
            foreach (Data.Product Product in Shop.GetProducts())
            {
                Products.Add(new ProductModel(Product.Id,
                                              Product.Name,
                                              Product.Price,
                                              Product.Quantity,
                                              Product.Types[0].Name));
            }
            return Products;
        }

        public List<string> GetListOfAllTypes()
        {
            List<string> Types = new List<string>();
            foreach (Data.Product Product in Shop.GetProducts())
            {
                Types.Add(Product.Types[0].Name);
            }
            return Types.Distinct().ToList();
        }
    }
}

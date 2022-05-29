using Shop.ServerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.ServerBusinessLogic
{
    public class ProductDTO
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public float ProductPrice { get; set; }

        public int ProductQuantity { get; set; }

        public string ProductType { get; set; }

        public ProductDTO()
        {

        }

        public ProductDTO(Product product)
        {
            ProductId = product.Id;
            ProductName = product.Name;
            ProductPrice = product.Price;
            ProductQuantity = product.Quantity;
            ProductType = product.Types[0].Name;
        }

        public ProductDTO(int ID, string Name, float Price, int Qty, string Type)
        {
            ProductId = ID;
            ProductName = Name;
            ProductPrice = Price;
            ProductQuantity = Qty;
            ProductType = Type;
        }
    }
}

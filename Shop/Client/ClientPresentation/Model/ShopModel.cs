using ClientBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Presentation.Model
{
    public class ShopModel
    {
        private ServerData.IStore Shop { get; }
        public IClientConnection Connection;

        public ShopModel()
        {
            Shop = new ServerData.Store();
            Shop.Initialize();
            Connection = new ClientConnection();
        }

        public List<ProductModel> GetListOfAllProducts()
        {
            List<ProductModel> Products = new List<ProductModel>();
            foreach (ServerData.Product Product in Shop.GetProducts())
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
            foreach (ServerData.Product Product in Shop.GetProducts())
            {
                Types.Add(Product.Types[0].Name);
            }
            return Types.Distinct().ToList();
        }

        public async Task SendMessage(string message)
        {
            await Connection.SendAsync(message);
        }

        public bool ClientConnected()
        {
            return Connection.Connected;
        }
    }
}

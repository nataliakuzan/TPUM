using Shop.ServerData;
using System.Collections.Generic;

namespace Shop.ServerBusinessLogic
{
    public interface IProductRepository
    {
        void Save(Store Shop, Product Product);

        Product FetchById(Store Shop, int Id);

        Product FetchByName(Store Shop, string Name);

        List<Product> FetchByType(Store Shop, ProductType Type);

        List<Product> FetchAll(Store Shop);
    }
}

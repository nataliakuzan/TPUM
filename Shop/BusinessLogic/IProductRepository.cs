using Shop.Data;

namespace Shop.BusinessLogic
{
    public interface IProductRepository
    {
        void Save(Store Shop, Product Product);

        Product FetchById(Store Shop, int Id);

        Product FetchByName(Store Shop, string Name);

        Product FetchByType(Store Shop, ProductType Type);
    }
}

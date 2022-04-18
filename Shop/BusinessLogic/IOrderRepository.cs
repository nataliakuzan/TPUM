using Shop.Data;

namespace Shop.BusinessLogic
{
    public interface IOrderRepository
    {
        void Save(Store Shop, Order Order);
    }
}

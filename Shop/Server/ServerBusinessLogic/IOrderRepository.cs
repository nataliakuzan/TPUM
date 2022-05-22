using Shop.ServerData;

namespace Shop.ServerBusinessLogic
{
    public interface IOrderRepository
    {
        void Save(Store Shop, Order Order);
    }
}

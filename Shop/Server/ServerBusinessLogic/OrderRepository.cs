using Shop.ServerData;

namespace Shop.ServerBusinessLogic
{
    internal class OrderRepository : IOrderRepository
    {
        public void Save(Store Shop, Order Order)
        {
            Shop.AddOrder(Order);
        }
    }
}

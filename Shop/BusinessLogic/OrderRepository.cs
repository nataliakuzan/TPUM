using Shop.Data;

namespace Shop.BusinessLogic
{
    internal class OrderRepository : IOrderRepository
    {
        public void Save(Store Shop, Order Order)
        {
            Shop.AddOrder(Order);
        }
    }
}

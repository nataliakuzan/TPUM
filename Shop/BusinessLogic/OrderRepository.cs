using Shop.Data;

namespace Shop.BusinessLogic
{
    public class OrderRepository
    {
        public void Save(Store Shop, Order Order)
        {
            Shop.AddOrder(Order);
        }
    }
}

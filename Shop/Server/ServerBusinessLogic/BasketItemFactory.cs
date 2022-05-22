using Shop.ServerData;

namespace Shop.ServerBusinessLogic
{
    internal class BasketItemFactory : IBasketItemFactory
    {
        public BasketItem CreateBasketItem(Product Product, int Quantity)
        {
            return new BasketItem(Product, Quantity);
        }
    }
}

namespace Shop.ServerData
{
    public class BasketItem : IEntity
    {
        private Product BasketItemProduct;

        private int BasketItemQuantity;

        private static int IdCounter = 1;

        private int BasketItemId;

        int IEntity.Id => BasketItemId;

        public BasketItem(Product Product, int Quantity)
        {
            BasketItemId = IdCounter;
            IdCounter++;

            BasketItemProduct = Product;
            BasketItemQuantity = Quantity;
        }

        public int Quantity => BasketItemQuantity;

        public float GetTotalPrice()
        {
            return BasketItemProduct.Price * Quantity;
        }
    }
}

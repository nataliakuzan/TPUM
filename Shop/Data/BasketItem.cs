namespace Shop.Data
{
    class BasketItem
    {
        private Product BasketItemProduct;

        private int BasketItemQuantity;

        public BasketItem(Product Product, int Quantity)
        {
            BasketItemProduct = Product;
            BasketItemQuantity = Quantity;
        }

        public int Quantity
        {
            get
            {
                return BasketItemQuantity;
            }
        }

        public float GetTotalPrice()
        {
            return BasketItemProduct.Price * Quantity;
        }
    }
}

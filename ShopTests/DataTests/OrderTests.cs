using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop.ServerData;
using System.Collections.Generic;

namespace Shop.ServerDataTests
{
    [TestClass]
    public class OrderTests
    {
        List<ProductType> ProductTypeList;

        [TestInitialize]
        public void Before()
        {
            ProductTypeList = new List<ProductType>();

            ProductTypeList.Add(new ProductType("Trousers"));
        }

        [TestMethod]
        public void GetTotalItemQuantity()
        {
            Product Product1 = new Product("Blue Jeans", 20, 5, ProductTypeList);
            Product Product2 = new Product("Gray Jeans", 15, 7, ProductTypeList);

            BasketItem BasketItem1 = new BasketItem(Product1, 2);
            BasketItem BasketItem2 = new BasketItem(Product2, 1);

            List<BasketItem> list = new List<BasketItem>();
            list.Add(BasketItem1);
            list.Add(BasketItem2);

            Order order = new Order(list, "Bob", "Uncle", "491 Bryan Avenue, 55406, Minneapolis");

            Assert.AreEqual(BasketItem1.Quantity + BasketItem2.Quantity, order.GetTotalItemQuantity());
        }

        [TestMethod]
        public void GetTotalPriceOfProducts()
        {
            Product Product1 = new Product("Blue Jeans", 20, 5, ProductTypeList);
            Product Product2 = new Product("Gray Jeans", 15, 7, ProductTypeList);

            BasketItem BasketItem1 = new BasketItem(Product1, 2);
            BasketItem BasketItem2 = new BasketItem(Product2, 1);

            List<BasketItem> list = new List<BasketItem>();
            list.Add(BasketItem1);
            list.Add(BasketItem2);

            Order order = new Order(list, "Bob", "Uncle", "491 Bryan Avenue, 55406, Minneapolis");

            Assert.AreEqual(BasketItem1.Quantity * 20 + BasketItem2.Quantity * 15, order.GetTotalPrice());
        }
    }
}

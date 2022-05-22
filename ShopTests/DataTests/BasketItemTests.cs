using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop.ServerData;
using System.Collections.Generic;

namespace Shop.ServerDataTests
{
    [TestClass]
    public class BasketItemTests
    {
        List<ProductType> ProductTypeList;

        [TestInitialize]
        public void Before()
        {
            ProductTypeList = new List<ProductType>();

            ProductTypeList.Add(new ProductType("Trousers"));
        }

        [TestMethod]
        public void GetBasketTotalPrice()
        {
            Product Product = new Product("Blue Jeans", 20, 5, ProductTypeList);

            BasketItem BasketItem = new BasketItem(Product, 2);

            Assert.AreEqual(40, BasketItem.GetTotalPrice());
        }
    }
}

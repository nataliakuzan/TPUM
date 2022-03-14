using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shop;

namespace ShopTests
{
    [TestClass]
    public class ShopTests
    {
        [TestMethod]
        public void AddItemTest()
        {
            Shop.Shop s = new Shop.Shop();
            s.AddItem(1);
        }
    }
}

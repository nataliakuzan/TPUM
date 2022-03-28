using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BusinessLogic;

namespace BussinessLogicTests
{
    [TestClass]
    public class BussinessLogicTest
    {
        [TestMethod]
        public void TestAddProduct()
        {
            Shop s = new Shop();
            s.AddProduct(1);
        }
    }
}

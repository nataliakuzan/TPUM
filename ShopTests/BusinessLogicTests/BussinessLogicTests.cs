using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shop.BusinessLogic;

namespace Shop.BussinessLogicTests
{
    [TestClass]
    public class BussinessLogicTest
    {
        [TestMethod]
        public void ProductRepositoryTest()
        {
            Mock <ProductRepository> mock = new Mock<ProductRepository>();
        }
    }
}

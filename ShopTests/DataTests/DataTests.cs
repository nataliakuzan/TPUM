using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;

namespace Shop.DataTests
{
    [TestClass]
    public class DataTests
    {
        [TestMethod]
        public void ProductQuantityTest()
        {
            Mock<Product> mock = new Mock<Product>("Name", 10.0, 5);
        }

    }
}

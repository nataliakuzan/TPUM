using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shop.ServerBusinessLogic;
using Shop.ServerData;
using System.Collections.Generic;

namespace Shop.ServerBussinessLogicTests
{
    [TestClass]
    public class OrderRepositoryTests
    {
        [TestMethod]
        public void OrderRepositorySaveTest()
        {
            List<ProductType> ProductTypeList = new List<ProductType>();
            ProductTypeList.Add(new ProductType("Trousers"));

            List<BasketItem> list = new List<BasketItem>();

            Mock<IBasketItemFactory> basketItemFactory = new Mock<IBasketItemFactory>();
            basketItemFactory.Setup(x => x.CreateBasketItem(new Product("Blue Jeans", 20, 5, ProductTypeList), 2));
            BasketItem expectedBasketItem = new BasketItem(new Product("Blue Jeans", 20, 5, ProductTypeList), 2);
            list.Add(expectedBasketItem);

            Store Shop = new Store();

            Mock<IOrderRepository> repository = new Mock<IOrderRepository>();
            repository.Setup(x => x.Save(Shop, new Order(list, "Anna", "Delvey", "Manhattan 101, New York")));

        }
    }
}

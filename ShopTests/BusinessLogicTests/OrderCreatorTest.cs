using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop.BusinessLogic;
using Moq;
using System;
using Shop.Data;
using System.Collections.Generic;

namespace Shop.BussinessLogicTests
{
    [TestClass]
    public class OrderCreatorTest
    {
        private Mock<ProductRepository> ProductRepository;

        private Mock<OrderRepository> OrderRepository;

        private Mock<BasketItemFactory> BasketItemFactory;

        private Mock<OrderFactory> OrderFactory;

        private Mock<Store> Store;

        private OrderCreator OrderCreator;

        private Product Product1;
        
        private Product Product2;

        [TestInitialize]
        public void Before()
        {
            ProductRepository = new Mock<ProductRepository>();
            OrderRepository = new Mock<OrderRepository>();
            BasketItemFactory = new Mock<BasketItemFactory>();
            OrderFactory = new Mock<OrderFactory>();

            Store = new Mock<Store>();

            OrderCreator = new OrderCreator(ProductRepository.Object, OrderRepository.Object, BasketItemFactory.Object, OrderFactory.Object);

            List<ProductType> ProductTypes = new List<ProductType>();
            ProductTypes.Add(new ProductType("Trousers"));

            Product1 = new Product("Blue Jeans", 10, 5, ProductTypes);
            Product2 = new Product("Blue Jeans", 15, 7, ProductTypes);

            //ProductRepository.Setup(x => x.FetchById(Store.Object, Product1.Id)).Returns(Product1);
            //ProductRepository.Setup(x => x.FetchById(Store.Object, Product2.Id)).Returns(Product2);
        }

        [TestMethod]
        public void ItShouldSaveOrder()
        {
            int Product1QuantityOrdered = 4;
            string ClientName = "Uncle";
            string ClientLastName = "Bob";
            string Address = "491 Bryan Avenue, 55406, Minneapolis";

            Dictionary<int, int> IdsAndQuantitiesOrdered = new Dictionary<int, int>();
            IdsAndQuantitiesOrdered.Add(Product1.Id, Product1QuantityOrdered);

            List<BasketItem> expectedBasketItems = new List<BasketItem>();
            BasketItem expectedBasketItem = new BasketItem(Product1, Product1QuantityOrdered);
            expectedBasketItems.Add(expectedBasketItem);

            Order expectedOrder = new Order(expectedBasketItems, ClientName, ClientLastName, Address);

            //BasketItemFactory.Setup(x => x.CreateBasketItem(Product1, Product1QuantityOrdered)).Returns(expectedBasketItem);
            //OrderFactory.Setup(x => x.CreateOrder(expectedBasketItems, ClientName, ClientLastName, Address));

            //OrderRepository.Verify(x => x.Save(Store.Object, expectedOrder), Times.Once());

            //OrderCreator.OrderProducts(Store.Object, IdsAndQuantitiesOrdered, ClientName, ClientLastName, Address);
        }

    }
}

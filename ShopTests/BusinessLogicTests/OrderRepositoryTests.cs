using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop.BusinessLogic;
using Shop.Data;
using System;
using System.Collections.Generic;

namespace Shop.BussinessLogicTests
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

            BasketItemFactory basketItemFactory = new BasketItemFactory();
            list.Add(basketItemFactory.CreateBasketItem(new Product("Blue Jeans", 20, 5, ProductTypeList), 2));

            Store Shop = new Store();

            IOrderRepository repository = new OrderRepository();
            repository.Save(Shop, new Order(list, "Anna", "Delvey", "Manhattan 101, New York"));

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop.BusinessLogic;
using Shop.Data;
using System.Collections.Generic;

namespace Shop.BussinessLogicTests
{
    [TestClass]
    public class ProductRepositoryTests
    {
        [TestMethod]
        public void ProductRepositoryFetchByIdTest()
        {
            List<ProductType> ProductTypeList = new List<ProductType>();
            ProductTypeList.Add(new ProductType("Trousers"));
            Store Shop = new Store();

            IProductRepository repository = new ProductRepository();
            Product expectedProduct = new Product("Blue Jeans", 20, 5, ProductTypeList);
            repository.Save(Shop, expectedProduct);

            Assert.AreEqual(expectedProduct.Name, repository.FetchById(Shop, expectedProduct.Id).Name);
        }

        [TestMethod]
        public void ProductRepositoryFetchByNameTest()
        {
            List<ProductType> ProductTypeList = new List<ProductType>();
            ProductTypeList.Add(new ProductType("Trousers"));
            Store Shop = new Store();

            IProductRepository repository = new ProductRepository();
            repository.Save(Shop, new Product("Blue Leggins", 20, 5, ProductTypeList));
            repository.Save(Shop, new Product("Gray Jeans", 20, 5, ProductTypeList));

            Assert.AreEqual("Gray Jeans", repository.FetchByName(Shop, "Gray Jeans").Name);
        }

        [TestMethod]
        public void ProductRepositoryFetchByOneTypeTest()
        {
            List<ProductType> ProductTypeList1 = new List<ProductType>();
            ProductTypeList1.Add(new ProductType("Trousers"));

            List<ProductType> ProductTypeList2 = new List<ProductType>();
            ProductTypeList2.Add(new ProductType("Shirts"));
            
            Store Shop = new Store();

            IProductRepository repository = new ProductRepository();

            Product expectedProduct1 = new Product("Blue Leggins", 20, 5, ProductTypeList1);
            Product expectedProduct2 = new Product("Gray Jeans", 20, 5, ProductTypeList1);

            List<Product> expectedProductList = new List<Product>();
            expectedProductList.Add(expectedProduct1);
            expectedProductList.Add(expectedProduct2);

            repository.Save(Shop, expectedProduct1);
            repository.Save(Shop, new Product("Blue Shirt", 20, 5, ProductTypeList2));
            repository.Save(Shop, expectedProduct2);

            Assert.AreEqual(expectedProductList[0].Id, repository.FetchByType(Shop, ProductTypeList1[0])[0].Id);
            Assert.AreEqual(expectedProductList[1].Id, repository.FetchByType(Shop, ProductTypeList1[0])[1].Id);
        }
    }
}

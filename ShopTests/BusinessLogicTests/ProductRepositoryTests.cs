using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shop.ServerBusinessLogic;
using Shop.ServerData;
using System.Collections.Generic;

namespace Shop.ServerBussinessLogicTests
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

            Mock<IProductRepository> repository = new Mock<IProductRepository>();
            Product expectedProduct = new Product("Blue Jeans", 20, 5, ProductTypeList);
            repository.Setup(x => x.Save(Shop, expectedProduct));

            repository.Setup(x => x.FetchById(Shop, expectedProduct.Id)).Returns(expectedProduct);
        }

        [TestMethod]
        public void ProductRepositoryFetchByNameTest()
        {
            List<ProductType> ProductTypeList = new List<ProductType>();
            ProductTypeList.Add(new ProductType("Trousers"));
            Store Shop = new Store();

            Product expectedProduct = new Product("Gray Jeans", 20, 5, ProductTypeList);

            Mock<IProductRepository> repository = new Mock<IProductRepository>();
            repository.Setup(x => x.Save(Shop, new Product("Blue Leggins", 20, 5, ProductTypeList)));
            repository.Setup(x => x.Save(Shop, expectedProduct));

            repository.Setup(x => x.FetchByName(Shop, "Gray Jeans")).Returns(expectedProduct);
        }

        [TestMethod]
        public void ProductRepositoryFetchByOneTypeTest()
        {
            List<ProductType> ProductTypeList1 = new List<ProductType>();
            ProductTypeList1.Add(new ProductType("Trousers"));

            List<ProductType> ProductTypeList2 = new List<ProductType>();
            ProductTypeList2.Add(new ProductType("Shirts"));
            
            Store Shop = new Store();

            Mock<IProductRepository> repository = new Mock<IProductRepository>();

            Product expectedProduct1 = new Product("Blue Leggins", 20, 5, ProductTypeList1);
            Product expectedProduct2 = new Product("Gray Jeans", 20, 5, ProductTypeList1);

            List<Product> expectedProductList = new List<Product>();
            expectedProductList.Add(expectedProduct1);
            expectedProductList.Add(expectedProduct2);

            repository.Setup(x => x.Save(Shop, expectedProduct1));
            repository.Setup(x => x.Save(Shop, new Product("Blue Shirt", 20, 5, ProductTypeList2)));
            repository.Setup(x => x.Save(Shop, expectedProduct2));

            repository.Setup(x => x.FetchByType(Shop, ProductTypeList1[0])).Returns(expectedProductList);
        }
    }
}

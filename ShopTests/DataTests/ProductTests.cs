using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop.Data;
using System.Collections.Generic;

namespace Shop.DataTests
{
    [TestClass]
    public class ProductTests
    {
        List<ProductType> ProductTypeList;

        [TestInitialize]
        public void Before()
        {
            ProductTypeList = new List<ProductType>();

            ProductTypeList.Add(new ProductType("Trousers"));
        }

        [TestMethod]
        public void DecreaseProductQuantityTest()
        {

            Product Product = new Product("Blue Jeans", 20, 5, ProductTypeList);

            Product.DecreaseQuantity(1);

            Assert.AreEqual(4, Product.Quantity);
        }

        [TestMethod]
        public void GetProductByIdInStoreTest()
        {
            Store Store = new Store();

            Product ExpectedProduct = new Product("Grey Jeans", 10, 7, ProductTypeList);

            Store.AddProduct(new Product("Blue Jeans", 20, 5, ProductTypeList));
            Store.AddProduct(ExpectedProduct);

            Assert.AreEqual(ExpectedProduct.Id, Store.GetProductById(ExpectedProduct.Id).Id);
        }

        [TestMethod]
        public void ReplaceProductInStoreTest()
        {
            Store Store = new Store();

            Product ProductToModify = new Product("Blue Jeans", 20, 5, ProductTypeList);

            Store.AddProduct(ProductToModify);
            Store.AddProduct(new Product("Grey Jeans", 10, 7, ProductTypeList));

            ProductToModify.DecreaseQuantity(1);

            Store.ReplaceProduct(ProductToModify);

            Assert.AreEqual(ProductToModify.Quantity, Store.GetProductById(ProductToModify.Id).Quantity);
        }
    }
}

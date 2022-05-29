using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop.ServerData;
using System;
using System.Collections.Generic;

namespace Shop.ServerDataTests
{
    [TestClass]
    public class StoreProductTests
    {
        List<ProductType> ProductTypeList;
        List<ProductType> ProductTypeList2;

        [TestInitialize]
        public void Before()
        {
            ProductTypeList = new List<ProductType>();

            ProductTypeList.Add(new ProductType("Trousers"));

            ProductTypeList2 = new List<ProductType>();

            ProductTypeList2.Add(new ProductType("Tops"));
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

        [TestMethod]
        public void GetProductByTypeInStoreTest()
        {
            Store Store = new Store();

            Product ExpectedProduct1 = new Product("Grey Jeans", 10, 7, ProductTypeList);
            Product ExpectedProduct2 = new Product("Blue Jeans", 15, 7, ProductTypeList);

            Store.AddProduct(ExpectedProduct1);
            Store.AddProduct(new Product("Black Top", 11, 9, ProductTypeList2));
            Store.AddProduct(ExpectedProduct2);

            List<Product> list = new List<Product>();
            list.Add(ExpectedProduct1);
            list.Add(ExpectedProduct2);

            Assert.AreEqual(list[0], Store.GetProductByTypes(ProductTypeList[0])[0]);
            Assert.AreEqual(list[1], Store.GetProductByTypes(ProductTypeList[0])[1]);
        }
    }
}

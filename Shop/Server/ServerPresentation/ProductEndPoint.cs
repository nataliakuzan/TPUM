using System;
using System.Collections.Generic;
using Shop.ServerBusinessLogic;
using Shop.ServerData;

namespace ServerPresentation
{
    class ProductEndPoint : EndPoint
    {
        private Serializer serializer;
        private Serializer typeSerializer;

        public ProductEndPoint(Serializer serializer, Serializer typeSerializer)
        {
            this.serializer = serializer;
            this.typeSerializer = typeSerializer;
        }

        public string Create()
        {
            throw new NotImplementedException();
        }

        public string ListAll()
        {
            var products = Program.LogicLayer.ProductRepository.FetchAll(Program.LogicLayer.Shop);

            return SerializeProductList(products);
        }

        public string ListAllByFilter(string Filter)
        {
            var type = (TypesListDTO)typeSerializer.parseXML(Filter);

            ProductType productType = new ProductType(type.Types[0].Name);

            var products = Program.LogicLayer.ProductRepository.FetchByType(Program.LogicLayer.Shop, productType);

            return SerializeProductList(products);
        }

        private string SerializeProductList(List<Product> products)
        {
            ProductListDTO productsDTO = new ProductListDTO();
            foreach (var Product in products)
            {
                productsDTO.Add(new ProductDTO(Product.Id,
                                               Product.Name,
                                               Product.Price,
                                               Product.Quantity,
                                               Product.Types[0].Name));
            }

            return serializer.parseObject(productsDTO);
        }
    }
}

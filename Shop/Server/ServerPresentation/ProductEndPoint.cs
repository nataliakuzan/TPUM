using System;
using System.Collections.Generic;
using Shop.ServerBusinessLogic;

namespace ServerPresentation
{
    class ProductEndPoint : EndPoint
    {
        private Serializer serializer;

        public ProductEndPoint(Serializer serializer)
        {
            this.serializer = serializer;
        }

        public string Create()
        {
            throw new NotImplementedException();
        }

        public string ListAll()
        {
            var products = Program.businessLogic.ProductRepository.FetchAll(Program.businessLogic.Shop);

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

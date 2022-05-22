using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ServerPresentation
{
    [XmlRoot("ProductList")]
    public class ProductListDTO : ISerializable
    {
        [XmlArrayItem("Product", typeof(ProductDTO))]
        public List<ProductDTO> Products;

        public ProductListDTO()
        {
            this.Products = new List<ProductDTO>();
        }

        public void Add(ProductDTO productDTO)
        {
            Products.Add(productDTO);
        }
    }
}

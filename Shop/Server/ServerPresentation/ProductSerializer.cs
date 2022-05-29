using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ServerPresentation
{
    public class ProductSerializer : Serializer
    {
        public override ISerializable parseXML(string XML)
        {
            ProductListDTO productList;
            XmlSerializer serializer = new XmlSerializer(typeof(ProductListDTO));
            using (TextReader reader = new StringReader(XML))
            {
                productList = (ProductListDTO)serializer.Deserialize(reader);
            }

            return productList;
        }

        protected override XmlSerializer GetXMLSerializer(ISerializable Serializable)
        {
            if (Serializable is ProductDTO)
            {
                return new XmlSerializer(typeof(ProductDTO));
            }
            if (Serializable is ProductListDTO)
            {
                return new XmlSerializer(typeof(ProductListDTO));
            }
            return null;
        }
    }
}

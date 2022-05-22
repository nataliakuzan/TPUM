using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ServerPresentation
{
    public class ProductSerializer : Serializer
    {
        public override ISerializable parseXML(string XML)
        {
            var reader = new System.Xml.Serialization.XmlSerializer(typeof(ProductDTO));
            TextReader textReader = new StringReader(XML);
            string overview = (string)reader.Deserialize(textReader);

            return new ProductDTO(1, "Fake", 10.0f, 2, "Fake");
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

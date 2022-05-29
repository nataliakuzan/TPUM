using System.IO;
using System.Xml.Serialization;

namespace ServerPresentation
{
    public class TypeSerializer : Serializer
    {
        public override ISerializable parseXML(string XML)
        {
            TypesListDTO typeList;
            XmlSerializer serializer = new XmlSerializer(typeof(TypesListDTO));
            using (TextReader reader = new StringReader(XML))
            {
                typeList = (TypesListDTO)serializer.Deserialize(reader);
            }

            return typeList;
        }

        protected override XmlSerializer GetXMLSerializer(ISerializable Serializable)
        {
            if (Serializable is TypeDTO)
            {
                return new XmlSerializer(typeof(TypeDTO));
            }
            if (Serializable is TypesListDTO)
            {
                return new XmlSerializer(typeof(TypesListDTO));
            }
            return null;
        }
    }
}
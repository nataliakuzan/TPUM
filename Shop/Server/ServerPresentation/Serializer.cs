using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ServerPresentation
{
    public abstract class Serializer
    {
        public abstract ISerializable parseXML(string XML);

        public string parseObject(ISerializable Serializable)
        {
            StringWriter stringWriter = new StringWriter();
            GetXMLSerializer(Serializable).Serialize(stringWriter, Serializable);

            return stringWriter.ToString();
        }

        protected abstract XmlSerializer GetXMLSerializer(ISerializable Serializable);
    }
}

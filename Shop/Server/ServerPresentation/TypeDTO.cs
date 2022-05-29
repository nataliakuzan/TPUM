using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ServerPresentation
{
    [XmlRoot("Type")]
    public class TypeDTO : ISerializable
    {
        public string Name { get; set; }

        public TypeDTO()
        {

        }

        public TypeDTO(string Name)
        {
            this.Name = Name;
        }

    }
}

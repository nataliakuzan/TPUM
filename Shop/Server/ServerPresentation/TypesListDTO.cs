using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ServerPresentation
{
    [XmlRoot("TypesList")]
    public class TypesListDTO : ISerializable
    {
        [XmlArrayItem("Type", typeof(TypeDTO))]
        public List<TypeDTO> Types;

        public TypesListDTO()
        {
            this.Types = new List<TypeDTO>();
        }

        public void Add(TypeDTO Type)
        {
            Types.Add(Type);
        }
    }
}

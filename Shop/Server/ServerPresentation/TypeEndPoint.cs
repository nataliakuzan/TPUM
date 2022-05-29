using System.Collections.Generic;

namespace ServerPresentation
{
    internal class TypeEndPoint : EndPoint
    {
        private Serializer serializer;

        public TypeEndPoint(Serializer serializer)
        {
            this.serializer = serializer;
        }

        public string Create()
        {
            throw new System.NotImplementedException();
        }

        public string ListAll()
        {
            var types = Program.LogicLayer.TypeRepository.FetchAll(Program.LogicLayer.Shop);

            TypesListDTO typesDTO = new TypesListDTO();
            foreach (var Type in types)
            {
                typesDTO.Add(new TypeDTO(Type.Name));
            }

            return serializer.parseObject(typesDTO);
        }

        public string ListAllByFilter(string Filter)
        {
            throw new System.NotImplementedException();
        }
    }
}
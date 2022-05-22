using System;

namespace Shop.ServerData
{
    public class ProductType
    {
        private string TypeName { get; set; }

        public ProductType(string Name)
        {
            TypeName = Name;
        }

        public string Name => TypeName;

    }
}

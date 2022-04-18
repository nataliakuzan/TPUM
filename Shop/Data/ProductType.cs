using System;

namespace Shop.Data
{
    public class ProductType
    {
        private string TypeName { get; set; }

        public ProductType(string Name)
        {
            TypeName = Name;
        }

        public string Name
        {
            get
            {
                return TypeName;
            }
        }

    }
}

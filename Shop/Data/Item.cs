using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data
{
    internal class Item : Entity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public float Price { get; set; }

        public Item() { }

        public Item(Item i)
        {
            Id = i.Id;
            Name = i.Name;
            Type = i.Type;
            Price = i.Price;
        }

        public override bool Equals(object obj)
        {
            return obj is Item i &&
                    base.Equals(obj) &&
                    Id == i.Id &&
                    Name == i.Name &&
                    Type == i.Type &&
                    Price == i.Price;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}

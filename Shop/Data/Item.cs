using System;
using System.Collections.Generic;
using System.Text;

namespace Data
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


    }
}

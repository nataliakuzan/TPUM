using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    internal class Entity : IEntity
    {
        public int Id { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Entity e && e.Id==Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}

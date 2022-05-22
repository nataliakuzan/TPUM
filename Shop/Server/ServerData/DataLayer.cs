using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.ServerData
{
    public interface IDataLayer
    {
        Store Shop { get; set; }
        DataLayer Create(Store data);
    }

    public class DataLayer : IDataLayer
    {
        public Store Shop { get; set; }

        public DataLayer(Store data = default)
        {
            Shop = data ?? new Store();
            Shop.Initialize();
        }

        public DataLayer Create(Store data)
        {
            return new DataLayer(data);
        }

    }
}

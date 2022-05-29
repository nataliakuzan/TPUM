using Shop.ServerData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.ServerBusinessLogic
{
    public interface ITypeRepository
    {
        List<ProductType> FetchAll(Store Shop);
    }

    internal class TypeRepository : ITypeRepository
    {
        public List<ProductType> FetchAll(Store Shop)
        {
            return Shop.GetTypes();
        }
    }
}

using Shop.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.BusinessLogic
{
    public interface IBusinessLogicLayer
    {
        Store Shop { get; set; }
        IDataLayer ShopData { get; set; }
        BusinessLogicLayer Create(IDataLayer ShopData = default(IDataLayer));
    }

    public class BusinessLogicLayer : IBusinessLogicLayer
    {
        public Store Shop { get; set; }
        public IDataLayer ShopData { get; set; }

        public BusinessLogicLayer(IDataLayer ShopData)
        {
            this.ShopData = ShopData;
            Shop = ShopData.Shop;
        }

        public BusinessLogicLayer Create(IDataLayer ShopData = default(IDataLayer))
        {
            return new BusinessLogicLayer(ShopData);
        }

    }
}

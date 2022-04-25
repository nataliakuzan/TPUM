using Shop.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Presentation.Model
{
    public abstract class ModelAbstractAPI
    {
        public abstract IBusinessLogicLayer ShopLogicLayer { get; }
        public abstract ShopModel Shop { get; }
        public abstract OrderModel Order { get; }

        public static ModelAbstractAPI CreateAPI(IBusinessLogicLayer LogicLayer = default(IBusinessLogicLayer))
        {
            return new ModelAPI(LogicLayer);
        }
    }

    internal class ModelAPI : ModelAbstractAPI
    {
        public ModelAPI(IBusinessLogicLayer ShopLogicLayer)
        {
            this.ShopLogicLayer = ShopLogicLayer;
            this.Shop = new ShopModel();
        }

        public override IBusinessLogicLayer ShopLogicLayer { get; }
        public override ShopModel Shop { get; }
        public override OrderModel Order { get; }
    }
}

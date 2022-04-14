using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data
{
    public interface IData //: IObservable<IEntity>
    {
        //void BuyItem(IEntity item);
        void AddItem();
        void UpdateItem();
        void ClearItem();
    }
}

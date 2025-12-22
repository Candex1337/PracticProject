using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentAccounting.BLL
{
    public interface IObservable
    {
        void AddObserver(IDataObserver observer);
        void RemoveObserver(IDataObserver observer);
        void NotifyObservers();
    }

}

using System.Collections.Generic;
using System.Linq;
using EquipmentAccounting.BLL;
using EquipmentAccounting.DAL.Data;
using EquipmentAccounting.DAL.Entities;

public class EquipmentTypeService : IObservable
{
    private EquipmentDbContext db = new EquipmentDbContext();
    private List<IDataObserver> observers = new List<IDataObserver>();

    public List<EquipmentType> GetAll()
    {
        return db.EquipmentTypes.ToList();
    }

    public void Add(EquipmentType type)
    {
        db.EquipmentTypes.Add(type);
        db.SaveChanges();

        // 🔴 ВАЖНО: уведомляем
        NotifyObservers();
    }

    public void AddObserver(IDataObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IDataObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
            observer.UpdateData();
    }
}

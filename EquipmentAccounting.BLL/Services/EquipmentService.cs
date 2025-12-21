using System.Collections.Generic;
using System.Linq;
using EquipmentAccounting.DAL.Data;
using EquipmentAccounting.DAL.Entities;

namespace EquipmentAccounting.BLL.Services
{
    public class EquipmentService
    {
        private EquipmentDbContext db;

        public EquipmentService()
        {
            db = new EquipmentDbContext();
        }

        public List<Equipment> GetAll()
        {
            return db.Equipments.ToList();
        }

        public void Add(Equipment equipment)
        {
            db.Equipments.Add(equipment);
            db.SaveChanges();
        }

        public void Update(Equipment equipment)
        {
            db.Equipments.Update(equipment);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var equipment = db.Equipments.Find(id);
            if (equipment != null)
            {
                db.Equipments.Remove(equipment);
                db.SaveChanges();
            }
        }
    }
}

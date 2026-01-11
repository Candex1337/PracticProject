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
        public EquipmentService(EquipmentDbContext context)
        {
            db = context;
        }

        public List<Equipment> GetAll()
        {
            return db.Equipments.ToList();
        }
        public void Add(Equipment equipment)
        {
            int nextNumber = 1;

            if (db.Equipments.Any())
                nextNumber = db.Equipments.Max(e => e.Id) + 1;

            equipment.InventoryNumber = $"INV-{nextNumber:0000}";
            equipment.SerialNumber = $"SN-{nextNumber:0000}";

            db.Equipments.Add(equipment);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var equipment = db.Equipments.FirstOrDefault(e => e.Id == id);
            if (equipment == null)
                return;

            var softwares = db.EquipmentSoftwares
                .Where(es => es.EquipmentId == id)
                .ToList();
            db.EquipmentSoftwares.RemoveRange(softwares);

            var history = db.EquipmentHistories
                .Where(h => h.EquipmentId == id)
                .ToList();
            db.EquipmentHistories.RemoveRange(history);

            db.Equipments.Remove(equipment);

            db.SaveChanges();
        }
        public void Update(Equipment equipment)
        {
            db.Equipments.Update(equipment);
            db.SaveChanges();
        }
    }
}

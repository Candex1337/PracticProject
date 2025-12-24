using EquipmentAccounting.DAL.Data;
using EquipmentAccounting.DAL.Entities;

namespace EquipmentAccounting.BLL.Services
{
    public class EquipmentTypeService
    {
        private EquipmentDbContext db = new EquipmentDbContext();

        public List<EquipmentType> GetAll()
        {
            return db.EquipmentTypes.ToList();
        }

        public void Add(EquipmentType type)
        {
            db.EquipmentTypes.Add(type);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var type = db.EquipmentTypes.FirstOrDefault(t => t.Id == id);
            if (type == null)
                return;

            db.EquipmentTypes.Remove(type);
            db.SaveChanges();
        }
    }
}
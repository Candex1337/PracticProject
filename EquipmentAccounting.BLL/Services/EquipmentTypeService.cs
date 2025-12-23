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
    }
}
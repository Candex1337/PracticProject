using EquipmentAccounting.DAL.Data;
using EquipmentAccounting.DAL.Entities;

namespace EquipmentAccounting.BLL.Services
{
    public class EquipmentStatusService
    {
        private EquipmentDbContext db = new EquipmentDbContext();

        public List<EquipmentStatus> GetAll()
        {
            return db.EquipmentStatuses.ToList();
        }
    }
}

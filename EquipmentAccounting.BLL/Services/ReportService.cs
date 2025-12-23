using System.Linq;
using EquipmentAccounting.DAL.Data;

namespace EquipmentAccounting.BLL.Services
{
    public class ReportService
    {
        private EquipmentDbContext db = new EquipmentDbContext();

        public object GetEquipmentByDepartments()
        {
            return db.Equipments
                .Select(e => new
                {
                    Department = e.Department.Name,
                    InventoryNumber = e.InventoryNumber,
                    EquipmentName = e.Name
                })
                .ToList();
        }
    }
}

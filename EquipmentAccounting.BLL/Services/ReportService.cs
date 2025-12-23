using EquipmentAccounting.DAL.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EquipmentAccounting.BLL.Services
{
    public class ReportService
    {
        private EquipmentDbContext db = new EquipmentDbContext();

        public object GetEquipmentByDepartments()
        {
            return db.Equipments
            .Include(e => e.Employee)
                .ThenInclude(emp => emp.Department)
            .Select(e => new
            {
                Department = e.Employee != null && e.Employee.Department != null
                    ? e.Employee.Department.Name
                    : "—",
                InventoryNumber = e.InventoryNumber,
                EquipmentName = e.Name
            })
            .ToList();
        }
    }
}

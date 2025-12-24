using EquipmentAccounting.DAL.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EquipmentAccounting.BLL.Services
{
    public class ReportService
    {
        private EquipmentDbContext db = new EquipmentDbContext();

        public List<object> GetSoftwareByEmployee(int employeeId)
        {
            return db.EquipmentSoftwares
                .Where(es => es.Equipment.EmployeeId == employeeId)
                .Select(es => new
                {
                    Employee = es.Equipment.Employee.FullName,
                    InventoryNumber = es.Equipment.InventoryNumber,
                    EquipmentName = es.Equipment.Name,
                    SoftwareName = es.SoftwareLicense.Name,
                    InstallDate = es.InstallDate
                })
                .ToList<object>();
        }

        public List<object> GetEquipmentByDepartments()
        {
            return db.Equipments
                .Select(e => new
                {
                    Department =
                        e.Employee != null && e.Employee.Department != null
                            ? e.Employee.Department.Name
                            : "—",
                    InventoryNumber = e.InventoryNumber,
                    EquipmentName = e.Name
                })
                .ToList<object>();
        }
    }
}

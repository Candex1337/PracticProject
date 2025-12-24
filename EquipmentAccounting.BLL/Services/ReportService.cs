using EquipmentAccounting.DAL.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EquipmentAccounting.BLL.Services
{
    public class ReportService
    {
        private EquipmentDbContext db = new EquipmentDbContext();

        public object GetSoftwareByEmployee(int employeeId)
        {
            return db.Equipments
                .Where(e => e.EmployeeId == employeeId)
                .Include(e => e.Employee)
                .Include(e => e.EquipmentSoftwares)
                    .ThenInclude(es => es.SoftwareLicense)
                .SelectMany(e => e.EquipmentSoftwares.Select(es => new
                {
                    Employee = e.Employee.FullName,
                    InventoryNumber = e.InventoryNumber,
                    EquipmentName = e.Name,
                    SoftwareName = es.SoftwareLicense.Name,
                    InstallDate = es.InstallDate
                }))
                .ToList();
        }

        public List<object> GetEquipmentByDepartments()
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
                .ToList<object>();
        }
    }
}

using EquipmentAccounting.DAL.Data;
using EquipmentAccounting.DAL.Entities;

namespace EquipmentAccounting.BLL.Services
{
    public class EmployeeService
    {
        private EquipmentDbContext db = new EquipmentDbContext();

        public List<Employee> GetAll()
        {
            return db.Employees.ToList();
        }
    }
}

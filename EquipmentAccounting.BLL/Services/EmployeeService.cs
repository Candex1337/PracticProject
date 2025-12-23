using EquipmentAccounting.DAL.Data;
using EquipmentAccounting.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EquipmentAccounting.BLL.Services
{
    public class EmployeeService
    {
        private EquipmentDbContext db = new EquipmentDbContext();

        public List<Employee> GetAll()
        {
            return db.Employees
                .Include(e => e.Department)
                .ToList();
        }

        public void Add(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
        }

        public void Update(Employee employee)
        {
            db.Employees.Update(employee);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var emp = db.Employees.Find(id);
            if (emp != null)
            {
                db.Employees.Remove(emp);
                db.SaveChanges();
            }
        }
    }
}

using EquipmentAccounting.DAL.Data;
using EquipmentAccounting.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EquipmentAccounting.BLL.Services
{
    public class EmployeeService
    {
        private EquipmentDbContext db = new EquipmentDbContext();

        public List<object> GetAllForGrid()
        {
            return db.Employees
                .Select(e => new
                {
                    e.Id,
                    e.FullName,
                    e.Position,
                    Department = e.Department != null ? e.Department.Name : ""
                })
                .ToList<object>();
        }

        public Employee GetById(int id)
        {
            return db.Employees.Find(id);
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
            bool usedInEquipment = db.Equipments.Any(e => e.EmployeeId == id);

            bool usedInHistory = db.EquipmentHistories.Any(h =>
                h.OldEmployeeId == id || h.NewEmployeeId == id
            );

            if (usedInEquipment || usedInHistory)
                throw new InvalidOperationException(
                    "Нельзя удалить сотрудника, так как он используется в оборудовании или истории перемещений"
                );

            var emp = db.Employees.Find(id);
            if (emp != null)
            {
                db.Employees.Remove(emp);
                db.SaveChanges();
            }
        }
    }
}

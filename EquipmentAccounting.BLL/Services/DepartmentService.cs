using System.Collections.Generic;
using System.Linq;
using EquipmentAccounting.DAL.Data;
using EquipmentAccounting.DAL.Entities;

namespace EquipmentAccounting.BLL.Services
{
    public class DepartmentService
    {
        private EquipmentDbContext db = new EquipmentDbContext();

        public List<Department> GetAll()
        {
            return db.Departments.ToList();
        }

        public void Add(Department department)
        {
            db.Departments.Add(department);
            db.SaveChanges();
        }

        public void Update(Department department)
        {
            db.Departments.Update(department);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var department = db.Departments.Find(id);
            if (department != null)
            {
                db.Departments.Remove(department);
                db.SaveChanges();
            }
        }
    }
}

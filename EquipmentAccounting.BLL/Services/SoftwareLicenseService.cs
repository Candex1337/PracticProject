using EquipmentAccounting.DAL.Data;
using EquipmentAccounting.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentAccounting.BLL.Services
{
    public class SoftwareLicenseService
    {
        private EquipmentDbContext db = new EquipmentDbContext();

        public List<SoftwareLicense> GetAll()
        {
            return db.SoftwareLicenses.ToList();
        }
        public void Add(SoftwareLicense license)
        {
            db.SoftwareLicenses.Add(license);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var license = db.SoftwareLicenses.FirstOrDefault(l => l.Id == id);
            if (license == null)
                return;

            db.SoftwareLicenses.Remove(license);
            db.SaveChanges();
        }
    }
}

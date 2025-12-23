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
    }
}

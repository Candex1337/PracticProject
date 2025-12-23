using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using EquipmentAccounting.DAL.Data;
using EquipmentAccounting.DAL.Entities;

namespace EquipmentAccounting.BLL.Services
{
    public class EquipmentSoftwareService
    {
        private EquipmentDbContext db = new EquipmentDbContext();

        // Установить ПО на оборудование
        public void Install(int equipmentId, int licenseId)
        {
            var link = new EquipmentSoftware
            {
                EquipmentId = equipmentId,
                SoftwareLicenseId = licenseId,
                InstallDate = DateTime.Now
            };

            db.EquipmentSoftwares.Add(link);
            db.SaveChanges();
        }

        // Получить установленное ПО
        public List<EquipmentSoftware> GetByEquipment(int equipmentId)
        {
            return db.EquipmentSoftwares
                .Include(x => x.SoftwareLicense)
                .Where(x => x.EquipmentId == equipmentId)
                .ToList();
        }

        // Удалить ПО
        public void Delete(int id)
        {
            var item = db.EquipmentSoftwares.Find(id);
            if (item == null) return;

            db.EquipmentSoftwares.Remove(item);
            db.SaveChanges();
        }
    }
}

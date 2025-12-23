using EquipmentAccounting.DAL.Data;
using EquipmentAccounting.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentAccounting.BLL.Services
{
    public class EquipmentHistoryService
    {
        private EquipmentDbContext db = new EquipmentDbContext();

        public List<EquipmentHistory> GetAll()
        {
            return db.EquipmentHistories.ToList();
        }

        public void Add(int equipmentId, int? oldEmployeeId, int newEmployeeId)
        {
            var history = new EquipmentHistory
            {
                EquipmentId = equipmentId,
                OldEmployeeId = oldEmployeeId,
                NewEmployeeId = newEmployeeId
            };

            db.EquipmentHistories.Add(history);
            db.SaveChanges();
        }
    }
}

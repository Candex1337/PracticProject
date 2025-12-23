using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentAccounting.DAL.Entities
{
    public class EquipmentHistory
    {
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        public int? OldEmployeeId { get; set; }
        public int NewEmployeeId { get; set; }
        public DateTime ChangeDate { get; set; }
    }
}

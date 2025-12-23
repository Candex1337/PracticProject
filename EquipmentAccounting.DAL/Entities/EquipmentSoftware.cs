using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentAccounting.DAL.Entities
{
    public class EquipmentSoftware
    {
        public int Id { get; set; }

        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }

        public int SoftwareLicenseId { get; set; }
        public SoftwareLicense SoftwareLicense { get; set; }

        public DateTime InstallDate { get; set; }

        public override string ToString()
        {
            return SoftwareLicense?.Name ?? "Без лицензии";
        }
    }
}

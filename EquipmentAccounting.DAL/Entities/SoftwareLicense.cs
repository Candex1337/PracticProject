using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentAccounting.DAL.Entities
{
    public class SoftwareLicense
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LicenseKey { get; set; }
        public ICollection<EquipmentSoftware> EquipmentSoftwares { get; set; }
           = new List<EquipmentSoftware>();
    }
}

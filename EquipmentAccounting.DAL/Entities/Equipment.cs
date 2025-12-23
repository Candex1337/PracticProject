namespace EquipmentAccounting.DAL.Entities
{
    public class Equipment
    {
        public int Id { get; set; }
        public string InventoryNumber { get; set; }
        public int EquipmentTypeId { get; set; }
        public EquipmentType EquipmentType { get; set; }
        public string Name { get; set; }  
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
        public int? EquipmentStatusId { get; set; }
        public EquipmentStatus EquipmentStatus { get; set; }
        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}

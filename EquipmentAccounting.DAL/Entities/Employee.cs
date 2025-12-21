namespace EquipmentAccounting.DAL.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}

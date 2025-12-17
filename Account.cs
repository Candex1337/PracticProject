namespace EquipmentAccounting.DAL.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public int UserId { get; set; }
    }
}
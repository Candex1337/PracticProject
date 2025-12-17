namespace EquipmentAccounting.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public int RoleId { get; set; }
        public int CurrencyId { get; set; }
    }
}
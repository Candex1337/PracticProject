using System;

namespace EquipmentAccounting.DAL.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public string OperationNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTime OperationDate { get; set; }
        public string Type { get; set; }
        public int CategoryId { get; set; }
        public int AccountId { get; set; }
        public string Description { get; set; }
    }
}
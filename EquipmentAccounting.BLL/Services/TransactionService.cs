using System.Collections.Generic;
using EquipmentAccounting.DAL.Data;
using EquipmentAccounting.DAL.Entities;
using EquipmentAccounting.DAL.Repositories;

namespace EquipmentAccounting.BLL.Services
{
    public class TransactionService
    {
        private readonly GenericRepository<Transaction> repository;

        public TransactionService()
        {
            var context = new FinanceDbContext();
            var repository = new GenericRepository<Transaction>(context);
        }

        public IEnumerable<Transaction> GetAll()
        {
            return repository.GetAll();
        }

        public void Add(Transaction transaction)
        {
            repository.Add(transaction);
            repository.Save();
        }

        public void Delete(Transaction transaction)
        {
            repository.Delete(transaction);
            repository.Save();
        }
    }
}

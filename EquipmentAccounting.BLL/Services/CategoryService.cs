using System.Collections.Generic;
using EquipmentAccounting.DAL.Data;
using EquipmentAccounting.DAL.Entities;
using EquipmentAccounting.DAL.Repositories;

namespace EquipmentAccounting.BLL.Services
{
    public class CategoryService
    {
        private readonly GenericRepository<Category> repository;

        public CategoryService()
        {
            var context = new FinanceDbContext();
            var repository = new GenericRepository<Category>(context);
        }

        public IEnumerable<Category> GetAll()
        {
            return repository.GetAll();
        }

        public void Add(Category category)
        {
            repository.Add(category);
            repository.Save();
        }

        public void Delete(Category category)
        {
            repository.Delete(category);
            repository.Save();
        }
    }
}

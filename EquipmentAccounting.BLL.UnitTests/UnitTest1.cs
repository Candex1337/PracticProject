using System;
using System.Linq;
using Xunit;
using Microsoft.EntityFrameworkCore;
using EquipmentAccounting.DAL.Data;
using EquipmentAccounting.DAL.Entities;
using EquipmentAccounting.BLL.Services;

public class EquipmentServiceTests
{
    // создание InMemory БД
    private EquipmentDbContext CreateDb()
    {
        var options = new DbContextOptionsBuilder<EquipmentDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        return new EquipmentDbContext(options);
    }

    // создание Equipment
    [Fact]
    public void Equipment_Created()
    {
        var equipment = new Equipment
        {
            Name = "Ноутбук",
            InventoryNumber = "INV-0001"
        };

        Assert.Equal("Ноутбук", equipment.Name);
        Assert.Equal("INV-0001", equipment.InventoryNumber);
    }

    // Add работает
    [Fact]
    public void Add_Equipment()
    {
        var db = CreateDb();
        var service = new EquipmentService(db);

        var equipment = new Equipment
        {
            Name = "ПК",
            EquipmentTypeId = 1,
            EquipmentStatusId = 1
        };

        service.Add(equipment);

        Assert.Single(db.Equipments);
    }

    // нельзя удалить оборудование с ПО
    [Fact]
    public void Delete_Equipment()
    {
        var db = CreateDb();

        db.Equipments.Add(new Equipment
        {
            Id = 1,
            Name = "ПК"
        });

        db.EquipmentSoftwares.Add(new EquipmentSoftware
        {
            EquipmentId = 1,
            SoftwareLicenseId = 1
        });

        db.SaveChanges();

        var service = new EquipmentService(db);

        Assert.Throws<InvalidOperationException>(() =>
            service.Delete(1)
        );
    }
}

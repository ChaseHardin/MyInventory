using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyInventory.Business.Features.Inventory;
using MyInventory.Business.Features.Inventory.Commands;
using MyInventory.Business.Tests.Data.Inventory;
using MyInventory.Data.Infrastructure;

namespace MyInventory.Business.Tests.Features.Inventory
{
    [TestClass]
    public class PutInventoryCommandExecuteTests
    {
        [TestMethod]
        public void ShouldUpdateInventory()
        {
            var inventoryId = Guid.NewGuid();
            SaveInventory(Inventory1234.Build(inventoryId));

            var inventoryVm = new InventoryViewModel
            {
                InventoryId = inventoryId,
                Name = "Updated Name",
                Description = "Updated Description",
                Price = 22.25M,
                Quantity = 10,
                Category = "Updated Category"
            };

            new PutInventoryCommand(inventoryId, inventoryVm).Execute();
            var updatedRecord = GetSavedRecord(inventoryId);

            Assert.AreEqual(inventoryVm.InventoryId, updatedRecord.InventoryId);
            Assert.AreEqual(inventoryVm.Name, updatedRecord.Name);
            Assert.AreEqual(inventoryVm.Description, updatedRecord.Description);
            Assert.AreEqual(inventoryVm.Category, updatedRecord.Category);
            Assert.AreEqual(inventoryVm.Price, updatedRecord.Price);
            Assert.AreEqual(inventoryVm.Quantity, updatedRecord.Quantity);
        }

        private MyInventory.Data.Models.Inventory GetSavedRecord(Guid inventoryId)
        {
            using (var db = Application.GetDatabaseInstance())
            {
                return db.Inventories.FirstOrDefault(i => i.InventoryId == inventoryId);
            }
        }

        private void SaveInventory(MyInventory.Data.Models.Inventory inventory)
        {
            using (var db = Application.GetDatabaseInstance())
            {
                db.Inventories.Add(inventory);
                db.SaveChanges();
            }
        }
    }
}
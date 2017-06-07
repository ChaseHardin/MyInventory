using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyInventory.Business.Features.Inventory.Commands;
using MyInventory.Business.Tests.Data.Inventory;
using MyInventory.Data.Infrastructure;

namespace MyInventory.Business.Tests.Features.Inventory
{
    [TestClass]
    public class DeleteInventoryCommandExecuteTests
    {
        [TestMethod]
        public void ShouldDeleteExistingInventory()
        {
            var inventoryId = Guid.NewGuid();
            var inventory = Inventory1234.Build(inventoryId);
            SaveInventory(inventory);

            new DeleteInventoryCommand(inventoryId).Execute();
            var getDeleted = GetInventory(inventoryId);
            
            Assert.IsTrue(getDeleted == null);
        }

        private MyInventory.Data.Models.Inventory GetInventory(Guid inventoryId)
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
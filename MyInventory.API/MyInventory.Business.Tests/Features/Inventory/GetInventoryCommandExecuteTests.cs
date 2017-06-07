using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyInventory.Business.Features.Inventory.Commands;
using MyInventory.Business.Tests.Data.Inventory;
using MyInventory.Data.Infrastructure;

namespace MyInventory.Business.Tests.Features.Inventory
{
    [TestClass]
    public class GetInventoryCommandExecuteTests
    {
        [TestMethod]
        public void ShouldReturnInventories()
        {
            var inventoryId = Guid.NewGuid();
            var inventory = Inventory1234.Build(inventoryId);
            SaveInventory(inventory);

            var actual = new GetInventoryCommand().Execute();

            Assert.AreEqual(inventoryId, actual.First(x => x.InventoryId == inventoryId).InventoryId);
            Assert.AreEqual(inventory.Name, actual.First(x => x.InventoryId == inventoryId).Name);
            Assert.AreEqual(inventory.Category, actual.First(x => x.InventoryId == inventoryId).Category);
            Assert.AreEqual(inventory.Description, actual.First(x => x.InventoryId == inventoryId).Description);
            Assert.AreEqual(inventory.Price, actual.First(x => x.InventoryId == inventoryId).Price);
            Assert.AreEqual(inventory.Quantity, actual.First(x => x.InventoryId == inventoryId).Quantity);
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

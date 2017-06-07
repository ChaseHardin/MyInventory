using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyInventory.Business.Features.Inventory.Commands;
using MyInventory.Business.Tests.Data.Inventory;
using MyInventory.Data.Infrastructure;

namespace MyInventory.Business.Tests.Features.Inventory
{
    [TestClass]
    public class GetInventoryByIdCommandExecuteTests
    {
        [TestMethod]
        public void ShouldReturnInventoryById()
        {
            var inventoryId = Guid.NewGuid();
            var inventory = Inventory1234.Build(inventoryId);
            SaveInventory(inventory);

            var actual = new GetInventoryByIdCommand(inventoryId).Execute();

            Assert.AreEqual(inventoryId, actual.InventoryId);
            Assert.AreEqual(inventory.Name, actual.Name);
            Assert.AreEqual(inventory.Category, actual.Category);
            Assert.AreEqual(inventory.Description, actual.Description);
            Assert.AreEqual(inventory.Price, actual.Price);
            Assert.AreEqual(inventory.Quantity, actual.Quantity); 
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
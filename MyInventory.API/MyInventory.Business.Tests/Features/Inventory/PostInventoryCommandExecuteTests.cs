using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyInventory.Business.Features.Inventory;
using MyInventory.Business.Features.Inventory.Commands;
using MyInventory.Data.Infrastructure;

namespace MyInventory.Business.Tests.Features.Inventory
{
    [TestClass]
    public class PostInventoryCommandExecuteTests
    {
        [TestMethod]
        public void ShouldSaveInventory()
        {
            var inventory = new InventoryViewModel
            {
                Name = "Peanut Butter",
                Price = 8.55M,
                Quantity = 1,
                Description = "Crunchy peanut butter",
                Category = "lunch"
            };

            var actual = new PostInventoryCommand(inventory).Execute();
            Assert.AreEqual(inventory.Name, actual.Name);
            Assert.AreEqual(inventory.Description, actual.Description);
            Assert.AreEqual(inventory.Category, actual.Category);
            Assert.AreEqual(inventory.Price, actual.Price);
            Assert.AreEqual(inventory.Quantity, actual.Quantity);
        }

        private MyInventory.Data.Models.Inventory SaveInventory(MyInventory.Data.Models.Inventory inventory)
        {
            using (var db = Application.GetDatabaseInstance())
            {
                db.Inventories.Add(inventory);
                db.SaveChanges();

                return db.Inventories.FirstOrDefault(x => x.InventoryId == inventory.InventoryId);
            }
        }
    }
}

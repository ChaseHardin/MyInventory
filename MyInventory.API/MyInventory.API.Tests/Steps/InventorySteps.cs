using System;
using MyInventory.API.Tests.Context;
using MyInventory.Business.Tests.Data.Inventory;
using MyInventory.Data.Infrastructure;
using MyInventory.Data.Models;
using TechTalk.SpecFlow;

namespace MyInventory.API.Tests.Steps
{
    [Binding]
    public sealed class InventorySteps
    {
        [Given(@"inventory exists")]
        public void GivenInventoryExists()
        {
            var inventory = Inventory1234.Build(Guid.NewGuid());

            SaveInventory(inventory);

            var context = MyInventoryFeatureContext.Get();
            context.Inventory = inventory;
            context.AddSubstitute("inventoryId", inventory.InventoryId.ToString());
        }

        private static void SaveInventory(Inventory inventory)
        {
            using (var db = Application.GetDatabaseInstance())
            {
                db.Inventories.Add(inventory);
                db.SaveChanges();
            }
        }
    }
}
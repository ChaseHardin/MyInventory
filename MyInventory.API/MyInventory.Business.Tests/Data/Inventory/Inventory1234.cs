using System;

namespace MyInventory.Business.Tests.Data.Inventory
{
    public class Inventory1234
    {
        public static MyInventory.Data.Models.Inventory Build(Guid inventoryId)
        {
            return new MyInventory.Data.Models.Inventory
            {
                InventoryId = inventoryId,
                Price = 22.25M,
                Quantity = 4,
                Description = "Freshly cut prime rib",
                Category = "Meat",
                Name = "Prime Rib"
            };
        }
    }
}
using System;
using System.Linq;
using MyInventory.Data.Infrastructure;

namespace MyInventory.Business.Features.Inventory.Commands
{
    public class DeleteInventoryCommand
    {
        private readonly Guid _inventoryId;
        public DeleteInventoryCommand(Guid inventoryId)
        {
            _inventoryId = inventoryId;
        }

        public Guid Execute()
        {
            using (var db = Application.GetDatabaseInstance())
            {
                var inventory = db.Inventories.FirstOrDefault(i => i.InventoryId == _inventoryId);
                if (inventory != null) db.Inventories.Remove(inventory);
                db.SaveChanges();
            }

            return _inventoryId;
        }
    }
}
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using MyInventory.Data.Infrastructure;

namespace MyInventory.Business.Features.Inventory.Commands
{
    public class PutInventoryCommand
    {
        private readonly Guid _inventoryId;
        private readonly InventoryViewModel _inventory;

        public PutInventoryCommand(Guid inventoryId, InventoryViewModel inventory)
        {
            _inventoryId = inventoryId;
            _inventory = inventory;
        }

        public InventoryViewModel Execute()
        {
            using (var db = Application.GetDatabaseInstance())
            {
                var dbInventory = db.Inventories.FirstOrDefault(i => i.InventoryId == _inventoryId);
                if (dbInventory == null) return _inventory;

                dbInventory.Name = _inventory.Name;
                dbInventory.Description = _inventory.Description;
                dbInventory.Category = _inventory.Category;
                dbInventory.Price = _inventory.Price;
                dbInventory.Quantity = _inventory.Quantity;

                db.Inventories.AddOrUpdate(dbInventory);
                db.SaveChanges();
            }

            return _inventory;
        }
    }
}
using System;
using MyInventory.Data.Infrastructure;

namespace MyInventory.Business.Features.Inventory.Commands
{
    public class PostInventoryCommand
    {
        private readonly InventoryViewModel _inventory;
        
        public PostInventoryCommand(InventoryViewModel inventory)
        {
            _inventory = inventory;
        }

        public InventoryViewModel Execute()
        {
            using (var db = Application.GetDatabaseInstance())
            {
                var dbInventory = new Data.Models.Inventory
                {
                    InventoryId = Guid.NewGuid(),
                    Name = _inventory.Name,
                    Description = _inventory.Description,
                    Price = _inventory.Price,
                    Quantity = _inventory.Quantity,
                    Category = _inventory.Category
                };

                db.Inventories.Add(dbInventory);
                db.SaveChanges();

                return _inventory;
            }
        }
    }
}
using System;
using System.Linq;
using MyInventory.Data.Infrastructure;

namespace MyInventory.Business.Features.Inventory.Commands
{
    public class GetInventoryByIdCommand
    {
        private readonly Guid _inventoryId;

        public GetInventoryByIdCommand(Guid inventoryId)
        {
            _inventoryId = inventoryId;
        }

        public InventoryViewModel Execute()
        {
            using (var db = Application.GetDatabaseInstance())
            {
                return db.Inventories.Select(x => new InventoryViewModel
                {
                    InventoryId = x.InventoryId,
                    Name = x.Name,
                    Category = x.Category,
                    Quantity = x.Quantity,
                    Description = x.Description,
                    Price = x.Price
                }).FirstOrDefault(x => x.InventoryId == _inventoryId);
            }
        }
    }
}
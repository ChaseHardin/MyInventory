using System.Collections.Generic;
using System.Linq;
using MyInventory.Data.Infrastructure;

namespace MyInventory.Business.Features.Inventory.Commands
{
    public class GetInventoryCommand
    {
        public IEnumerable<InventoryViewModel> Execute()
        {
            using (var db = Application.GetDatabaseInstance())
            {
                return db.Inventories.Select(x => new InventoryViewModel
                {
                    InventoryId = x.InventoryId,
                    Name = x.Name,
                    Price = x.Price,
                    Quantity = x.Quantity,
                    Description = x.Description,
                    Category = x.Category
                }).ToList();
            }
        }
    }
}
using System;
using AutoMapper;

namespace MyInventory.Business.Features.Inventory
{
    public class InventoryViewModel
    {
        static InventoryViewModel()
        {
            Mapper.CreateMap<InventoryViewModel, Data.Models.Inventory>().ReverseMap();
        }

        public Guid InventoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    }
}
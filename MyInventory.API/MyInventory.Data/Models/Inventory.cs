using System;
using System.Data.Entity.ModelConfiguration;

namespace MyInventory.Data.Models
{
    public class Inventory
    {
        public Guid InventoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    }

    internal class InventoryConfiguration : EntityTypeConfiguration<Inventory>
    {
        public InventoryConfiguration()
        {
            HasKey(x => x.InventoryId);

            Property(x => x.InventoryId).HasColumnName("InventoryId").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired();
            Property(x => x.Price).HasColumnName("Price").IsRequired();
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.Category).HasColumnName("Category").IsRequired();
            Property(x => x.Description).HasColumnName("Description").IsRequired();
        }
    }
}
using System.Data.Entity;
using MyInventory.Data.Models;

namespace MyInventory.Data.Infrastructure
{
    public class MyInventoryEntity : DbContext
    {
        public MyInventoryEntity() : base("MyInventoryConnectionString") { }
        public DbSet<Inventory> Inventories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<MyInventoryEntity>(null);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new InventoryConfiguration());
        }
    }
}
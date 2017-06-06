namespace MyInventory.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitInventoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        InventoryId = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        Category = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Test = c.String(),
                    })
                .PrimaryKey(t => t.InventoryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Inventories");
        }
    }
}

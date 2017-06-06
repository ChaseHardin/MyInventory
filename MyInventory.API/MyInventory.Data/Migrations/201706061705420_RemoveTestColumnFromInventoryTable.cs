namespace MyInventory.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveTestColumnFromInventoryTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Inventories", "Test");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Inventories", "Test", c => c.String());
        }
    }
}

namespace ECommerce.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class x : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Categories", "Name", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Products", "Price");
        }
    }
}

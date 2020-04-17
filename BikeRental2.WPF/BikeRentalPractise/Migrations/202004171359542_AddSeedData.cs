namespace BikeRentalPractise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSeedData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stores", "Name", c => c.String());
            AlterColumn("dbo.Customers", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false));
            CreateIndex("dbo.Bikes", "Id", unique: true);
            CreateIndex("dbo.Customers", "Id", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "Id" });
            DropIndex("dbo.Bikes", new[] { "Id" });
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "LastName", c => c.String());
            AlterColumn("dbo.Customers", "FirstName", c => c.String());
            DropColumn("dbo.Stores", "Name");
        }
    }
}

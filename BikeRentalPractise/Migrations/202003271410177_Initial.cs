namespace BikeRentalPractise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bikes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BikeModel = c.Int(nullable: false),
                        BikeType = c.Int(nullable: false),
                        BikeGender = c.Int(nullable: false),
                        Size = c.Int(nullable: false),
                        HourlyRate = c.Int(nullable: false),
                        DailyRate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        City = c.String(),
                        MaxCapacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Bikes_Id = c.Int(),
                        Customer_Id = c.Int(),
                        DropOffStore_Id = c.Int(),
                        PickUpStore_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bikes", t => t.Bikes_Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .ForeignKey("dbo.Stores", t => t.DropOffStore_Id)
                .ForeignKey("dbo.Stores", t => t.PickUpStore_Id)
                .Index(t => t.Bikes_Id)
                .Index(t => t.Customer_Id)
                .Index(t => t.DropOffStore_Id)
                .Index(t => t.PickUpStore_Id);
            
            CreateTable(
                "dbo.StoreBikes",
                c => new
                    {
                        Store_Id = c.Int(nullable: false),
                        Bike_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Store_Id, t.Bike_Id })
                .ForeignKey("dbo.Stores", t => t.Store_Id, cascadeDelete: true)
                .ForeignKey("dbo.Bikes", t => t.Bike_Id, cascadeDelete: true)
                .Index(t => t.Store_Id)
                .Index(t => t.Bike_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "PickUpStore_Id", "dbo.Stores");
            DropForeignKey("dbo.Reservations", "DropOffStore_Id", "dbo.Stores");
            DropForeignKey("dbo.Reservations", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Reservations", "Bikes_Id", "dbo.Bikes");
            DropForeignKey("dbo.StoreBikes", "Bike_Id", "dbo.Bikes");
            DropForeignKey("dbo.StoreBikes", "Store_Id", "dbo.Stores");
            DropIndex("dbo.StoreBikes", new[] { "Bike_Id" });
            DropIndex("dbo.StoreBikes", new[] { "Store_Id" });
            DropIndex("dbo.Reservations", new[] { "PickUpStore_Id" });
            DropIndex("dbo.Reservations", new[] { "DropOffStore_Id" });
            DropIndex("dbo.Reservations", new[] { "Customer_Id" });
            DropIndex("dbo.Reservations", new[] { "Bikes_Id" });
            DropTable("dbo.StoreBikes");
            DropTable("dbo.Reservations");
            DropTable("dbo.Customers");
            DropTable("dbo.Stores");
            DropTable("dbo.Bikes");
        }
    }
}

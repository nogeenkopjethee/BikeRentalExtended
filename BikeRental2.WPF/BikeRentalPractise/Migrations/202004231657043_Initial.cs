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
                        HourlyRate = c.Double(nullable: false),
                        DailyRate = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id, unique: true);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
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
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Gender = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id, unique: true);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false, storeType: "date"),
                        EndDate = c.DateTime(nullable: false, storeType: "date"),
                        TotalPrice = c.Double(nullable: false),
                        DateAdded = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Customer_Id = c.Int(nullable: false),
                        DropOffStore_Id = c.Int(),
                        PickUpStore_Id = c.Int(),
                        SelectedBike_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Stores", t => t.DropOffStore_Id)
                .ForeignKey("dbo.Stores", t => t.PickUpStore_Id)
                .ForeignKey("dbo.Bikes", t => t.SelectedBike_Id, cascadeDelete: true)
                .Index(t => t.Customer_Id)
                .Index(t => t.DropOffStore_Id)
                .Index(t => t.PickUpStore_Id)
                .Index(t => t.SelectedBike_Id);
            
            CreateTable(
                "dbo.BikeStores",
                c => new
                    {
                        BikeId = c.Int(nullable: false),
                        StoreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.BikeId, t.StoreId })
                .ForeignKey("dbo.Stores", t => t.BikeId, cascadeDelete: true)
                .ForeignKey("dbo.Bikes", t => t.StoreId, cascadeDelete: true)
                .Index(t => t.BikeId)
                .Index(t => t.StoreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "SelectedBike_Id", "dbo.Bikes");
            DropForeignKey("dbo.Reservations", "PickUpStore_Id", "dbo.Stores");
            DropForeignKey("dbo.Reservations", "DropOffStore_Id", "dbo.Stores");
            DropForeignKey("dbo.Reservations", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.BikeStores", "StoreId", "dbo.Bikes");
            DropForeignKey("dbo.BikeStores", "BikeId", "dbo.Stores");
            DropIndex("dbo.BikeStores", new[] { "StoreId" });
            DropIndex("dbo.BikeStores", new[] { "BikeId" });
            DropIndex("dbo.Reservations", new[] { "SelectedBike_Id" });
            DropIndex("dbo.Reservations", new[] { "PickUpStore_Id" });
            DropIndex("dbo.Reservations", new[] { "DropOffStore_Id" });
            DropIndex("dbo.Reservations", new[] { "Customer_Id" });
            DropIndex("dbo.Customers", new[] { "Id" });
            DropIndex("dbo.Bikes", new[] { "Id" });
            DropTable("dbo.BikeStores");
            DropTable("dbo.Reservations");
            DropTable("dbo.Customers");
            DropTable("dbo.Stores");
            DropTable("dbo.Bikes");
        }
    }
}

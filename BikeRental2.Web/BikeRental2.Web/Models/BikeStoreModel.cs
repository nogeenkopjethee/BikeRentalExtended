namespace BikeRental2.Web.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BikeStoreModel : DbContext
    {
        public BikeStoreModel()
            : base("name=BikeStoreModel")
        {
        }

        public virtual DbSet<Bike> Bikes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Store> Stores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Store>()
                .HasMany(c => c.Bikes).WithMany(i => i.Stores)
                .Map(t => t.MapLeftKey("StoreId")
                    .MapRightKey("BikeId")
                    .ToTable("BikeStores"));
        }
    }
}
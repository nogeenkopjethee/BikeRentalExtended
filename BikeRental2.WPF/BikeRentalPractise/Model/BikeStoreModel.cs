namespace BikeRentalPractise.Model
{
    using System.Data.Entity;

    public class BikeStoreModel : DbContext
    {
        // Your context has been configured to use a 'BikeStoreModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BikeRentalPractise.Model.BikeStoreModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BikeStoreModel' 
        // connection string in the application configuration file.
        public BikeStoreModel()
            : base("name=BikeStoreModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
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

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
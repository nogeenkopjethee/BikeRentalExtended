using BikeRentalPractise.Model;

namespace BikeRentalPractise.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<BikeRentalPractise.Model.BikeStoreModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        /**
         * This is the configuration for the initial seed.
         * For the application to work, some example stores with bikes and some example users are needed.
         */
        protected override void Seed(BikeRentalPractise.Model.BikeStoreModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Stores.AddOrUpdate(x => x.Name, 
                new Store());
            
        }
    }
}

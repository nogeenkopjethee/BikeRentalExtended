using System.Collections.ObjectModel;
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
            context.Stores.AddOrUpdate(x => x.Name,
                new Store()
                {
                    Name = "Beste Fietsenwinkel in Almere",
                    Bikes = new ObservableCollection<Bike>
                    {
                        new Bike()
                        {
                            BikeModel = BikeModel.Batavus,
                        }
                    }
                },
                new Store()
            {
                Name = "Beste Fietsenwinkel in Almere",
                Bikes = new ObservableCollection<Bike>
                {
                    new Bike()
                    {
                        BikeModel = BikeModel.Batavus,
                    }
                }
            });

        }
    }
}

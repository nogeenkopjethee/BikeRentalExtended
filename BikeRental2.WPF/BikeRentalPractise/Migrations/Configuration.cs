using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Documents;
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
        protected override void Seed(BikeStoreModel context)
        {
            var stores = new List<Store>()
            {
                new Store()
                {
                    Name = "Beste Fietsenwinkel in Almere",
                    Address = "g674b56",
                    City = "Almere",
                    MaxCapacity = 50,
                    Bikes = new ObservableCollection<Bike>()
                },
                new Store()
                {
                    Name = "Beste Fietsenwinkel in Amsterdam",
                    Address = "654h78456",
                    City = "Amsterdam",
                    MaxCapacity = 100,
                    Bikes = new ObservableCollection<Bike>()
                },
            };

            stores.ForEach(s => context.Stores.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();

            var bikes = new List<Bike>()
            {
                new Bike()
                {
                    BikeModel = BikeModel.Batavus,
                    BikeType = BikeType.EBike,
                    BikeGender = BikeGender.Man,
                    Size = 100,
                    HourlyRate = 5.00,
                    DailyRate = 50.00,
                    Stores = new ObservableCollection<Store>()
                },
                new Bike()
                {
                    BikeModel = BikeModel.Altec,
                    BikeType = BikeType.Mountainbike,
                    BikeGender = BikeGender.Man,
                    Size = 70,
                    HourlyRate = 6.00,
                    DailyRate = 60.00,
                    Stores = new ObservableCollection<Store>()
                },

                new Bike()
                {

                    BikeModel = BikeModel.Bellage,
                    BikeType = BikeType.Racefiets,
                    BikeGender = BikeGender.Vrouw,
                    Size = 80,
                    HourlyRate = 5.00,
                    DailyRate = 50.00,
                    Stores = new ObservableCollection<Store>()
                },
                new Bike()
                {
                    BikeModel = BikeModel.Spirit,
                    BikeType = BikeType.Stadsfiets,
                    BikeGender = BikeGender.Vrouw,
                    Size = 85,
                    HourlyRate = 6.00,
                    DailyRate = 60.00,
                    Stores = new ObservableCollection<Store>()
                },
                new Bike()
                {
                    BikeModel = BikeModel.Popal,
                    BikeType = BikeType.Kinderfiets,
                    BikeGender = BikeGender.Man,
                    Size = 40,
                    HourlyRate = 2.00,
                    DailyRate = 20.00,
                    Stores = new ObservableCollection<Store>()
                },
                new Bike()
                {
                    BikeModel = BikeModel.Union,
                    BikeType = BikeType.Kinderfiets,
                    BikeGender = BikeGender.Vrouw,
                    Size = 40,
                    HourlyRate = 2.00,
                    DailyRate = 20.00,
                    Stores = new ObservableCollection<Store>()
                },
                new Bike()
                {
                    BikeModel = BikeModel.Umit,
                    BikeType = BikeType.Omafiets,
                    BikeGender = BikeGender.Man,
                    Size = 70,
                    HourlyRate = 3.00,
                    DailyRate = 30.00,
                    Stores = new ObservableCollection<Store>()
                },
                new Bike()
                {
                    BikeModel = BikeModel.Gazelle,
                    BikeType = BikeType.Driewieler,
                    BikeGender = BikeGender.Man,
                    Size = 20,
                    HourlyRate = 2.00,
                    DailyRate = 20.00,
                    Stores = new ObservableCollection<Store>()
                },
                new Bike()
                {

                    BikeModel = BikeModel.Sensa,
                    BikeType = BikeType.Racefiets,
                    BikeGender = BikeGender.Vrouw,
                    Size = 70,
                    HourlyRate = 5.00,
                    DailyRate = 50.00,
                    Stores = new ObservableCollection<Store>()
                },
                new Bike()
                {

                    BikeModel = BikeModel.Spirit,
                    BikeType = BikeType.Mountainbike,
                    BikeGender = BikeGender.Vrouw,
                    Size = 85,
                    HourlyRate = 6.00,
                    DailyRate = 60.00,
                    Stores = new ObservableCollection<Store>()
                },
                new Bike()
                {
                    BikeModel = BikeModel.Popal,
                    BikeType = BikeType.Kinderfiets,
                    BikeGender = BikeGender.Man,
                    Size = 40,
                    HourlyRate = 2.00,
                    DailyRate = 20.00,
                    Stores = new ObservableCollection<Store>()
                },
                new Bike()
                {
                    BikeModel = BikeModel.Cortina,
                    BikeType = BikeType.Kinderfiets,
                    BikeGender = BikeGender.Vrouw,
                    Size = 40,
                    HourlyRate = 2.00,
                    DailyRate = 20.00,
                    Stores = new ObservableCollection<Store>()
                }
            };

            bikes.ForEach(s => context.Bikes.AddOrUpdate(p => p.Id, s));
            context.SaveChanges();

            AddOrUpdateBikeToStore(context, "Beste Fietsenwinkel in Amsterdam", 1);
            AddOrUpdateBikeToStore(context, "Beste Fietsenwinkel in Almere", 4);
            AddOrUpdateBikeToStore(context, "Beste Fietsenwinkel in Amsterdam", 6);
            AddOrUpdateBikeToStore(context, "Beste Fietsenwinkel in Almere", 3);
            AddOrUpdateBikeToStore(context, "Beste Fietsenwinkel in Amsterdam", 5);
            AddOrUpdateBikeToStore(context, "Beste Fietsenwinkel in Almere", 7);
            AddOrUpdateBikeToStore(context, "Beste Fietsenwinkel in Amsterdam", 3);
            AddOrUpdateBikeToStore(context, "Beste Fietsenwinkel in Almere", 2);
            AddOrUpdateBikeToStore(context, "Beste Fietsenwinkel in Amsterdam", 8);
            AddOrUpdateBikeToStore(context, "Beste Fietsenwinkel in Almere", 9);
            AddOrUpdateBikeToStore(context, "Beste Fietsenwinkel in Amsterdam", 12);
            AddOrUpdateBikeToStore(context, "Beste Fietsenwinkel in Almere", 10);
            AddOrUpdateBikeToStore(context, "Beste Fietsenwinkel in Amsterdam", 11);
            AddOrUpdateBikeToStore(context, "Beste Fietsenwinkel in Almere", 6);
            AddOrUpdateBikeToStore(context, "Beste Fietsenwinkel in Almere", 5);
            AddOrUpdateBikeToStore(context, "Beste Fietsenwinkel in Amsterdam", 7);
            AddOrUpdateBikeToStore(context, "Beste Fietsenwinkel in Almere", 3);


            context.Customers.AddOrUpdate(x => x.Id,
              new Customer
              {
                  Id = 11,
                  FirstName = "Geralt",
                  LastName = "Rivia",
                  Gender = Gender.Man,
                  Height = 188,
                  Email = "geralt@test.nl",
              },
              new Customer
              {
                  Id = 22,
                  FirstName = "Nienke",
                  LastName = "Meijer",
                  Gender = Gender.Vrouw,
                  Height = 178,
                  Email = "nienke@test.nl",
              },
              new Customer
              {
                  Id = 33,
                  FirstName = "Jenny",
                  LastName = "Blok",
                  Gender = Gender.Overig,
                  Height = 166,
                  Email = "jenny@test.nl",
              }
            );

            context.SaveChanges();

        }

        /**
         * Helper function to add or update bikes to stores in the many-to-many sitation.
         *
         */
        void AddOrUpdateBikeToStore(BikeStoreModel context, string storeName, int bikeId)
        {
            var store = context.Stores.SingleOrDefault(c => c.Name == storeName);
            var bike = store.Bikes.SingleOrDefault(i => i.Id == bikeId);
            if (bike == null)
            {
                store.Bikes.Add(context.Bikes.Single(i => i.Id == bikeId));
            }
        }


    }
}

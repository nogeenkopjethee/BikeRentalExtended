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
                new Store
                {
                    Name = "Beste Fietsenwinkel in Almere",
                    Id = 1,
                    Address = "",
                    City = "Almere",
                    MaxCapacity = 50,
                    Bikes = new ObservableCollection<Bike>
                    {
                        new Bike()
                        {
                            BikeModel = BikeModel.Batavus,
                            BikeType  = BikeType.EBike,
                            BikeGender = BikeGender.Man,
                            Size = 100,
                            HourlyRate = 5,
                            DailyRate =  50,
                        },

                        new Bike()
                        {
                            BikeModel = BikeModel.Altec ,
                            BikeType  = BikeType.Mountainbike,
                            BikeGender = BikeGender.Man,
                            Size = 70,
                            HourlyRate = 6,
                            DailyRate =  60,
                        },

                        new Bike()
                        {

                            BikeModel = BikeModel.Bellage ,
                            BikeType  = BikeType.Racefiets,
                            BikeGender = BikeGender.Vrouw,
                            Size = 80,
                            HourlyRate = 5,
                            DailyRate =  50,
                        },

                         new Bike()
                        {

                            BikeModel = BikeModel.Spirit,
                            BikeType  = BikeType.Stadsfiets,
                            BikeGender = BikeGender.Vrouw,
                            Size = 85,
                            HourlyRate = 6,
                            DailyRate =  60,
                        },
                         new Bike()
                         {
                            BikeModel = BikeModel.Popal,
                            BikeType  = BikeType.Kinderfiets,
                            BikeGender = BikeGender.Man,
                            Size = 40,
                            HourlyRate = 2,
                            DailyRate = 20,
                         },

                         new Bike()
                         {
                            BikeModel = BikeModel.Union,
                            BikeType  = BikeType.Kinderfiets,
                            BikeGender = BikeGender.Vrouw,
                            Size = 40,
                            HourlyRate = 2,
                            DailyRate = 20,
                         }
                    }
                },

                new Store
                {
                    Name = "Beste Fietsenwinkel in Amsterdam",
                    Id = 2,
                    Address = "",
                    City = "Amsterdam",
                    MaxCapacity = 100,
                    Bikes = new ObservableCollection<Bike>
                    {

                    new Bike()
                    {
                        BikeModel = BikeModel.Batavus,
                    },

                    new Bike()
                    {
                        BikeModel = BikeModel.Umit,
                        BikeType  = BikeType.Omafiets,
                        BikeGender = BikeGender.Man,
                        Size = 70,
                        HourlyRate = 3,
                        DailyRate =  30,
                    },

                        new Bike()
                        {
                            BikeModel = BikeModel.Gazelle ,
                            BikeType  = BikeType.Driewieler,
                            BikeGender = BikeGender.Man,
                            Size = 20,
                            HourlyRate = 2,
                            DailyRate =  20,
                        },

                        new Bike()
                        {

                            BikeModel = BikeModel.Sensa ,
                            BikeType  = BikeType.Racefiets,
                            BikeGender = BikeGender.Vrouw,
                            Size = 70,
                            HourlyRate = 5,
                            DailyRate =  50,
                        },

                         new Bike()
                        {

                            BikeModel = BikeModel.Spirit,
                            BikeType  = BikeType.Mountainbike,
                            BikeGender = BikeGender.Vrouw,
                            Size = 85,
                            HourlyRate = 6,
                            DailyRate =  60,
                        },
                         new Bike()
                         {
                            BikeModel = BikeModel.Popal,
                            BikeType  = BikeType.Kinderfiets,
                            BikeGender = BikeGender.Man,
                            Size = 40,
                            HourlyRate = 2,
                            DailyRate = 20,
                         },

                         new Bike()
                         {
                            BikeModel = BikeModel.Cortina,
                            BikeType  = BikeType.Kinderfiets,
                            BikeGender = BikeGender.Vrouw,
                            Size = 40,
                            HourlyRate = 2,
                            DailyRate = 20,
                         }
                    }
                });
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

        }
                
   
    }
}

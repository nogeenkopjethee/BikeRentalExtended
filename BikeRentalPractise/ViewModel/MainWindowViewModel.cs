using BikeRentalPractise.Model;
using System.Collections.ObjectModel;

namespace BikeRentalPractise.ViewModel
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Store> Stores { get; set; }
        public ObservableCollection<Bike> Bikes { get; set; }
        public Store SelectedStore { get; set; }
        public MainWindowViewModel()
        {
            // Makes empty list of stores
            Stores = new ObservableCollection<Store>
            {
                new Store
                {
                    Address = "Kalverstraat 1",
                    City = "Amsterdam",
                    MaxCapacity = 50,
                    Bikes = new ObservableCollection<Bike>
                    {
                        new Bike
                        {
                            BikeModel = BikeModel.Popal,
                            BikeType = BikeType.Omafiets,
                            BikeGender = BikeGender.Vrouw,
                            Size = 50,
                            HourlyRate = 15,
                            DailyRate = 350,
                        },
                        new Bike
                        {
                            BikeModel = BikeModel.Gazelle,
                            BikeType = BikeType.Stadsfiets,
                            BikeGender = BikeGender.Man,
                            Size = 60,
                            HourlyRate = 20,
                            DailyRate = 450
                        },
                        new Bike
                        {
                            BikeModel = BikeModel.Batavus,
                            BikeType = BikeType.Racefiets,
                            BikeGender = BikeGender.Vrouw,
                            Size = 40,
                            HourlyRate = 35,
                            DailyRate = 750
                        }
                    }
                },
                new Store
                {
                    Address = "Hospitaaldreef 12",
                    City = "Almere",
                    MaxCapacity = 80,
                    Bikes = new ObservableCollection<Bike>
                    {
                        new Bike
                        {
                            BikeModel = BikeModel.Altec,
                            BikeType = BikeType.Stadsfiets,
                            BikeGender = BikeGender.Vrouw,
                            Size = 40,
                            HourlyRate = 20,
                            DailyRate = 450
                        },
                        new Bike
                        {
                            BikeModel = BikeModel.Lorelli,
                            BikeType = BikeType.Driewieler,
                            BikeGender = BikeGender.Man,
                            Size = 15,
                            HourlyRate = 5,
                            DailyRate = 75
                        },
                        new Bike
                        {
                            BikeModel = BikeModel.Union,
                            BikeType = BikeType.Stadsfiets,
                            BikeGender = BikeGender.Man,
                            Size = 40,
                            HourlyRate = 20,
                            DailyRate = 450
                        }
                    }
                },
                new Store
                {
                    Address = "'t Hof 7",
                    City = "Den Bosch",
                    MaxCapacity = 65,
                    Bikes = new ObservableCollection<Bike>
                    {
                        new Bike
                        {
                            BikeModel = BikeModel.Sensa,
                            BikeType = BikeType.Mountainbike,
                            BikeGender = BikeGender.Man,
                            Size = 30,
                            HourlyRate = 30,
                            DailyRate = 600
                        },
                        new Bike
                        {
                            BikeModel = BikeModel.Spirit,
                            BikeType = BikeType.Stadsfiets,
                            BikeGender = BikeGender.Vrouw,
                            Size = 35,
                            HourlyRate = 20,
                            DailyRate = 450
                        },
                        new Bike
                        {
                            BikeModel = BikeModel.Bellage,
                            BikeType = BikeType.Omafiets,
                            BikeGender = BikeGender.Man,
                            Size = 35,
                            HourlyRate = 20,
                            DailyRate = 450
                        }
                    }
                }
            };
        }
    }
}

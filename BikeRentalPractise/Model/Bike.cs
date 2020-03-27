using System.Collections.ObjectModel;

namespace BikeRentalPractise.Model
{
    public class Bike
    {
        public BikeModel BikeModel { get; set; }
        public BikeType BikeType { get; set; }
        public BikeGender BikeGender { get; set; }
        public int Size { get; set; }
        public int HourlyRate { get; set; }
        public int DailyRate { get; set; }
        public ObservableCollection<Store> Stores { get; set; }

        public Bike()
        {
            Stores = new ObservableCollection<Store>(); // creates a new empty list of stores when creating a bike
        }
    }
    public enum BikeModel
    {
        Popal,
        Altec,
        Spirit,
        Umit,
        Gazelle,
        Union,
        Bellage,
        Batavus,
        Cortina,
        Sensa,
        Lorelli
    }
    public enum BikeType
    {
        Stadsfiets,
        Kinderfiets,
        Racefiets,
        Mountainbike,
        EBike,
        Driewieler,
        Omafiets
    }

    public enum BikeGender
    {
        Man,
        Vrouw,
    }
}
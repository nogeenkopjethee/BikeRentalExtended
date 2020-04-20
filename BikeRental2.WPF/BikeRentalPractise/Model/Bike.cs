using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BikeRentalPractise.Model
{
    public class Bike
    {
        [Index(IsUnique = true)]
        public int Id { get; set; }
        public BikeModel BikeModel { get; set; }
        [Required]
        public BikeType BikeType { get; set; }
        [Required]
        public BikeGender BikeGender { get; set; }
        public int Size { get; set; }
        public double HourlyRate { get; set; }
        public double DailyRate { get; set; }
        [Required]
        public virtual ObservableCollection<Store> Stores { get; set; }
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
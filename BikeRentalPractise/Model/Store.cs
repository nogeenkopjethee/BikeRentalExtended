using System.Collections.ObjectModel;

namespace BikeRentalPractise.Model
{
    public class Store
    {

        public string Address { get; set; }
        public string City { get; set; }
        public int MaxCapacity { get; set; }
        public ObservableCollection<Bike> Bikes { get; set; }


        public Store()
        {
            Bikes = new ObservableCollection<Bike>(); // creates a new empty list of bikes when creating a store
        }
    }
}
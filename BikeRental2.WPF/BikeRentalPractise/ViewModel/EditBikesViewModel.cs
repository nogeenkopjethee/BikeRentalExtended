using BikeRentalPractise.Model;
using System.Collections.ObjectModel;
using System.Windows;

namespace BikeRentalPractise.ViewModel
{
    public class EditBikesViewModel
    {

        private BikeStoreModel _db;
        public ObservableCollection<Bike> Bikes { get; set; }
        public Bike SelectedBike { get; set; }
      
        public RelayCommand AddBikeClick { get; set; }
        public RelayCommand DeleteBikeClick { get; set; }

        public Bike NewBike { get; set; }

        public EditBikesViewModel(ObservableCollection<Bike> bikes, BikeStoreModel db)
        {
            _db = db;
            
            Bikes = bikes;
            NewBike = new Bike();

            AddBikeClick = new RelayCommand(AddBike);
            DeleteBikeClick = new RelayCommand(DeleteBike);
        }

        // Adds new Bike to the Bike list
        public void AddBike(object a)
        {
            Bikes.Add(NewBike);
            NewBike = new Bike();
        }

        // Deletes selected Bike from the Bike list
        public void DeleteBike (object a)
        {
            if (SelectedBike != null)
            {
                Bikes.Remove(SelectedBike);
            }
            else
            {
                MessageBox.Show("Please select a bike first");
            }
        }
    }
}

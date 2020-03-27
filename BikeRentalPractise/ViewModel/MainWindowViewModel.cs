using BikeRentalPractise.Model;
using System.Collections.ObjectModel;
using System.Data.Entity;

namespace BikeRentalPractise.ViewModel
{
    public class MainWindowViewModel
    {
        
        private BikeStoreModel _db = new BikeStoreModel();
        public ObservableCollection<Store> Stores { get; set; }
        public ObservableCollection<Bike> Bikes { get; set; }
        public Store SelectedStore { get; set; }
        public MainWindowViewModel()
        {
            
        }
    }
}

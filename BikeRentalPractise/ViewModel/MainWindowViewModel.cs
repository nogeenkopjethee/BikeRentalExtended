using BikeRentalPractise.Model;
using BikeRentalPractise.View;
using System.Collections.ObjectModel;
using System.Data.Entity;

namespace BikeRentalPractise.ViewModel
{
    public class MainWindowViewModel
    {
        
        private readonly BikeStoreModel _db = new BikeStoreModel();
        public ObservableCollection<Store> Stores { get; set; }
        public ObservableCollection<Bike> Bikes { get; set; }
        public Store SelectedStore { get; set; }
        public MainWindowViewModel()
        {
            _db.Stores.Load();
            _db.Bikes.Load();

            Stores = _db.Stores.Local;
            Bikes = _db.Bikes.Local;
        }
    }
}

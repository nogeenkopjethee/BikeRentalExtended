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

        // Shows the Edit Stores Window
        private void ShowEditStoresWindow(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel vm = (MainWindowViewModel)DataContext;

            EditStoresViewModel editVM = new EditStoresViewModel(vm.Stores);

            EditStoresWindow view = new EditStoresWindow(vm.Stores);
            view.DataContext = editVM;
            view.Show();
        }

        // Shows the Edit Bikes Window
        private void ShowEditBikesWindow(object sender, RoutedEventArgs e)
        {

            MainWindowViewModel vm = (MainWindowViewModel)DataContext;

            // Checks if a Store is selected in order to show to Edit Bikes Window
            if (vm.SelectedStore != null)
            {
                EditBikesViewModel editVM = new EditBikesViewModel(vm.SelectedStore.Bikes);
                EditBikesWindow view = new EditBikesWindow(vm.Bikes);

                view.DataContext = editVM;
                view.Show();
            }
            else
            {
                MessageBox.Show("Please select a bike first");

            }
        }
    }
}

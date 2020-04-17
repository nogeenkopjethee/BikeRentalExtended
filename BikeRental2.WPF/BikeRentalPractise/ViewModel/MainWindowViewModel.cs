using BikeRentalPractise.Model;
using BikeRentalPractise.View;
using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Windows;

namespace BikeRentalPractise.ViewModel
{
    public class MainWindowViewModel
    {
        
        private BikeStoreModel _db = new BikeStoreModel();
        public ObservableCollection<Store> Stores { get; set; }
        public ObservableCollection<Bike> Bikes { get; set; }

        public RelayCommand OpenStoreEditClick { get; set; }
        public RelayCommand OpenBikesEditClick { get; set; }
        public Store SelectedStore { get; set; }
        public MainWindowViewModel()
        {
            _db.Stores.Load();
            _db.Bikes.Load();

            OpenStoreEditClick = new RelayCommand(ShowEditStoresWindow);
            OpenBikesEditClick = new RelayCommand(ShowEditBikesWindow);

            Stores = _db.Stores.Local;
            Bikes = _db.Bikes.Local;


        }

        // Shows the Edit Stores Window
        private void ShowEditStoresWindow(object obj)
        {
            EditStoresViewModel editVM = new EditStoresViewModel(Stores, _db);

            EditStoresWindow view = new EditStoresWindow();
            view.DataContext = editVM;
            view.Show();
        }

        // Shows the Edit Bikes Window
        private void ShowEditBikesWindow(object obj)
        {
            // Checks if a Store is selected in order to show to Edit Bikes Window
            if (SelectedStore != null)
            {
                EditBikesViewModel editVM = new EditBikesViewModel(Bikes, _db);
                EditBikesWindow view = new EditBikesWindow();

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

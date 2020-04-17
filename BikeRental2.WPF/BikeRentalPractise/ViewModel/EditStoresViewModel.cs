using BikeRentalPractise.Model;
using BikeRentalPractise.View;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace BikeRentalPractise.ViewModel
{
    public class EditStoresViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private BikeStoreModel _db;

        public ObservableCollection<Store> Stores { get; set; }

        private Store _selectedStore;
        // Calls the INotifyPropertyChanged to check if the value has changed
        public Store SelectedStore { get => _selectedStore; set { _selectedStore = value; Notify("SelectedStore"); } }

        public RelayCommand AddClick { get; set; }
        public RelayCommand DeleteClick { get; set; }
        public RelayCommand OpenAddBikesClick { get; set; }

        private Store _newStore;
        // Calls the INotifyPropertyChanged to check if the value has changed
        public Store NewStore { get => _newStore; set { _newStore = value; Notify("NewStore"); } }

        // You need a command to save the changes to the database.
        public RelayCommand SaveClick { get; set; }
        public EditStoresViewModel(ObservableCollection<Store> stores, BikeStoreModel db)
        {
            _db = db;
            
            Stores = stores;

            NewStore = new Store();

            AddClick = new RelayCommand(AddStore);
            DeleteClick = new RelayCommand(DeleteStore);
            //OpenAddBikesClick = new RelayCommand(OpenAddBikes);

            SaveClick = new RelayCommand(x => _db.SaveChanges());
        }

        // Open Add bikes screen
        //private void OpenAddBikes(object o)
        //{
        //    if(SelectedStore == null)
        //    {
        //        MessageBox.Show("Select a store  first");
        //    }
        //    else
        //    {
        //        EditBikesWindow view = new EditBikesWindow(SelectedStore.Bikes);
        //        view.Show();
        //    }   
        //}

        // Deletes the selected Store
        private void DeleteStore(object obj)
        {
            if (SelectedStore != null)
            {
                Stores.Remove(SelectedStore);
            }
            else
            {
                MessageBox.Show("Please Select Store first!");
            }
        }

        // Adds a new empty Store to the Store list and selects it
        public void AddStore(object a)
        {
            Store store = new Store();
            Stores.Add(store);
            SelectedStore = store;
        }

        // Checks if the property has changed
        public void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
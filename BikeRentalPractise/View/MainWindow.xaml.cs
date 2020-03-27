using BikeRentalPractise.View;
using BikeRentalPractise.ViewModel;
using System.Windows;

namespace BikeRentalPractise
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel();
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

using System.Windows;
using BikeRentalPractise.ViewModel;

namespace BikeRentalPractise.View
{
    /// <summary>
    /// Interaction logic for EditBikesWindow.xaml
    /// </summary>
    public partial class EditBikesWindow : Window
    {
        public EditBikesWindow(System.Collections.ObjectModel.ObservableCollection<Model.Bike> bikes)
        {
            InitializeComponent();

            // Fills the Datagrid with Bikes
            DataContext = new EditBikesViewModel(bikes);
        }
    }
}

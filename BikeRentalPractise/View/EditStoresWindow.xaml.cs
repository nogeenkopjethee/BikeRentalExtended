using BikeRentalPractise.Model;
using System.Collections.ObjectModel;
using System.Windows;

namespace BikeRentalPractise.View
{
    /// <summary>
    /// Interaction logic for EditStoresWindow.xaml
    /// </summary>
    public partial class EditStoresWindow : Window
    {
        public EditStoresWindow(ObservableCollection<Store> stores)
        {
            InitializeComponent();
        }
    }
}

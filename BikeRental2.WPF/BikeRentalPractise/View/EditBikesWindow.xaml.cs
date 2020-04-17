using System.Windows;
using BikeRentalPractise.ViewModel;

namespace BikeRentalPractise.View
{
    /// <summary>
    /// Interaction logic for EditBikesWindow.xaml
    /// </summary>
    public partial class EditBikesWindow : Window
    {
        public EditBikesWindow()
        {
            InitializeComponent();

            // Fills the Datagrid with Bikes
            //DataContext = new EditBikesViewModel();
        }
    }
}

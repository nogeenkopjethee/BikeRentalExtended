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
        
        
    }
}

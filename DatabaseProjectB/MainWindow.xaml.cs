using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DatabaseProjectB.Views;
namespace DatabaseProjectB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Displaying All User Controls inside the dockPanel
        private void topRentedTrucksButton_Click(object sender, RoutedEventArgs e)
        {
            centralPanel.Children.Clear();
            centralPanel.Children.Add(new TopRentedTrucksUC());        
        }

        private void leastRentedModelsButton_Click(object sender, RoutedEventArgs e)
        {
            centralPanel.Children.Clear();
            centralPanel.Children.Add(new LeastRentedModelsUC());
        }

        private void totalRentalSaleForMonthButton_Click(object sender, RoutedEventArgs e)
        {
            centralPanel.Children.Clear();
            centralPanel.Children.Add(new MonthTotalRentalSaleUC());
        }

        private void selectedDateRangeButton_Click(object sender, RoutedEventArgs e)
        {
            centralPanel.Children.Clear();
            centralPanel.Children.Add(new TruckModelTotalSalesForSelectedDateUC());
        }
    }
}

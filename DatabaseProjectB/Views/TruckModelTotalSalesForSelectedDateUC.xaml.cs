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
using DatabaseProjectB.Controller;

namespace DatabaseProjectB.Views
{
    /// <summary>
    /// Interaction logic for TruckModelTotalSalesForSelectedDateUC.xaml
    /// </summary>
    public partial class TruckModelTotalSalesForSelectedDateUC : UserControl
    {
        public TruckModelTotalSalesForSelectedDateUC()
        {
            InitializeComponent();
            //Displaying all Models to combobox
            truckModelComboBox.ItemsSource = DAO.getTruckModels();
            truckModelComboBox.DisplayMemberPath = "Model";
            truckModelComboBox.SelectedValuePath = "Model";
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            //Validation
            if(truckModelComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select truck model first");
            }
            else if(firstDatePicker.SelectedDate == null)
            {
                MessageBox.Show("Please select a start date first");
            } 
            else if (secondDatePicker.SelectedDate == null)
            {
                MessageBox.Show("Please select an end date first");
            }
            else
            {
                string model = truckModelComboBox.Text;
                DateTime firstDate = firstDatePicker.SelectedDate.Value;
                DateTime secondDate = secondDatePicker.SelectedDate.Value;
                dataGrid.ItemsSource = DAO.getTotalSalesTruckModel(model, firstDate, secondDate); 

                //Checking if datagrid has displayed any data
                if(dataGrid.Items.Count == 0)
                {
                    MessageBox.Show("No matching results found");
                    dataGrid.ItemsSource = null;
                }
            }
        }
    }
}

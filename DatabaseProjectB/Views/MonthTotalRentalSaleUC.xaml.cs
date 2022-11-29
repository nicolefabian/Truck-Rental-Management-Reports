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
    /// Interaction logic for MonthTotalRentalSaleUC.xaml
    /// </summary>
    public partial class MonthTotalRentalSaleUC : UserControl
    {
        public MonthTotalRentalSaleUC()
        {
            InitializeComponent();
            //Add Months in Combobox (1-12)
            for (int month = 1;month <= 12; month++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = month;
                monthComboBox.Items.Add(item);
            }

            //Add Years in Combobox(2010 - currentYear)
            int currentYear = DateTime.Now.Year;
            for (int startYear = 2010; startYear <= currentYear; startYear++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = startYear;
                yearComboBox.Items.Add(item);
            }
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            //Validation
            if (monthComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select month first");
            }
            else if (yearComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select year first");
            }
            else
            {
                int month = int.Parse(monthComboBox.Text);
                int year = int.Parse(yearComboBox.Text);
                //calling getMonthTotalRentalSale from stored procedure 
                dataGrid.ItemsSource = DAO.getMonthTotalRentalSale(month, year);

                //Validation: if no data found
                if (dataGrid.Items.Count == 0)
                {
                    MessageBox.Show("No matching results found");
                    dataGrid.ItemsSource = null;
                }
            }
        }
    }
}

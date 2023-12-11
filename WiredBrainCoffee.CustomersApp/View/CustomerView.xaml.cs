using System.Windows;
using System.Windows.Controls;

namespace WiredBrainCoffee.CustomersApp.View
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : UserControl
    {
        public CustomerView()
        {
            InitializeComponent();
        }
        private void CustomerView_Click(object sender, RoutedEventArgs e)
        {
            var currentColumn = (int)CustomerList.GetValue(Grid.ColumnProperty);
            var newColumn = currentColumn == 2 ? 0 : 2;
            CustomerList.SetValue(Grid.ColumnProperty, newColumn);
           
        }

    }
}

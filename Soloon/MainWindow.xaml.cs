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

namespace Soloon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RefreshAll();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddClient_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEditClient_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDeleteClient_Click(object sender, RoutedEventArgs e)
        {

        }
        private void RefreshAll()
        {
            dgServise.ItemsSource = null;
            dgServise.ItemsSource = App.DB.Services.ToList();

            dgClient.ItemsSource = null;
            dgClient.ItemsSource = App.DB.Clients.ToList();

            dgClientService.ItemsSource = null;
            dgClientService.ItemsSource = App.DB.ClientServices.ToList();
        }

        private void btnAddClientService_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEditClientService_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDeleteClientService_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

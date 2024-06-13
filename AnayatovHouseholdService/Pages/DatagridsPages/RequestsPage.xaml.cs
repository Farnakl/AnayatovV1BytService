using AnayatovHouseholdService.Classes;
using AnayatovHouseholdService.Models;
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

namespace AnayatovHouseholdService.Pages.DatagridsPages
{
    /// <summary>
    /// Логика взаимодействия для RequestsPage.xaml
    /// </summary>
    public partial class RequestsPage : Page
    {
        public RequestsPage()
        {
            InitializeComponent();

            DGUsers.ItemsSource = ConnectionDataBase.connection.Requests.Where(r => r.clientID == Navigation.User.userID).ToList();
        }
    }
}

using AnayatovHouseholdService.Classes;
using AnayatovHouseholdService.Models;
using AnayatovHouseholdService.Pages.DatagridsPages;
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

namespace AnayatovHouseholdService.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public AutorizationPage()
        {
            InitializeComponent();
            
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            Users users = ConnectionDataBase.connection.Users.FirstOrDefault(x => x.login == TxbLogin.Text && x.password == TxbPassword.Text);
            if (TxbLogin.Text == "")
            {
                MessageBox.Show("Не записан логин!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TxbPassword.Text == "")
            {
                MessageBox.Show("Не записан пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (users == null)
            {
                MessageBox.Show("Такого пользователя нет!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                Navigation.User = users;
                if (users.roleId == 4)
                {
                    Navigation.frameNav.Navigate(new RequestsPage());
                    
                }
                if (users.roleId == 2)
                {
                    MessageBox.Show("Здраствуй мастер");
                }
                if (users.roleId == 3)
                {
                    MessageBox.Show("Здраствуй Оператор");
                }
                if (users.roleId == 1)
                {
                    MessageBox.Show("Здраствуй менеджер");
                }
            }
        }
    }
}

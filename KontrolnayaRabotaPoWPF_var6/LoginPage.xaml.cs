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

namespace KontrolnayaRabotaPoWPF_var6
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Проверяем правильность введенных данных
            if (CheckCredentials(username, password))
            {
                // Правильные учетные данные - перенаправляем на страницу редактирования расписания
                ScheduleEditorPage scheduleEditorPage = new ScheduleEditorPage();
                NavigationService.Navigate(scheduleEditorPage);
            }
            else
            {
                // Неправильные учетные данные - выводим сообщение об ошибке
                MessageBox.Show("Неправильный логин или пароль. Повторите попытку.", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool CheckCredentials(string username, string password)
        {
            return (username == "sa" && password == "sa");
        }

    }
}

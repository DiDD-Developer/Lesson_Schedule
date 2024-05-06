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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Кнопка диспетчера расписания
        private void btnDispetchers_Click(object sender, RoutedEventArgs e)
        {
            // Перенаправление на страницу входа диспетчера
            LoginPage loginPage = new LoginPage();
            mainFrame.Content = loginPage;
        }

        //Кнопка студента
        private void btnStudents_Click(object sender, RoutedEventArgs e)
        {
            // Перенаправление на страницу студента
            StudentSchedulePage studentSchedulePage = new StudentSchedulePage();
            mainFrame.Content = studentSchedulePage;
        }
    }
}

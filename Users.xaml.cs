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
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Practik_4_Test
{
    /// <summary>
    /// Логика взаимодействия для Users.xaml
    /// </summary>
    public partial class Users : Window
    {
        public Users()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Editor_Click(object sender, RoutedEventArgs e)
        {
            AllFrame.Content = new Admin();
        }
        private void Using_Click(object sender, RoutedEventArgs e)
        {
            List<My_Data> pivasa = Class1.myDeserialize<List<My_Data>>();
            AllFrame.Content = new Polzovatel();
            if (pivasa == null || pivasa.Count == 0)
            {
                AllFrame.Content = new Exit();
            }
            else
            {
                PgFrame.Content = new PageTest();
            }


        }


        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}

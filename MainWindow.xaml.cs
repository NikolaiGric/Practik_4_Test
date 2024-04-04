using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practik_4_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string password = "код";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void users_Click(object sender, RoutedEventArgs e)
        {
            Users users = new Users();
            users.Editor.IsEnabled = false;
            users.Show();
            Close();
        }

        private void editor_Click(object sender, RoutedEventArgs e)
        {
            if (entrance.Text == password)
            {
                Users users = new Users();
                users.Show();
                Close();
            }
        }
    }
}
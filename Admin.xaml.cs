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
using static MaterialDesignThemes.Wpf.Theme;
using static System.Net.Mime.MediaTypeNames;

namespace Practik_4_Test
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        List<My_Data> pivas = new List<My_Data>();
        public Admin()
        {
            InitializeComponent();
            List<My_Data> pivas = new List<My_Data>();
            foreach (var item in AllDataGrid.Items)
            {
                if (item is My_Data item2)
                {
                    pivas.Add(item2);
                }
            }
            Class1.mySerialize(pivas);
        }
    }
}

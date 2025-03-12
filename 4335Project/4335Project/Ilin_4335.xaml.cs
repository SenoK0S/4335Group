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

namespace _4335Project
{
    /// <summary>
    /// Логика взаимодействия для Ilin_4335.xaml
    /// </summary>
    public partial class Ilin_4335 : Window
    {
        public Ilin_4335()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ilin Arsen 18 years old");
        }
    }
}

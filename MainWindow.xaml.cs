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

namespace Cap6_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Capitulo6Button_Click(object sender, RoutedEventArgs e)
        {
            Capitulo6.Capitulo6 c6 = new Capitulo6.Capitulo6();
            c6.Show();
            this.Close();
        }

        private void Capitulo7Button_Click(object sender, RoutedEventArgs e)
        {
            Capitulo7.Capitulo7 c7 = new Capitulo7.Capitulo7();
            c7.Show();
            this.Close();
        }
    }
}

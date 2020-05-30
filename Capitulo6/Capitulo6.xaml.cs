using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Cap6_7.Capitulo6
{
    /// <summary>
    /// Interaction logic for Capitulo6.xaml
    /// </summary>
    public partial class Capitulo6 : Window
    {
        
        public Capitulo6()
        {
            InitializeComponent();
        }

        private void Ejer1_3Button_Click(object sender, RoutedEventArgs e)
        {
            Ejer1_3 eje1_3 = new Ejer1_3();
            eje1_3.Show();
            this.Close();
        }

        private void Ejer4Button_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio4 ejercicio4 = new Ejercicio4();
            ejercicio4.Show();
            this.Close();
        }

        private void Ejer5Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AtrasButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}

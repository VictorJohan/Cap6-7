using Cap6_7.Capitulo6;
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

namespace Cap6_7.Capitulo7
{
    /// <summary>
    /// Interaction logic for Capitulo7.xaml
    /// </summary>
    public partial class Capitulo7 : Window
    {
        public Capitulo7()
        {
            InitializeComponent();
        }

        private void Ejer1_3Button_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1 ejercicio1 = new Ejercicio1();
            ejercicio1.Show();
            this.Close();
        }

        private void Ejer2Button_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio2 ejercicio2 = new Ejercicio2();
            ejercicio2.Show();
            this.Close();
        }

        private void Ejer5Button_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5 ejercicio5 = new Ejercicio5();
            ejercicio5.Show();
            this.Close();
        }

        private void AtrasButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}

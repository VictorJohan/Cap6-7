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
    /// Interaction logic for Ejercicio_5.xaml
    /// </summary>
    public partial class Ejercicio5 : Window
    {
        int[][] numeros = new int[7][];
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void generarButon_Click(object sender, RoutedEventArgs e)
        {
            
            var semilla = Environment.TickCount;
            var random = new Random(semilla);
            matrizTextBlock.Text = "";
            for(int i = 0; i<7; i++)
            {
                numeros[i] = new int[random.Next(1, 5)];
            }

            for (int i = 0; i<7; i++)
            {
                for(int j = 0; j<numeros[i].GetLength(0); j++)
                {
                    numeros[i][j] = random.Next(23, 80);
                }
            }

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < numeros[i].GetLength(0); j++)
                {
                    matrizTextBlock.Text += numeros[i][j] + " "; 
                }

                matrizTextBlock.Text += "\n";
            }

            matrizPasadaTextBlock.Text = "";
        }

        private void pasarbutton_Click(object sender, RoutedEventArgs e)
        {
            if(matrizTextBlock.Text == "" && matrizPasadaTextBlock.Text == "")
            {
                MessageBox.Show("Genere un matriz para pasarla", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            PasarJagged(numeros);
        }

        public void PasarJagged(int[][] numeros)
        {
            if(matrizPasadaTextBlock.Text == "")
            {
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < numeros[i].GetLength(0); j++)
                    {
                        matrizPasadaTextBlock.Text += numeros[i][j] + " ";
                    }

                    matrizPasadaTextBlock.Text += "\n";
                }

                matrizTextBlock.Text = "";
            }
            else
            {
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < numeros[i].GetLength(0); j++)
                    {
                        matrizTextBlock.Text += numeros[i][j] + " ";
                    }

                    matrizTextBlock.Text += "\n";
                }

                matrizPasadaTextBlock.Text = "";
            }
        }

        private void atrasButton_Click(object sender, RoutedEventArgs e)
        {
            Capitulo6 capitulo6 = new Capitulo6();
            capitulo6.Show();
            this.Close();
        }
    }
}

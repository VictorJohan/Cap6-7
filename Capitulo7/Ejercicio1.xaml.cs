using System;
using System.Collections;
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
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>
    public partial class Ejercicio1 : Window
    {
        ArrayList calificaciones = new ArrayList();
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void insertarButton_Click(object sender, RoutedEventArgs e)
        {
            calificaciones.Add(float.Parse(califTextBox.Text));
            califTextBox.Text = "";
        }

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            float promedio = 0, max = 0, min = 100, suma = 0;

            foreach (float elemeto in calificaciones)
            {
                suma += elemeto;
                if(elemeto > max)
                {
                    max = elemeto;
                }
                if(elemeto < min)
                {
                    min = elemeto;
                }
            }

            promedio = suma / calificaciones.Count;

            

            Imprimir(max, min, promedio);
        }

        public void Imprimir(float max, float min, float promedio)
        {
            resultadoTextBlock.Text += $"Minima: {min}\nMaxima: {max}\nPromedio: {Math.Round(promedio, 2)}";
        }

        private void atrasButon_Click(object sender, RoutedEventArgs e)
        {
            Capitulo7 capitulo7 = new Capitulo7();
            capitulo7.Show();
            this.Close();
        }
    }
}

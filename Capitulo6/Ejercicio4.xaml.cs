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
    /// Interaction logic for Ejercicio4.xaml
    /// </summary>
    public partial class Ejercicio4 : Window
    {
        int n = 0; // Variable de control de ciclo salones
        int m = 0; // Variable de control del ciclo alumnos
        int salones = 0;
        int cantidadAlumnos = 0;
        float[,] calif;

        public Ejercicio4()
        {
            InitializeComponent();
           
        }

        //*******************SE PIDEN LOS DATOS AL USUARIO*******************
        private void insertarDatosButton_Click(object sender, RoutedEventArgs e)
        {
            salones = int.Parse(salonesTextBox.Text); // Cantidad de salones
            cantidadAlumnos = int.Parse(alumnosTextBox.Text); // Cantidad de alumnos
            calif = new float[salones, cantidadAlumnos];

            salonesTextBox.IsEnabled = false;
            alumnosTextBox.IsEnabled = false;
            insertarDatosButton.IsEnabled = false;
        }

        private void insertarButton_Click(object sender, RoutedEventArgs e)
        {

            // Capturamos la información
            calif[n, m] = float.Parse(califTextBox.Text);
            califTextBox.Text = "";

            if (m == cantidadAlumnos - 1)
            {
                n++;
                if (n == salones)
                {
                    insertarButton.IsEnabled = false;
                    califTextBox.IsEnabled = false;
                    return;
                }

                m = 0;
                int s = n + 1;
                contadorSalon.Content = $"Salones: {s}";
                contadorCalifiLabel.Content = $"Calificacion: {1}";
            }
            else
            {

                m++;
                int c = m + 1;
                contadorCalifiLabel.Content = $"Calificacion: {c}";
                
            }
            if (n == salones)
            {
                insertarButton.IsEnabled = false;
                califTextBox.IsEnabled = false;
            }

        }

        //*******************SE PIDEN LOS DATOS AL USUARIO (FIN)*******************

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            
            CalcularPromedioMinMax();
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            n = 0; // Variable de control de ciclo salones
            m = 0; // Variable de control del ciclo alumnos
            calif = new float[0, 0];

            salonesTextBox.IsEnabled = true;
            alumnosTextBox.IsEnabled = true;
            insertarDatosButton.IsEnabled = true;
            insertarButton.IsEnabled = true;
            califTextBox.IsEnabled = true;
        }

        private void atrasButton_Click(object sender, RoutedEventArgs e)
        {
            Capitulo6 capitulo6 = new Capitulo6();
            capitulo6.Show();
            this.Close();
        }

        //********************************FUNCIONES DE CALCULOS******************************
        public void CalcularPromedioMinMax()
        {
            Promedio();
            Minima();
            Maxima();

        }


        public void Promedio()
        {

            float suma = 0, promedio = 0;
            for (int n = 0; n < salones; n++) // Ciclo salones
            {
                for (int m = 0; m < cantidadAlumnos; m++) // Ciclo alumnos
                {
                    suma += calif[n, m];
                }
            }

            promedio = suma / (cantidadAlumnos * salones);

            resultadoTextBlock.Text = $"Promedio: {promedio}\n";
        }

        public void Minima()
        {
            float minima = 10.0f;// Variable para la calificación mínima
            // Encontramos la calificación mínima
            for (int n = 0; n < salones; n++) // Ciclo salones
            {
                for (int m = 0; m < cantidadAlumnos; m++) // Ciclo alumnos
                {
                    if (calif[n, m] < minima)
                        minima = calif[n, m];
                }
            }

            resultadoTextBlock.Text += $"Minima: {minima}\n";
        }


        public void Maxima()
        {
            float maxima = 0;
            // Encontramos la calificación maxima
            for (int n = 0; n < salones; n++) // Ciclo salones
            {
                for (int m = 0; m < cantidadAlumnos; m++) // Ciclo alumnos
                {
                    if (calif[n, m] > maxima)
                        maxima = calif[n, m];
                }
            }
            resultadoTextBlock.Text += $"Maxima: {maxima}";
        }
       
    }
}

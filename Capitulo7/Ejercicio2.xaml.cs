using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for Ejercicio2.xaml
    /// </summary>
    public partial class Ejercicio2 : Window
    {
        Hashtable palabraHash = new Hashtable();
        private int previousLineCount = 0;
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void agregarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            String palabra = palabraTextBox.Text;
            palabraHash.Add(palabra, definicionTextBox.Text);

            palabraTextBox.Text = "";
            definicionTextBox.Text = "";
        }

        private void buscarButton_Click(object sender, RoutedEventArgs e)
        {
            String palabra = palabraTextBox.Text;

            definicionTextBox.Text = (string) palabraHash[palabra];
            
        }

        private void definicionTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(definicionTextBox.LineCount > previousLineCount)
            {
                previousLineCount = definicionTextBox.LineCount;
            }

        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            palabraTextBox.Text = "";
            definicionTextBox.Text = "";
        }

        public bool Validar()
        {
            bool ok = true;
            String palabra = palabraTextBox.Text;
            if(palabraHash.Contains(palabra) == true)
            {
                MessageBox.Show("Esta palabra ya existe en el diccionario", "Aviso", MessageBoxButton.OK,
                    MessageBoxImage.Information);
                ok = false;
            }

            return ok;
        }

        private void atrasButton_Click(object sender, RoutedEventArgs e)
        {
            Capitulo7 capitulo7 = new Capitulo7();
            capitulo7.Show();
            this.Close();
        }
    }
}

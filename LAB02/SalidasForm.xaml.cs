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

namespace LAB02
{
    /// <summary>
    /// Interaction logic for SalidasForm.xaml
    /// </summary>
    public partial class SalidasForm : Window
    {
        public SalidasForm()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Datos guardados.");
        }

        private void Limpiar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Datos Limpiados.");
        }

        private void Regresar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

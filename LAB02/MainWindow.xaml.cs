using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LAB02
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

        private void OperacionesSalidas_Click(object sender, RoutedEventArgs e)
        {
            SalidasForm salidasForm = new SalidasForm();
            salidasForm.ShowDialog();
        }

        private void Camiones_Click(object sender, RoutedEventArgs e)
        {
            CamionesMantenimiento camionesMantenimiento = new CamionesMantenimiento();
            camionesMantenimiento.Show();
        }

        private void Conductores_Click(object sender, RoutedEventArgs e)
        {
            Conductores conductores = new Conductores();
            conductores.Show();
        }

        private void SalidasReportes_Click(object sender, RoutedEventArgs e)
        {
            SalidasReportes salidasReportes = new SalidasReportes();
            salidasReportes.Show();
        }
        
    }
}
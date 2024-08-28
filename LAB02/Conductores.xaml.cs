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
using System.Collections.Generic;

namespace LAB02
{
    /// <summary>
    /// Interaction logic for Conductores.xaml
    /// </summary>
    public partial class Conductores : Window
    {
        public Conductores()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            List<Conductor> conductores = new List<Conductor>
            {
                new Conductor { Id = 1, PesoMaximo = "15000", Placa = "ABC123", PesoVacio = "5000" },
                new Conductor { Id = 2, PesoMaximo = "12000", Placa = "XYZ789", PesoVacio = "4500" },
                new Conductor { Id = 3, PesoMaximo = "18000", Placa = "LMN456", PesoVacio = "6000" }
            };

            // Set the DataContext of the DataGrid
            ConductoresDataGrid.ItemsSource = conductores;
        }

        private void Regresar_Click(object sender, RoutedEventArgs e)
        {
            // Close the current window to return to the main menu
            this.Close();
        }
    }

    public class Conductor
    {
        public int Id { get; set; }
        public string PesoMaximo { get; set; }
        public string Placa { get; set; }
        public string PesoVacio { get; set; }
    }
}

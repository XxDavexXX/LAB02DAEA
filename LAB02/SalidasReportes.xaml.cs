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
    /// Interaction logic for SalidasReportes.xaml
    /// </summary>
    public partial class SalidasReportes : Window
    {
        public SalidasReportes()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Define una lista de datos estáticos
            List<SalidaReporte> salidas = new List<SalidaReporte>
            {
                new SalidaReporte { Id = 1, Fecha = "2024-08-01", Peso = "10000", TipoAuto = "Camión", NombreTransportista = "Juan Pérez", PesoIngreso = "5000", PesoSalida = "6000", FechaYHora = "2024-08-01 10:00:00" },
                new SalidaReporte { Id = 2, Fecha = "2024-08-02", Peso = "12000", TipoAuto = "Camión", NombreTransportista = "Ana López", PesoIngreso = "4000", PesoSalida = "8000", FechaYHora = "2024-08-02 11:00:00" },
                new SalidaReporte { Id = 3, Fecha = "2024-08-03", Peso = "15000", TipoAuto = "Camión", NombreTransportista = "Carlos Gómez", PesoIngreso = "6000", PesoSalida = "9000", FechaYHora = "2024-08-03 12:00:00" }
            };

            // Establece la fuente de datos del DataGrid
            SalidasDataGrid.ItemsSource = salidas;
        }

        private void Regresar_Click(object sender, RoutedEventArgs e)
        {
            // Cierra la ventana actual para volver al menú principal
            this.Close();
        }
    }

    public class SalidaReporte
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Peso { get; set; }
        public string TipoAuto { get; set; }
        public string NombreTransportista { get; set; }
        public string PesoIngreso { get; set; }
        public string PesoSalida { get; set; }
        public string FechaYHora { get; set; }
    }
}

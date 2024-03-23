using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace lab02
{
    /// <summary>
    /// Lógica de interacción para Operaciones.xaml
    /// </summary>
    public partial class Operaciones : Window
    {
        public ObservableCollection<Operacion> OperacionesList { get; set; }
        public Operaciones()
        {
            InitializeComponent();
            OperacionesList = new ObservableCollection<Operacion>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Datos Guardados");
        }

        public class Operacion
        {
            public string TipoDocumento { get; set; }
            public string NumeroDocumento { get; set; }
            public string Placa { get; set; }
            public string Turno { get; set; }
            public string Conductor { get; set; }
            public string Cliente { get; set; }
            public DateTime Fecha { get; set; }
            public double Peso { get; set; }

            // Constructor
            public Operacion(string tipoDocumento, string numeroDocumento, string placa, string turno, string conductor, string cliente, DateTime fecha, double peso)
            {
                TipoDocumento = tipoDocumento;
                NumeroDocumento = numeroDocumento;
                Placa = placa;
                Turno = turno;
                Conductor = conductor;
                Cliente = cliente;
                Fecha = fecha;
                Peso = peso;
            }
        }

    }
}

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
    /// Lógica de interacción para Conductores.xaml
    /// </summary>
    public partial class Conductores : Window
    {
        public ObservableCollection<Conductor> ConductoresList { get; set; }

        public Conductores()
        {
            InitializeComponent();
            ConductoresList = new ObservableCollection<Conductor>();
            dataGridConductores.ItemsSource = ConductoresList;
        }

        private void Button_Insertar(object sender, RoutedEventArgs e)
        {
            // Obtener datos ingresados
            string nombre = txtNombre.Text;
            string licencia = txtLicencia.Text;
            string transporte = txtTransporte.Text;

            // Crear un nuevo conductor
            Conductor nuevoConductor = new Conductor(nombre, licencia, transporte);

            // Agregar el nuevo conductor a la lista
            ConductoresList.Add(nuevoConductor);

            // Limpiar los campos después de guardar
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtLicencia.Text = string.Empty;
            txtTransporte.Text = string.Empty;
        }
    }

    public class Conductor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }

        public Conductor(string nombre, string apellido, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
        }
    }
}

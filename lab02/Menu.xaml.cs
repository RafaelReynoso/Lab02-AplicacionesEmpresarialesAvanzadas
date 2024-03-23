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

namespace lab02
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_Operaciones(object sender, RoutedEventArgs e)
        {
            Operaciones operaciones = new Operaciones();
            operaciones.ShowDialog();

        }

        private void Button_Mantenimientos(object sender, RoutedEventArgs e)
        {
            Conductores conductores = new Conductores();
            conductores.ShowDialog();

        }

        private void Button_Reportes(object sender, RoutedEventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.ShowDialog();

        }
    }
}

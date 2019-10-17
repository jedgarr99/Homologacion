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

namespace Homologacion
{
    /// <summary>
    /// Interaction logic for BuscarServicio.xaml
    /// </summary>
    public partial class BuscarServicio : Window
    {
        public BuscarServicio()
        {
            InitializeComponent();
        }

        private void BtBuscar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtRegresar_Click(object sender, RoutedEventArgs e)
        {
            Menu w = new Menu();
            w.Show();
            this.Close();
        }
    }
}

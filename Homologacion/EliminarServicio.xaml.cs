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
    /// Interaction logic for EliminarServicio.xaml
    /// </summary>
    public partial class EliminarServicio : Window
    {
        public EliminarServicio()
        {
            InitializeComponent();
        }

        private void BtEliminar_Click(object sender, RoutedEventArgs e)
        {
            String cu = txEliminar.Text;
            Servicio s = new Servicio();
            s.eliminar(Int32.Parse(cu));
        }

        private void Button_Agregar(object sender, RoutedEventArgs e)
        {
            AgregarServicio w = new AgregarServicio();
            w.Show();
            this.Close();
        }

        private void Button_Eliminar(object sender, RoutedEventArgs e)
        {
            EliminarServicio w = new EliminarServicio();
            w.Show();
            this.Close();

        }



        private void BtRegresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Close();
        }

        private void BtModificar_Click(object sender, RoutedEventArgs e)
        {
            ModificarServicio w = new ModificarServicio();
            w.Show();
            this.Close();
        }

        private void BtBuscar_Click(object sender, RoutedEventArgs e)
        {
            BuscarServicio w = new BuscarServicio();
            w.Show();
            this.Close();
        }

    }
}

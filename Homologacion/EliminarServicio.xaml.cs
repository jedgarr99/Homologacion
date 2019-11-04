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
        // se elimina el servicio con el id proporcionado 
        private void BtEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String cu = txEliminar.Text;
                Int32 id = 0, x = 2;
                try
                {
                    id = Int32.Parse(cu); // intenta castear a int 
                }
                catch (Exception ex)
                {
                    x = 0;
                }

                if (x != 0)
                {
                    Servicio s = new Servicio();
                    x = s.eliminar(id);
                    if (x != 0)
                    {
                        MessageBox.Show("Eliminacion Exitosa");
                        txEliminar.Text = "";
                    }

                }
                if (x == 0)
                {
                    MessageBox.Show("Id invalido"); // en caso de que no fuera un entero o no se encontro 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo. " + ex.Message);
            }
        }
        // se cambia a la ventana elegida 
        private void Button_Agregar(object sender, RoutedEventArgs e)
        {
            AgregarServicio w = new AgregarServicio();
            w.Show();
            this.Close();
        }
        // se cambia a la ventana elegida 
        private void Button_Eliminar(object sender, RoutedEventArgs e)
        {
            EliminarServicio w = new EliminarServicio();
            w.Show();
            this.Close();

        }
        // se cambia a la ventana elegida 
        private void BtRegresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Close();
        }
        // se cambia a la ventana elegida 
        private void BtModificar_Click(object sender, RoutedEventArgs e)
        {
            ModificarServicio w = new ModificarServicio();
            w.Show();
            this.Close();
        }
        // se cambia a la ventana elegida 
        private void BtBuscar_Click(object sender, RoutedEventArgs e)
        {
            BuscarServicio w = new BuscarServicio();
            w.Show();
            this.Close();
        }

    }
}

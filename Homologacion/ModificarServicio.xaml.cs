using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for ModificarServicio.xaml
    /// </summary>
    public partial class ModificarServicio : Window
    {
        public ModificarServicio()
        {
            InitializeComponent();
            //se llena el list box de hora inicio y hora fin con intervalos de medias horas 

            lbInicio.Items.Add("7:00");
            lbInicio.Items.Add("7:30");
            lbInicio.Items.Add("8:00");
            lbInicio.Items.Add("8:30");
            lbInicio.Items.Add("9:00");
            lbInicio.Items.Add("9:30");
            lbInicio.Items.Add("10:00");
            lbInicio.Items.Add("10:30");
            lbInicio.Items.Add("11:00");
            lbInicio.Items.Add("11:30");
            lbInicio.Items.Add("12:00");
            lbInicio.Items.Add("12:30");
            lbInicio.Items.Add("13:00");
            lbInicio.Items.Add("13:30");
            lbInicio.Items.Add("14:00");
            lbInicio.Items.Add("14:30");
            lbInicio.Items.Add("15:00");
            lbInicio.Items.Add("15:30");
            lbInicio.Items.Add("16:00");
            lbInicio.Items.Add("16:30");
            lbInicio.Items.Add("17:00");
            lbInicio.Items.Add("17:30");
            lbInicio.Items.Add("18:00");
            lbInicio.Items.Add("18:30");
            lbInicio.Items.Add("19:00");
            lbInicio.Items.Add("19:30");
            lbInicio.Items.Add("20:00");
            lbInicio.Items.Add("20:30");
            lbInicio.Items.Add("21:00");
            lbInicio.Items.Add("21:30");

            lbFin.Items.Add("7:00");
            lbFin.Items.Add("7:30");
            lbFin.Items.Add("8:00");
            lbFin.Items.Add("8:30");
            lbFin.Items.Add("9:00");
            lbFin.Items.Add("9:30");
            lbFin.Items.Add("10:00");
            lbFin.Items.Add("10:30");
            lbFin.Items.Add("11:00");
            lbFin.Items.Add("11:30");
            lbFin.Items.Add("12:00");
            lbFin.Items.Add("12:30");
            lbFin.Items.Add("13:00");
            lbFin.Items.Add("13:30");
            lbFin.Items.Add("14:00");
            lbFin.Items.Add("14:30");
            lbFin.Items.Add("15:00");
            lbFin.Items.Add("15:30");
            lbFin.Items.Add("16:00");
            lbFin.Items.Add("16:30");
            lbFin.Items.Add("17:00");
            lbFin.Items.Add("17:30");
            lbFin.Items.Add("18:00");
            lbFin.Items.Add("18:30");
            lbFin.Items.Add("19:00");
            lbFin.Items.Add("19:30");
            lbFin.Items.Add("20:00");
            lbFin.Items.Add("20:30");
            lbFin.Items.Add("21:00");
            lbFin.Items.Add("21:30");
        }

        // cambia a la ventana elegida 
        private void Button_Agregar(object sender, RoutedEventArgs e)
        {
            AgregarServicio w = new AgregarServicio();
            w.Show();
            this.Close();
        }
        // cambia a la ventana elegida 
        private void Button_Eliminar(object sender, RoutedEventArgs e)
        {
            EliminarServicio w = new EliminarServicio();
            w.Show();
            this.Close();

        }
        // cambia a la ventana elegida 
        private void BtRegresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Close();
        }
        // cambia a la ventana elegida 
        private void BtModificar_Click(object sender, RoutedEventArgs e)
        {
            ModificarServicio w = new ModificarServicio();
            w.Show();
            this.Close();
        }
        // cambia a la ventana elegida 
        private void BtBuscar_Click(object sender, RoutedEventArgs e)
        {
            BuscarServicio w = new BuscarServicio();
            w.Show();
            this.Close();
        }

        // se modifica la hora inicial y/o la hora final del servicio con el id proporcionado 
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            String id = txEliminar.Text;
            Int32 x=0;
            short idI = 0;
            StringBuilder bui = new StringBuilder();
            String horaInicio = "", horaFin = "";
            Servicio s;
            if (id != "")
            {
                if (lbInicio.SelectedIndex != -1)
                    horaInicio = lbInicio.SelectedItem.ToString();
                if (lbFin.SelectedIndex != -1)
                    horaFin = lbFin.SelectedItem.ToString();
                try
                {
                    idI = short.Parse(id);

                }catch(Exception ex)
                {
                }
                if (lbInicio.SelectedIndex != -1)
                {
                    s = new Servicio(idI, horaInicio);
                    x = s.modificarIn(s);
                }
                if (lbFin.SelectedIndex != -1)
                {

                    s = new Servicio(idI, horaFin);
                    x = s.modificarFin(s);
                }
                if (lbInicio.SelectedIndex == -1 && lbFin.SelectedIndex == -1)
                {
                    MessageBox.Show("No se selecciono hora de inicio u hora de fin a cambiar");
                }
                else if (x == 0)
                {
                    MessageBox.Show("Id incorrecto");
                }
                else
                {
                    MessageBox.Show("Modificacion exitosa");
                }

            }
            else
            {
                MessageBox.Show("Parametro de ID vacio");
            }
            
        }

        private void lbInicio_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //una vez que se elige la hora inicial, se cambia a la vista la hora final de hora y media despues para que sea mas facil
            //encontrar la hora deseada 
            int pos = lbInicio.SelectedIndex;
            pos += 3;
            string x = lbFin.Items[pos].ToString();
            lbFin.ScrollIntoView(x);
        }
    }
}

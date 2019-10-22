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
    /// Interaction logic for AgregarServicio.xaml
    /// </summary>
    public partial class AgregarServicio : Window
    {
        public AgregarServicio()
        {
            InitializeComponent();
            cbTipo.Items.Add("Laboratorio");
            cbTipo.Items.Add("Horas de Cubiculo");
            cbTipo.Items.Add("Facultad Menor");
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



        private void CbTipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LbInicio_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show( lbInicio.SelectedIndex.ToString());
            int pos = lbInicio.SelectedIndex;
            pos += 3;
            string x = lbFin.Items[pos].ToString();
            lbFin.ScrollIntoView(x);
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String id = txId.Text;
            String lugar = txLugar.Text;
        }
    }
}

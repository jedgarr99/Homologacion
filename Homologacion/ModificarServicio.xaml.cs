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
            
            String id = txEliminar.Text;
            Int32 x;
            StringBuilder bui = new StringBuilder();
            String horaInicio="", horaFin="";
            Servicio s;
            if (lbInicio.SelectedIndex!=-1)
                horaInicio = lbInicio.SelectedItem.ToString();
            if (lbFin.SelectedIndex != -1)
                horaFin = lbFin.SelectedItem.ToString();


            try
            {
                if (cbLunes.IsChecked.HasValue && cbLunes.IsChecked.Value)
                {
                    if (lbInicio.SelectedIndex != -1)
                    {
                        s = new Servicio(short.Parse(id), horaInicio, "Lunes");
                        s.modificarIn(s);
                    }
                    if (lbFin.SelectedIndex != -1)
                    {

                        s = new Servicio(short.Parse(id), horaFin, "Lunes");
                        s.modificarFin(s);
                    }
                }



                if (cbMartes.IsChecked.HasValue && cbMartes.IsChecked.Value)
                {
                    if (lbInicio.SelectedIndex != -1)
                    {
                        s = new Servicio(short.Parse(id), horaInicio, "Martes");
                        s.modificarIn(s);
                    }
                    if (lbFin.SelectedIndex != -1)
                    {
                        s = new Servicio(short.Parse(id), horaFin, "Martes");
                        s.modificarFin(s);
                    }

                }

                if (cbMiercoles.IsChecked.HasValue && cbMiercoles.IsChecked.Value)
                {
                    if (lbInicio.SelectedIndex != -1)
                    {
                        s = new Servicio(short.Parse(id), horaInicio, "Miercoles");
                        s.modificarIn(s);
                    }
                    if (lbFin.SelectedIndex != -1)
                    {
                        s = new Servicio(short.Parse(id), horaFin, "Miercoles");
                        s.modificarFin(s);
                    }
                }

                if (cbJueves.IsChecked.HasValue && cbJueves.IsChecked.Value)
                {
                    if (lbInicio.SelectedIndex != -1)
                    {
                        s = new Servicio(short.Parse(id), horaInicio, "Jueves");
                        s.modificarIn(s);
                    }
                    if (lbFin.SelectedIndex != -1)
                    {
                        s = new Servicio(short.Parse(id), horaFin, "Jueves");
                        s.modificarFin(s);
                    }
                }

                if (cbViernes.IsChecked.HasValue && cbViernes.IsChecked.Value)
                {
                    if (lbInicio.SelectedIndex != -1)
                    {
                        s = new Servicio(short.Parse(id), horaInicio, "Viernes");
                        s.modificarIn(s);
                    }
                    if (lbFin.SelectedIndex != -1)
                    {
                        s = new Servicio(short.Parse(id), horaFin, "Viernes");
                        s.modificarFin(s);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede modificar. "+ex.Message);
            }
            
        }
    }
}

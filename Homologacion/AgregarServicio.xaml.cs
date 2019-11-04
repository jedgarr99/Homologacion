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
    /// Interaction logic for AgregarServicio.xaml
    /// </summary>
    public partial class AgregarServicio : Window
    {
        public AgregarServicio()
        {

            InitializeComponent();
            //se instancian las variables a usar en la conexion 
            SqlCommand cmd;
            SqlDataReader rd;
            SqlConnection con;
            //se llena el cb Tipo con los tres servicios posibles 
            cbTipo.Items.Add("Laboratorio");
            cbTipo.Items.Add("Horas de Cubiculo");
            cbTipo.Items.Add("Facultad Menor");
            try
            {
                //se intenta abrir la conexion para llenar el cb de departamentos 
                con = Conexion.conectar();
                cmd = new SqlCommand("select nombre from departamentos", con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    // se llena el cb departamentos ( aunque los nombres estan al reves)
                    cbMateria.Items.Add(rd["nombre"].ToString());
                }
                //cb.SelectedIndex = 0;
                rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar el comboooo" + ex);
            }
            try
            {
                //se intenta abrir la conexion para llenar el cb de materias
                con = Conexion.conectar();
                cmd = new SqlCommand("select nombre from materias", con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    // se llena el cb materias aunque los nombres estan al reves)
                    cbDepartamento.Items.Add(rd["nombre"].ToString());
                }
                //cb.SelectedIndex = 0;
                rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar el comboll" + ex.Message);
            }
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



        private void CbTipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LbInicio_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //una vez que se elige la hora inicial, se cambia a la vista la hora final de hora y media despues para que sea mas facil
            //encontrar la hora deseada 
            int pos = lbInicio.SelectedIndex;
            pos += 3;
            string x = lbFin.Items[pos].ToString();
            lbFin.ScrollIntoView(x);
        }

        private void Button_Agregar(object sender, RoutedEventArgs e)
        {
            // se cambia a la ventana elegida 
            AgregarServicio w = new AgregarServicio();
            w.Show();

            this.Close();
        }

        private void Button_Eliminar(object sender, RoutedEventArgs e)
        {
            // se cambia a la ventana elegida 
            EliminarServicio w = new EliminarServicio();
            w.Show();
            this.Close();

        }



        private void BtRegresar_Click(object sender, RoutedEventArgs e)
        {
            // se cambia a la ventana elegida 
            MainWindow w = new MainWindow();
            w.Show();
            this.Close();
        }

        private void BtModificar_Click(object sender, RoutedEventArgs e)
        {
            // se cambia a la ventana elegida 
            ModificarServicio w = new ModificarServicio();
            w.Show();
            this.Close();
        }

        private void BtBuscar_Click(object sender, RoutedEventArgs e)
        {
            // se cambia a la ventana elegida 
            BuscarServicio w = new BuscarServicio();
            w.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                //si se quiere agregar un servicio se instancian los elementos necesarios para la conexion 
                Int16 id = 0;// se pone el id provisionalmente en 0 para que no marque error 
                SqlCommand cmd;
                SqlDataReader rd;
                SqlConnection con;
                try
                {
                    con = Conexion.conectar();
                    cmd = new SqlCommand("select max(servicios.idServicio) from servicios", con);//se encuentra el actual id servicio maximo para poner uno mayor
                    rd = cmd.ExecuteReader();
                    rd.Read();
                    id = Int16.Parse(rd[0].ToString());
                    id++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Id maximo no encontrado. \n " + ex.Message);
                }

                String lugar = txLugar.Text; // es posible dejar el lugar en blanco si asi se desea 
                String tipo = cbTipo.SelectedItem.ToString();
                String horaInicio = lbInicio.SelectedItem.ToString();
                String horaFin = lbFin.SelectedItem.ToString();
                String curso;
                // si se ingresa el servicio en los primeros 5 meses es que es de Primavera 
                if (int.Parse(DateTime.Now.Month.ToString()) < 6)
                {
                    curso = "Primavera";

                }
                else if (int.Parse(DateTime.Now.Month.ToString()) < 7)
                {
                    // antes del 7 es en verano 
                    curso = "Verano";

                }
                else
                {
                    // despues es en otoño 
                    curso = "Otoño";
                }
                // se pone el año actual 
                int año = int.Parse(DateTime.Now.Year.ToString());
                int idMateria = -1;
                // checa que alguna materia este seleccionada, el departamento es opcional para reducir la lista de materias 
                if (cbDepartamento.SelectedIndex != -1)
                {

                    try
                    {
                        //se abre una conexion y se obtiene el id del nombre de la materia seleccionada 
                        con = Conexion.conectar();
                        cmd = new SqlCommand(String.Format("select materias.idMateria from materias where materias.nombre='{0}'", cbDepartamento.SelectedItem.ToString()), con);
                        rd = cmd.ExecuteReader();
                        rd.Read();
                        idMateria = int.Parse(rd[0].ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Materia no encontrada \n " + ex.Message);
                    }
                    Servicio s;
                    //checa que al menos un dia este seleccionado 
                    if (cbLunes.IsChecked.HasValue && cbLunes.IsChecked.Value || cbMartes.IsChecked.HasValue && cbMartes.IsChecked.Value || cbMiercoles.IsChecked.HasValue && cbMiercoles.IsChecked.Value
                        || cbJueves.IsChecked.HasValue && cbJueves.IsChecked.Value || cbViernes.IsChecked.HasValue && cbViernes.IsChecked.Value)
                    {
                        if (cbLunes.IsChecked.HasValue && cbLunes.IsChecked.Value)
                        {
                            //si se selecciono este dia de la semana, se da de alta un servicio en este dia 
                            s = new Servicio(id, lugar, tipo, horaInicio, horaFin, curso, año, idMateria, "Lunes");
                            s.agregar(s);
                            id++;
                        }

                        if (cbMartes.IsChecked.HasValue && cbMartes.IsChecked.Value)
                        {
                            //si se selecciono este dia de la semana, se da de alta un servicio en este dia 
                            s = new Servicio(id, lugar, tipo, horaInicio, horaFin, curso, año, idMateria, "Martes");
                            s.agregar(s);
                            id++;

                        }

                        if (cbMiercoles.IsChecked.HasValue && cbMiercoles.IsChecked.Value)
                        {
                            //si se selecciono este dia de la semana, se da de alta un servicio en este dia 
                            s = new Servicio(id, lugar, tipo, horaInicio, horaFin, curso, año, idMateria, "Miercoles");
                            s.agregar(s);
                            id++;
                        }

                        if (cbJueves.IsChecked.HasValue && cbJueves.IsChecked.Value)
                        {
                            //si se selecciono este dia de la semana, se da de alta un servicio en este dia 
                            s = new Servicio(id, lugar, tipo, horaInicio, horaFin, curso, año, idMateria, "Jueves");
                            s.agregar(s);
                            id++;
                        }

                        if (cbViernes.IsChecked.HasValue && cbViernes.IsChecked.Value)
                        {
                            //si se selecciono este dia de la semana, se da de alta un servicio en este dia 
                            s = new Servicio(id, lugar, tipo, horaInicio, horaFin, curso, año, idMateria, "Viernes");
                            s.agregar(s);
                            id++;
                        }
                        System.Media.SystemSounds.Asterisk.Play(); // se reproduce un sonidito 
                        MessageBox.Show("Alta exitosa");
                        AgregarServicio w = new AgregarServicio();
                        w.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ningun dia seleccionado ");
                    }
                }
                else
                {
                    MessageBox.Show("Materia no seleccionada ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo dar de alta, parametros incompletos  ");
            }

        }

        private void cbMateria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // si se elige un departamento, la lista de materias disponibles se limita a las de ese departamento 
            SqlCommand cmd;
            SqlDataReader rd;
            SqlConnection con;
            int x = -1;
            try
            {
                // se obtiene el id del departamento elegido 
                con = Conexion.conectar();
                cmd = new SqlCommand(String.Format("select departamentos.idDepartamento from departamentos where departamentos.nombre = '{0}'", cbMateria.SelectedItem.ToString()), con);
                rd = cmd.ExecuteReader();
                rd.Read();
                x = int.Parse(rd[0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Departamento invalido. " + ex.Message);
            }

            try
            {
                // se llena el combo box de las materias con las que pertenecen al departamento indicado 
                cbDepartamento.Items.Clear();
                con = Conexion.conectar();
                cmd = new SqlCommand(String.Format("select materias.nombre from materias where materias.idDepartamento = {0}", x), con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cbDepartamento.Items.Add(rd["nombre"].ToString());
                }
                //cb.SelectedIndex = 0;
                rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar el combo. " + ex.Message);
            }
            //select materias.nombre from materias where materias.idDepartamento = 3
        }


    }
}

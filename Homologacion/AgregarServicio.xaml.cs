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
            SqlCommand cmd;
            SqlDataReader rd;
            SqlConnection con;
            cbTipo.Items.Add("Laboratorio");
            cbTipo.Items.Add("Horas de Cubiculo");
            cbTipo.Items.Add("Facultad Menor");
            try
            {
                
                con = Conexion.conectar();
                cmd = new SqlCommand("select nombre from departamentos", con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cbMateria.Items.Add(rd["nombre"].ToString());
                }
                //cb.SelectedIndex = 0;
                rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar el combo" + ex);
            }
            try
            {
                
                con = Conexion.conectar();
                cmd = new SqlCommand("select nombre from materias", con);
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
                MessageBox.Show("no se pudo llenar el combo" + ex);
            }

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

            try
            {
                Int16 id=0;
                SqlCommand cmd;
                SqlDataReader rd;
                SqlConnection con;
                try
                {
                    con = Conexion.conectar();
                    cmd = new SqlCommand("select max(materias.idMateria) from materias", con);
                    rd = cmd.ExecuteReader();
                    rd.Read();
                    id = Int16.Parse(rd[0].ToString());
                    id++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Id maximo no encontrado \n " + ex);
                }
                
                String lugar = txLugar.Text;
                String tipo = cbTipo.SelectedItem.ToString();
                String horaInicio = lbInicio.SelectedItem.ToString();
                String horaFin = lbFin.SelectedItem.ToString();
                String curso;
                if (int.Parse(DateTime.Now.Month.ToString()) < 7)
                {
                    curso = "Primavera";

                }
                else
                {
                    curso = "Otoño";
                }
                int año = int.Parse(DateTime.Now.Year.ToString());

             
                int idMateria = -1;
                try
                {
                    con = Conexion.conectar();
                    cmd = new SqlCommand(String.Format("select materias.idMateria from materias where materias.nombre='{0}'", cbDepartamento.SelectedItem.ToString()), con);
                    rd = cmd.ExecuteReader();
                    rd.Read();
                    idMateria = int.Parse(rd[0].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Materia no encontrada \n " + ex);
                }
                Servicio s;
                if (cbLunes.IsChecked.HasValue && cbLunes.IsChecked.Value)
                {
                    s = new Servicio(id, lugar, tipo, horaInicio, horaFin, curso, año, idMateria, "Lunes");
                    s.agregar(s);
                    MessageBox.Show("Servicio agregado");
                    id++;
                }
                    
                if (cbMartes.IsChecked.HasValue && cbMartes.IsChecked.Value)
                {
                    s = new Servicio(id, lugar, tipo, horaInicio, horaFin, curso, año, idMateria, "Martes");
                    s.agregar(s);
                    id++;

                }
                   
                if (cbMiercoles.IsChecked.HasValue && cbMiercoles.IsChecked.Value)
                {
                    s = new Servicio(id, lugar, tipo, horaInicio, horaFin, curso, año, idMateria, "Miercoles");
                    s.agregar(s);
                    id++;
                }
                    
                if (cbJueves.IsChecked.HasValue && cbJueves.IsChecked.Value)
                {
                    s = new Servicio(id, lugar, tipo, horaInicio, horaFin, curso, año, idMateria, "Jueves");
                    s.agregar(s);
                    id++;
                }
                   
                if (cbViernes.IsChecked.HasValue && cbViernes.IsChecked.Value)
                {
                    s = new Servicio(id, lugar, tipo, horaInicio, horaFin, curso, año, idMateria, "Viernes");
                    s.agregar(s);
                    id++;
                }
                    

      


            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo dar de alta" + ex);
            }
            
        }

        private void cbMateria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader rd;
            SqlConnection con;
            int x = -1;
            try
            {
                con = Conexion.conectar();
                cmd = new SqlCommand(String.Format("select departamentos.idDepartamento from departamentos where departamentos.nombre = '{0}'", cbMateria.SelectedItem.ToString()), con);
                rd = cmd.ExecuteReader();
                rd.Read();
                x = int.Parse(rd[0].ToString());
            }
            catch(Exception ex){
                MessageBox.Show("Departamento invalido " + ex);
            }

            try
            {
                cbDepartamento.Items.Clear();
                con = Conexion.conectar();
                cmd = new SqlCommand(String.Format("select materias.nombre from materias where materias.idDepartamento = {0}",x), con);
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
                MessageBox.Show("no se pudo llenar el combo" + ex);
            }
            //select materias.nombre from materias where materias.idDepartamento = 3
        }

        
    }
}

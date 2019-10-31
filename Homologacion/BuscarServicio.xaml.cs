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
    /// Interaction logic for BuscarServicio.xaml
    /// </summary>
    public partial class BuscarServicio : Window
    {
        public BuscarServicio()
        {
            InitializeComponent();
            SqlCommand cmd;
            SqlDataReader rd;
            SqlConnection con;
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
                MessageBox.Show("no se pudo llenar el combo. " + ex.Message);
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
                MessageBox.Show("no se pudo llenar el combo. " + ex.Message);
            }

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
            catch (Exception ex)
            {
                MessageBox.Show("Departamento invalido. " + ex.Message);
            }

            try
            {
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
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader rd;
            SqlConnection con;
            int idMateria = 0;
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
                MessageBox.Show("Materia no encontrada. \n " + ex.Message);
            }
            Servicio s = new Servicio();
            s.buscar(idMateria);

            dgBuscar1.ItemsSource = s.buscar(idMateria);

        }
    }
}

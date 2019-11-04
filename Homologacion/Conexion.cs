using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Homologacion
{
    class Conexion
    {
        SqlCommand cmd;
        SqlDataReader rd;
        //abre una conexion y se conecta con la base de datos 
        public static SqlConnection conectar()
        {
            SqlConnection cnn;
            try
            {
              
                //cnn = new SqlConnection("Data Source =JORGE; Initial Catalog = baseServiciosItam; User ID = sa; Password = sqladmin");
                //cnn = new SqlConnection("Data Source = 112SALAS01; Initial Catalog = baseServiciosItam; User ID = sa; Password = sqladmin");
                cnn = new SqlConnection("Data Source=CC202-23\\SA;Initial Catalog=baseServiciosItam;User ID=sa;Password=adminadmin");
                cnn.Open();
                //MessageBox.Show("Si se pudo hacer la coneccion");
            }
            catch (Exception ex)
            {
                cnn = null;
                MessageBox.Show("No se pudo hacer la coneccion" + ex);
            }
            return cnn;
        }
        // checa que la contraseña y el usuario proporcionados sean correctos 
        public static String comprobarPwd(String usuario, String contra)
        {
            String res = "error";
            SqlDataReader rd;
            SqlConnection con;
            try
            {
                con = Conexion.conectar();
                SqlCommand cmd = new SqlCommand(String.Format("select contra from usuarios where nombreUsuario='{0}'", usuario), con);
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    String str = rd.GetString(0);
                    if (str.Equals(contra))
                        res = "Contraseña correcta";
                    else
                        res = "Contraseña incorrecta";
                }
                else
                {
                    res = "Usuario incorrecto";
                }
            }
            catch (Exception ex)
            {
                res += ex;
            }
            return res;
        }
        // metodo que llena un combo box 
        public void llenarComboAlta(ComboBox cb)
        {
            try
            {
                SqlConnection con;
                con = Conexion.conectar();
                cmd = new SqlCommand("select nombre from programa", con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cb.Items.Add(rd["nombre"].ToString());
                }
                cb.SelectedIndex = 0;
                rd.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar" + ex);
            }

        }
    }
}

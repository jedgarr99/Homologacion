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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Homologacion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txUsuario.Text = "Jorge";
            txContraseña.Text = "Jorge";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AgregarServicio w = new AgregarServicio();
            w.Show();
            this.Close();
            /*
            String res = Conexion.comprobarPwd(txUsuario.Text, txContraseña.Text);
            if (res.Equals("contraseña correcta"))
            {
                //MessageBox.Show("Mandar a la siguiente pantalla");
                 AgregarServicio w = new AgregarServicio();
            w.Show();
            this.Close();
            }
            else
            {
                MessageBox.Show(res);

            }
               */

        }
    }
}

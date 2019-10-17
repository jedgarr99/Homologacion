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
    /// Interaction logic for ModificarServicio.xaml
    /// </summary>
    public partial class ModificarServicio : Window
    {
        public ModificarServicio()
        {
            InitializeComponent();
        }

        private void BtRegresar_Click(object sender, RoutedEventArgs e)
        {
            Menu w = new Menu();
            w.Show();
            this.Close();
        }
    }
}

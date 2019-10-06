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

namespace ProyectoSegundoParcial
{
    /// <summary>
    /// Lógica de interacción para Computadora.xaml
    /// </summary>
    public partial class Computadora : UserControl
    {
        public Computadora()
        {
            InitializeComponent();
            txtwarning.Visibility = Visibility.Hidden;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (tbCodigo.Text == string.Empty || tbDescripcion.Text == string.Empty || tbDescuento.Text == string.Empty || tbPrecio.Text == string.Empty || tbProveedor.Text == string.Empty || cbMarca.Text == string.Empty)
            {
                txtwarning.Visibility = Visibility.Visible;
            }

            else
            {
                grdUserControl.Children.Clear();

            }
        }


        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdUserControl.Children.Clear();
        }

        private void TbCodigo_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtwarning.Visibility = Visibility.Hidden;
        }

        private void TbDescripcion_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtwarning.Visibility = Visibility.Hidden;
        }

        private void TbPrecio_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtwarning.Visibility = Visibility.Hidden;
        }

        private void TbDescuento_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtwarning.Visibility = Visibility.Hidden;
        }

        private void TbProveedor_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtwarning.Visibility = Visibility.Hidden;
        }
    }
}

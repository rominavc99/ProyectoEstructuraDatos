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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window  
    {
       
        public MainWindow()
        {
            InitializeComponent();

            
        }
        private void CbProductos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdFormulario.Children.Clear();
           
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            switch (cbProductos.SelectedIndex)
            {
                case 0: //Celular
                    grdFormulario.Children.Add(new Celular());
                    

                break;

                case 1: //Computadora
                    grdFormulario.Children.Add(new Computadora());
                    

                break;

                case 2: //Laptop
                    grdFormulario.Children.Add(new Laptop());
                    

                break;

                case 3: //Impresora
                    grdFormulario.Children.Add(new Impresora());
                    

                break;

                case 4: //Bocina
                    grdFormulario.Children.Add(new Bocina());
                   ;
                   

                    break;

                case 5: //Televsion
                    grdFormulario.Children.Add(new Television());
                   

                break;

                
            }
        }

      
       
        
    }
}

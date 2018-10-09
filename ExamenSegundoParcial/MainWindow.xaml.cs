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

namespace ExamenSegundoParcial
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

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {

            if (controlInformacionPersonal.Visibility == Visibility.Visible)
            {
                
                if (controlInformacionPersonal.txtNombre.Text != "" 
                    && controlInformacionPersonal.txtEdad.Text != ""
                    && controlInformacionPersonal.txtApellidoPaterno.Text != "" 
                    && controlInformacionPersonal.txtApellidoMaterno.Text != "")
                {
                    lblAlerta.Text = "";
                    controlInformacionPersonal.Visibility = Visibility.Collapsed;
                    controlContacto.Visibility = Visibility.Visible;
                    controlInformacionPago.Visibility = Visibility.Collapsed;
                }
                else
                {
                    lblAlerta.Text = "Asegurar de llenar todos los campos";
                }
            }
            else if (controlContacto.Visibility == Visibility.Visible)
            {
                
                if (controlContacto.txtCelular.Text != "" &&
                    controlContacto.txtCorreo.Text != "" && 
                    controlContacto.txtTelefono.Text != "")
                {
                    controlInformacionPersonal.Visibility = Visibility.Collapsed;
                    controlContacto.Visibility = Visibility.Collapsed;
                    controlInformacionPago.Visibility = Visibility.Visible;
                    lblAlerta.Text = "";
                    btnSiguiente.Content = "Terminar";
                }
                else
                {
                    lblAlerta.Text = "Asegurece de llenar todos los campos";
                }
            }
            else
            {
                
                int cantidad = controlInformacionPago.txtNumeroTarjeta.Text.Length;
                if (cantidad != 16)
                {
                    controlInformacionPago.lblAnuncioTarjeta.Text = "Eel numero de tarjeta son 16 digitos.";
                }
                else
                {
                    controlInformacionPago.lblAnuncioTarjeta.Text = "";
                }
            }    

            
        }
    }
}

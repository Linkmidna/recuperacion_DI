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

namespace UT5E03_Julio_F
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Evento evento;
        public MainWindow()
        {
            InitializeComponent();
            evento = new Evento();
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            if (validarDatos())
            {
                rellenarEvento();
                Window resumen = new ResumenWnd(evento);
                if (resumen.ShowDialog() == true)
                {
                    MessageBox.Show("Has dado a si");
                    return;
                }
                MessageBox.Show("Has dado a no");
            }
        }

        private bool validarDatos()
        {
            return true;
        }
        private void rellenarEvento()
        {
            evento.Nombre = txtNombre.Text;
            evento.Fecha = dtpFecha.DisplayDate;
            evento.Hora = DateTime.Parse(txtHora.Text);
            evento.Aforo = int.Parse(txtAforo.Text);
            //evento.Tipo = tipo; lo de los radiobuttons y el valor
            evento.Descripcion = txtDescripcion.Text;
            evento.Seguridad = chbSeguridad.IsChecked.Value;
            evento.Bar = chbBar.IsChecked.Value;
            evento.Montaje = chbMontaje.IsChecked.Value;
            evento.Sanitarios = chbSanitarios.IsChecked.Value;
        }
    }
}

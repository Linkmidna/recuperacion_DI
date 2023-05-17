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

namespace UT5E03_Julio_F
{
    /// <summary>
    /// Lógica de interacción para ResumenWnd.xaml
    /// </summary>
    public partial class ResumenWnd : Window
    {
        Evento evento;
        public ResumenWnd(Evento evento)
        {
            InitializeComponent();
            this.evento = evento;
            cargarDatos();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult=true;
            Close();
        }

        private void cargarDatos()
        {
            txtNombre.Text =evento.Nombre ;
            dtpFecha.SelectedDate = evento.Fecha;
            txtHora.Text = evento.Hora.ToShortTimeString();
            txtAforo.Text = evento.Aforo.ToString();
            //evento.Tipo = tipo; lo de los radiobuttons y el valor
            txtDescripcion.Text = evento.Descripcion;
            //Lo de los chackbox
        }
    }
}

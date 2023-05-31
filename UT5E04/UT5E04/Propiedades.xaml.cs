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

namespace UT5E04
{
    /// <summary>
    /// Lógica de interacción para Propiedades.xaml
    /// </summary>
    public partial class Propiedades : Window
    {
        public Reserva reserva;
        public Propiedades(Reserva reserva)
        {
            InitializeComponent();
            this.reserva = reserva;
            if (reserva.Nombre!=null)
            {
                cargarDatos();
            }
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (validarDatos())
            {
                guardarDatos();
                DialogResult = true;
                Close();
            }
        }
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
        private bool validarDatos()
        {
            return true;
        }
        private void guardarDatos()
        {
            reserva.Nombre = txtNombre.Text;
            reserva.Fecha = DateTime.Parse(dtpFecha.Text);
            reserva.Telefono = txtTelefono.Text;
            reserva.Comensales = int.Parse(txtComensales.Text);
            reserva.Asiste = chbAsiste.IsChecked.Value;
            reserva.Observaciones = txtDescripcion.Text;
        }
        private void cargarDatos()
        {
            txtNombre.Text = reserva.Nombre;
            dtpFecha.Text = reserva.Fecha.ToString();
            txtTelefono.Text = reserva.Telefono;
            txtComensales.Text = reserva.Comensales.ToString();
            if (reserva.Asiste)
            {
                chbAsiste.IsChecked = true;
            }
            txtDescripcion.Text = reserva.Observaciones;
        }
    }
}

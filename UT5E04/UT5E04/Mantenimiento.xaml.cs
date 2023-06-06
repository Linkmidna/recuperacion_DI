using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Lógica de interacción para Mantenimiento.xaml
    /// </summary>
    public partial class Mantenimiento : Window
    {
        Negocio negocio;
        public Mantenimiento()
        {
            InitializeComponent();
            negocio = new Negocio();
            cargarDatos();
        }

        private bool FiltroVista(object item)
        {
            if (string.IsNullOrEmpty(this.txtFiltro.Text))
            {
                return true;
            }
            Reserva reserva = item as Reserva;
            return reserva.Nombre.Contains(this.txtFiltro.Text);
        }

        private void lvReservas_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            if (lvReservas.SelectedItems.Count > 0)
            {
                cmiBorrar.IsEnabled = true;
                cmiModificar.IsEnabled = true;
                cmiConfirmar.IsEnabled = true;
                return;
            }

            cmiBorrar.IsEnabled = false;
            cmiModificar.IsEnabled = false;
            cmiConfirmar.IsEnabled = false;
            return;
        }

        private void btnNueva_Click(object sender, RoutedEventArgs e)
        {
            Reserva reserva = new Reserva();
            Window propiedades = new Propiedades(reserva);
            if (propiedades.ShowDialog() == true)
            {
                negocio.CrearReserva(reserva);
                cargarDatos();
            }
        }

        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {
            CollectionView vista = (CollectionView)CollectionViewSource.GetDefaultView(lvReservas.Items);
            vista.Filter = FiltroVista;

            lblRegistros.Content = lvReservas.Items.Count + " registros";
            if (txtFiltro.Text.Length == 0)
            {
                lblFiltro.Content = "Sin filtro";
                return;
            }
            lblFiltro.Content = "Filtrado por: " + txtFiltro.Text;
        }

        private void lvReservas_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lvReservas.SelectedItems.Count > 0)
            {
                Window propiedades = new Propiedades((Reserva)lvReservas.SelectedItem);
                propiedades.ShowDialog();
                cargarDatos();
            }

        }
        private void cmiNueva_Click(object sender, RoutedEventArgs e)
        {
            Reserva reserva = new Reserva();
            Window propiedades = new Propiedades(reserva);
            if (propiedades.ShowDialog() == true)
            {
                negocio.CrearReserva(reserva);
                cargarDatos();
            }
        }
        private void cmiModificar_Click(object sender, RoutedEventArgs e)
        {

            Window propiedades = new Propiedades((Reserva)lvReservas.SelectedItem);
            propiedades.ShowDialog();
            cargarDatos();
        }
        private void cmiBorrar_Click(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "¿Deseas eliminar la reserva?";
            string caption = "Eliminar reserva";
            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxImage icon = MessageBoxImage.Question;
            MessageBoxResult result;

            result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);

            if (result == MessageBoxResult.Yes)
            {
                Reserva reserva = (Reserva)lvReservas.SelectedItem;
                negocio.BorrarReserva(reserva.ReservaId);
                cargarDatos();
            }

        }
        private void cmiConfirmar_Click(object sender, RoutedEventArgs e)
        {
            Reserva reserva = (Reserva)lvReservas.SelectedItem;
            if (reserva.Asiste)
            {
                reserva.Asiste = false;
                cargarDatos();
                return;
            }
            reserva.Asiste = true;
            cargarDatos();
            return;
        }

        private void cargarDatos()
        {
            lvReservas.Items.Clear();
            foreach (Reserva r in negocio.ObtenerReservas())
            {
                lvReservas.Items.Add(r);
            }
            lblRegistros.Content = lvReservas.Items.Count + " registros";
        }

    }
}

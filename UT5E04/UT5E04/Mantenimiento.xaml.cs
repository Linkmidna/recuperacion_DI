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

            CollectionView vista = (CollectionView)CollectionViewSource.GetDefaultView(lvReservas.Items);
            vista.Filter = FiltroVista;
            lblRegistros.Content = lvReservas.Items.Count + " registros";
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

    private void ListView_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (lvReservas.SelectedItems.Count > 0)
            {
                ContextMenu menuSeleccionado = this.FindResource("ctmSeleccionado") as ContextMenu;
                menuSeleccionado.PlacementTarget = sender as Label;
                menuSeleccionado.IsOpen = true;
                return;
            }

            ContextMenu menuSinSeleccionar = this.FindResource("ctmSinSeleccionar") as ContextMenu;
            menuSinSeleccionar.PlacementTarget = sender as Label;
            menuSinSeleccionar.IsOpen = true;
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
                return;
            }
        }

        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {
            CollectionView vista = (CollectionView)CollectionViewSource.GetDefaultView(lvReservas.Items);
            vista.Filter = FiltroVista;

            lblRegistros.Content = lvReservas.Items.Count + " registros";
            if (txtFiltro.Text.Length==0)
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
        private void cargarDatos()
        {
            lvReservas.Items.Clear();
            foreach(Reserva r in negocio.ObtenerReservas())
            {
                lvReservas.Items.Add(r);
            }
        }
    }
}

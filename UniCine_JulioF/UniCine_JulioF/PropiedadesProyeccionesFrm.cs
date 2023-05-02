using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniCine_JulioF
{
    public partial class PropiedadesProyeccionesFrm : Form
    {
        Proyeccion proyeccion;
        Negocio negocio;
        public PropiedadesProyeccionesFrm(Proyeccion pro)
        {
            InitializeComponent();
            negocio = new Negocio();
            proyeccion = pro;
            if (proyeccion.PeliculaId > 0)
            {
                rellenarCampos();
            }
        }
        private void rellenarCampos()
        {
            txtSesion.Text = negocio.ObtenerSesion(proyeccion.SesionId).Sala+", "+ negocio.ObtenerSesion(proyeccion.SesionId).DiaSemana+", "+negocio.ObtenerSesion(proyeccion.SesionId).Comienzo.ToShortTimeString();
            txtPelicula.Text = negocio.ObtenerPelicula(proyeccion.PeliculaId).Nombre;
            dtpInicio.Value = proyeccion.Inicio;
            if (proyeccion.Fin!=null)
            {
                dtpFin.Value = proyeccion.Fin.Value;
            }
        }

        private void btnBuscarSesion_Click(object sender, EventArgs e)
        {
            BuscarSesionFrm buscarSesion = new BuscarSesionFrm();

            if (buscarSesion.ShowDialog() == DialogResult.OK)
            {
                proyeccion.SesionId = buscarSesion.sesion.SesionId;
                txtSesion.Text = buscarSesion.sesion.Sala + ", " + buscarSesion.sesion.DiaSemana + ", " + buscarSesion.sesion.Comienzo;

            }
        }

        private void btnBuscarPelicula_Click(object sender, EventArgs e)
        {
            BuscarPeliculaFrm buscarPelicula = new BuscarPeliculaFrm();

            if (buscarPelicula.ShowDialog() == DialogResult.OK)
            {
                proyeccion.PeliculaId = buscarPelicula.pelicula.PeliculaId;
                txtPelicula.Text = buscarPelicula.pelicula.Nombre;

            }
        }
    }
}

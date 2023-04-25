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
    public partial class PeliculasFrm : Form
    {
        public PeliculasFrm()
        {
            InitializeComponent();
            actualizarLista();
        }

        private void lvPeliculas_DoubleClick(object sender, EventArgs e)
        {
            if (lvPeliculas.SelectedItems.Count == 1)
            {
                Pelicula pelicula = Negocio.ObtenerPelicula((int)lvPeliculas.SelectedItems[0].Tag);
                abrirPropiedades(pelicula);
            }
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            pelicula.PeliculaId = 0;
            abrirPropiedades(pelicula);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = Negocio.ObtenerPelicula((int)lvPeliculas.SelectedItems[0].Tag);
            abrirPropiedades(pelicula);
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.BorrarPelicula((int)lvPeliculas.SelectedItems[0].Tag);
            actualizarLista();
        }

        private void cmsPeliculas_Opening(object sender, CancelEventArgs e)
        {
            modificarToolStripMenuItem.Enabled = false;
            borrarToolStripMenuItem.Enabled = false;
            if (lvPeliculas.SelectedItems.Count > 0)
            {
                modificarToolStripMenuItem.Enabled = true;
                borrarToolStripMenuItem.Enabled = true;
            }
        }

        private void actualizarLista()
        {
            lvPeliculas.Items.Clear();
            foreach (Pelicula p in Negocio.ObtenerPeliculas())
            {
                string[] lvItem = new string[6];
                lvItem[0] = p.Nombre;
                lvItem[1] = p.Categoria;
                lvItem[2] = p.Genero;
                lvItem[3] = p.Duracion.ToString();
                lvItem[4] = p.Anno.ToString();
                lvItem[5] = p.Sinopsis;

                ListViewItem lviPelicula = new ListViewItem(lvItem);
                lviPelicula.Tag = p.PeliculaId;
                lvPeliculas.Items.Add(lviPelicula);
            }

        }

        private void abrirPropiedades(Pelicula pelicula)
        {
            PropiedadesPeliculasFrm propiedades = new PropiedadesPeliculasFrm(pelicula);
            if (pelicula.PeliculaId <= 0)
            {
                if (propiedades.ShowDialog() == DialogResult.OK)
                {
                    Negocio.CrearPelicula(pelicula);
                    actualizarLista();
                }
                return;
            }
            if (propiedades.ShowDialog() == DialogResult.OK)
            {
                Negocio.ModificarPelicula(pelicula);
                actualizarLista();
            }
        }


    }
}

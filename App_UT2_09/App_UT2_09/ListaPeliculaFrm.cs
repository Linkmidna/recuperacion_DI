using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_UT2_09
{
    public partial class ListaPeliculaFrm : Form
    {
        public ListaPeliculaFrm()
        {
            InitializeComponent();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            pelicula.PeliculasId = 0;
            abrirPropiedades(pelicula);

        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = Negocio.ObtenerPelicula((int)lvPeliculas.SelectedItems[0].Tag);
            abrirPropiedades(pelicula);
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio.BorrarPelicula((int)lvPeliculas.SelectedItems[0].Tag);
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

        private void actualizarLista()
        {
            lvPeliculas.Items.Clear();
            foreach (Pelicula p in Negocio.ObtenerPeliculas())
            {
                string[] lvItem = new string[3];
                lvItem[0] = p.Titulo;
                lvItem[1] = p.Anno.ToString();
                lvItem[2] = p.Genero;

                ListViewItem lviPelicula = new ListViewItem(lvItem);
                lviPelicula.Tag = p.PeliculasId;
                lvPeliculas.Items.Add(lviPelicula);
            }
            
        }

        private void abrirPropiedades(Pelicula pelicula)
        {
            PeliculaFrm propiedades = new PeliculaFrm(pelicula);
            if (pelicula.PeliculasId <= 0)
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

        private void cmsPeliculas_Opening(object sender, CancelEventArgs e)
        {
            cmsiVer.Enabled = false;
            cmsiBorrar.Enabled = false;

            if (lvPeliculas.SelectedItems.Count == 1)
            {
                cmsiVer.Enabled = true;
                cmsiBorrar.Enabled = true;
            }
        }
    }
}

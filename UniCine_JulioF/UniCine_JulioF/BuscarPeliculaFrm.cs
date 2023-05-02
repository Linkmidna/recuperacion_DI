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
    public partial class BuscarPeliculaFrm : Form
    {
        Negocio negocio;
        public Pelicula pelicula;
        public BuscarPeliculaFrm()
        {
            InitializeComponent();
            negocio = new Negocio();
            pelicula = new Pelicula();
            cbGenero.SelectedIndex = 0;
        }

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
                actualizarLista(cbGenero.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void lvPeliculas_DoubleClick(object sender, EventArgs e)
        {
            pelicula = negocio.ObtenerPelicula((int)lvPeliculas.SelectedItems[0].Tag);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void actualizarLista(string filtro)
        {
            lvPeliculas.Items.Clear();
            List<Pelicula> peliculas;
            peliculas = negocio.ObtenerPeliculas();

            if (!filtro.Equals("Todo"))
            {
                peliculas = negocio.ObtenerPeliculas().Where(p => p.Genero.Equals(cbGenero.Text)).ToList();
            }
            
            
            foreach (Pelicula p in peliculas)
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
    }
}

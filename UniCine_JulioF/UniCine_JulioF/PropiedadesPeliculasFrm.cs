using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace UniCine_JulioF
{
    public partial class PropiedadesPeliculasFrm : Form
    {
        Pelicula pelicula;
        public PropiedadesPeliculasFrm(Pelicula pel)
        {
            InitializeComponent();
            pelicula = pel;
            if (pelicula.PeliculaId > 0)
            {
                rellenarCampos();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            guardarDatos();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void rellenarCampos()
        {

            txtNombre.Text = pelicula.Nombre;
            cbCategoria.Text = pelicula.Categoria;
            cbGenero.Text = pelicula.Genero;
            txtDuracion.Text = pelicula.Duracion.ToString();
            txtAnno.Text = pelicula.Anno.ToString();
            txtSinopsis.Text = pelicula.Sinopsis;

            DialogResult = DialogResult.Cancel;
        }

        private void guardarDatos()
        {
            pelicula.Nombre = txtNombre.Text;
            pelicula.Categoria = cbCategoria.Text;
            pelicula.Genero = cbGenero.Text;
            if (int.TryParse(txtDuracion.Text, out int result1))
            {
                pelicula.Duracion = result1;
            }
            if (int.TryParse(txtAnno.Text, out int result2))
            {
                pelicula.Anno = result2;
            }
            pelicula.Sinopsis = txtSinopsis.Text;
        }
    }
}

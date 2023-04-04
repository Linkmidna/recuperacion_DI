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
    public partial class PeliculaFrm : Form
    {
        Pelicula pelicula;
        public PeliculaFrm(Pelicula pel)
        {
            InitializeComponent();
            pelicula = pel;
            if (pelicula.PeliculasId > 0)
            {
                rellenar();
            }
        }

        private void bntAceptar_Click(object sender, EventArgs e)
        {
            if (validarPelicula())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void rellenar()
        {
            if (!pelicula.Titulo.Equals(string.Empty))
            {
                txtTitulo.Text = pelicula.Titulo;
                txtAnno.Text = pelicula.Anno.ToString();
                txtGenero.Text = pelicula.Genero;
            }
            DialogResult = DialogResult.Cancel;
        }

        private bool validarPelicula()
        {
            if (txtTitulo.Text.Equals(string.Empty))
            {
                MessageBox.Show("El título está vacío", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (txtAnno.Text.Equals(string.Empty))
            {
                MessageBox.Show("El año está vacío", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (txtGenero.Text.Equals(string.Empty))
            {
                MessageBox.Show("El genero está vacío", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (int.TryParse(txtAnno.Text, out int result))
            {
                pelicula.Titulo = txtTitulo.Text;
                pelicula.Anno = result;
                pelicula.Genero = txtGenero.Text;
                return true;
            }
            MessageBox.Show("El año no es un número válido", "Error", MessageBoxButtons.OK);
            return false;
        }
    }
}

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
    public partial class LibroFrm : Form
    {
        Libro libro;
        public LibroFrm(Libro lib)
        {
            InitializeComponent();
            libro = lib;
            if (libro.LibrosId>0)
            {
                rellenar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarLibro()) 
            { 
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        
        private void rellenar()
        {
            if (!libro.Titulo.Equals(string.Empty))
            {
                txtTitulo.Text = libro.Titulo;
                txtAnno.Text = libro.Anno.ToString();
                txtAutor.Text = libro.Autor;
            }
            DialogResult = DialogResult.Cancel;
        }

        private bool validarLibro()
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

            if (txtAutor.Text.Equals(string.Empty))
            {
                MessageBox.Show("El autor está vacío", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (int.TryParse(txtAnno.Text,out int result))
            {
                libro.Titulo = txtTitulo.Text;
                libro.Anno = result;
                libro.Autor = txtAutor.Text;
                return true;
            }
            MessageBox.Show("El año no es un número válido", "Error", MessageBoxButtons.OK);
            return false;
        }
    }
}

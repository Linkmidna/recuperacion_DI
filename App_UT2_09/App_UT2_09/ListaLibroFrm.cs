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
    public partial class ListaLibroFrm : Form
    {
        public ListaLibroFrm()
        {
            InitializeComponent();
            actualizarLista();
        }

        private void cmsLibros_Opening(object sender, CancelEventArgs e)
        {
            cmsiVer.Enabled = false;
            cmsiBorrar.Enabled = false;

            if (lvLibros.SelectedItems.Count == 1)
            {
                cmsiVer.Enabled = true;
                cmsiBorrar.Enabled = true;
            }
        }

        private void lvLibros_DoubleClick(object sender, EventArgs e)
        {
            if (lvLibros.SelectedItems.Count==1)
            {
                Libro libro = Negocio.ObtenerLibro((int)lvLibros.SelectedItems[0].Tag);
                abrirPropiedades(libro);
            }
        } 
        
        private void cmsiCrear_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();
            libro.LibrosId = 0;
            abrirPropiedades(libro);
        }

        private void cmsiVer_Click(object sender, EventArgs e)
        {
            Libro libro = Negocio.ObtenerLibro((int)lvLibros.SelectedItems[0].Tag);
            abrirPropiedades(libro);
        }

        private void cmsiBorrar_Click(object sender, EventArgs e)
        {
            Negocio.BorrarLibro((int)lvLibros.SelectedItems[0].Tag);
            actualizarLista();
        }

        private void actualizarLista()
        {
            lvLibros.Items.Clear();
            foreach(Libro l in Negocio.ObtenerLibros())
            {
                string[] lvItem = new string[3];
                lvItem[0] = l.Titulo;
                lvItem[1] = l.Anno.ToString();
                lvItem[2] = l.Autor;

                ListViewItem lviLibro = new ListViewItem(lvItem);
                lviLibro.Tag = l.LibrosId;
                lvLibros.Items.Add(lviLibro);
            }
        }

        private void abrirPropiedades(Libro libro)
        {
            LibroFrm propiedades = new LibroFrm(libro);
            if (libro.LibrosId<=0)
            {
                if (propiedades.ShowDialog() == DialogResult.OK)
                {
                    Negocio.CrearLibro(libro);
                    actualizarLista();
                }
                return;
            }
            if (propiedades.ShowDialog() == DialogResult.OK)
            {
                Negocio.ModificarLibro(libro);
                actualizarLista();
            }
        }
    }
}

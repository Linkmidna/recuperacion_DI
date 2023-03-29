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
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (typeof(ListaPeliculaFrm) == form.GetType())
                {
                    form.Activate();
                    return;
                }
            }
            ListaPeliculaFrm manPeliculas = new ListaPeliculaFrm();
            manPeliculas.MdiParent = this;
            manPeliculas.Show();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (typeof(ListaLibroFrm) == form.GetType())
                {
                    form.Activate();
                    return;
                }
            }
            ListaLibroFrm manLibros = new ListaLibroFrm();
            manLibros.MdiParent = this;
            manLibros.Show();
        }

        private void ventanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            switch (tsmi.Tag)
            {
                case "cascada":
                    this.LayoutMdi(MdiLayout.Cascade);
                    break;
                case "horizontal":
                    this.LayoutMdi(MdiLayout.TileHorizontal);
                    break;
                case "vertical":
                    this.LayoutMdi(MdiLayout.TileVertical);
                    break;
            }
        }
    }
}

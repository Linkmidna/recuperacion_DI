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
    public partial class ContenedorMDI : Form
    {
        public ContenedorMDI()
        {
            InitializeComponent();
        }
        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (typeof(PeliculasFrm) == form.GetType())
                {
                    form.Activate();
                    return;
                }
            }
            PeliculasFrm peliculasFrm = new PeliculasFrm();
            peliculasFrm.MdiParent = this;
            peliculasFrm.Show();

        }

        private void sesionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (typeof(SesionesFrm) == form.GetType())
                {
                    form.Activate();
                    return;
                }
            }
            SesionesFrm sesionesFrm = new SesionesFrm();
            sesionesFrm.MdiParent = this;
            sesionesFrm.Show();
        }

        

        private void proyeccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (typeof(ProyeccionesFrm) == form.GetType())
                {
                    form.Activate();
                    return;
                }
            }
            ProyeccionesFrm proyeccionesFrm = new ProyeccionesFrm();
            proyeccionesFrm.MdiParent = this;
            proyeccionesFrm.Show();
        }
    }
}

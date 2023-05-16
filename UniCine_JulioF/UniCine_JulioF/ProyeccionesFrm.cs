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
    public partial class ProyeccionesFrm : Form
    {
        Negocio negocio;

        public ProyeccionesFrm()
        {
            InitializeComponent();
            negocio = new Negocio();
            actualizarLista();
            
        }

        private void lvProyecciones_DoubleClick(object sender, EventArgs e)
        {
            if (lvProyecciones.SelectedItems.Count == 1)
            {
                Dictionary<int, Object> dict= (Dictionary<int,Object>)lvProyecciones.SelectedItems[0].Tag;

                Proyeccion proyeccion = negocio.ObtenerProyeccion((int)dict.ElementAt(0).Value, (int)dict.ElementAt(1).Value, (DateTime)dict.ElementAt(2).Value);
                abrirPropiedades(proyeccion);
            }
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proyeccion proyeccion = new Proyeccion();
            proyeccion.PeliculaId = 0;
            abrirPropiedades(proyeccion);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<int, Object> dict = (Dictionary<int, Object>)lvProyecciones.SelectedItems[0].Tag;
            Proyeccion proyeccion = negocio.ObtenerProyeccion((int)dict.ElementAt(0).Value, (int)dict.ElementAt(1).Value, (DateTime)dict.ElementAt(2).Value);
            abrirPropiedades(proyeccion);
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<int, Object> dict = (Dictionary<int, Object>)lvProyecciones.SelectedItems[0].Tag;
            negocio.BorrarProyeccion((int)dict.ElementAt(0).Value, (int)dict.ElementAt(1).Value, (DateTime)dict.ElementAt(2).Value);
            actualizarLista();
        }

        private void cmsProyecciones_Opening(object sender, CancelEventArgs e)
        {
            modificarToolStripMenuItem.Enabled = false;
            borrarToolStripMenuItem.Enabled = false;
            if (lvProyecciones.SelectedItems.Count > 0)
            {
                modificarToolStripMenuItem.Enabled = true;
                borrarToolStripMenuItem.Enabled = true;
            }
        }
        private void actualizarLista()
        {
            lvProyecciones.Items.Clear();
            foreach (Proyeccion p in negocio.ObtenerProyecciones())
            {
                Dictionary<int, Object> dict = new Dictionary<int, Object>();
                dict.Add(0, p.SesionId);
                dict.Add(1, p.PeliculaId);
                dict.Add(2, p.Inicio);

                Sesion s = negocio.ObtenerSesion(p.SesionId);

                string[] lvItem = new string[4];
                lvItem[0] = s.Sala + ", " + s.DiaSemana + ", " + s.Comienzo.ToShortTimeString();
                lvItem[1] = negocio.ObtenerPelicula(p.PeliculaId).Nombre;
                lvItem[2] = p.Inicio.ToShortDateString();
                if (p.Fin != null)
                {
                    lvItem[3] = ((DateTime)p.Fin).ToShortDateString();
                }
                else
                {
                    lvItem[3] = "No hay fecha final";
                }


                ListViewItem lviProyeccion = new ListViewItem(lvItem);
                lviProyeccion.Tag = dict;
                lvProyecciones.Items.Add(lviProyeccion);
            }

        }

        private void abrirPropiedades(Proyeccion proyeccion)
        {
            try { 
            PropiedadesProyeccionesFrm propiedades = new PropiedadesProyeccionesFrm(proyeccion);
            if (proyeccion.PeliculaId <= 0)
            {
                if (propiedades.ShowDialog() == DialogResult.OK)
                {
                    negocio.CrearProyeccion(proyeccion);
                    actualizarLista();
                }
                return;
            }
            if (propiedades.ShowDialog() == DialogResult.OK)
            {
                negocio.ModificarProyeccion(proyeccion);
                actualizarLista();
            }
            }
            catch (UniCineException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }
        }


    }
}

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
    public partial class SesionesFrm : Form
    {
        Negocio negocio;
        public SesionesFrm()
        {
            InitializeComponent();
            actualizarLista();
            negocio = new Negocio();

        }

        private void lvSesiones_DoubleClick(object sender, EventArgs e)
        {
            if (lvSesiones.SelectedItems.Count == 1)
            {
                Sesion sesion = negocio.ObtenerSesion((int)lvSesiones.SelectedItems[0].Tag);
                abrirPropiedades(sesion);
            }
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sesion sesion = new Sesion();
            sesion.SesionId = 0;
            abrirPropiedades(sesion);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sesion sesion = negocio.ObtenerSesion((int)lvSesiones.SelectedItems[0].Tag);
            abrirPropiedades(sesion);
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            negocio.BorrarSesion((int)lvSesiones.SelectedItems[0].Tag);
            actualizarLista();
        }
        private void cmsSesiones_Opening(object sender, CancelEventArgs e)
        {
            modificarToolStripMenuItem.Enabled = false;
            borrarToolStripMenuItem.Enabled = false;
            if (lvSesiones.SelectedItems.Count > 0)
            {
                modificarToolStripMenuItem.Enabled = true;
                borrarToolStripMenuItem.Enabled = true;
            }
        }

        private void actualizarLista()
        {
            lvSesiones.Items.Clear();
            foreach (Sesion s in negocio.ObtenerSesiones())
            {
                string[] lvItem = new string[6];
                lvItem[0] = s.Sala;
                lvItem[1] = s.DiaSemana;
                lvItem[2] = s.Comienzo.ToShortTimeString();
                lvItem[3] = s.FinMax.ToShortTimeString();
                lvItem[4] = s.Precio.ToString();
                lvItem[5] = s.Aforo.ToString();

                ListViewItem lviSesion = new ListViewItem(lvItem);
                lviSesion.Tag = s.SesionId;
                lvSesiones.Items.Add(lviSesion);
            }

        }

        private void abrirPropiedades(Sesion sesion)
        {
            PropiedadesSesionesFrm propiedades = new PropiedadesSesionesFrm(sesion);
            if (sesion.SesionId <= 0)
            {
                if (propiedades.ShowDialog() == DialogResult.OK)
                {
                    negocio.CrearSesion(sesion);
                    actualizarLista();
                }
                return;
            }
            if (propiedades.ShowDialog() == DialogResult.OK)
            {
                negocio.ModificarSesion(sesion);
                actualizarLista();
            }
        }


    }
}

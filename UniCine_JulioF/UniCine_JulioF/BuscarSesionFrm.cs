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
    public partial class BuscarSesionFrm : Form
    {
        Negocio negocio;
        public Sesion sesion;
        public BuscarSesionFrm()
        {
            InitializeComponent();
            negocio = new Negocio();
            sesion = new Sesion();
            cbDia.SelectedIndex = 0;
            cbSala.SelectedIndex = 0;
        }

        private void lvSesion_DoubleClick(object sender, EventArgs e)
        {
            sesion = negocio.ObtenerSesion((int)lvSesion.SelectedItems[0].Tag);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void actualizarLista()
        {
            lvSesion.Items.Clear();
            List<Sesion> sesiones;
            sesiones = negocio.ObtenerSesiones();

            if (!cbSala.Equals("Todo") && !cbDia.Equals("Todo"))
            {
                sesiones = negocio.ObtenerSesiones().Where(s => s.DiaSemana.Equals(cbDia.Text) && s.Sala.Equals(cbSala.Text)).ToList();
            }
            if (cbSala.Equals("Todo") && !cbDia.Equals("Todo"))
            {
                sesiones = negocio.ObtenerSesiones().Where(s => s.DiaSemana.Equals(cbDia.Text)).ToList();
            }
            if (!cbSala.Equals("Todo") && cbDia.Equals("Todo"))
            {
                sesiones = negocio.ObtenerSesiones().Where(s => s.Sala.Equals(cbSala.Text)).ToList();
            }


            foreach (Sesion s in sesiones)
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
                lvSesion.Items.Add(lviSesion);
            }
        }

        private void cbSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void cbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarLista();
        }
    }
}

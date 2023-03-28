using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT2E2
{
    public partial class Entrada : Form
    {
        private string genero;

        public Entrada()
        {
            InitializeComponent();

            cbSituacion.SelectedIndex = 0;
            genero = "Masculino";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Resumen res = new Resumen(guardarSocio());
            if (res.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Se han guardado los datos","Guardado",MessageBoxButtons.OK);
                reiniciarFormulario();
                return;
            }
            MessageBox.Show("Se ha cancelado la operación", "Cancelado", MessageBoxButtons.OK);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            reiniciarFormulario();
        }
        private void rButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                genero = (string)rb.Tag;
            }
        }

        private void cbOtras_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOtras.Checked)
            {
                tbOtras.Enabled = true;
                return;
            }
            tbOtras.Text = string.Empty;
            tbOtras.Enabled = false;
        }

        private Socio guardarSocio()
        {
            Socio socio = new Socio();
            string aficiones = String.Empty;
            if (tbNombre.Text.Equals(String.Empty))
            {
                socio = null;
                return socio;
            }
            socio.nombre = tbNombre.Text;
            socio.nacimiento = dtpNacimiento.Value.ToShortDateString();
            socio.genero = genero;
            if (cbDeportes.Checked) aficiones += "Deportes";
            if (cbMusica.Checked) aficiones += "Musica";
            if (cbLectura.Checked) aficiones += "Lectura";
            if (cbOtras.Checked) aficiones += "Otras";
            socio.aficiones = aficiones;
            socio.otras = tbOtras.Text;
            socio.situacion = cbSituacion.Text;


            return socio;
        }

        private void reiniciarFormulario()
        {
            tbNombre.Text = string.Empty;
            dtpNacimiento.Value = DateTime.Parse("31/12/2000");
            rbMasc.Checked = true;
            cbDeportes.Checked = false;
            cbLectura.Checked = false;
            cbMusica.Checked = false;
            cbOtras.Checked = false;
            cbSituacion.SelectedIndex = 0;
        }
    }
}

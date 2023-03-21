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

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            tbNombre.Text = string.Empty;
            dtpNacimiento.Value = DateTime.Parse();
            cbSituacion.SelectedIndex = 0;
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
    }
}

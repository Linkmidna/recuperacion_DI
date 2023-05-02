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
    public partial class PropiedadesSesionesFrm : Form
    {
        Sesion sesion;
        public PropiedadesSesionesFrm(Sesion ses)
        {
            InitializeComponent();
            sesion = ses;
            if (sesion.SesionId > 0)
            {
                rellenarCampos();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            guardarDatos();
            DialogResult = DialogResult.OK;
            Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void rellenarCampos()
        {

            txtSala.Text = sesion.Sala;
            txtDia.Text = sesion.DiaSemana;
            dtpInicio.Value = sesion.Comienzo;
            dtpFin.Value = sesion.FinMax;
            txtPrecio.Text = sesion.Precio.ToString();
            txtAforo.Text = sesion.Aforo.ToString();

            DialogResult = DialogResult.Cancel;
        }

        private void guardarDatos()
        {
            sesion.Sala = txtSala.Text;
            sesion.DiaSemana = txtDia.Text;
            sesion.Comienzo = dtpInicio.Value;
            sesion.FinMax = dtpFin.Value;
            if (float.TryParse(txtPrecio.Text, out float result1))
            {
                sesion.Precio = result1;
            }
            if (int.TryParse(txtAforo.Text, out int result2))
            {
                sesion.Aforo = result2;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtPrecio.Text, out int result))
            {
                if (0 > result)
                {
                    txtPrecio.Text = 0.ToString();
                }
                return;
            }
        }

        private void txtAforo_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtAforo.Text, out int result))
            {
                if (0 > result)
                {
                    txtAforo.Text = 0.ToString();
                }
                return;
            }
        }
    }
}


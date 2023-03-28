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
    public partial class Resumen : Form
    {
        Socio socio;
        public Resumen(Socio socio)
        {
            InitializeComponent();
            this.socio = socio;
            cargarSocio();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void cargarSocio()
        {
            lbNombre.Text = socio.nombre;
            lbNacimiento.Text=socio.nacimiento;
            lbGenero.Text = socio.genero;
            lbAficiones.Text = socio.aficiones;
            tbOtras.Text = socio.otras;
            lbSituacion.Text = socio.situacion;
        }
    }
}

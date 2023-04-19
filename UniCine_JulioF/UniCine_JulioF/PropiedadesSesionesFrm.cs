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
            if(sesion.SesionId > 0)
            {
                rellenar();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
                DialogResult = DialogResult.OK;
                Close();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void rellenar()
        {
            if (!sesion.Sala.Equals(string.Empty))
            {
                txtSala.Text = sesion.Sala;
                txtDia.Text = sesion.DiaSemana;
                dtpInicio.Value = sesion.Comienzo;
                dtpFin.Value = sesion.FinMax;
                txtPrecio.Text = sesion.Precio.ToString();
                txtAforo.Text = sesion.Aforo.ToString();
                
            }
            DialogResult = DialogResult.Cancel;
        }
    }
}

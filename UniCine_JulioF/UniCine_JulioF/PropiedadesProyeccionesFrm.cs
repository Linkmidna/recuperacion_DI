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
    public partial class PropiedadesProyeccionesFrm : Form
    {
        Proyeccion proyeccion;
        public PropiedadesProyeccionesFrm(Proyeccion pro)
        {
            InitializeComponent();
            InitializeComponent();
            proyeccion = pro;
            if (proyeccion.PeliculaId > 0)
            {
                rellenarCampos();
            }
        }
        private void rellenarCampos()
        {
            txtSesion.Text = proyeccion.SesionId.ToString();
            txtPelicula.Text = proyeccion.PeliculaId.ToString();
            dtpInicio.Value = proyeccion.Inicio;
        }
    }
}

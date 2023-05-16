using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Julio_F_Higuera
{
    public partial class MDIFrm : Form
    {
        public MDIFrm()
        {
            InitializeComponent();
        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiEmpresas_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (typeof(EmpresasFrm) == form.GetType())
                {
                    form.Activate();
                    return;
                }
            }
            EmpresasFrm empresasFrm = new EmpresasFrm();
            empresasFrm.MdiParent = this;
            empresasFrm.Show();
        }

        private void tsmiAlumnos_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (typeof(AlumnosFrm) == form.GetType())
                {
                    form.Activate();
                    return;
                }
            }
            AlumnosFrm alumnosFrm = new AlumnosFrm();
            alumnosFrm.MdiParent = this;
            alumnosFrm.Show();
        }
    }
}

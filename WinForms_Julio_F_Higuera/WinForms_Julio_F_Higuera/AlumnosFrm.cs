using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace WinForms_Julio_F_Higuera
{
    public partial class AlumnosFrm : Form
    {
        Negocio negocio;
        public AlumnosFrm()
        {
            InitializeComponent();
            negocio = new Negocio();
            actualizarLista();
        }

        private void tsmiCrear_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.AlumnoId = 0;
            abrirPropiedades(alumno);
        }

        private void cmsCrear_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.AlumnoId = 0;
            abrirPropiedades(alumno);
        }

        private void cmsVer_Click(object sender, EventArgs e)
        {
            Alumno alumno = negocio.BuscarAlumnos().FirstOrDefault(x => x.AlumnoId == int.Parse(lvAlumnos.SelectedItems[0].Tag.ToString()));
            abrirPropiedades(alumno);
        }

        private void lvAlumnos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Alumno alumno = negocio.BuscarAlumnos().FirstOrDefault(x => x.AlumnoId == int.Parse(lvAlumnos.SelectedItems[0].Tag.ToString()));
            abrirPropiedades(alumno);
        }

        private void cmsEliminar_Click(object sender, EventArgs e)
        {
            Alumno alumno = negocio.BuscarAlumnos().FirstOrDefault(x => x.AlumnoId == int.Parse(lvAlumnos.SelectedItems[0].Tag.ToString()));
            negocio.Borrar(alumno);
            actualizarLista();
        }

        private void cmsAlumnos_Opening(object sender, CancelEventArgs e)
        {
            cmsVer.Enabled = false;
            cmsEliminar.Enabled = false;
            if (lvAlumnos.SelectedItems.Count > 0)
            {
                cmsVer.Enabled = true;
                cmsEliminar.Enabled = true;
            }
        }

        private void actualizarLista()
        {
            lvAlumnos.Items.Clear();
            foreach (Alumno a in negocio.BuscarAlumnos())
            {
                string[] lvItem = new string[4];
                lvItem[0] = a.DNI;
                lvItem[1] = a.Nombre;
                lvItem[2] = Herramientas.ObtenerNombreEmpresa(a.EmpresaId);
                lvItem[3] = "No ha empezado";
                if (a.ComienzoPracticas != null)
                {
                    lvItem[3] = a.ComienzoPracticas.Value.ToShortDateString();
                }

                ListViewItem lviAlumno = new ListViewItem(lvItem);
                lviAlumno.Tag = a.AlumnoId;
                lvAlumnos.Items.Add(lviAlumno);
            }
        }

        private void abrirPropiedades(Alumno alumno)
        {
            PropiedadesAlumnoFrm propiedades = new PropiedadesAlumnoFrm(alumno);
            if (alumno.AlumnoId <= 0)
            {
                if (propiedades.ShowDialog() == DialogResult.OK)
                {
                    negocio.Crear(alumno);
                    actualizarLista();
                }
                return;
            }
            if (propiedades.ShowDialog() == DialogResult.OK)
            {
                negocio.Actualizar(alumno);
                actualizarLista();
            }
        }
    }
}

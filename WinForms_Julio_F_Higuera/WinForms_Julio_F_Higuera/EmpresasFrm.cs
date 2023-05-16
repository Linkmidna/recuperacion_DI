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
    public partial class EmpresasFrm : Form
    {
        Negocio negocio;
        public EmpresasFrm()
        {
            InitializeComponent();
            negocio = new Negocio();
            actualizarLista();
        }

        private void tsmiCrear_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            empresa.EmpresaId = 0;
            abrirPropiedades(empresa);
        }

        private void cmsCrear_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            empresa.EmpresaId = 0;
            abrirPropiedades(empresa);
        }

        private void cmsVer_Click(object sender, EventArgs e)
        {
            Empresa empresa = negocio.BuscarEmpresas().FirstOrDefault(x => x.EmpresaId == int.Parse(lvEmpresas.SelectedItems[0].Tag.ToString()));
            abrirPropiedades(empresa);
        }

        private void lvEmpresas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Empresa empresa = negocio.BuscarEmpresas().FirstOrDefault(x => x.EmpresaId == int.Parse(lvEmpresas.SelectedItems[0].Tag.ToString()));
            abrirPropiedades(empresa);
        }

        private void cmsBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Empresa empresa = negocio.BuscarEmpresas().FirstOrDefault(x => x.EmpresaId == int.Parse(lvEmpresas.SelectedItems[0].Tag.ToString()));
                negocio.Borrar(empresa);
                actualizarLista();
            }
            catch (PracticasException x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void cmsEmpresas_Opening(object sender, CancelEventArgs e)
        {
            cmsVer.Enabled = false;
            cmsBorrar.Enabled = false;
            if (lvEmpresas.SelectedItems.Count > 0)
            {
                cmsVer.Enabled = true;
                cmsBorrar.Enabled = true;
            }
        }

        private void actualizarLista()
        {
            lvEmpresas.Items.Clear();
            foreach (Empresa e in negocio.BuscarEmpresas())
            {
                string[] lvItem = new string[3];
                lvItem[0] = e.Nombre;
                lvItem[1] = e.Telefono;
                lvItem[2] = e.PersonaContacto;

                ListViewItem lviEmpresa = new ListViewItem(lvItem);
                lviEmpresa.Tag = e.EmpresaId;
                lvEmpresas.Items.Add(lviEmpresa);
            }
        }

        private void abrirPropiedades(Empresa empresa)
        {
            PropiedadesEmpresaFrm propiedades = new PropiedadesEmpresaFrm(empresa);
            if (empresa.EmpresaId <= 0)
            {
                if (propiedades.ShowDialog() == DialogResult.OK)
                {
                    negocio.Crear(empresa);
                    actualizarLista();
                }
                return;
            }
            if (propiedades.ShowDialog() == DialogResult.OK)
            {
                negocio.Actualizar(empresa);
                actualizarLista();
            }
        }
    }
}

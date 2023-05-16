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
    public partial class BuscarEmpresaFrm : Form
    {
        public Empresa empresa { get; set; }
        public BuscarEmpresaFrm()
        {
            InitializeComponent();
            actualizarLista();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (lvEmpresas.SelectedItems.Count > 0)
            {
                empresa = Herramientas.ObtenerEmpresa(int.Parse(lvEmpresas.SelectedItems[0].Tag.ToString()));
                //Añadí el set a empresa porque no sabia esta empresa dentro de la variable si era de solo lectura

                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void lvEmpresas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvEmpresas.SelectedItems.Count > 0)
            {
                empresa = Herramientas.ObtenerEmpresa(int.Parse(lvEmpresas.SelectedItems[0].Tag.ToString()));
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void actualizarLista()
        {
            lvEmpresas.Items.Clear();
            foreach (Empresa e in Herramientas.ObtenerEmpresas(txtFiltro.Text))
            {
                string lvItem = e.Nombre;

                ListViewItem lviEmpresa = new ListViewItem(lvItem);
                lviEmpresa.Tag = e.EmpresaId;
                lvEmpresas.Items.Add(lviEmpresa);
            }
        }


    }
}

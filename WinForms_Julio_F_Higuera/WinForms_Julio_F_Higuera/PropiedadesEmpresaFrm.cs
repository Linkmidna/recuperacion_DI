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
    public partial class PropiedadesEmpresaFrm : Form
    {
        Empresa empresa;
        public PropiedadesEmpresaFrm(Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
            if (empresa.EmpresaId != 0)
            {
                cargarDatos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                guardarDatos();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void cargarDatos()
        {
            txtNombre.Text = empresa.Nombre;
            txtNIF.Text = empresa.NIF;
            txtTelefono.Text = empresa.Telefono;
            txtContacto.Text = empresa.PersonaContacto;
            dtpConvenio.Value = empresa.Convenio;
            txtDireccion.Text = empresa.Direccion;
        }

        private bool validarDatos()
        {
            if (txtNombre.Text.Equals(string.Empty))
            {
                return false;
            }
            if (txtNIF.Text.Equals(string.Empty))
            {
                return false;
            }
            if (txtTelefono.Text.Equals(string.Empty))
            {
                return false;
            }
            return true;
        }

        private void guardarDatos()
        {
            empresa.Nombre = txtNombre.Text;
            empresa.NIF = txtNIF.Text;
            empresa.Telefono = txtTelefono.Text;
            empresa.PersonaContacto = txtContacto.Text;
            empresa.Convenio = dtpConvenio.Value;
            empresa.Direccion = txtDireccion.Text;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!int.TryParse(e.KeyChar.ToString(), out int result))
            {
                e.Handled = true;
            }
        }

        private void txtNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (txtNIF.Text.Length > 8)
            {
                e.Handled = true;
            }
            if (txtNIF.Text.Length == 0 && int.TryParse(e.KeyChar.ToString(), out int result1))
            {
                e.Handled = true;
            }
            if (txtNIF.Text.Length > 0 && !int.TryParse(e.KeyChar.ToString(), out int result2))
            {
                e.Handled = true;
            }
            */
            //Si utilizo este codigo no deja borrar porque no se como hacer que el tabulador y retroceso se salten el filtro
        }
    }
}

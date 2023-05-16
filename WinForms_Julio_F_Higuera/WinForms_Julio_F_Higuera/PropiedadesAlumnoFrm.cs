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
    public partial class PropiedadesAlumnoFrm : Form
    {
        Alumno alumno;
        public PropiedadesAlumnoFrm(Alumno alumno)
        {
            InitializeComponent();
            this.alumno = alumno;
            cbEstudios.SelectedIndex = 0;
            if (alumno.AlumnoId != 0)
            {
                cargarDatos();
            }
        }

        private void btnBuscarEmpresa_Click(object sender, EventArgs e)
        {
            BuscarEmpresaFrm buscarEmpresa = new BuscarEmpresaFrm();

            if (buscarEmpresa.ShowDialog() == DialogResult.OK)
            {
                alumno.EmpresaId = buscarEmpresa.empresa.EmpresaId;
                txtNIF.Text = buscarEmpresa.empresa.NIF;
                txtEmpresa.Text = buscarEmpresa.empresa.Nombre;
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
            txtNombre.Text = alumno.Nombre;
            txtDNI.Text = alumno.DNI;
            txtTelefono.Text = alumno.Telefono;
            cbEstudios.Text = alumno.Estudios;
            if (alumno.EmpresaId != null)
            {
                txtNIF.Text = Herramientas.ObtenerEmpresa(alumno.EmpresaId).NIF;
                txtEmpresa.Text = Herramientas.ObtenerNombreEmpresa(alumno.EmpresaId);
                dtpComienzo.Value = alumno.ComienzoPracticas.Value;
                chbSuperadas.Checked = alumno.SuperaPracticas;
            }
        }

        private bool validarDatos()
        {
            if (txtNombre.Text.Equals(string.Empty))
            {
                return false;
            }
            if (txtDNI.Text.Equals(string.Empty))
            {
                return false;
            }
            if (txtTelefono.Text.Equals(string.Empty))
            {
                return false;
            }
            if (!txtNIF.Text.Equals(string.Empty) && txtEmpresa.Text.Equals(string.Empty)) //Si hay algo en nif pero no en empresa el nif no es valido
            {
                return false;
            }
            return true;
        }

        private void guardarDatos()
        {
            alumno.Nombre = txtNombre.Text;
            alumno.DNI = txtDNI.Text;
            alumno.Telefono = txtTelefono.Text;
            alumno.Estudios = cbEstudios.Text;
            if (!txtEmpresa.Text.Equals(string.Empty))
            {
                dtpComienzo.Value = alumno.ComienzoPracticas.Value;
                chbSuperadas.Checked = alumno.SuperaPracticas;
            }
        }

        private void txtNIF_TextChanged(object sender, EventArgs e)
        {
            if (Herramientas.ObtenerEmpresa(txtNIF.Text).Nombre != null) // casca igual al ser nulo y no se por que si debería estar controlado
            {
                txtEmpresa.Text = Herramientas.ObtenerEmpresa(txtNIF.Text).Nombre;
            }
            
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!int.TryParse(e.KeyChar.ToString(), out int result))
            {
                e.Handled = true;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (txtDNI.Text.Length > 8)
            {
                e.Handled = true;
            }
            if (txtDNI.Text.Length > 7 && int.TryParse(e.KeyChar.ToString(), out int result1))
            {
                e.Handled = true;
            }
            if (txtDNI.Text.Length <= 7 && !int.TryParse(e.KeyChar.ToString(), out int result2))
            {
                e.Handled = true;
            }
            */
            //lo mismo, no se como hacer que el tabulador y retroceso se salten el filtro
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT2_E3
{
    public partial class FormCalculadora : Form
    {
        private Calculadora cal;
        public FormCalculadora()
        {
            InitializeComponent();
            cal = new Calculadora();
            tbVisor.Text = "0";
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            string num = ((Button)sender).Tag.ToString();

            if (tbVisor.Text.Equals("0"))
            {
                tbVisor.Text = num;
                return;
            }

            tbVisor.Text += num;
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {

        }
    }
}

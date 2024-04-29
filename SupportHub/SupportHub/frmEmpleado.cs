using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            frmAgregarEmpleado formEmpleado = new frmAgregarEmpleado();

            // Mostrar el formulario OtroFormulario
            formEmpleado.Show();
        }
    }
}

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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

<<<<<<< Updated upstream
        private void frmUsuario_Load(object sender, EventArgs e)
        {

        }
    }
=======
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnagregarusuario_Click(object sender, EventArgs e)
        {
            frmAgregarusuario agrusuario = new frmAgregarusuario();
            agrusuario.Show();
        }

        private void btnmodificarusuario_Click(object sender, EventArgs e)
        {
            frmModificarusuario mdfusuario = new frmModificarusuario();
            mdfusuario.Show();
        }

        private void btnEliminarusuario_Click(object sender, EventArgs e)
        {
            frmEliminarusuario elmusuario = new frmEliminarusuario();
            elmusuario.Show();
        }
}
>>>>>>> Stashed changes
}

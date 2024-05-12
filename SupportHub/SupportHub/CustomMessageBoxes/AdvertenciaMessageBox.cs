using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.CustomMessageBoxes
{
    public partial class AdvertenciaMessageBox : Form
    {
        bool confirmacion = false;
        public AdvertenciaMessageBox(string encabezadoAdvertencia, string descripcionAdvertencia)
        {
            InitializeComponent();
            this.lblTextoTab.Text = encabezadoAdvertencia;
            this.tboxDescripcionError.Text = descripcionAdvertencia;
        }

        public DialogResult obtenerConfirmacion()
        {
            ShowDialog();
            if (confirmacion)
            {
                return DialogResult.Yes;
            }
            else
            {
                return DialogResult.No;
            }
        }

        private void iconButtonX_Click(object sender, EventArgs e)
        {
            confirmacion = false;
            this.Close();
        }

        private void ibtnSi_Click(object sender, EventArgs e)
        {
            confirmacion = true;
            this.Close();
        }

        private void ibtnNo_Click(object sender, EventArgs e)
        {
            confirmacion = false;
            this.Close();
        }
    }
}

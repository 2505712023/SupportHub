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
    public partial class ExitoMessageBox : Form
    {
        public ExitoMessageBox(string encabezadoError, string descripcionError)
        {
            InitializeComponent();
            this.lblTextoTab.Text = encabezadoError;
            this.tboxDescripcionExito.Text = descripcionError;
            this.ShowDialog();
        }

        private void ibtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButtonX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

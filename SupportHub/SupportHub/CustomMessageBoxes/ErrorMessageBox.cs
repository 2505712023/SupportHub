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
    public partial class ErrorMessageBox : Form
    {
        public ErrorMessageBox(string encabezadoError, string descripcionError)
        {
            InitializeComponent();
            this.lblTextoTab.Text = encabezadoError;
            this.tboxDescripcionError.Text = descripcionError;
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

        private void ErrorMessageBox_Load(object sender, EventArgs e)
        {
            iconButtonX.Focus();
        }
    }
}

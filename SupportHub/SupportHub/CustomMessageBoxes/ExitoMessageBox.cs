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
        public ExitoMessageBox(string encabezadoExito, string descripcionExito)
        {
            InitializeComponent();
            this.lblTextoTab.Text = encabezadoExito;
            this.tboxDescripcionExito.Text = descripcionExito;
            
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

        private void ExitoMessageBox_Load(object sender, EventArgs e)
        {
            iconButtonX.Focus();
        }
    }
}

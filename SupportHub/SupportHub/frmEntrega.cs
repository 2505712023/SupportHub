using Dominio;
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
    public partial class frmEntrega : Form
    {
        public frmEntrega()
        {
            InitializeComponent();
        }

        private void frmEntrega_Load(object sender, EventArgs e)
        {
            dgvEntregas.DataSource = ModeloEntrega.mostrarEntregas();
            dgvEntregas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtBuscarEntrega_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarEntrega.Text))
            {
                dgvEntregas.DataSource = ModeloEntrega.mostrarEntregas();
            }
            else
            { 
                dgvEntregas.DataSource = ModeloEntrega.filtrarTablaEntregasPorCodigo(txtBuscarEntrega.Text);
            }
        }
    }
}

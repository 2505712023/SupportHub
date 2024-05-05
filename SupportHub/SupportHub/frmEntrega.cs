using Dominio;
using System;
using System.Collections;
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
        private List<string> tiposDeBusqueda;
        public frmEntrega()
        {
            InitializeComponent();
            tiposDeBusqueda = new List<string>()
            {
                "Código de Entrega",
                "Tipo de Entrega",
                "Tipo de Equipo",
                "Modelo",
                "Marca",
                "Empleado",
                "Observación"
            };
            cBoxTipoBusqueda.DataSource = tiposDeBusqueda;
        }

        private void frmEntrega_Load(object sender, EventArgs e)
        {
            dgvEntregas.DataSource = ModeloEntrega.mostrarEntregas();
            dgvEntregas.Columns["idTipoEntrega"].Visible = false;
            dgvEntregas.Columns["idEquipo"].Visible = false;
            dgvEntregas.Columns["idEmpleado"].Visible = false;
            dgvEntregas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEntregas.ClearSelection();
        }

        private void txtBuscarEntrega_TextChanged(object sender, EventArgs e)
        {
            actualizarTablaEntregas();
        }

        private void cBoxTipoBusqueda_TextChanged(object sender, EventArgs e)
        {
            actualizarTablaEntregas();
        }

        private void actualizarTablaEntregas()
        {
            if (string.IsNullOrEmpty(txtBuscarEntrega.Text))
            {
                dgvEntregas.DataSource = ModeloEntrega.mostrarEntregas();
                dgvEntregas.ClearSelection();
            }
            else
            {
                switch (cBoxTipoBusqueda.Text)
                {
                    case "Código de Entrega":
                        dgvEntregas.DataSource = ModeloEntrega.filtrarTablaEntregas(codEntrega: txtBuscarEntrega.Text);
                        break;
                    case "Tipo de Entrega":
                        dgvEntregas.DataSource = ModeloEntrega.filtrarTablaEntregas(nombreTipoEntrega: txtBuscarEntrega.Text);
                        break;
                    case "Tipo de Equipo":
                        dgvEntregas.DataSource = ModeloEntrega.filtrarTablaEntregas(nombreTipoEquipo: txtBuscarEntrega.Text);
                        break;
                    case "Modelo":
                        dgvEntregas.DataSource = ModeloEntrega.filtrarTablaEntregas(modeloEquipo: txtBuscarEntrega.Text);
                        break;
                    case "Marca":
                        dgvEntregas.DataSource = ModeloEntrega.filtrarTablaEntregas(marcaEquipo: txtBuscarEntrega.Text);
                        break;
                    case "Empleado":
                        dgvEntregas.DataSource = ModeloEntrega.filtrarTablaEntregas(empleadoEntrega: txtBuscarEntrega.Text);
                        break;
                    case "Observación":
                        dgvEntregas.DataSource = ModeloEntrega.filtrarTablaEntregas(observacionEntrega: txtBuscarEntrega.Text);
                        break;
                    default:
                        break;
                }
            }
            dgvEntregas.Columns["idTipoEntrega"].Visible = false;
            dgvEntregas.Columns["idEquipo"].Visible = false;
            dgvEntregas.Columns["idEmpleado"].Visible = false;
            dgvEntregas.ClearSelection();
        }

        private void btnEliminarEntrega_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar entregas?", "Eliminar entregas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                if (dgvEntregas.SelectedRows.Count > 0)
                {
                    int totalRegistrosEliminados = 0;

                    foreach (DataGridViewRow row in dgvEntregas.SelectedRows)
                    {
                        ModeloEntrega.eliminarEntrega(row.Cells["Código de Entrega"].Value.ToString());
                        totalRegistrosEliminados++;
                    }

                    if (totalRegistrosEliminados > 1)
                    {
                        MessageBox.Show("Se eliminaron " + totalRegistrosEliminados.ToString() + " registros.");
                    }
                    else
                    {
                        MessageBox.Show("Se eliminó " + totalRegistrosEliminados.ToString() + " registro.");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una o varias entregas para eliminarlas.");
                }
                actualizarTablaEntregas();
            }
        }

        private void btnAgregarEntrega_Click(object sender, EventArgs e)
        {
            frmAgregarEntrega formEntrega = new frmAgregarEntrega();
            formEntrega.Show();
        }
    }
}

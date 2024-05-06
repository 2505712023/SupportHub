using Comun.Cache;
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
                "Empleado Entregó",
                "Empleado Recibió",
                "Observación"
            };
            cBoxTipoBusqueda.DataSource = tiposDeBusqueda;
        }

        private void frmEntrega_Load(object sender, EventArgs e)
        {
            dgvEntregas.DataSource = ModeloEntrega.mostrarEntregas();
            dgvEntregas.Columns["idTipoEntrega"].Visible = false;
            dgvEntregas.Columns["idEquipo"].Visible = false;
            dgvEntregas.Columns["idEmpleadoEntrega"].Visible = false;
            dgvEntregas.Columns["idEmpleadoRecibe"].Visible = false;
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

        public void actualizarTablaEntregas()
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
                    case "Empleado Entregó":
                        dgvEntregas.DataSource = ModeloEntrega.filtrarTablaEntregas(empleadoEntrega: txtBuscarEntrega.Text);
                        break;
                    case "Empleado Recibió":
                        dgvEntregas.DataSource = ModeloEntrega.filtrarTablaEntregas(empleadoRecibe: txtBuscarEntrega.Text);
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
            dgvEntregas.Columns["idEmpleadoEntrega"].Visible = false;
            dgvEntregas.Columns["idEmpleadoRecibe"].Visible = false;
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
                        MessageBox.Show("Se eliminaron " + totalRegistrosEliminados.ToString() + " entregas.");
                    }
                    else
                    {
                        MessageBox.Show("Se eliminó " + totalRegistrosEliminados.ToString() + " entrega.");
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
            if (CacheInicioUsuario.idEmpleado == 0)
            {
                MessageBox.Show("Su usuario debe tener un empleado asociado para poder agregar una entrega.", "Usuario Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvEntregas.Enabled = false;
                frmAgregarEntrega formEntrega = new frmAgregarEntrega();
                SuscribirEventosAgregarEntrega(formEntrega);
                formEntrega.Show();
            }
        }

        private void AgregarActualizarEventHandler(object sender, frmAgregarEntrega.UpdateEventArgs args)
        {
            actualizarTablaEntregas();
        }

        private void AgregarHabilitarEventHandler(object sender, frmAgregarEntrega.UpdateEventArgs args)
        {
            dgvEntregas.Enabled = true;
        }

        private void SuscribirEventosAgregarEntrega(frmAgregarEntrega form)
        {
            if (form != null)
            {
                form.UpdateEventHandler += AgregarActualizarEventHandler;
                form.CloseEventHandler += AgregarHabilitarEventHandler;
            }
        }

        private void btnGenerarDevolucion_Click(object sender, EventArgs e)
        {
            if (dgvEntregas.SelectedRows.Count == 1)
            {
                string? codEntrega = string.Empty;

                DataGridViewSelectedRowCollection selectedRow = dgvEntregas.SelectedRows;

                foreach (DataGridViewRow row in selectedRow)
                {
                    if (string.IsNullOrEmpty(row.Cells["Fecha de Devolución"].Value.ToString()))
                    {
                        codEntrega = row.Cells["Código de Entrega"].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("La entrega seleccionada ya tiene fecha de devolución.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                frmDevolucionEntrega devolucionEntrega = new frmDevolucionEntrega(codEntrega);
                SuscribirEventosDevolucionEntrega(devolucionEntrega);
                dgvEntregas.Enabled = false;
                devolucionEntrega.Show();
            }
            else if (dgvEntregas.SelectedRows.Count > 1)
            {
                MessageBox.Show("Solo debe seleccionar una entrega para asignar fecha de devolución.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una entrega para asignar fecha de devolución.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DevolucionActualizarEventHandler(object sender, frmDevolucionEntrega.UpdateEventArgs args)
        {
            actualizarTablaEntregas();
        }

        private void DevolucionHabilitarEventHandler(object sender, frmDevolucionEntrega.UpdateEventArgs args)
        {
            dgvEntregas.Enabled = true;
        }

        private void SuscribirEventosDevolucionEntrega(frmDevolucionEntrega form)
        {
            if (form != null)
            {
                form.UpdateEventHandler += DevolucionActualizarEventHandler;
                form.CloseEventHandler += DevolucionHabilitarEventHandler;
            }
        }
    }
}

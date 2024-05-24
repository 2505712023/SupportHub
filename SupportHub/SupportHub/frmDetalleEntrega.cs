using Comun.Cache;
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
    public partial class frmDetalleEntrega : Form
    {
        private List<string> tiposDeBusqueda;
        private bool formCargado = false;
        private string? codEntrega = string.Empty;

        public frmDetalleEntrega()
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

        private void frmDetalleEntrega_Load(object sender, EventArgs e)
        {
            prepararDgvEntregas();

            formCargado = true;

            if (!CacheInicioUsuario.permisosUser.Contains("Agregar"))
            {
                //btnAgregarEntrega.Visible = false;
            }
            if (!CacheInicioUsuario.permisosUser.Contains("Modificar"))
            {
                //btnModificarEntrega.Visible = false;
                //btnGenerarDevolucion.Visible = false;
            }
            if (!CacheInicioUsuario.permisosUser.Contains("Eliminar"))
            {
                //btnEliminarEntrega.Visible = false;
            }
        }

        private void prepararDgvEntregas()
        {
            cBoxTipoBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            dgvEntregas.DataSource = ModeloEntrega.mostrarEntregas();
            dgvEntregas.Columns["idTipoEntrega"].Visible = false;
            dgvEntregas.Columns["idEquipo"].Visible = false;
            dgvEntregas.Columns["idEmpleadoEntrega"].Visible = false;
            dgvEntregas.Columns["idEmpleadoRecibe"].Visible = false;
            dgvEntregas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn col in dgvEntregas.Columns)
            {
                if (col.Name == "Cantidad Entregada")
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                else
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            }
            dgvEntregas.ClearSelection();
        }

        private void SuscribirEventosAgregarEntrega(frmMostrarEntregaDetalle form)
        {
            if (form != null)
            {
                form.CloseEventHandler += AgregarHabilitarEventHandler;
            }
        }
        private void txtBuscarEntrega_TextChanged(object sender, EventArgs e)
        {
            actualizarTablaEntregas();
        }

        private void cBoxTipoBusqueda_TextChanged(object sender, EventArgs e)
        {
            txtBuscarEntrega.Focus();
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
            prepararDgvEntregas();
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
                        MessageBox.Show("Se eliminaron " + totalRegistrosEliminados.ToString() + " entregas.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se eliminó " + totalRegistrosEliminados.ToString() + " entrega.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una o varias entregas para eliminarlas.", "Error en selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                actualizarTablaEntregas();
            }
        }

        private void AgregarHabilitarEventHandler(object sender, frmMostrarEntregaDetalle.UpdateEventArgs args)
        {
            dgvEntregas.Enabled = true;
        }

        private void dgvEntregas_SelectionChanged(object sender, EventArgs e)
        {
            if (formCargado && dgvEntregas.SelectedRows.Count == 1)
            {
                DataGridViewSelectedRowCollection selectedRow = dgvEntregas.SelectedRows;
                //btnModificarEntrega.Enabled = true;

                foreach (DataGridViewRow row in selectedRow)
                {
                    if (string.IsNullOrEmpty(row.Cells["Fecha de Devolución"].Value.ToString()))
                    {

                        codEntrega = row.Cells["Código de Entrega"].Value.ToString();
                    }
                    else
                    {

                        codEntrega = row.Cells["Código de Entrega"].Value.ToString();
                    }
                }
            }
            else if (formCargado && dgvEntregas.SelectedRows.Count > 1)
            {

            }
        }


        private void dgvEntregas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;

            DataGridViewRow selectedRow = dgvEntregas.SelectedRows[0];

            frmMostrarEntregaDetalle MostrarEntrega = new frmMostrarEntregaDetalle(
                    codEntrega: selectedRow.Cells["Código de Entrega"].Value.ToString(),
                    esModificacion: true,
                    cantidadEntregaAnterior: Convert.ToInt32(selectedRow.Cells["Cantidad Entregada"].Value.ToString()),
                    idTipoEntrega: Convert.ToInt32(selectedRow.Cells["idTipoEntrega"].Value.ToString()),
                    marca: selectedRow.Cells["Marca"].Value.ToString(),
                    modelo: selectedRow.Cells["Modelo"].Value.ToString(),
                    fechaEntrega: selectedRow.Cells["Fecha de Entrega"].Value.ToString(),
                    empleadoEntrega: selectedRow.Cells["Empleado Entregó"].Value.ToString(),
                    idEmpleadoRecibe: Convert.ToInt32(selectedRow.Cells["idEmpleadoRecibe"].Value.ToString()),
                    idEquipo: Convert.ToInt32(selectedRow.Cells["idEquipo"].Value.ToString()),
                    cantidadEntrega: Convert.ToInt32(selectedRow.Cells["Cantidad Entregada"].Value.ToString()),
                    observacion: selectedRow.Cells["Observación"].Value.ToString());
            dgvEntregas.Enabled = false;
            MostrarEntrega.ShowDialog();
            dgvEntregas.Enabled = true;
        }

        private void cBoxTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

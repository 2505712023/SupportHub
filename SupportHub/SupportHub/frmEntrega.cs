using Comun.Cache;
using Dominio;
using Presentacion.CustomMessageBoxes;
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
        private bool formCargado = false;
        private string? codEntrega = string.Empty;

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
            formCargado = true;
            prepararDgvEntregas();

            if (!CacheInicioUsuario.permisosUser.Contains("Agregar"))
            {
                btnAgregarEntrega.Visible = false;
            }
            if (!CacheInicioUsuario.permisosUser.Contains("Modificar"))
            {
                btnModificarEntrega.Visible = false;
                btnGenerarDevolucion.Visible = false;
            }
            if (!CacheInicioUsuario.permisosUser.Contains("Eliminar"))
            {
                btnEliminarEntrega.Visible = false;
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
            if (CustomMessageBox.Advertencia("Confirmar eliminación", "¿Seguro que desea eliminar entregas?") == DialogResult.Yes)
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
                        CustomMessageBox.Exito("Eliminación exitosa", "Se eliminaron " + totalRegistrosEliminados.ToString() + " entregas.");
                    }
                    else
                    {
                        CustomMessageBox.Exito("Eliminación exitosa", "Se eliminó " + totalRegistrosEliminados.ToString() + " entrega.");
                    }
                }
                else
                {
                    CustomMessageBox.Error("Error en selección", "Debe seleccionar una o varias entregas para eliminarlas.");
                }
                actualizarTablaEntregas();
            }
        }

        private void btnAgregarEntrega_Click(object sender, EventArgs e)
        {
            if (CacheInicioUsuario.idEmpleado == 0)
            {
                CustomMessageBox.Error("Usuario Inválido", "Su usuario debe tener un empleado asociado para poder agregar una entrega.");
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
            frmDevolucionEntrega devolucionEntrega = new frmDevolucionEntrega(codEntrega);
            SuscribirEventosDevolucionEntrega(devolucionEntrega);

            if (btnGenerarDevolucion.Text == "DEVOLUCIÓN")
            {
                dgvEntregas.Enabled = false;
                devolucionEntrega.Show();
            }
            else if (btnGenerarDevolucion.Text == "ELIMINAR DEVOLUCIÓN")
            {
                if (CustomMessageBox.Advertencia("Eliminar devolución", $"¿Está seguro que desea eliminar la fecha de devolución de la entrega {codEntrega}?") == DialogResult.Yes)
                {
                    devolucionEntrega.eliminarFechaDevolucion();
                }
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

        private void dgvEntregas_SelectionChanged(object sender, EventArgs e)
        {
            if (formCargado && dgvEntregas.SelectedRows.Count == 1)
            {
                DataGridViewSelectedRowCollection selectedRow = dgvEntregas.SelectedRows;
                btnModificarEntrega.Enabled = true;

                foreach (DataGridViewRow row in selectedRow)
                {
                    if (string.IsNullOrEmpty(row.Cells["Fecha de Devolución"].Value.ToString()))
                    {
                        btnGenerarDevolucion.Enabled = true;
                        btnGenerarDevolucion.Text = "DEVOLUCIÓN";
                        btnGenerarDevolucion.IconChar = FontAwesome.Sharp.IconChar.RotateBack;
                        codEntrega = row.Cells["Código de Entrega"].Value.ToString();
                    }
                    else
                    {
                        btnGenerarDevolucion.Enabled = true;
                        btnGenerarDevolucion.Text = "ELIMINAR DEVOLUCIÓN";
                        btnGenerarDevolucion.IconChar = FontAwesome.Sharp.IconChar.Xmark;
                        codEntrega = row.Cells["Código de Entrega"].Value.ToString();
                    }
                }
            }
            else if (formCargado && dgvEntregas.SelectedRows.Count != 1)
            {
                btnGenerarDevolucion.Text = "DEVOLUCIÓN";
                btnGenerarDevolucion.IconChar = FontAwesome.Sharp.IconChar.RotateBack;
                btnGenerarDevolucion.Enabled = false;

                btnModificarEntrega.Enabled = false;
            }
        }

        private void btnModificarEntrega_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvEntregas.SelectedRows[0];

            frmAgregarEntrega modificarEntrega = new frmAgregarEntrega(
                    codEntrega: codEntrega,
                    esModificacion: true,
                    cantidadEntregaAnterior: Convert.ToInt32(selectedRow.Cells["Cantidad Entregada"].Value.ToString()),
                    idTipoEntrega: Convert.ToInt32(selectedRow.Cells["idTipoEntrega"].Value.ToString()),
                    fechaEntrega: selectedRow.Cells["Fecha de Entrega"].Value.ToString(),
                    empleadoEntrega: selectedRow.Cells["Empleado Entregó"].Value.ToString(),
                    idEmpleadoRecibe: Convert.ToInt32(selectedRow.Cells["idEmpleadoRecibe"].Value.ToString()),
                    idEquipo: Convert.ToInt32(selectedRow.Cells["idEquipo"].Value.ToString()),
                    cantidadEntrega: Convert.ToInt32(selectedRow.Cells["Cantidad Entregada"].Value.ToString()),
                    observacion: selectedRow.Cells["Observación"].Value.ToString()
                );
            dgvEntregas.Enabled = false;
            SuscribirEventosAgregarEntrega(modificarEntrega);
            modificarEntrega.Show();
        }
    }
}

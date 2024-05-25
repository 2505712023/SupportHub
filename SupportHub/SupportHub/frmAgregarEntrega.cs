using Comun.Cache;
using Dominio;
using Presentacion.CustomMessageBoxes;
using Presentacion.ReportesPDF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Annotations;
using System.Windows.Forms;
using System.Xaml;

namespace Presentacion
{
    public partial class frmAgregarEntrega : Form
    {
        private bool esModificacion = false, esImpresion = false;
        private int cantidadEntregaAnterior = 0, idEquipoAnterior = 0;
        private string codEntrega = string.Empty;
        private string tipoEquipo = string.Empty, modeloEquipo = string.Empty, marcaEquipo = string.Empty;

        public frmAgregarEntrega()
        {
            InitializeComponent();
            dtpickerFechaEntrega.Format = DateTimePickerFormat.Custom;
            dtpickerFechaEntrega.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtpickerFechaEntrega.ShowUpDown = false;
            llenarTiposEntrega();
            llenarEmpleados();
            llenarEquipos();
        }

        public frmAgregarEntrega(
                bool esModificacion,
                string codEntrega,
                int cantidadEntregaAnterior,
                int idEquipoAnterior,
                int idTipoEntrega,
                string fechaEntrega,
                string empleadoEntrega,
                int idEmpleadoRecibe,
                int idEquipo,
                int cantidadEntrega,
                string observacion = ""
                )
        {
            InitializeComponent();
            dtpickerFechaEntrega.Format = DateTimePickerFormat.Custom;
            dtpickerFechaEntrega.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtpickerFechaEntrega.ShowUpDown = false;
            llenarTiposEntrega();
            llenarEmpleados();
            llenarEquipos();

            this.codEntrega = codEntrega;
            this.esModificacion = esModificacion;
            this.cantidadEntregaAnterior = cantidadEntregaAnterior;
            this.idEquipoAnterior = idEquipoAnterior;
            this.cboxTipoEntrega.SelectedValue = idTipoEntrega;
            this.dtpickerFechaEntrega.Text = fechaEntrega;
            this.tboxEmpleadoEntrega.Text = empleadoEntrega;
            this.cboxEmpleadoRecibe.SelectedValue = idEmpleadoRecibe;
            this.cboxEquipo.SelectedValue = idEquipo;
            this.tboxCantidadEntrega.Text = cantidadEntrega.ToString();
            this.rtxtObservacionEntrega.Text = observacion;
        }

        public frmAgregarEntrega(
                bool esImpresion,
                string codEntrega,
                int idTipoEntrega,
                string empleadoEntrega,
                int idEmpleadoRecibe,
                int cantidadEntrega,
                int idEquipo,
                string tipoEquipo,
                string marcaEquipo,
                string modeloEquipo,
                string observacionEntrega,
                string fechaEntrega
                )
        {
            InitializeComponent();
            dtpickerFechaEntrega.Format = DateTimePickerFormat.Custom;
            dtpickerFechaEntrega.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtpickerFechaEntrega.ShowUpDown = false;
            llenarTiposEntrega();
            llenarEmpleados();
            llenarEquipos();

            this.codEntrega = codEntrega;
            this.esImpresion = esImpresion;
            this.cboxTipoEntrega.SelectedValue = idTipoEntrega;
            this.dtpickerFechaEntrega.Text = fechaEntrega;
            this.tboxEmpleadoEntrega.Text = empleadoEntrega;
            this.cboxEmpleadoRecibe.SelectedValue = idEmpleadoRecibe;
            this.cboxEquipo.SelectedValue = idEquipo;
            this.tboxCantidadEntrega.Text = cantidadEntrega.ToString();
            this.rtxtObservacionEntrega.Text = observacionEntrega;
            this.tipoEquipo = tipoEquipo;
            this.marcaEquipo = marcaEquipo;
            this.modeloEquipo = modeloEquipo;
        }

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        public delegate void UpdateDelagate(object sender, UpdateEventArgs args);
        public event UpdateDelagate UpdateEventHandler;
        public event UpdateDelagate CloseEventHandler;

        protected void actualizardgvEntregas()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        protected void habilitardgvEntregas()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            CloseEventHandler.Invoke(this, args);
        }

        private void frmAgregarEntrega_Load(object sender, EventArgs e)
        {
            if (!esModificacion && !esImpresion)
            {
                dtpickerFechaEntrega.Value = DateTime.Now;
                cboxTipoEntrega.SelectedItem = 0;
                cboxEmpleadoRecibe.SelectedItem = null;
                cboxEquipo.SelectedItem = null;
                tboxCantidadDisponible.Text = "0";
                tboxEmpleadoEntrega.Text = CacheInicioUsuario.empleado;
                ibtnImprimir.Visible = false;
            }
            else if (esModificacion && !esImpresion)
            {
                gbAddEntrega.Text = "MODIFICAR ENTREGA: " + codEntrega;
                ibtnImprimir.Visible = false;
                obtenerCantidadDisponible();
            }
            else if (esImpresion && !esModificacion)
            {
                gbAddEntrega.Text = "IMPRIMIR ENTREGA: " + codEntrega;
                tboxCantidadDisponible.Text = string.Empty;
                cboxTipoEntrega.Enabled = false;
                dtpickerFechaEntrega.Enabled = false;
                tboxEmpleadoEntrega.Enabled = false;
                cboxEmpleadoRecibe.Enabled = false;
                cboxEquipo.Enabled = false;
                tboxCantidadEntrega.Enabled = false;
                rtxtObservacionEntrega.Enabled = false;
                ibtnGuardarEntrega.Visible = false;
                ibtnImprimir.Focus();
            }
        }

        private void ibtnCancelarEntrega_Click(object sender, EventArgs e)
        {
            habilitardgvEntregas();
            this.Close();
        }

        private void llenarEmpleados()
        {
            cboxEmpleadoRecibe.DataSource = ModeloEntrega.obtenerEmpleados();
            cboxEmpleadoRecibe.ValueMember = "idEmpleado";
            cboxEmpleadoRecibe.DisplayMember = "Empleado";
        }

        private void llenarEquipos()
        {
            cboxEquipo.DataSource = ModeloEntrega.obtenerEquipos();
            cboxEquipo.ValueMember = "idEquipo";
            cboxEquipo.DisplayMember = "Equipo";
        }

        private void llenarTiposEntrega()
        {
            cboxTipoEntrega.DataSource = ModeloEntrega.obtenerTiposEntrega();
            cboxTipoEntrega.ValueMember = "idTipoEntrega";
            cboxTipoEntrega.DisplayMember = "nombreTipoEntrega";
        }

        private void obtenerCantidadDisponible()
        {
            if (Convert.ToInt32(cboxEquipo.SelectedValue) == idEquipoAnterior)
            {
                int cantidadDisponible = ModeloEntrega.cantidadDisponibleEquipo(Convert.ToInt32(cboxEquipo.SelectedValue));
                tboxCantidadDisponible.Text = (cantidadDisponible + cantidadEntregaAnterior).ToString();
            }
            else if(cboxEquipo.SelectedValue != null)
            {
                int cantidadDisponible = ModeloEntrega.cantidadDisponibleEquipo(Convert.ToInt32(cboxEquipo.SelectedValue));
                tboxCantidadDisponible.Text = (cantidadDisponible).ToString();
            }
            else
            {
                tboxCantidadDisponible.Text = "0";
            }
        }

        private void cboxEquipo_Leave(object sender, EventArgs e)
        {
            obtenerCantidadDisponible();
            validarCantidades();
        }

        private void tboxCantidadEntrega_Leave(object sender, EventArgs e)
        {
            validarCantidades();
        }

        private void validarCantidades()
        {
            if (!string.IsNullOrEmpty(tboxCantidadEntrega.Text))
            {
                if (int.Parse(tboxCantidadEntrega.Text) > int.Parse(tboxCantidadDisponible.Text))
                {
                    tboxCantidadEntrega.ForeColor = Color.Red;
                    lblErrorCantidad.Text = "No hay saldo suficiente.";
                }
                else
                {
                    tboxCantidadEntrega.ForeColor = Color.Black;
                    lblErrorCantidad.Text = string.Empty;
                }
            }
        }

        private void ibtnGuardarEntrega_Click(object sender, EventArgs e)
        {
            if (cboxTipoEntrega.SelectedIndex == -1)
            {
                CustomMessageBox.Error("Error", "Debe seleccionar un tipo de entrega.");
            }
            else if (cboxEmpleadoRecibe.SelectedIndex == -1)
            {
                CustomMessageBox.Error("Error", "Debe seleccionar un empleado.");
            }
            else if (cboxEquipo.SelectedIndex == -1)
            {
                CustomMessageBox.Error("Error", "Debe seleccionar un equipo.");
            }
            else if (tboxCantidadEntrega.ForeColor == Color.Red)
            {
                CustomMessageBox.Error("Error", "La cantidad a entregar no puede ser mayor a la cantidad disponible.");
            }
            else if (Convert.ToInt32(tboxCantidadEntrega.Text) <= 0 || string.IsNullOrEmpty(tboxCantidadEntrega.Text))
            {
                CustomMessageBox.Error("Error", "La cantidad a entregar debe ser mayor a cero.");
            }
            else
            {
                if (!esModificacion)
                {
                    int registrosAgregados = ModeloEntrega.crearEntrega(
                    Convert.ToInt32(cboxTipoEntrega.SelectedValue),
                    dtpickerFechaEntrega.Text,
                    CacheInicioUsuario.idEmpleado,
                    Convert.ToInt32(cboxEmpleadoRecibe.SelectedValue),
                    Convert.ToInt32(cboxEquipo.SelectedValue),
                    Convert.ToInt32(tboxCantidadEntrega.Text),
                    rtxtObservacionEntrega.Text
                    );

                    CustomMessageBox.Exito("Registro exitoso", "Se agregó " + registrosAgregados.ToString() + " entrega correctamente.");

                    actualizardgvEntregas();
                    cboxTipoEntrega.SelectedItem = 1;
                    dtpickerFechaEntrega.Value = DateTime.Now;
                    cboxEmpleadoRecibe.SelectedItem = null;
                    cboxEquipo.SelectedItem = null;
                    tboxCantidadDisponible.Text = "0";
                    tboxCantidadEntrega.Text = "0";
                    rtxtObservacionEntrega.Text = string.Empty;
                }
                else
                {
                    int registrosModificados = ModeloEntrega.modificarEntrega(
                        codEntrega,
                        Convert.ToInt32(cboxTipoEntrega.SelectedValue.ToString()),
                        dtpickerFechaEntrega.Text,
                        Convert.ToInt32(cboxEmpleadoRecibe.SelectedValue.ToString()),
                        Convert.ToInt32(cboxEquipo.SelectedValue.ToString()),
                        Convert.ToInt32(tboxCantidadEntrega.Text),
                        rtxtObservacionEntrega.Text
                    );

                    CustomMessageBox.Exito("Modificación exitosa", "Se modificó " + registrosModificados.ToString() + " entrega correctamente.");

                    actualizardgvEntregas();
                    habilitardgvEntregas();
                    this.Close();
                }
            }
        }

        private void frmAgregarEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ibtnGuardarEntrega_Click(sender, e);
            }
        }

        private void ibtnImprimir_Click(object sender, EventArgs e)
        {
            ReporteDetalleEntrega.GenerarReporte
                (
                codEntrega: this.codEntrega,
                empleadoEntrega: this.tboxEmpleadoEntrega.Text,
                empleadoRecibe: this.cboxEmpleadoRecibe.Text,
                cantidadEntrega: this.tboxCantidadEntrega.Text,
                tipoEquipo: this.tipoEquipo,
                marcaEquipo: this.marcaEquipo,
                modeloEquipo: this.modeloEquipo,
                observacionEntrega: this.rtxtObservacionEntrega.Text
                );
            habilitardgvEntregas();
            this.Close();
        }

        private void btnCerrarAgregarEntrega_Click(object sender, EventArgs e)
        {
            habilitardgvEntregas();
            this.Close();
        }
    }
}

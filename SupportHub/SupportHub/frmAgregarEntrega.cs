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
    public partial class frmAgregarEntrega : Form
    {
        public frmAgregarEntrega()
        {
            InitializeComponent();
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
            dtpickerFechaEntrega.Format = DateTimePickerFormat.Custom;
            dtpickerFechaEntrega.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtpickerFechaEntrega.ShowUpDown = false;
            dtpickerFechaEntrega.Value = DateTime.Now;

            llenarTiposEntrega();
            cboxTipoEntrega.SelectedItem = 0;

            llenarEmpleados();
            cboxEmpleadoRecibe.SelectedItem = null;

            llenarEquipos();
            cboxEquipo.SelectedItem = null;
            obtenerCantidadDisponible();

            tboxEmpleadoEntrega.Text = CacheInicioUsuario.empleado;
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
            if (cboxEquipo.SelectedValue != null)
            {
                int cantidadDisponible = ModeloEntrega.cantidadDisponibleEquipo(Convert.ToInt32(cboxEquipo.SelectedValue));
                tboxCantidadDisponible.Text = cantidadDisponible.ToString();
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
            if (cboxTipoEntrega.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de entrega.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cboxEmpleadoRecibe.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cboxEquipo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un equipo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tboxCantidadEntrega.ForeColor == Color.Red)
            {
                MessageBox.Show("La cantidad a entregar no puede ser mayor a la cantidad disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(tboxCantidadEntrega.Text) <= 0)
            {
                MessageBox.Show("La cantidad a entregar debe ser mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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

                MessageBox.Show("Se agregó " + registrosAgregados.ToString() + " entrega correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                actualizardgvEntregas();
                cboxTipoEntrega.SelectedItem = 1;
                dtpickerFechaEntrega.Value = DateTime.Now;
                cboxEmpleadoRecibe.SelectedItem = null;
                cboxEquipo.SelectedItem = null;
                tboxCantidadDisponible.Text = "0";
                tboxCantidadEntrega.Text = "0";
                rtxtObservacionEntrega.Text = string.Empty;
            }
        }
    }
}

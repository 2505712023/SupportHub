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

        private void frmAgregarEntrega_Load(object sender, EventArgs e)
        {
            dtpickerFechaEntrega.Format = DateTimePickerFormat.Custom;
            dtpickerFechaEntrega.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtpickerFechaEntrega.ShowUpDown = false;
            dtpickerFechaEntrega.Value = DateTime.Now;

            llenarTiposEntrega();
            cboxTipoEntrega.SelectedItem = null;

            llenarEmpleados();
            cboxEmpleado.SelectedItem = null;

            llenarEquipos();
            cboxEquipo.SelectedItem = null;
            obtenerCantidadDisponible();
        }

        private void ibtnCancelarEntrega_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenarEmpleados()
        {
            cboxEmpleado.DataSource = ModeloEntrega.obtenerEmpleados();
            cboxEmpleado.ValueMember = "idEmpleado";
            cboxEmpleado.DisplayMember = "Empleado";
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
        }

        private void tboxCantidadEntrega_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tboxCantidadEntrega.Text))
            {
                if (int.Parse(tboxCantidadEntrega.Text) > int.Parse(tboxCantidadDisponible.Text))
                {
                    tboxCantidadEntrega.ForeColor = Color.Red;
                }
            }
        }
    }
}

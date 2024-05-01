using Comun.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
namespace Presentacion
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }
        ModeloEmpleado Empleado = new ModeloEmpleado();
        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            frmAgregarEmpleado formEmpleado = new frmAgregarEmpleado();

            // Mostrar el formulario OtroFormulario
            formEmpleado.Show();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {

            mostrarEmpleado();

            dgvEmpleado.Columns["idEmpleado"].HeaderText = "ID";
            dgvEmpleado.Columns["codEmpleado"].HeaderText = "Código";
            dgvEmpleado.Columns["nombreEmpleado"].HeaderText = "Nombre";
            dgvEmpleado.Columns["apellidoEmpleado"].HeaderText = "Apellido";
            dgvEmpleado.Columns["telefonoEmpleado"].HeaderText = "Telefono";
            dgvEmpleado.Columns["emailEmpleado"].HeaderText = "Correo";
            dgvEmpleado.Columns["codArea"].HeaderText = "Codigo Area";
            dgvEmpleado.Columns["nombreArea"].HeaderText = " Area";
            dgvEmpleado.Columns["codCargo"].HeaderText = "Codigo Cargo";
            dgvEmpleado.Columns["nombreCargo"].HeaderText = "Cargo";
            dgvEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (!CacheInicioUsuario.permisosUser.Contains("Realizar todas las acciones"))
            {

                btnAgregarEmpleado.Visible = false;
                btnEliminarEmpleado.Visible = false;
                btnModificaEmpleado.Visible = false;
            }
        }
        private void mostrarEmpleado()
        {
            dgvEmpleado.DataSource = Empleado.mostrarEmpleado();
        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

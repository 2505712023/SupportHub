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
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Presentacion
{
    public partial class frmEmpleado : Form
    {
        ModeloEmpleado EmpObjeto = new ModeloEmpleado();
        private string codEmpleado = null;
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            frmAgregarEmpleado formEmpleado = new frmAgregarEmpleado();

            // Mostrar el formulario OtroFormulario
            formEmpleado.Show();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {

            mostrarEmpleado();

            ajusteDataGrid();
            if (!CacheInicioUsuario.permisosUser.Contains("Realizar todas las acciones"))
            {

                btnAgregarEmpleado.Visible = false;
                btnEliminarEmpleado.Visible = false;
                btnModificaEmpleado.Visible = false;
            }
            txtBuscarEmpleado.Focus();

        }
        private void mostrarEmpleado()
        {

            ModeloEmpleado Empleado = new ModeloEmpleado();
            dgvEmpleado.DataSource = Empleado.mostrarEmpleado();

        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleado.SelectedRows.Count > 0)
            {
                // Verificar si se ha seleccionado solo una fila
                if (dgvEmpleado.SelectedRows.Count == 1)
                {
                    string codEmpleado = dgvEmpleado.CurrentRow.Cells["codEmpleado"].Value.ToString();
                    EmpObjeto.EliminarEmp(codEmpleado); // Pasar el código del empleado como string
                    MessageBox.Show("Eliminado Correctamente");
                    mostrarEmpleado();
                    txtBuscarEmpleado.Focus();
                    mostrarEmpleado();
                    ajusteDataGrid();
                    dgvEmpleado.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Seleccione solo una fila por favor");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }


        }
        public void ajusteDataGrid()
        {


           
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


        }

        private void frmEmpleado_Shown(object sender, EventArgs e)
        {
            dgvEmpleado.ClearSelection();
        }
    }
}

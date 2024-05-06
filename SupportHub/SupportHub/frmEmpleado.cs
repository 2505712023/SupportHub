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
using System.Linq.Expressions;
using System.Data.SqlClient;
namespace Presentacion
{
    public partial class frmEmpleado : Form
    {
        ModeloEmpleado EmpObjeto = new ModeloEmpleado();
        //private string codEmpleado = null;
        private List<string> tipoEmpleado;
        public frmEmpleado()
        {
            InitializeComponent();

            tipoEmpleado = new List<string>()
 {
            "Código de Empleado",
            "Nombre",
             "Apellido"
 };
            cbxTipoBusquedaEmpleado.DataSource = tipoEmpleado;
        }
        private void AgregarUpdateEvenHandler(object sender, frmAgregarEmpleado.UpdateEventArgs args)
        {

            mostrarEmpleado();
        }
        private void ModificarUpdateEvenHandler(object sender, frmModificarEmpleado.ModificarEventArgs args)
        {

            mostrarEmpleado();
        }



        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            frmAgregarEmpleado formEmpleado = new frmAgregarEmpleado(this);
            formEmpleado.UpdateEventHandler += AgregarUpdateEvenHandler;



            formEmpleado.Show();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            cbxTipoBusquedaEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            mostrarEmpleado();

            ajusteDataGrid();
    
            if (CacheInicioUsuario.permisosUser.Contains("Realizar todas las acciones"))
            {
                
                btnAgregarEmpleado.Visible = true;
                btnEliminarEmpleado.Visible = true;
                btnModificaEmpleado.Visible = true;
            }
            else if (CacheInicioUsuario.permisosUser.Contains("Agregar") &&
                     CacheInicioUsuario.permisosUser.Contains("Modificar") &&
                     CacheInicioUsuario.permisosUser.Contains("Consultar Datos"))
            {
              
                btnEliminarEmpleado.Visible = false;
            }
            else if (CacheInicioUsuario.permisosUser.Contains("Consultar Datos"))
            {

                btnAgregarEmpleado.Visible = false;
                btnEliminarEmpleado.Visible = false;
                btnModificaEmpleado.Visible = false;
            }

            txtBuscarEmpleado.Focus();

        }
        private void cbxTipoBusquedaEmpleado_TextChanged(object sender, EventArgs e)
        {
            txtBuscarEmpleado.Focus();
            actualizarTablaEmpleado();
        }

        private void txtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            actualizarTablaEmpleado();
        }

        private void actualizarTablaEmpleado()
        {
            if (string.IsNullOrEmpty(txtBuscarEmpleado.Text))
            {
                mostrarEmpleado();
                dgvEmpleado.ClearSelection();

            }
            else
            {
                switch (cbxTipoBusquedaEmpleado.Text)
                {
                    case "Código de Empleado":
                        dgvEmpleado.DataSource = EmpObjeto.filtrarTablaEmpleado(codEmpleado: txtBuscarEmpleado.Text);
                        break;
                    case "Nombre":
                        dgvEmpleado.DataSource = EmpObjeto.filtrarTablaEmpleado(nombreEmpleado: txtBuscarEmpleado.Text);
                        break;
                    case "Apellido":
                        dgvEmpleado.DataSource = EmpObjeto.filtrarTablaEmpleado(apellidoEmpleado: txtBuscarEmpleado.Text);
                        break;
                    default:
                        break;
                }
            }
            dgvEmpleado.ClearSelection();
        }


        private void mostrarEmpleado()
        {

            ModeloEmpleado Empleado = new ModeloEmpleado();
            dgvEmpleado.DataSource = Empleado.mostrarEmpleado();
            dgvEmpleado.ClearSelection();
        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {

            
            DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar empleado?", "Eliminar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                if (dgvEmpleado.SelectedRows.Count == 1)
                {
                    string codEmpleado = dgvEmpleado.CurrentRow.Cells["codEmpleado"].Value.ToString();
                    try
                    {
                        EmpObjeto.EliminarEmp(codEmpleado);
                        MessageBox.Show("Empleado eliminado correctamente");
                        mostrarEmpleado();
                        txtBuscarEmpleado.Focus();
                        mostrarEmpleado();
                        ajusteDataGrid();
                        dgvEmpleado.ClearSelection();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 547)
                        {
                            MessageBox.Show("No se puede eliminar el empleado porque tiene entregas pendientes.");
                        }
                        else
                        {
                            MessageBox.Show($"Error al intentar eliminar el empleado: {ex.Message}");
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("El empleado tiene entregas o asignaciones pendientes");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione solo una fila por favor");
                }
            }
            else
            {
                MessageBox.Show("Operación de eliminación cancelada");
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

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {


            dgvEmpleado.DataSource = null;


        }

        private void btnModificaEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleado.SelectedRows.Count > 0)
            {
                if (dgvEmpleado.SelectedRows.Count == 1)
                {
                    frmModificarEmpleado frm = new frmModificarEmpleado(this);
                    frm.UpdateEventHandler += ModificarUpdateEvenHandler;
                    frm.LlenarComboBoxCargos();
                    frm.LlenarComboBoxAreas();
                    frm.codEmpleado = dgvEmpleado.CurrentRow.Cells["codEmpleado"].Value.ToString();
                    frm.txtNombreEmpleadoUpdate.Text = dgvEmpleado.CurrentRow.Cells["nombreEmpleado"].Value.ToString();
                    frm.txtApellidoEmpleadoUpdate.Text = dgvEmpleado.CurrentRow.Cells["apellidoEmpleado"].Value.ToString();
                    frm.txtTelefonoEmpleadoUpdate.Text = dgvEmpleado.CurrentRow.Cells["telefonoEmpleado"].Value.ToString();
                    frm.txtEmailEmpleadoUpdate.Text = dgvEmpleado.CurrentRow.Cells["emailEmpleado"].Value.ToString();
                    frm.cbxAreaEmpleadoUpdate.Text = dgvEmpleado.CurrentRow.Cells["nombreArea"].Value.ToString();
                    frm.cbxCargoEmpleadoUpdate.Text = dgvEmpleado.CurrentRow.Cells["nombreCargo"].Value.ToString();
                    frm.ShowDialog();

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

       

        private void cbxTipoBusquedaEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

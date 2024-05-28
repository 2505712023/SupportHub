using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dominio;
using Comun.Cache;
using Presentacion.CustomMessageBoxes;


namespace Presentacion
{
    public partial class frmUsuario : Form
    {
        ModeloUsuario ModUser = new ModeloUsuario();
        private List<string> tipoBusquedaUsuario;
        private bool formCargado = false;
        public frmUsuario()
        {
            InitializeComponent();
            tipoBusquedaUsuario = new List<string>()
            {
            "Login de Usuario",
            "Nombres del Usuario",
            "Apellidos del Usuario"
            };
            cbxTipoBusquedaUsuario.DataSource = tipoBusquedaUsuario;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == (Keys.Control | Keys.Shift | Keys.A))
            {
                btnAgregarUsuario_Click(this, EventArgs.Empty);
                return true;
            }

            if (keyData == (Keys.Control | Keys.Shift | Keys.M))
            {
                btnModificaUsuario_Click(this, EventArgs.Empty);
                return true;
            }

            if (keyData == (Keys.Control | Keys.Shift | Keys.E))
            {
                btnEliminarUsuario_Click_1(this, EventArgs.Empty);
                return true;
            }
            if (keyData == (Keys.Delete))
            {
                btnEliminarUsuario_Click_1(this, EventArgs.Empty);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void mostrarUsuario()
        {
            ModeloUsuario Usuario = new ModeloUsuario();
            dgvUsuario.DataSource = Usuario.mostrarUsuario();
            dgvUsuario.ClearSelection();
        }

        private void actualizarTablaUsuario()
        {
            if (string.IsNullOrEmpty(txtBuscarUsuario.Text))
            {
                mostrarUsuario();
                dgvUsuario.ClearSelection();
            }
            else
            {
                switch (cbxTipoBusquedaUsuario.Text)
                {
                    case "Login de Usuario":
                        dgvUsuario.DataSource = ModUser.filtrarTablaUsuario(loginUsuario: txtBuscarUsuario.Text);
                        break;
                    case "Nombres del Usuario":
                        dgvUsuario.DataSource = ModUser.filtrarTablaUsuario(nombresUsuario: txtBuscarUsuario.Text);
                        break;
                    case "Apellidos del Usuario":
                        dgvUsuario.DataSource = ModUser.filtrarTablaUsuario(apellidosUsuario: txtBuscarUsuario.Text);
                        break;
                    default:
                        break;
                }
            }
            dgvUsuario.ClearSelection();
        }
        public void ajusteDataGrid()
        {
            dgvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuario.Columns["idEmpleado"].Visible = false;
            dgvUsuario.Columns["Código del Empleado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuario.Columns["Activo?"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            cbxTipoBusquedaUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            mostrarUsuario();
            ajusteDataGrid();

            if (CacheInicioUsuario.permisosUser.Contains("Realizar todas las acciones"))
            {
                btnAgregarUsuario.Visible = true;
                btnEliminarUsuario.Visible = true;
                btnModificaUsuario.Visible = true;
            }
            else if (CacheInicioUsuario.permisosUser.Contains("Agregar") &&
                     CacheInicioUsuario.permisosUser.Contains("Modificar") &&
                     CacheInicioUsuario.permisosUser.Contains("Consultar Datos"))
            {
                btnEliminarUsuario.Visible = false;
            }
            else if (CacheInicioUsuario.permisosUser.Contains("Consultar Datos"))
            {
                btnAgregarUsuario.Visible = false;
                btnEliminarUsuario.Visible = false;
                btnModificaUsuario.Visible = false;
            }

            txtBuscarUsuario.Focus();
            formCargado = true;
        }

        private void btnModificaUsuario_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvUsuario.SelectedRows[0];
            int activoUsuario = Convert.ToBoolean(selectedRow.Cells["Activo?"].Value) ? 1 : 0;

            frmAgregarUsuario formUsuario = new(
                loginUsuario: selectedRow.Cells["Login de Usuario"].Value.ToString(),
                idEmpleado: Convert.ToInt32(selectedRow.Cells["idEmpleado"].Value.ToString()),
                activoUsuario: activoUsuario
                );
            formUsuario.UpdateEventHandler += AgregarUpdateEvenHandler;
            formUsuario.ShowDialog();
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            actualizarTablaUsuario();
        }

        private void cbxTipoBusquedaUsuario_TextChanged(object sender, EventArgs e)
        {
            txtBuscarUsuario.Focus();
            actualizarTablaUsuario();
        }

        private void AgregarUpdateEvenHandler(object sender, frmAgregarUsuario.UpdateEventArgs args)
        {
            mostrarUsuario();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            frmAgregarUsuario agrusuario = new frmAgregarUsuario(this);
            agrusuario.UpdateEventHandler += AgregarUpdateEvenHandler;
            agrusuario.ShowDialog();
        }

        ModeloUsuario UsuarioObjeto = new ModeloUsuario();

        private void btnEliminarUsuario_Click_1(object sender, EventArgs e)
        {
            if (CustomMessageBox.Advertencia("Eliminar usuario", "¿Seguro que desea eliminar usuario?") == DialogResult.Yes)
            {
                if (dgvUsuario.SelectedRows.Count == 1)
                {
                    string loginUsuario = dgvUsuario.CurrentRow.Cells["Login de Usuario"].Value.ToString();
                    bool hasError = false;
                    try
                    {
                        UsuarioObjeto.EliminarUsuario(loginUsuario);
                    }
                    catch (SqlException ex)
                    {
                        hasError = true;
                        if (ex.Number == 547)
                        {
                            CustomMessageBox.Error("Error en eliminación", "No se puede eliminar el empleado porque tiene entregas pendientes.");
                        }
                        else
                        {
                            CustomMessageBox.Error("Error en eliminación", $"Error al intentar eliminar el empleado: {ex.Message}.");
                        }
                    }
                    catch (FormatException)
                    {
                        hasError = true;
                        CustomMessageBox.Error("Error en eliminación", "El empleado tiene entregas o asignaciones pendientes.");
                    }
                    if (hasError == false)
                    {
                        CustomMessageBox.Exito("Eliminación exitosa", "Empleado eliminado correctamente.");
                        mostrarUsuario();
                        txtBuscarUsuario.Focus();
                        mostrarUsuario();
                        ajusteDataGrid();
                        dgvUsuario.ClearSelection();
                    }
                }
                else
                {
                    CustomMessageBox.Error("Error en selección", "Seleccione solo una fila por favor.");
                }
            }
            else
            {
                CustomMessageBox.Error("Operación cancelada", "Operación de eliminación cancelada");
            }
        }

        private void dgvUsuario_SelectionChanged(object sender, EventArgs e)
        {
            if (formCargado && dgvUsuario.SelectedRows.Count == 1)
            {
                btnModificaUsuario.Enabled = true;
            }
            else if (formCargado)
            {
                btnModificaUsuario.Enabled = false;
            }
        }
    }
}

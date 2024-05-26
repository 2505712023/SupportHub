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


namespace Presentacion
{
    public partial class frmUsuario : Form
    {
        ModeloUsuario ModUser = new ModeloUsuario();
        private List<string> tipoUsuario;
        public frmUsuario()
        {
            InitializeComponent();
            tipoUsuario = new List<string>()
            {
            "Nombre de usuario",
            "Nombre del empleado",
            "Apellidos del empleado"
            };
            cbxTipoBusquedaUsuario.DataSource = tipoUsuario;
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
                    case "Nombre de usuario":
                        dgvUsuario.DataSource = ModUser.filtrarTablaUsuario(loginUsuario: txtBuscarUsuario.Text);
                        break;
                    case "Nombre del empleado":
                        dgvUsuario.DataSource = ModUser.filtrarTablaUsuario(nombreUsuario: txtBuscarUsuario.Text);
                        break;
                    case "Apellidos del empleado":
                        dgvUsuario.DataSource = ModUser.filtrarTablaUsuario(apellidoUsuario: txtBuscarUsuario.Text);
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

            if (!CacheInicioUsuario.permisosUser.Contains("Realizar todas las acciones"))
            {
                btnAgregarUsuario.Visible = false;
                btnEliminarUsuario.Visible = false;
                btnModificaUsuario.Visible = false;
            }
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

        }

        private void btnModificaUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count == 1)
            {
               
                string loginUsuario = dgvUsuario.CurrentRow.Cells[0].Value.ToString();
                string nombreUsuario = dgvUsuario.CurrentRow.Cells[1].Value.ToString();
                string apellidoUsuario = dgvUsuario.CurrentRow.Cells[2].Value.ToString();
            
     
              
                frmAgregarUsuario frm = new frmAgregarUsuario(this);
                frm.UpdateEventHandler += AgregarUpdateEvenHandler;
                frm.llenarComboboxTipoUsuario();
                frm.LlenarComboBoxNombres();
                frm.LlenarComboboxApellidos();
                frm.CargarDatosUsuario(loginUsuario, nombreUsuario, apellidoUsuario);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione solo una fila por favor", "Error en selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


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
        private void cbxTipoBusquedaUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

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

            DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar datos del usuario?", "Eliminar datos del usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                if (dgvUsuario.SelectedRows.Count == 1)
                {
                    string loginUsuario = dgvUsuario.CurrentRow.Cells["Nombre de usuario"].Value.ToString();
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
                            MessageBox.Show("No se puede eliminar el empleado porque tiene entregas pendientes.", "Error en eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show($"Error al intentar eliminar el empleado: {ex.Message}", "Error en eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (FormatException)
                    {
                        hasError = true;
                        MessageBox.Show("El empleado tiene entregas o asignaciones pendientes", "Error en eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (hasError == false)
                    {
                        MessageBox.Show("Empleado eliminado correctamente", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mostrarUsuario();
                        txtBuscarUsuario.Focus();
                        mostrarUsuario();
                        ajusteDataGrid();
                        dgvUsuario.ClearSelection();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione solo una fila por favor", "Error en selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Operación de eliminación cancelada", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    

        
    }


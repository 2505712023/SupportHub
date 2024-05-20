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
            "Código de usuario",
            "Nombre",
             "Apellido"
            };
            cbxTipoBusquedaUsuario.DataSource = tipoUsuario;
        }

        private void mostrarUsuario()
        {
            ModeloUsuario Usuario = new ModeloUsuario();
            dgvUsuario.DataSource = Usuario.mostrarUsuario();
            dgvUsuario.ClearSelection();
        }
        private void actualizarTablaEmpleado()
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
                    case "Código de Empleado":
                        dgvUsuario.DataSource = ModUser.filtrarTablaUsuario(idUsuario: txtBuscarUsuario.Text);
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
            frmModificarusuario mdfusuario = new frmModificarusuario();
            mdfusuario.Show();
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            actualizarTablaEmpleado();
        }

        private void cbxTipoBusquedaUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            frmAgregarusuario agrusuario = new frmAgregarusuario();
            agrusuario.Show();
        }

        private void btnEliminarUsuario_Click_1(object sender, EventArgs e)
        {
            frmEliminarusuario elmusuario = new frmEliminarusuario();
            elmusuario.Show();
        }
    }
}

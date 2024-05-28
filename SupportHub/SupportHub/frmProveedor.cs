using Comun.Cache;
using Dominio;
using Presentacion.CustomMessageBoxes;

namespace Presentacion
{
    public partial class frmProveedor : Form
    {
        private bool formCargado = false;
        ModeloProveedor proveedor = new();

        private List<string> tipoBusquedaProveedor = new()
        {   
            "Código Proveedor",
            "Nombre Proveedor"
        };

        public frmProveedor()
        {
            InitializeComponent();
            cbxTipoBusquedaProveedor.DataSource = tipoBusquedaProveedor;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Shift | Keys.A))
            {
                btnAgregarProveedor_Click(this, EventArgs.Empty);
                return true;
            }

            if (keyData == (Keys.Control | Keys.Shift | Keys.M))
            {
                btnModificaProveedor_Click(this, EventArgs.Empty);
                return true;
            }

            if (keyData == (Keys.Control | Keys.Shift | Keys.E))
            {
                btnEliminarProveedor_Click(this, EventArgs.Empty);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            txtBuscarProveedor.Focus();
            cbxTipoBusquedaProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            MostrarProveedor();
            AjustarGridView();

            if (CacheInicioUsuario.permisosUser != null && CacheInicioUsuario.permisosUser.Contains("Realizar todas las acciones"))
            {
                btnAgregarProveedor.Visible = true;
                btnEliminarProveedor.Visible = true;
                btnModificaProveedor.Visible = true;
            }
            else if (CacheInicioUsuario.permisosUser != null && CacheInicioUsuario.permisosUser.Contains("Agregar") &&
                     CacheInicioUsuario.permisosUser.Contains("Modificar") &&
                     CacheInicioUsuario.permisosUser.Contains("Consultar Datos"))
            {
                btnEliminarProveedor.Visible = false;
            }
            else if (CacheInicioUsuario.permisosUser != null && CacheInicioUsuario.permisosUser.Contains("Consultar Datos"))
            {
                btnAgregarProveedor.Visible = false;
                btnEliminarProveedor.Visible = false;
                btnModificaProveedor.Visible = false;
            }
            dgvProveedor.ClearSelection();
            formCargado = true;
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            frmAgregarProveedor frmAgregarProveedor = new frmAgregarProveedor();
            frmAgregarProveedor.ShowDialog();
            MostrarProveedor();
        }

        private void btnModificaProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count > 0)
            {
                if (dgvProveedor.SelectedRows.Count == 1)
                {
                    frmAgregarProveedor editar = new frmAgregarProveedor(int.Parse(dgvProveedor.CurrentRow.Cells["idProveedor"].Value.ToString()!));

                    editar.txtCodProveedor.Text = dgvProveedor.CurrentRow.Cells["codProveedor"].Value.ToString();
                    editar.txtNombre.Text = dgvProveedor.CurrentRow.Cells["nombreProveedor"].Value.ToString();
                    editar.txtDireccion.Text = dgvProveedor.CurrentRow.Cells["direccionProveedor"].Value.ToString();
                    editar.txtTelefono.Text = dgvProveedor.CurrentRow.Cells["telefonoProveedor"].Value.ToString();

                    editar.ShowDialog();
                    MostrarProveedor();
                }
                else
                {
                    CustomMessageBox.Error("Error en selección", "Seleccione solo una fila por favor.");
                }
            }
            else
            {
                CustomMessageBox.Error("Error en selección", "Seleccione solo una fila por favor.");
            }
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (CustomMessageBox.Advertencia("Eliminar proveedor", "¿Seguro que desea eliminar proveedor?") == DialogResult.Yes)
            {
                if (dgvProveedor.SelectedRows.Count == 1)
                {
                    try
                    {
                        proveedor.EliminarProveedor(int.Parse(dgvProveedor.CurrentRow.Cells["idProveedor"].Value?.ToString()!));
                        MostrarProveedor();
                    }
                    catch (Exception ex)
                    {
                        CustomMessageBox.Error("Error en eliminación", $"Error al intentar eliminar el proveedor: {ex.Message}.");
                    }
                }
                else
                {
                    CustomMessageBox.Error("Error en selección", "Seleccione solo una fila por favor.");
                }
            }
        }

        private void MostrarProveedor()
        {
            ModeloProveedor proveedor = new ModeloProveedor();
            dgvProveedor.DataSource = proveedor.MostrarProveedores();
        }

        public void AjustarGridView()
        {
            dgvProveedor.Columns["codProveedor"].HeaderText = "Código";
            dgvProveedor.Columns["nombreProveedor"].HeaderText = "Nombre";
            dgvProveedor.Columns["direccionProveedor"].HeaderText = "Dirección";
            dgvProveedor.Columns["telefonoProveedor"].HeaderText = "Teléfono";
            dgvProveedor.Columns["idProveedor"].Visible = false;
            dgvProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedor.ClearSelection();
        }

        private void txtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            FiltrarResultados();
        }

        private void FiltrarResultados()
        {
            if (string.IsNullOrEmpty(txtBuscarProveedor.Text))
            {
                MostrarProveedor();
            }
            else
            {
                switch (cbxTipoBusquedaProveedor.Text)
                {
                    case "Nombre Proveedor":
                        dgvProveedor.DataSource = proveedor.ObtenerProveedor(nombreProveedor: txtBuscarProveedor.Text);
                        break;
                    case "Código Proveedor":
                        dgvProveedor.DataSource = proveedor.ObtenerProveedor(codProveedor: txtBuscarProveedor.Text);
                        break;
                    default:
                        break;
                }
            }
            AjustarGridView();
        }

        private void dgvProveedor_SelectionChanged(object sender, EventArgs e)
        {
            if (formCargado)
            {
                if(dgvProveedor.SelectedRows.Count == 1)
                {
                    btnModificaProveedor.Enabled = true;
               
                }
                else if (dgvProveedor.SelectedRows.Count != 1)
                {
                    btnModificaProveedor.Enabled = false;
               
                }
            }
        }
    }
}

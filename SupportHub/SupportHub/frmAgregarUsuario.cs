using DataAccess;
using Dominio;
using Presentacion.CustomMessageBoxes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmAgregarUsuario : Form
    {
        private bool formCargado = false, esModificacion = false;
        private string loginUsuario = string.Empty;
        private int idEmpleado = 0;

        ModeloUsuario moduser = new ModeloUsuario();
        public frmAgregarUsuario(frmUsuario agrusuario)
        {
            InitializeComponent();
        }

        public frmAgregarUsuario(
            string loginUsuario,
            int idEmpleado,
            int activoUsuario
            )
        {
            InitializeComponent();
            this.loginUsuario = loginUsuario;
            this.esModificacion = true;
            this.idEmpleado = idEmpleado;
            this.Activo = activoUsuario;
            gbAddUsuario.Text = $"MODIFICAR USUARIO: {loginUsuario}";
        }

        public delegate void UpdateDelagate(object sender, UpdateEventArgs arg);
        public event UpdateDelagate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Agregar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event EventHandler UsuarioGuardado;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (!esModificacion)
                {
                    bool usuarioIngresado = false;
                    moduser.InsertarUsuario(
                        LoginUsuario: tboxLoginUsuario.Text,
                        NombreUsuario: tboxNombresUsuario.Text,
                        ApellidoUsuario: tboxApellidosUsuario.Text,
                        Contrasenia: mtboxContrasenia.Text,
                        ActivoUsuario: Activo,
                        idEmpleado: Convert.ToInt32(cbxEmpAddUsuario.SelectedValue)
                        );
                    usuarioIngresado = true;

                    bool rolesAgregados = false;
                    if (usuarioIngresado)
                    {
                        foreach (DataGridViewRow row in dgvRoles.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells["Asociar"].Value))
                            {
                                moduser.InsertarUsuarioxRol(Convert.ToInt32(row.Cells["idRol"].Value), tboxLoginUsuario.Text);
                            }
                        }
                        rolesAgregados = true;
                    }

                    if (usuarioIngresado && rolesAgregados)
                    {
                        CustomMessageBox.Exito("Registro exitoso", "El usuario se registró correctamente.");
                        Agregar();

                        tboxLoginUsuario.Text = "";
                        mtboxContrasenia.Text = "";
                        cbxEmpAddUsuario.SelectedIndex = -1;
                        chbActivoUsuario.Checked = true;
                        llenarDgvRoles();
                    }
                    else
                    {
                        CustomMessageBox.Error("Error de registro", "Ocurrió un error al registrar el usuario.");
                    }
                }
                else if (esModificacion)
                {
                    bool usuarioModificado = false;
                    string contrasenia = string.IsNullOrEmpty(mtboxContrasenia.Text)? null : mtboxContrasenia.Text;
                    moduser.ActualizarUsuario(
                        loginUsuario: tboxLoginUsuario.Text,
                        nombresUsuario: tboxNombresUsuario.Text,
                        apellidosUsuario: tboxApellidosUsuario.Text,
                        contraseniaUsuario: contrasenia,
                        activoUsuario: Activo,
                        idEmpleado: Convert.ToInt32(cbxEmpAddUsuario.SelectedValue)
                        );
                    usuarioModificado = true;

                    bool rolesModificados = false;
                    if (usuarioModificado)
                    {
                        foreach (DataGridViewRow row in dgvRoles.Rows)
                        {
                            bool asociar = Convert.ToBoolean(row.Cells["Asociar"].Value);
                            int idRol = Convert.ToInt32(row.Cells["idRol"].Value);
                            if (asociar && !moduser.ValidarRolActivoXUsuario(tboxLoginUsuario.Text, idRol))
                            {
                                moduser.InsertarUsuarioxRol(idRol, tboxLoginUsuario.Text);
                            }
                            else if (!asociar)
                            {
                                moduser.EliminarUsuarioxRol(idRol, tboxLoginUsuario.Text);
                            }
                        }
                        rolesModificados = true;
                    }

                    if (usuarioModificado && rolesModificados)
                    {
                        CustomMessageBox.Exito("Modificación exitosa", "El usuario se modificó correctamente.");
                        Agregar();
                        this.Close();
                    }
                    else
                    {
                        CustomMessageBox.Error("Error de modificación", "Ocurrió un error al modificar el usuario.");
                    }
                }
            }
        }

        public void CargarDatosUsuario(string loginUsuario, string nombreUsuario, string apellidoUsuario)
        {
            tboxLoginUsuario.Text = loginUsuario;
            tboxNombresUsuario.Text = nombreUsuario;
            tboxApellidosUsuario.Text = apellidoUsuario;
        }

        private void frmAgregarUsuario_Load(object sender, EventArgs e)
        {
            LlenarComboBoxEmpleados();
            llenarDgvRoles();
            formCargado = true;
            if (!esModificacion)
            {
                chbActivoUsuario.Checked = true;
                tboxNombresUsuario.Enabled = false;
                tboxApellidosUsuario.Enabled = false;
                tboxLoginUsuario.Text = "";
                cbxEmpAddUsuario.SelectedIndex = -1;
            }
            else if (esModificacion)
            {
                if (Activo == 1)
                {
                    chbActivoUsuario.Checked = true;
                }
                else if (Activo == 0)
                {
                    chbActivoUsuario.Checked = false;
                }
                tboxNombresUsuario.Enabled = false;
                tboxApellidosUsuario.Enabled = false;
                tboxLoginUsuario.Text = loginUsuario;
                cbxEmpAddUsuario.SelectedValue = idEmpleado;
            }
        }

        public void llenarDgvRoles()
        {
            dgvRoles.Columns.Clear();
            DataTable roles = moduser.ObtenerRoles();
            dgvRoles.DataSource = roles;
            dgvRoles.Columns["idRol"].Visible = false;
            dgvRoles.Columns["Nombre Rol"].ReadOnly = true;

            DataGridViewCheckBoxColumn checkBoxColumn = new();
            checkBoxColumn.Name = "Asociar";
            checkBoxColumn.HeaderText = "Asociar";
            checkBoxColumn.FalseValue = false;
            checkBoxColumn.TrueValue = true;

            dgvRoles.Columns.Add(checkBoxColumn);

            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoles.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRoles.AllowUserToAddRows = false;

            if (esModificacion)
            {
                foreach (DataGridViewRow row in dgvRoles.Rows)
                {
                    if (moduser.ValidarRolActivoXUsuario(loginUsuario, Convert.ToInt32(row.Cells["idRol"].Value)))
                    {
                        row.Cells["Asociar"].Value = true;
                    }
                }
            }
        }

        public void LlenarComboBoxEmpleados()
        {
            DataTable empleados = moduser.ObtenerEmpleados(idEmpleado);

            cbxEmpAddUsuario.DataSource = empleados;
            cbxEmpAddUsuario.DisplayMember = "Empleado";
            cbxEmpAddUsuario.ValueMember = "idEmpleado";
        }

        private void cbxEmpAddUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formCargado && cbxEmpAddUsuario.SelectedIndex != -1)
            {
                tboxNombresUsuario.Text = moduser.ObtenerNombreEmpleado(Convert.ToInt32(cbxEmpAddUsuario.SelectedValue));
                tboxApellidosUsuario.Text = moduser.ObtenerApellidoEmpleado(Convert.ToInt32(cbxEmpAddUsuario.SelectedValue));
            }
            else
            {
                tboxNombresUsuario.Text = string.Empty;
                tboxApellidosUsuario.Text = string.Empty;
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(tboxLoginUsuario.Text) || !EsLetras(tboxLoginUsuario.Text))
            {
                CustomMessageBox.Error("Dato inválido", "Ingrese un nombre válido.");
                return false;
            }

            int longitud = mtboxContrasenia.TextLength;
            if ((string.IsNullOrEmpty(mtboxContrasenia.Text) || longitud < 5) && !esModificacion)
            {
                CustomMessageBox.Error("Dato inválido", "Ingrese una contreña valida, de al menos 5 caracteres");
                return false;
            }
            else if (!string.IsNullOrEmpty(mtboxContrasenia.Text) && longitud < 5 && esModificacion)
            {
                CustomMessageBox.Error("Dato inválido", "Ingrese una contreña valida, de al menos 5 caracteres");
                return false;
            }

            if (!moduser.ValidarLogin(tboxLoginUsuario.Text) && !esModificacion)
            {
                CustomMessageBox.Error("Dato inválido", "El login ingresado ya existe");
                return false;
            }

            if (cbxEmpAddUsuario.SelectedIndex == -1)
            {
                CustomMessageBox.Error("Dato faltante", "Seleccione un empleado.");
                return false;
            }

            bool asociarRol = false;
            foreach (DataGridViewRow row in dgvRoles.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Asociar"].Value))
                {
                    asociarRol = true;
                }
                if (asociarRol)
                {
                    return true;
                }
            }

            if (!asociarRol)
            {
                CustomMessageBox.Error("Dato faltante", "Seleccione al menos un rol para asociar al usuario.");
                return false;
            }

            return true;
        }

        private bool EsLetras(string texto)
        {
            string[] palabras = texto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string palabra in palabras)
            {
                if (!palabra.All(char.IsLetter))
                {
                    return false;
                }
            }
            return true;
        }

        private int Activo;

        private void chbActivoUsuario_CheckedChanged(object sender, EventArgs e)
        {
            Activo = chbActivoUsuario.Checked ? 1 : 0;
        }

        public int IdUsuario()
        {
            int id = moduser.ObtenerIdUsuario(tboxLoginUsuario.Text);
            return id;
        }
    }
}

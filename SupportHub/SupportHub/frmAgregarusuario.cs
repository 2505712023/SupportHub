using DataAccess;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class frmAgregarUsuario : Form
    {
        ModeloUsuario moduser = new ModeloUsuario();
        public frmAgregarUsuario(frmUsuario agrusuario)
        {
            InitializeComponent();
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

        private void gbAddUsuario_Enter(object sender, EventArgs e)
        {

        }


        public event EventHandler UsuarioGuardado;
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (ValidarCampos())
            {

                int TipoUsuario = 0;
                if (cbxTipoUsuario.Text == "Administrador")
                {
                    TipoUsuario = 1;
                }
                if (cbxTipoUsuario.Text == "Técnico")
                {
                    TipoUsuario = 2;
                }
                if (cbxTipoUsuario.Text == "Común")
                {
                    TipoUsuario = 3;
                }


                if (tboxNombresUsuario.Text == ""  )
                {
                    MessageBox.Show("Nombre No debe estar vacio");

                }
                else if (tboxApellidosUsuario.Text == "") {

                    MessageBox.Show("Apellido No  debe estar vacio");

                }
                else {   

                moduser.InsertarUsuario(
                tboxLoginUsuario.Text,
                tboxNombresUsuario.Text,
                tboxApellidosUsuario.Text,
                mtboxContrasenia.Text,
                Activo,
                Convert.ToInt32(cbxEmpAddUsuario.SelectedValue));
               

                MessageBox.Show("El usuario se registró correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Agregar();

                tboxLoginUsuario.Text = "";
                tboxNombresUsuario.Text = "";
                tboxApellidosUsuario.Text = "";
                mtboxContrasenia.Text = "";
             
                moduser.InsertarUsuarioxRol(TipoUsuario);

                    cbxEmpAddUsuario.SelectedIndex = -1;
                    cbxApellidosAddUsuario.SelectedIndex = -1;
                    chbActivoUsuario.Checked = false;
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
          
            tboxNombresUsuario.Enabled = false;
            tboxApellidosUsuario.Enabled = false;
            tboxLoginUsuario.Text = "";
            chbActivoUsuario.Checked=false;
            LlenarComboBoxNombres();
            llenarComboboxTipoUsuario();
            LlenarComboboxApellidos();
            cbxEmpAddUsuario.SelectedIndex = -1;
            cbxApellidosAddUsuario.SelectedIndex = -1;
            tboxNombresUsuario.Text = "";
            tboxApellidosUsuario.Text = "";
        }

        public void llenarComboboxTipoUsuario()
        {
            DataTable roles = moduser.ObtenerRoles();
            cbxTipoUsuario.DataSource = roles;
            cbxTipoUsuario.DisplayMember = "nombreRol";
            cbxTipoUsuario.ValueMember = "nombreRol";

        }

        public void LlenarComboboxApellidos()
        {

            DataTable apellidos = moduser.ObtenerApellidos();

            cbxApellidosAddUsuario.DataSource = apellidos;
            cbxApellidosAddUsuario.DisplayMember = "apellido Empleado";
            cbxApellidosAddUsuario.ValueMember = "apellidoempleado";
        }

        public void LlenarComboBoxNombres()
        {
            DataTable nombres = moduser.Obtenernombres();

            cbxEmpAddUsuario.DataSource = nombres;
            cbxEmpAddUsuario.DisplayMember = "nombreEmpleado";
            cbxEmpAddUsuario.ValueMember = "idEmpleado";
        }

        private void tboxNombresUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tboxApellidosUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxEmpAddUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = cbxEmpAddUsuario.SelectedItem;

            if (selectedItem == null || string.IsNullOrEmpty(selectedItem.ToString()))
            {
               
            }
            else
            {
                tboxNombresUsuario.Text = cbxEmpAddUsuario.Text;
            }


        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(tboxLoginUsuario.Text) || !EsLetras(tboxLoginUsuario.Text))
            {
                MessageBox.Show("Ingrese un nombre válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            int longitud = mtboxContrasenia.TextLength;

            if (string.IsNullOrEmpty(mtboxContrasenia.Text) || longitud < 5)
            {
                MessageBox.Show("ingrese una contreña valida, de al menos 5 caracteres", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
            if (!moduser.ValidarLogin(tboxLoginUsuario.Text))
            {
                MessageBox.Show("El login ya existe");
                return false;
            }

            if (cbxApellidosAddUsuario.SelectedIndex.ToString() != cbxEmpAddUsuario.SelectedIndex.ToString())
            {
                MessageBox.Show("Los apellidos no corresponden al nombre del empleado", "Datos no compatibles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbxTipoUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de usuario.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbxEmpAddUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un nombre.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool EsTelefono(string telefono)
        {
            return Regex.IsMatch(telefono, @"^\d{4}-\d{4}$");
        }

        private bool EsCorreo(string correo)
        {
            return Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void mtboxContrasenia_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private int Activo;
        private void chbActivoUsuario_CheckedChanged(object sender, EventArgs e)
        {
         
            Activo = chbActivoUsuario.Checked ? 1 : 0;
        }
        public void IdUsuario()
        {
            moduser.ObtenerIdUsuario(tboxLoginUsuario.Text);
        }
        private void cbxApellidosAddUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

           

            if (cbxApellidosAddUsuario.SelectedItem == null || string.IsNullOrEmpty(cbxApellidosAddUsuario.SelectedItem.ToString()))
            {
             
            }
            else
            {
                tboxApellidosUsuario.Text = cbxApellidosAddUsuario.Text;
            }
        }
      
        private void cbxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}

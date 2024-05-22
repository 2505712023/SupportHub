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
        public frmAgregarUsuario()
        {
            InitializeComponent();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void frmAgregarUsuario_Load(object sender, EventArgs e)
        {
            tboxNombresUsuario.Enabled = false;
            tboxApellidosUsuario.Enabled = false;
            LlenarComboBoxEmpleados();
            llenarComboboxTipoUsuario();

        }

        public void llenarComboboxTipoUsuario()
        {
            DataTable roles = moduser.ObtenerRoles();
            cbxTipoUsuario.DataSource = roles;
            cbxTipoUsuario.DisplayMember = "nombreRol";
            cbxTipoUsuario.ValueMember = "nombreRol";

        }



        private void LlenarComboBoxEmpleados()
        {
            DataTable empleados = moduser.ObtenerEmpleados();

            cbxEmpAddUsuario.DataSource = empleados;
            cbxEmpAddUsuario.DisplayMember = "nombre Empleado";
            cbxEmpAddUsuario.ValueMember = "nombreempleado";
        }

        private void tboxNombresUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tboxApellidosUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxEmpAddUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(tboxLoginUsuario.Text) || !EsLetras(tboxLoginUsuario.Text))
            {
                MessageBox.Show("Ingrese un nombre válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int longitud = mtboxContrasenia.TextLength;

            if (string.IsNullOrEmpty(mtboxContrasenia.Text) || longitud<5)
            {
                MessageBox.Show("ingrese una contreña valida, de al menos 5 caracteres", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

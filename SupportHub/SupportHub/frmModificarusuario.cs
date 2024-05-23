using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Presentacion.frmModificarEmpleado;

namespace Presentacion
{
    public partial class frmModificarUsuario : Form
    {
        ModeloUsuario modeloUsuario = new ModeloUsuario();
        public string Operacion = "Insertar";
        public string codEmpleado;
        public frmModificarUsuario(frmUsuario usuario)
        {
            InitializeComponent();
        }


        private void frmModificarUsuario_Load(object sender, EventArgs e)
        {



        }

        private void gbAddUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void cbxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            if (ValidarCampos())
            {
                modeloUsuario.ActualizarUsuario(
                tboxLoginUsuario.Text,
                    tboxNombresUsuario.Text,
                    tboxApellidosUsuario.Text,
                   mtboxContrasenia.Text,
                     Convert.ToInt32(cbxTipoUsuario.SelectedValue),
                    Convert.ToInt32(cbxEmpModUsuario.SelectedValue)

                );
                MessageBox.Show("El empleado se modificó correctamente", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Actualizar();
                tboxLoginUsuario.Text = "";
                tboxNombresUsuario.Text = "";
                tboxApellidosUsuario.Text = "";
                mtboxContrasenia.Text = "";
                cbxTipoUsuario.Text = null;
                cbxEmpModUsuario.Text = null;
            }
        }
        public event ModificarDelegate UpdateEventHandler;
        public class ModificarEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void Actualizar()
        {
            ModificarEventArgs args = new ModificarEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void btnGuardarUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarCampos()
        {

            if (string.IsNullOrEmpty(tboxLoginUsuario.Text) || !EsLetras(tboxLoginUsuario.Text))
            {
                MessageBox.Show("Ingrese un nombre válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar apellido
            if (string.IsNullOrEmpty(tboxNombresUsuario.Text) || !EsLetras(tboxNombresUsuario.Text))
            {
                MessageBox.Show("Ingrese un apellido válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(tboxApellidosUsuario.Text) || !EsTelefono(tboxApellidosUsuario.Text))
            {
                MessageBox.Show("Ingrese un número de teléfono válido (formato: 2222-0000).", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(mtboxContrasenia.Text) || !EsCorreo(mtboxContrasenia.Text))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbxTipoUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cargo.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbxEmpModUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un área.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }




    }

    private void tboxNombresUsuario_TextChanged (object sender, EventArgs e)
        {

        }
    }
}

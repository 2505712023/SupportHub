using Dominio;
using Presentacion.CustomMessageBoxes;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class frmAgregarProveedor : Form
    {
        ModeloProveedor modeloProveedor = new();

        public frmAgregarProveedor(int? id = null)
        {
            InitializeComponent();

            gbAddProveedor.Text = "AGREGAR PROVEEDOR";

            if (id != null)
            {
                txtId.Text = id.ToString();
                gbAddProveedor.Text = "MODIFICAR PROVEEDOR";
            }
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    modeloProveedor.AgregarProveedor(txtCodProveedor.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text);

                    CustomMessageBox.Exito("Registro exitoso", "El proveedor se registró correctamente.");
                }
                else
                {
                    modeloProveedor.ActualizarProveedor(int.Parse(txtId.Text), txtCodProveedor.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text);
                }
                LimpiarTxt();

                Close();
            }
        }

        private void LimpiarTxt()
        {
            txtCodProveedor.Text = "";
            txtNombre.Text = "";
            txtCodProveedor.Text = "";
            txtTelefono.Text = "";
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtCodProveedor.Text) || txtCodProveedor.Text.Length > 8)
            {
                CustomMessageBox.Error("Dato inválido", "El máximo de caracteres del código tiene que ser de 8.");
                return false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                CustomMessageBox.Error("Dato inválido", "Ingrese un nombre válido.");
                return false;
            }

            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                CustomMessageBox.Error("Dato inválido", "Ingrese una direccion válido.");
                return false;
            }

            if (string.IsNullOrEmpty(txtTelefono.Text) || !EsTelefono(txtTelefono.Text))
            {
                CustomMessageBox.Error("Dato inválido", "Ingrese un número de teléfono válido (formato: 2222-0000).");
                return false;
            }
            return true;
        }

        private bool EsTelefono(string telefono)
        {
            return Regex.IsMatch(telefono, @"^\d{4}-\d{4}$");
        }

        private void txtCodProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnGuardarProveedor_Click(sender, e);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnGuardarProveedor_Click(sender, e);
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnGuardarProveedor_Click(sender, e);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnGuardarProveedor_Click(sender, e);
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnGuardarProveedor_Click(sender, e);
            }
        }
    }
}

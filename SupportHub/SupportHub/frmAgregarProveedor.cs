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

            if (id != null)
                txtId.Text = id.ToString();
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    modeloProveedor.AgregarProveedor(txtCodProveedor.Text, txtNombre.Text, txtCodProveedor.Text, txtTelefono.Text);

                    CustomMessageBox.Exito("Registro exitoso", "El proveedor se registró correctamente.");
                }
                else
                {
                    modeloProveedor.ActualizarProveedor(int.Parse(txtId.Text), txtCodProveedor.Text, txtNombre.Text, txtCodProveedor.Text, txtTelefono.Text);
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
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                CustomMessageBox.Error("Dato inválido", "Ingrese un nombre válido.");
                return false;
            }

            if (string.IsNullOrEmpty(txtCodProveedor.Text))
            {
                CustomMessageBox.Error("Dato inválido", "Ingrese un codigo de proveedor valido válido.");
                return false;
            }

            if (string.IsNullOrEmpty(txtCodProveedor.Text))
            {
                CustomMessageBox.Error("Dato inválido", "Ingrese una direccion válido.");
                return false;
            }

            if (string.IsNullOrEmpty(txtCodProveedor.Text) || !EsTelefono(txtTelefono.Text))
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
    }
}

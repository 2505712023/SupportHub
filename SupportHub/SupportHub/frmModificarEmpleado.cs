using Dominio;
using Presentacion.CustomMessageBoxes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmModificarEmpleado : Form
    {
        ModeloEmpleado agregarEmpleados = new ModeloEmpleado();

        public frmModificarEmpleado(frmEmpleado Emple)
        {
            InitializeComponent();
        }
        ModeloEmpleado modeloEmpleado = new ModeloEmpleado();
        public string Operacion = "Insertar";
        public string codEmpleado;

        public delegate void ModificarDelegate(object sender, ModificarEventArgs arg);
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
        public void LlenarComboBoxAreas()
        {
            DataTable areas = agregarEmpleados.ObtenerArea();

            cbxAreaEmpleadoUpdate.DataSource = areas;
            cbxAreaEmpleadoUpdate.DisplayMember = "nombreArea";
            cbxAreaEmpleadoUpdate.ValueMember = "idArea";
        }

        public void LlenarComboBoxCargos()
        {
            DataTable cargos = agregarEmpleados.ObtenerCargo();

            cbxCargoEmpleadoUpdate.DataSource = cargos;
            cbxCargoEmpleadoUpdate.DisplayMember = "nombreCargo";
            cbxCargoEmpleadoUpdate.ValueMember = "idCargo";
        }

        private void btnGuaardarUpdate_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                modeloEmpleado.ActualizarEmpleado(codEmpleado,
                 txtNombreEmpleadoUpdate.Text,
                    txtApellidoEmpleadoUpdate.Text,
                    txtTelefonoEmpleadoUpdate.Text,
                    txtEmailEmpleadoUpdate.Text,
                     Convert.ToInt32(cbxCargoEmpleadoUpdate.SelectedValue),
                    Convert.ToInt32(cbxAreaEmpleadoUpdate.SelectedValue)

                );
                CustomMessageBox.Exito("Modificación exitosa", "El empleado se modificó correctamente.");
                Actualizar();
                txtNombreEmpleadoUpdate.Text = "";
                txtApellidoEmpleadoUpdate.Text = "";
                txtTelefonoEmpleadoUpdate.Text = "";
                txtEmailEmpleadoUpdate.Text = "";
                cbxAreaEmpleadoUpdate.Text = null;
                cbxCargoEmpleadoUpdate.Text = null;
            }
            this.Close();
        }

        private void btnGuardarUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarCampos()
        {

            if (string.IsNullOrEmpty(txtNombreEmpleadoUpdate.Text) || !EsLetras(txtNombreEmpleadoUpdate.Text))
            {
                CustomMessageBox.Error("Dato inválido", "Ingrese un nombre válido.");
                return false;
            }

            // Validar apellido
            if (string.IsNullOrEmpty(txtApellidoEmpleadoUpdate.Text) || !EsLetras(txtApellidoEmpleadoUpdate.Text))
            {
                CustomMessageBox.Error("Dato inválido", "Ingrese un apellido válido.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefonoEmpleadoUpdate.Text) || !EsTelefono(txtTelefonoEmpleadoUpdate.Text))
            {
                CustomMessageBox.Error("Dato inválido", "Ingrese un número de teléfono válido (formato: 2222-0000).");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmailEmpleadoUpdate.Text) || !EsCorreo(txtEmailEmpleadoUpdate.Text))
            {
                CustomMessageBox.Error("Dato inválido", "Ingrese un correo electrónico válido.");
                return false;
            }

            if (cbxCargoEmpleadoUpdate.SelectedIndex == -1)
            {
                CustomMessageBox.Error("Dato faltante", "Seleccione un cargo.");
                return false;
            }

            if (cbxAreaEmpleadoUpdate.SelectedIndex == -1)
            {
                CustomMessageBox.Error("Dato faltante", "Seleccione un área.");
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

        private void btnCerrarAddEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarUpdate_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarModificarEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModificarEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                btnGuaardarUpdate_Click(sender, e);
            }
        }

        private void frmModificarEmpleado_Load(object sender, EventArgs e)
        {
            txtNombreEmpleadoUpdate.Focus();
        }
    }
}

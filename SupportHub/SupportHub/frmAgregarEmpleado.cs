using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
namespace Presentacion
{
    public partial class frmAgregarEmpleado : Form
    {
        ModeloEmpleado agregarEmpleados = new ModeloEmpleado();
        public frmAgregarEmpleado(frmEmpleado formEmpleado)
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

        private void btnCancelaEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregarEmpleado_Load(object sender, EventArgs e)
        {
            LlenarComboBoxAreas();
            LlenarComboBoxCargos();
        }


       
        private void LlenarComboBoxAreas()
        {
            DataTable areas = agregarEmpleados.ObtenerArea();

            cbxAreaEmpleado.DataSource = areas;
            cbxAreaEmpleado.DisplayMember = "nombreArea";
            cbxAreaEmpleado.ValueMember = "idArea";
        }

        private void LlenarComboBoxCargos()
        {
            DataTable cargos = agregarEmpleados.ObtenerCargo();

            cbxCargoEmpleado.DataSource = cargos;
            cbxCargoEmpleado.DisplayMember = "nombreCargo";
            cbxCargoEmpleado.ValueMember = "idCargo";
        }

      

        private void cbxCargoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public event EventHandler EmpleadoGuardado;
        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos y cumplan con los formatos requeridos
            if (ValidarCampos())
            {
                // Si la validación es exitosa, guardar el empleado
                agregarEmpleados.InsertarEmpleado(
                    txtNombreEmpleado.Text,
                    txtApellidoEmpleado.Text,
                    txtTelefonoEmpleado.Text,
                    txtEmailEmpleado.Text,
                    Convert.ToInt32(cbxCargoEmpleado.SelectedValue),
                    Convert.ToInt32(cbxAreaEmpleado.SelectedValue)
                );
                MessageBox.Show("Se insertó correctamente");
                Agregar();

            }
        }

        private bool ValidarCampos()
        {
            // Validar nombre
            if (string.IsNullOrWhiteSpace(txtNombreEmpleado.Text) || !EsLetras(txtNombreEmpleado.Text))
            {
                MessageBox.Show("Ingrese un nombre válido.");
                return false;
            }

            // Validar apellido
            if (string.IsNullOrWhiteSpace(txtApellidoEmpleado.Text) || !EsLetras(txtApellidoEmpleado.Text))
            {
                MessageBox.Show("Ingrese un apellido válido.");
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtTelefonoEmpleado.Text) || !EsTelefono(txtTelefonoEmpleado.Text))
            {
                MessageBox.Show("Ingrese un número de teléfono válido (formato: 2222-0000).");
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtEmailEmpleado.Text) || !EsCorreo(txtEmailEmpleado.Text))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.");
                return false;
            }


            if (cbxCargoEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cargo.");
                return false;
            }


            if (cbxAreaEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un área.");
                return false;
            }

            return true;
        }

        private bool EsLetras(string texto)
        {

            return texto.All(char.IsLetter);
        }

        private bool EsTelefono(string telefono)
        {

            return Regex.IsMatch(telefono, @"^\d{4}-\d{4}$");
        }

        private bool EsCorreo(string correo)
        {

            return Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        private void pSuperiorAddEmpleado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrarAddEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
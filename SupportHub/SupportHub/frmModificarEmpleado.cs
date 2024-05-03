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

namespace Presentacion
{
    public partial class frmModificarEmpleado : Form
    {



        public frmModificarEmpleado()
        {
            InitializeComponent();
        }
        ModeloEmpleado modEmpleado = new ModeloEmpleado();
      public string Operacion = "Insertar";
      public string codEmpleado;

        public void LlenarComboBoxAreas()
        {
            DataTable areas = modEmpleado.ObtenerArea();

            cbxAreaEmpleadoUpdate.DataSource = areas;
            cbxAreaEmpleadoUpdate.DisplayMember = "nombreArea";
            cbxAreaEmpleadoUpdate.ValueMember = "idArea";
        }

        public void LlenarComboBoxCargos()
        {
            DataTable cargos = modEmpleado.ObtenerCargo();

            cbxCargoEmpleadoUpdate.DataSource = cargos;
            cbxCargoEmpleadoUpdate.DisplayMember = "nombreCargo";
            cbxCargoEmpleadoUpdate.ValueMember = "idCargo";
        }
        private void frmModificarEmpleado_Load(object sender, EventArgs e)
        {

        }
        public void CargarDatosEmpleado(string nombreEmpleado, string apellidoEmpleado, string telefono, string email, string idCargo, string idArea)
        {
            // Llena los controles del formulario con los datos del empleado seleccionado
            txtNombreEmpleadoUpdate.Text = nombreEmpleado;
            txtApellidoEmpleadoUpdate.Text = apellidoEmpleado;
            txtTelefonoEmpleadoUpdate.Text = telefono;
            txtEmailEmpleadoUpdate.Text = email;

            // Selecciona los valores en los ComboBox basados en los ID proporcionados
            cbxCargoEmpleadoUpdate.SelectedValue = idCargo;
            cbxAreaEmpleadoUpdate.SelectedValue = idArea;
        }

        private void btnGuaardarUpdate_Click(object sender, EventArgs e)
        {
            if (Operacion == "Insertar")
            {
                modEmpleado.InsertarEmpleado(
                    txtNombreEmpleadoUpdate.Text,
                    txtApellidoEmpleadoUpdate.Text,
                    txtTelefonoEmpleadoUpdate.Text,
                    txtEmailEmpleadoUpdate.Text,
                    Convert.ToInt32(cbxAreaEmpleadoUpdate.SelectedValue),
                    Convert.ToInt32(cbxCargoEmpleadoUpdate.SelectedValue)
                );
                MessageBox.Show("Se insertó correctamente");
            }
            // Si la operación es una edición
            else if (Operacion == "Editar")
            {
                modEmpleado.EditarEmpleado(
                    txtNombreEmpleadoUpdate.Text,
                    txtApellidoEmpleadoUpdate.Text,
                    txtTelefonoEmpleadoUpdate.Text,
                    txtEmailEmpleadoUpdate.Text,
                    Convert.ToInt32(cbxAreaEmpleadoUpdate.SelectedValue),
                    Convert.ToInt32(cbxCargoEmpleadoUpdate.SelectedValue)
                );
                MessageBox.Show("Se editó correctamente");

            }

        }
    }

}
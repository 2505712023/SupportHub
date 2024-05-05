using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
namespace Presentacion
{
    public partial class frmAgregarEmpleado : Form
    {
        ModeloEmpleado agregarEmpleados = new ModeloEmpleado();
        public frmAgregarEmpleado()
        {
            InitializeComponent();
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
            DataTable areas = agregarEmpleados.ObtenerAreas();

            cbxAreaEmpleado.Items.Clear();


            foreach (DataRow row in areas.Rows)
            {

                cbxAreaEmpleado.Items.Add(row["nombreArea"]);
            }
        }


        private void LlenarComboBoxCargos()
        {
            DataTable cargo = agregarEmpleados.ObtenerCargos();

            cbxCargoEmpleado.Items.Clear();


            foreach (DataRow row in cargo.Rows)
            {

                cbxCargoEmpleado.Items.Add(row["nombreCargo"]);
            }
        }
    }
}

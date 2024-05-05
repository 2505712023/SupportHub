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
    public partial class frmAgregarEntrega : Form
    {
        public frmAgregarEntrega()
        {
            InitializeComponent();
        }

        private void frmAgregarEntrega_Load(object sender, EventArgs e)
        {
            dtpickerFechaEntrega.Format = DateTimePickerFormat.Custom;
            dtpickerFechaEntrega.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtpickerFechaEntrega.ShowUpDown = false;
            dtpickerFechaEntrega.Value = DateTime.Now;


        }

        private void ibtnCancelarEntrega_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenarEmpleados()
        {
            cboxEmpleado.DataSource = ModeloEntrega.obtenerEmpleados();

            cboxEmpleado.ValueMember = "idEmpleado";
            cboxEmpleado.DisplayMember = "Empleado";
        }

        private void llenarEquipos()
        {

        }
    }
}

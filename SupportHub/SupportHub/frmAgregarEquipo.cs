using Dominio;
using Presentacion.CustomMessageBoxes;
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
    public partial class frmAgregarEquipo : Form
    {
        public frmAgregarEquipo()
        {
            InitializeComponent();
            llenarProveedor();




        }

        private void frmAgregarEquipo_Load(object sender, EventArgs e)
        {
            llenarProveedor();
        }
        private void llenarProveedor()
        {
            comboBproveedor.DataSource = ModeloEquipo.obtenerProveedor();
            comboBproveedor.ValueMember = "idProveedor";
            comboBproveedor.DisplayMember = "Proveedor";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            CustomMessageBox.Exito("Registro Exitoso", "Se guardó el Equipo Correctamente");

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}

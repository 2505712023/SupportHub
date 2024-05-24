using Comun.Cache;
using DataAccess;
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
    public partial class frmEquipo : Form
    {
        private List<string> tipoBusquedaEquipo;
        public frmEquipo()
        {
            InitializeComponent();
            tipoBusquedaEquipo = new List<string>()
            {   
                "Tipo Equipo",
                "Marca Equipo",
                "Modelo Equipo",
                "Cantidad Equipo",
                "Precio Equipo",
                "Proveedor",
                "Descripción Equipo"
            };
            cbxTipoBusquedaEquipo.DataSource = tipoBusquedaEquipo;
        }

        private void frmEquipo_Load(object sender, EventArgs e)
        {
            dgvEquipo.DataSource = EquipoDato.obtenerTablaEquipos();
            dgvEquipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (!CacheInicioUsuario.permisosUser.Contains("Agregar"))
            {
                btnAgregarEquipo.Visible = false;
            }
            dgvEquipo.Columns["Precio de Equipo"].DefaultCellStyle.Format = "C2";
        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            DialogResult resultado = CustomMessageBox.Advertencia("Eliminar Equipo", "¿Quiere eliminar un Equipo?");

            if (resultado == DialogResult.Yes)
            {
                if (dgvEquipo.SelectedRows.Count > 0)
                {
                    int totalRegistrosEliminados = 0;


                    totalRegistrosEliminados = ModeloEquipo.EliminarEquipo(dgvEquipo.SelectedRows[0].Cells["Código de Equipo"].Value.ToString());

                    if (totalRegistrosEliminados == 1)
                    {
                        MessageBox.Show("Se eliminaron " + totalRegistrosEliminados.ToString() + " Equipos. ", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show("No se pudo eliminar, verifique si el equipo tiene una entrega registrada");
                    }

                    actualizarTablaEquipos();

                }
                else
                {
                    MessageBox.Show("Debe seleccionar una o varias Equipos para eliminarlos.", "Error en selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
        public void actualizarTablaEquipos()
        {
            if (string.IsNullOrEmpty(txtBuscarEquipo.Text))
            {
                dgvEquipo.DataSource = ModeloEquipo.obtenerTablaEquipos();
                dgvEquipo.ClearSelection();
            }
            else
            {
                switch (cbxTipoBusquedaEquipo.Text)
                {
                    case "Tipo Equipo":

                        break;
                }
            }
        }

        private void AgreUpdateEventHandler(object sender, frmAgregarEquipo.UpdateEventArgs args)
        {
            actualizarTablaEquipos();
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            dgvEquipo.Enabled = false;
            frmAgregarEquipo formEquipo = new frmAgregarEquipo(this);
            formEquipo.UpdateEventHandler += AgreUpdateEventHandler;
            formEquipo.ShowDialog();
        }

        private void btnModificarEquipo_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarEquipo_TextChanged(object sender, EventArgs e)
        {
            actualizarTablaEquipos();
        }

        private void cbxTipoBusquedaEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscarEquipo.Focus();
            actualizarTablaEquipos();
        }
    }
}

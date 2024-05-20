using Comun.Cache;
using DataAccess;
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
    public partial class frmEquipo : Form
    {
        public frmEquipo()
        {
            InitializeComponent();
        }

        private void frmEquipo_Load(object sender, EventArgs e)
        {
            dgvEquipo.DataSource = EquipoDato.obtenerTablaEquipos();
            dgvEquipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (!CacheInicioUsuario.permisosUser.Contains("Agregar"))
            {
                btnAgregarEquipo.Visible = false;
            }
        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Quiere eliminar un Equipo?", "Eliminar Equipo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                    MessageBox.Show("Debe seleccionar una o varias entregas para eliminarlas.", "Error en selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            dgvEquipo.Enabled = false;
            frmAgregarEquipo formEquipo = new frmAgregarEquipo();
            formEquipo.Show();
        }

        private void btnModificarEquipo_Click(object sender, EventArgs e)
        {

        }
    }
}

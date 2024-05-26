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
using System.Windows;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmEquipo : Form
    {
        private List<string> tipoBusquedaEquipo;
        private bool frmCargado = false;
        public frmEquipo()
        {
            InitializeComponent();
            tipoBusquedaEquipo = new List<string>()
            {   "Codigo de Equipo",
                "Tipo de Equipo",
                "Marca de Equipo",
                "Modelo de Equipo"
            };
            cbxTipoBusquedaEquipo.DataSource = tipoBusquedaEquipo;
        }

        private void frmEquipo_Load(object sender, EventArgs e)
        {
            cbxTipoBusquedaEquipo.DropDownStyle = ComboBoxStyle.DropDownList;
            dgvEquipo.DataSource = EquipoDato.obtenerTablaEquipos();
            prepararDgvEquipos();
            dgvEquipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (!CacheInicioUsuario.permisosUser.Contains("Agregar"))
            {
                btnAgregarEquipo.Visible = false;
            }
            dgvEquipo.Columns["Precio de Equipo"].DefaultCellStyle.Format = "C2";
     
            frmCargado = true;
        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            if (CustomMessageBox.Advertencia("Eliminar equipo", "¿Quiere eliminar un equipo?") == DialogResult.Yes)
            {
                if (dgvEquipo.SelectedRows.Count == 1)
                {
                    int totalRegistrosEliminados = ModeloEquipo.EliminarEquipo(dgvEquipo.SelectedRows[0].Cells["Código de Equipo"].Value.ToString());

                    if (totalRegistrosEliminados == 1)
                    {
                        CustomMessageBox.Exito("Eliminación exitosa", "Se eliminó " + totalRegistrosEliminados.ToString() + " equipo.");
                    }
                    else
                    {
                        CustomMessageBox.Error("Error en eliminación", "No se pudo eliminar, verifique si el equipo tiene una entrega registrada");
                    }

                    actualizarTablaEquipos();
                }
                else if (dgvEquipo.SelectedRows.Count == 0)
                {
                    CustomMessageBox.Error("Error en selección", "Debe seleccionar un equipo para eliminar.");
                }
                else
                {
                    CustomMessageBox.Error("Error en selección", "Debe seleccionar solo un equipo para eliminar.");
                }
            }
        }

        public void actualizarTablaEquipos()
        {
            if (string.IsNullOrEmpty(txtBuscarEquipo.Text))
            {
                dgvEquipo.DataSource = ModeloEquipo.obtenerTablaEquipos();
                prepararDgvEquipos();
            }
            else
            {
                switch (cbxTipoBusquedaEquipo.Text)
                {
                    case "Codigo de Equipo":
                        dgvEquipo.DataSource = ModeloEquipo.filtrarTablaEquipo(codEquipo: txtBuscarEquipo.Text);
                        break;
                    case "Tipo de Equipo":
                        dgvEquipo.DataSource = ModeloEquipo.filtrarTablaEquipo(tipoEquipo: txtBuscarEquipo.Text);
                        break;
                    case "Marca de Equipo":
                        dgvEquipo.DataSource = ModeloEquipo.filtrarTablaEquipo(marcaEquipo: txtBuscarEquipo.Text);
                        break;
                    case "Modelo de Equipo":
                        dgvEquipo.DataSource = ModeloEquipo.filtrarTablaEquipo(modeloEquipo: txtBuscarEquipo.Text);
                        break;
                    default:
                        break;
                }
                prepararDgvEquipos();
            }
        }

        private void prepararDgvEquipos()
        {
            dgvEquipo.Enabled = true;
            dgvEquipo.Columns["idProveedor"].Visible = false;
            foreach (DataGridViewColumn col in dgvEquipo.Columns)
            {
                if (col.Name == "Cantidad Adquirida" || col.Name == "Cantidad Disponible" || col.Name == "Precio de Equipo")
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                else
                {
                    col.DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleLeft;
                }
            }
            dgvEquipo.ClearSelection();
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
            DataGridViewRow selectedRow = dgvEquipo.SelectedRows[0];
            dgvEquipo.Enabled = false;
            frmAgregarEquipo formEquipo = new frmAgregarEquipo(
                codEquipo:selectedRow.Cells["Código de Equipo"].Value.ToString(),
                tipoEquipo: selectedRow.Cells["Tipo de Equipo"].Value.ToString(),
                marcaEquipo: selectedRow.Cells["Marca de Equipo"].Value.ToString(),
                modeloEquipo: selectedRow.Cells["Modelo de Equipo"].Value.ToString(),
                cantidadEquipo: Convert.ToInt32(selectedRow.Cells["Cantidad Adquirida"].Value),
                precioEquipo: selectedRow.Cells["Precio de Equipo"].Value.ToString(),
                idProveedor: Convert.ToInt32(selectedRow.Cells["idProveedor"].Value),
                descripcion: selectedRow.Cells["Descripción"].Value.ToString()
                );
            formEquipo.UpdateEventHandler += AgreUpdateEventHandler;
            formEquipo.ShowDialog();
        }

        private void txtBuscarEquipo_TextChanged(object sender, EventArgs e)
        {
            actualizarTablaEquipos();
        }

        private void cbxTipoBusquedaEquipo_TextChanged(object sender, EventArgs e)
        {
            txtBuscarEquipo.Focus();
            actualizarTablaEquipos();
        }

        private void dgvEquipo_SelectionChanged(object sender, EventArgs e)
        {
            if (frmCargado && dgvEquipo.SelectedRows.Count == 1){
                btnModificarEquipo.Enabled = true;
            }
            else if (frmCargado){
                btnModificarEquipo.Enabled=false;
            }
        }
    }
}

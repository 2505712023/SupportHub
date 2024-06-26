﻿using Comun.Cache;
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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq.Expressions;
using System.Data.SqlClient;
using Presentacion.CustomMessageBoxes;
namespace Presentacion
{
    public partial class frmEmpleado : Form
    {
        private bool formCargado = false;
        ModeloEmpleado EmpObjeto = new ModeloEmpleado();
        private List<string> tipoEmpleado;
        private bool frmAgregarEmpleadoAbierto = false;

        public frmEmpleado()
        {
            InitializeComponent();

            tipoEmpleado = new List<string>()
            {
            "Código de Empleado",
            "Nombre",
             "Apellido"
            };
            cbxTipoBusquedaEmpleado.DataSource = tipoEmpleado;
        }

        private void AgregarUpdateEvenHandler(object sender, frmAgregarEmpleado.UpdateEventArgs args)
        {
            mostrarEmpleado();
        }

        private void ModificarUpdateEvenHandler(object sender, frmModificarEmpleado.ModificarEventArgs args)
        {
            mostrarEmpleado();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Shift | Keys.A))
            {
                btnAgregarEmpleado_Click(this, EventArgs.Empty);
                return true;
            }

            if (keyData == (Keys.Control | Keys.Shift | Keys.M))
            {
                btnModificaEmpleado_Click(this, EventArgs.Empty);
                return true;
            }

            if (keyData == (Keys.Control | Keys.Shift | Keys.E))
            {
                btnEliminarEmpleado_Click(this, EventArgs.Empty);
                return true;
            }
            if (keyData == (Keys.Delete))
            {
                btnEliminarEmpleado_Click(this, EventArgs.Empty);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            frmAgregarEmpleado formEmpleado = new frmAgregarEmpleado(this);
            formEmpleado.UpdateEventHandler += AgregarUpdateEvenHandler;
            formEmpleado.ShowDialog();
            frmAgregarEmpleadoAbierto = true;
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            cbxTipoBusquedaEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            mostrarEmpleado();
            ajusteDataGrid();

            if (CacheInicioUsuario.permisosUser.Contains("Realizar todas las acciones"))
            {
                btnAgregarEmpleado.Visible = true;
                btnEliminarEmpleado.Visible = true;
                btnModificaEmpleado.Visible = true;
            }
            else if (CacheInicioUsuario.permisosUser.Contains("Agregar") &&
                     CacheInicioUsuario.permisosUser.Contains("Modificar") &&
                     CacheInicioUsuario.permisosUser.Contains("Consultar Datos"))
            {
                btnEliminarEmpleado.Visible = false;
            }
            else if (CacheInicioUsuario.permisosUser.Contains("Consultar Datos"))
            {
                btnAgregarEmpleado.Visible = false;
                btnEliminarEmpleado.Visible = false;
                btnModificaEmpleado.Visible = false;
            }
            txtBuscarEmpleado.Focus();
            formCargado = true;
        }

        private void cbxTipoBusquedaEmpleado_TextChanged(object sender, EventArgs e)
        {
            txtBuscarEmpleado.Focus();
            actualizarTablaEmpleado();
        }

        private void txtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            actualizarTablaEmpleado();
        }

        private void actualizarTablaEmpleado()
        {
            if (string.IsNullOrEmpty(txtBuscarEmpleado.Text))
            {
                mostrarEmpleado();
                dgvEmpleado.ClearSelection();
            }
            else
            {
                switch (cbxTipoBusquedaEmpleado.Text)
                {
                    case "Código de Empleado":
                        dgvEmpleado.DataSource = EmpObjeto.filtrarTablaEmpleado(codEmpleado: txtBuscarEmpleado.Text);
                        break;
                    case "Nombre":
                        dgvEmpleado.DataSource = EmpObjeto.filtrarTablaEmpleado(nombreEmpleado: txtBuscarEmpleado.Text);
                        break;
                    case "Apellido":
                        dgvEmpleado.DataSource = EmpObjeto.filtrarTablaEmpleado(apellidoEmpleado: txtBuscarEmpleado.Text);
                        break;
                    default:
                        break;
                }
            }
            dgvEmpleado.ClearSelection();
        }

        private void mostrarEmpleado()
        {
            ModeloEmpleado Empleado = new ModeloEmpleado();
            dgvEmpleado.DataSource = Empleado.mostrarEmpleado();
            dgvEmpleado.ClearSelection();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {

            if (CustomMessageBox.Advertencia("Eliminar empleado", "¿Seguro que desea eliminar empleado?") == DialogResult.Yes)
            {
                if (dgvEmpleado.SelectedRows.Count == 1)
                {
                    string codEmpleado = dgvEmpleado.CurrentRow.Cells["codEmpleado"].Value.ToString();
                    bool hasError = false;
                    try
                    {
                        EmpObjeto.EliminarEmp(codEmpleado);
                    }
                    catch (SqlException ex)
                    {
                        hasError = true;
                        if (ex.Number == 547)
                        {
                            CustomMessageBox.Error("Error en eliminación", "No se puede eliminar el empleado porque tiene entregas pendientes.");
                        }
                        else
                        {
                            CustomMessageBox.Error("Error en eliminación", $"Error al intentar eliminar el empleado: {ex.Message}.");
                        }
                    }
                    catch (FormatException)
                    {
                        hasError = true;
                        CustomMessageBox.Error("Error en eliminación", "El empleado tiene entregas o asignaciones pendientes.");
                    }
                    if (hasError == false)
                    {
                        CustomMessageBox.Exito("Eliminación exitosa", "Empleado eliminado correctamente.");
                        mostrarEmpleado();
                        txtBuscarEmpleado.Focus();
                        mostrarEmpleado();
                        ajusteDataGrid();
                        dgvEmpleado.ClearSelection();
                    }
                }
                else
                {
                    CustomMessageBox.Error("Error en selección", "Seleccione solo una fila por favor.");
                }
            }
            else
            {
                CustomMessageBox.Error("Operación cancelada", "Operación de eliminación cancelada.");
            }
        }

        public void ajusteDataGrid()
        {
            dgvEmpleado.Columns["codEmpleado"].HeaderText = "Código";
            dgvEmpleado.Columns["nombreEmpleado"].HeaderText = "Nombre";
            dgvEmpleado.Columns["apellidoEmpleado"].HeaderText = "Apellido";
            dgvEmpleado.Columns["telefonoEmpleado"].HeaderText = "Teléfono";
            dgvEmpleado.Columns["emailEmpleado"].HeaderText = "Correo";
            dgvEmpleado.Columns["codArea"].HeaderText = "Código Área";
            dgvEmpleado.Columns["nombreArea"].HeaderText = "Área";
            dgvEmpleado.Columns["codCargo"].HeaderText = "Código Cargo";
            dgvEmpleado.Columns["nombreCargo"].HeaderText = "Cargo";
            dgvEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (!CacheInicioUsuario.permisosUser.Contains("Realizar todas las acciones"))
            {
                btnAgregarEmpleado.Visible = false;
                btnEliminarEmpleado.Visible = false;
                btnModificaEmpleado.Visible = false;
            }
        }

        private void frmEmpleado_Shown(object sender, EventArgs e)
        {
            dgvEmpleado.ClearSelection();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            dgvEmpleado.DataSource = null;
        }

        private void btnModificaEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleado.SelectedRows.Count > 0)
            {
                if (dgvEmpleado.SelectedRows.Count == 1)
                {
                    frmModificarEmpleado frm = new frmModificarEmpleado(this);
                    frm.UpdateEventHandler += ModificarUpdateEvenHandler;
                    frm.LlenarComboBoxCargos();
                    frm.LlenarComboBoxAreas();
                    string codEmpleado = dgvEmpleado.CurrentRow.Cells["codEmpleado"].Value.ToString();
                    frm.codEmpleado = codEmpleado;
                    frm.gbUpdEmpleado.Text = "MODIFICAR EMPLEADO: " + codEmpleado;
                    frm.txtNombreEmpleadoUpdate.Text = dgvEmpleado.CurrentRow.Cells["nombreEmpleado"].Value.ToString();
                    frm.txtApellidoEmpleadoUpdate.Text = dgvEmpleado.CurrentRow.Cells["apellidoEmpleado"].Value.ToString();
                    frm.txtTelefonoEmpleadoUpdate.Text = dgvEmpleado.CurrentRow.Cells["telefonoEmpleado"].Value.ToString();
                    frm.txtEmailEmpleadoUpdate.Text = dgvEmpleado.CurrentRow.Cells["emailEmpleado"].Value.ToString();
                    frm.cbxAreaEmpleadoUpdate.Text = dgvEmpleado.CurrentRow.Cells["nombreArea"].Value.ToString();
                    frm.cbxCargoEmpleadoUpdate.Text = dgvEmpleado.CurrentRow.Cells["nombreCargo"].Value.ToString();
                    frm.ShowDialog();
                }
                else
                {
                    CustomMessageBox.Error("Error en selección", "Seleccione solo una fila por favor.");
                }
            }
            else
            {
                CustomMessageBox.Error("Error en selección", "Seleccione solo una fila por favor.");
            }
        }

        private void dgvEmpleado_SelectionChanged(object sender, EventArgs e)
        {
            if (formCargado && dgvEmpleado.SelectedRows.Count == 1)
            {
                btnModificaEmpleado.Enabled = true;
            }
            else if (formCargado)
            {
                btnModificaEmpleado.Enabled = false;
            }
        }
    }
}

﻿using System;
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
            cbxAreaEmpleado.Text = null;
            cbxCargoEmpleado.Text = null;
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

        public event EventHandler EmpleadoGuardado;
        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {

            if (ValidarCampos())
            {

                agregarEmpleados.InsertarEmpleado(
                    txtNombreEmpleado.Text,
                    txtApellidoEmpleado.Text,
                    txtTelefonoEmpleado.Text,
                    txtEmailEmpleado.Text,
                    Convert.ToInt32(cbxCargoEmpleado.SelectedValue),
                    Convert.ToInt32(cbxAreaEmpleado.SelectedValue)
                );
                MessageBox.Show("El empleado se registró correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Agregar();

                txtNombreEmpleado.Text = "";
                txtApellidoEmpleado.Text = "";
                txtTelefonoEmpleado.Text = "";
                txtEmailEmpleado.Text = "";
                cbxAreaEmpleado.Text = null;
                cbxCargoEmpleado.Text = null;
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombreEmpleado.Text) || !EsLetras(txtNombreEmpleado.Text))
            {
                MessageBox.Show("Ingrese un nombre válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtApellidoEmpleado.Text) || !EsLetras(txtApellidoEmpleado.Text))
            {
                MessageBox.Show("Ingrese un apellido válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtTelefonoEmpleado.Text) || !EsTelefono(txtTelefonoEmpleado.Text))
            {
                MessageBox.Show("Ingrese un número de teléfono válido (formato: 2222-0000).", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtEmailEmpleado.Text) || !EsCorreo(txtEmailEmpleado.Text))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbxCargoEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cargo.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbxAreaEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un área.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void pSuperiorAddEmpleado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxAreaEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbAddEmpleado_Enter(object sender, EventArgs e)
        {

        }
    }
}

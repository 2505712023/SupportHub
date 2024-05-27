using Dominio;
using Presentacion.CustomMessageBoxes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmAgregarEquipo : Form
    {
        private bool esModificacion = false;
        private string codEquipo = string.Empty;

        public frmAgregarEquipo(frmEquipo equipo)
        {

            InitializeComponent();
            llenarProveedor();

        }

        public frmAgregarEquipo(
            string codEquipo,
           string tipoEquipo,
           string marcaEquipo,
           string modeloEquipo,
           int cantidadEquipo,
           string precioEquipo,
           int idProveedor,
           string descripcion)
        {
            InitializeComponent();
            llenarProveedor();
            esModificacion = true;
            gbAddEequipo.Text = "MODIFICAR EQUIPO: " + codEquipo;
            this.codEquipo = codEquipo;
            tboxTipoEquipo.Text = tipoEquipo;
            tboxmarcaEquipo.Text = marcaEquipo;
            tboxmodeloEquipo.Text = modeloEquipo;
            tboxcantidadEquipo.Text = cantidadEquipo.ToString();
            string temporal = "       " + precioEquipo.ToString();
            temporal.Replace("$", "").Replace(",", "");
            maskprecioEquipo.Text = temporal.Substring(temporal.Length - 10);
            comboBproveedor.SelectedValue = idProveedor;
            rtxtDescripcion.Text = descripcion;

        }

        public delegate void updateDelegate(object sender, UpdateEventArgs args);
        public event updateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void actualizarDgvEquipos()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void frmAgregarEquipo_Load(object sender, EventArgs e)
        {
            tboxTipoEquipo.Focus();
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
            try {
                if (string.IsNullOrEmpty(tboxTipoEquipo.Text))
                {
                    CustomMessageBox.Error("Error", "Debe ingresar un tipo de Equipo.");
                }
                else if (string.IsNullOrEmpty(tboxmarcaEquipo.Text))
                {
                    CustomMessageBox.Error("Error", "Debe ingresar una marca de Equipo");
                }
                else if (string.IsNullOrEmpty(tboxmodeloEquipo.Text))
                {
                    CustomMessageBox.Error("Error", "Debe ingresar una modelo de Equipo.");
                }

                else if (Convert.ToInt32(tboxcantidadEquipo.Text) <= 0 )
                {
                    CustomMessageBox.Error("Error", "La cantidad de equipos debe ser mayor a cero.");

                }
                else if (string.IsNullOrEmpty(maskprecioEquipo.Text))
                {
                    CustomMessageBox.Error("Error", "Debe ingresar un precio de Equipo.");
                }
                else if (comboBproveedor.SelectedIndex == -1)
                {
                    CustomMessageBox.Error("Error", "Debe seleccionar un proveedor.");
                }
                else if (string.IsNullOrEmpty(rtxtDescripcion.Text))
                {
                    CustomMessageBox.Error("Error", "Debe ingresar una descripción.");
                }

                else
                {
                    if (!esModificacion)
                    {
                        int registrosAgregados = ModeloEquipo.crearEquipo(
                            tboxTipoEquipo.Text,
                            tboxmarcaEquipo.Text,
                            tboxmodeloEquipo.Text,
                            Convert.ToInt32(tboxcantidadEquipo.Text),
                            Convert.ToDouble(maskprecioEquipo.Text.Replace("$", "")),
                            Convert.ToInt32(comboBproveedor.SelectedValue),
                            rtxtDescripcion.Text
                            );
                        CustomMessageBox.Exito("Registro Exitoso", $"Se guardó {registrosAgregados.ToString()} Equipo Correctamente");
                        actualizarDgvEquipos();
                    }
                    else if (esModificacion)
                    {
                        int registrosModificados = ModeloEquipo.modificarEquipo(
                           codEquipo,
                           tboxTipoEquipo.Text,
                           tboxmarcaEquipo.Text,
                           tboxmodeloEquipo.Text,
                           Convert.ToInt32(tboxcantidadEquipo.Text),
                           Convert.ToDouble(maskprecioEquipo.Text.Replace("$", "")),
                           Convert.ToInt32(comboBproveedor.SelectedValue),
                           rtxtDescripcion.Text
                           );
                        CustomMessageBox.Exito("Modificación Exitosa", $"Se Modificó {registrosModificados} Equipo Correctamente");
                        actualizarDgvEquipos();
                        this.Close();
                    }
                }
            }
            catch (FormatException) {
                CustomMessageBox.Error("Error", "Debe ingresar cantidad o precios validos ");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregarEquipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                BtnGuardar_Click(sender, e);
            }
        }
    }
}

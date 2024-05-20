using Dominio;
using Presentacion.CustomMessageBoxes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmAgregarEquipo : Form
    {
        private bool esModificacion = false;
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
            if (tboxTipoEquipo.Text == null)
            {
                CustomMessageBox.Error("Error", "Debe ingresar un tipo de Equipo");

            }
            else if (tboxmarcaEquipo.Text == null)
            {
                CustomMessageBox.Error("Error", "Debe ingresar una marca de Equipo");

            }
            else if (tboxmodeloEquipo.Text == null)
            {
                CustomMessageBox.Error("Error", "Debe ingresar una modelo de Equipo");
            }
            else if (Convert.ToInt32(tboxcantidadEquipo.Text) == 0 || string.IsNullOrEmpty(tboxcantidadEquipo.Text))
            {

                CustomMessageBox.Error("Error", "La cantidad de equipos debe ser mayor a cero.");
            }
            else if (maskprecioEquipo.Text == null)
            {
                CustomMessageBox.Error("Error", "Debe ingresar un precio de Equipo");
            }
            else if (comboBproveedor.SelectedItem == null)
            {
                CustomMessageBox.Error("Error", "Debe seleccionar un proveedor");
            }
            else if (rtxtDescripcion.Text == null)
            {
                CustomMessageBox.Error("Error", "Debe ingresar una descripción");
            }
            else { 
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

                }
            }

           
            

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

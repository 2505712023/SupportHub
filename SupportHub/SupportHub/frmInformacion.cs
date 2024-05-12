using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun.Cache;
using DataAccess;
using Dominio;
using Presentacion.CustomMessageBoxes;
namespace Presentacion
{
    public partial class frmInformacion : Form
    {
        public frmInformacion()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmInformacion_Load(object sender, EventArgs e)
        {
            cargarDatoUsuario();
            inicializarControlPass();
        }
        private void cargarDatoUsuario()
        {
            lblIdInfo.Text = CacheInicioUsuario.IdUser.ToString();
            lblUser.Text = CacheInicioUsuario.user;
            lblNombreInfo.Text = CacheInicioUsuario.nombreUser;
            lblApellidoInfor.Text = CacheInicioUsuario.apellidoUser;

            txtUsuario.Text = CacheInicioUsuario.user;
            txtNombreUsuario.Text = CacheInicioUsuario.nombreUser;
            txtApellidoUsuario.Text = CacheInicioUsuario.apellidoUser;
            txtNuevaContra.Text = CacheInicioUsuario.password;
            txtContraActual.Text = "";
            txtConfirmarContra.Text = CacheInicioUsuario.password;
        }
        private void inicializarControlPass()
        {

            lblEditar.Text = "Editar";
            txtNuevaContra.Enabled = false;
            txtNuevaContra.UseSystemPasswordChar = true;
            txtConfirmarContra.Enabled = false;
            txtConfirmarContra.UseSystemPasswordChar = true;
            txtContraActual.UseSystemPasswordChar=true;
        }

        private void reset()
        {
            cargarDatoUsuario();
            inicializarControlPass();

        }

        private void linkEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pCambiarcontraseña.Visible = true;
            cargarDatoUsuario();
        }

        private void lblEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblEditar.Text == "Editar")
            {
                lblEditar.Text = "Cancelar";
                txtNuevaContra.Enabled = true;
                txtNuevaContra.Text = "";
                txtConfirmarContra.Enabled = true;
                txtConfirmarContra.Text = "";
               
            }
            else if (lblEditar.Text == "Cancelar")
            {
                reset();
            }
        }

        private void btnGuardarContraseña_Click(object sender, EventArgs e)
        {
            string contraseñaActual = txtContraActual.Text;
            string nuevaContraseña = txtNuevaContra.Text;
            string confirmarContraseña = txtConfirmarContra.Text;

            if (nuevaContraseña.Length >= 5)
            {
                if (nuevaContraseña == confirmarContraseña)
                {
                    if (contraseñaActual == CacheInicioUsuario.password)
                    {
                        ModeloUsuario modeloUsuario = new ModeloUsuario(CacheInicioUsuario.IdUser, nuevaContraseña);
                        string resultado = modeloUsuario.EditarPerfil();

                        if (resultado.Contains("error"))
                        {
                            ErrorMessageBox error = new("Error", resultado);
                        }
                        else
                        {
                            ExitoMessageBox exito = new("Registro exitoso", resultado);
                        }

                        ResetearFormulario();
                        pCambiarcontraseña.Visible = false;
                    }
                    else
                    {
                        ErrorMessageBox error = new("Error", "Contraseña actual incorrecta.");
                    }
                }
                else
                {
                    ErrorMessageBox error = new("Error", "La contraseña ingresada no coincide con la confirmación de contraseña.");
                }
            }
            else
            {
                ErrorMessageBox error = new("Error", "La contraseña debe tener al menos 5 caracteres.");
            }


        }
        private void ResetearFormulario()
        {
            txtContraActual.Text = "";
            txtNuevaContra.Text = "";
            txtConfirmarContra.Text = "";
        }
        private void btnCancelaEmpleado_Click(object sender, EventArgs e)
        {
            pCambiarcontraseña.Visible=false;
            reset();
        }
    }
}

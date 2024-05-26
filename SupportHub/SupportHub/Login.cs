using Dominio;
using Presentacion;
using Presentacion.CustomMessageBoxes;
using System.Windows.Forms;
namespace SupportHub
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtContraseña.KeyPress += new KeyPressEventHandler(txtContraseña_KeyPress);
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == (char)Keys.Enter)
            {
        
                btnAcceder_Click(sender, e);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnAcceder.Enabled = false;
            btnAcceder.Focus();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.FromArgb(31, 35, 40);
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.FromArgb(31, 35, 40);
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.FromArgb(31, 35, 40);
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.FromArgb(31, 35, 40);
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO" && txtContraseña.Text != "CONTRASEÑA" && txtUsuario.Text != "" && txtContraseña.Text != "")
            {
                
                DataAccess.UsuarioDato usuarioDato = new DataAccess.UsuarioDato();
                string user = txtUsuario.Text;
                string pass = txtContraseña.Text;
                string mensaje = usuarioDato.Login(user, pass);

                if (mensaje == "Inicio de sesión exitoso")
                {
                    this.Hide();
                    //frmCarga formLogin = new frmCarga();
                    //formLogin.ShowDialog();
                    frmIndex inicio = new frmIndex();
                    inicio.Show();
                    inicio.FormClosed += CerrarSeccion;
                }
               
                else
                {
                    pictureError.Visible = true;
                    lblMensajeError.Text = mensaje;
                    lblMensajeError.Visible = true;
                    txtUsuario.Focus();

                    if (mensaje == "Usuario o contraseña incorrecto" || mensaje == "El usuario está inactivo")
                    {
                        
                    }
                    else
                    {
                        pictureError.Visible = false;
                        lblMensajeError.Visible = false;
                        CustomMessageBox.Error("Error de conexión", "El sistema no tiene conexión con el servidor. Favor notifique el impase al administrador."); 
                        txtUsuario.Focus();
                    }
                }
            
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO" || txtContraseña.Text == "CONTRASEÑA" || txtUsuario.Text == "" || txtContraseña.Text == "")
            {   pictureError.Visible = false;
                lblMensajeError.Visible = false;
                btnAcceder.Enabled = false;
            }
            else
            {
                btnAcceder.Enabled = true;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO" || txtContraseña.Text == "CONTRASEÑA" || txtUsuario.Text == "" || txtContraseña.Text == "")
            {
                pictureError.Visible =false;
                lblMensajeError.Visible = false;
                btnAcceder.Enabled = false;
            }
            else
            {
                btnAcceder.Enabled = true;
            }
        }

        private void CerrarSeccion(object sender, FormClosedEventArgs e) 
        { 
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            lblMensajeError.Visible=false;   
            this.Show();
            txtUsuario.Focus();
        }
    }
}

using Dominio;
using Presentacion;

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
                // Simula un clic en el botón Acceder cuando se presiona Enter en el campo de contraseña
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
                ModeloUsuario usuario = new ModeloUsuario();
                var LoginValido = usuario.LoginUsuario(txtUsuario.Text, txtContraseña.Text);
                if (LoginValido == true) {
                    this.Hide();
                    frmCarga formLogin = new frmCarga();
                    formLogin.ShowDialog();
                    frmIndex inicio = new frmIndex();
                    inicio.Show();
                    inicio.FormClosed += CerrarSeccion;
                }
                else
                {
                    lblMensajeError.Text = "             " +"USUARIO O CONTRASEÑA INCORECTO";
                    lblMensajeError.Visible = true;
                    txtUsuario.Focus();
                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO" || txtContraseña.Text == "CONTRASEÑA" || txtUsuario.Text == "" || txtContraseña.Text == "")
            {
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
                lblMensajeError.Visible = false;
                btnAcceder.Enabled = false;
            }
            else
            {
                btnAcceder.Enabled = true;
            }
        }

        private void CerrarSeccion(object sender, FormClosedEventArgs e) { 
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            lblMensajeError.Visible=false;   
            this.Show();
        }
    }
}

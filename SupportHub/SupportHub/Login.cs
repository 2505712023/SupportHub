using Dominio;
using Presentacion;

namespace SupportHub
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtContrase�a.KeyPress += new KeyPressEventHandler(txtContrase�a_KeyPress);
          
           
        }

        private void txtContrase�a_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Simula un clic en el bot�n Acceder cuando se presiona Enter en el campo de contrase�a
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

        private void txtContrase�a_Enter(object sender, EventArgs e)
        {
            if (txtContrase�a.Text == "CONTRASE�A")
            {
                txtContrase�a.Text = "";
                txtContrase�a.ForeColor = Color.FromArgb(31, 35, 40);
                txtContrase�a.UseSystemPasswordChar = true;

            }
        }

        private void txtContrase�a_Leave(object sender, EventArgs e)
        {
            if (txtContrase�a.Text == "")
            {
                txtContrase�a.Text = "CONTRASE�A";
                txtContrase�a.ForeColor = Color.FromArgb(31, 35, 40);
                txtContrase�a.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO" && txtContrase�a.Text != "CONTRASE�A" && txtUsuario.Text != "" && txtContrase�a.Text != "")
            { 
                ModeloUsuario usuario = new ModeloUsuario();
                var LoginValido = usuario.LoginUsuario(txtUsuario.Text, txtContrase�a.Text);
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
                    lblMensajeError.Text = "             " +"USUARIO O CONTRASE�A INCORECTO";
                    lblMensajeError.Visible = true;
                    txtUsuario.Focus();
                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO" || txtContrase�a.Text == "CONTRASE�A" || txtUsuario.Text == "" || txtContrase�a.Text == "")
            {
                lblMensajeError.Visible = false;
                btnAcceder.Enabled = false;
            }
            else
            {
                btnAcceder.Enabled = true;
            }
        }

        private void txtContrase�a_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO" || txtContrase�a.Text == "CONTRASE�A" || txtUsuario.Text == "" || txtContrase�a.Text == "")
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
            txtContrase�a.Text = "CONTRASE�A";
            txtContrase�a.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            lblMensajeError.Visible=false;   
            this.Show();
        }
    }
}

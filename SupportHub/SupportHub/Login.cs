using Dominio;

namespace SupportHub
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "USUARIO" || txtContraseña.Text == "CONTRASEÑA" || txtUsuario.Text == "" || txtContraseña.Text == "")
            {
                // Si contienen alguno de estos valores, deshabilitar el botón
                btnAcceder.Enabled = false;
            }
            else
            {
                // Si no contienen ninguno de estos valores, habilitar el botón
                btnAcceder.Enabled = true;
            }
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
        //    if (txtUsuario.Text != "USUARIO")
        //    {
        //        if (txtContraseña.Text != "CONTRASEÑA") { }
        //        else { MessageError("Ingrese Contraseña"); }

        //    }
        //    else
        //    {
        //        MessageError("Ingrese usuario");
        //    }

        //}
        //public void MessageError(string mensaje)
        //{
        //    lblMensajeError.Text = mensaje;
        //    lblMensajeError.Visible = true;
        }

        
    }
}

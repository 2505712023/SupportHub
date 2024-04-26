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

            if (txtUsuario.Text == "USUARIO" || txtContrase�a.Text == "CONTRASE�A" || txtUsuario.Text == "" || txtContrase�a.Text == "")
            {
                // Si contienen alguno de estos valores, deshabilitar el bot�n
                btnAcceder.Enabled = false;
            }
            else
            {
                // Si no contienen ninguno de estos valores, habilitar el bot�n
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
        //    if (txtUsuario.Text != "USUARIO")
        //    {
        //        if (txtContrase�a.Text != "CONTRASE�A") { }
        //        else { MessageError("Ingrese Contrase�a"); }

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

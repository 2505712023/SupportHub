using Dominio;
using Presentacion;

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
            btnAcceder.Enabled = false;



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
                //ModeloUsuario usuario = new ModeloUsuario();
                //var LoginValido = usuario.LoginUsuario(txtUsuario.Text,txtContraseña.Text);


                //esto solo es para carga el form sin credendenciales
                foreach (Form FormSp in this.MdiChildren)
                {
                    FormSp.Close();
                }


                frmCarga formLogin = new frmCarga();


                this.Hide();
                formLogin.ShowDialog();


                this.Show();
                frmIndex inicio = new frmIndex();


                this.Hide();
                inicio.ShowDialog();
                // aqui finaliza
            }
            else
            {
                // Mostrar un mensaje de error utilizando ErrorProvider
                errorAcceso.SetError(btnAcceder, "Ingrese un usuario y contraseña válidos.");
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO" || txtContraseña.Text == "CONTRASEÑA" || txtUsuario.Text == "" || txtContraseña.Text == "")
            {
         
                btnAcceder.Enabled = false;
            }
            else
            {
             
                btnAcceder.Enabled = true;

                
                errorAcceso.SetError(btnAcceder, "hola");
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO" || txtContraseña.Text == "CONTRASEÑA" || txtUsuario.Text == "" || txtContraseña.Text == "")
            {
              
                btnAcceder.Enabled = false;
            }
            else
            {
                
                btnAcceder.Enabled = true;

              
            }
        }
    }
}

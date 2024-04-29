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
                //ModeloUsuario usuario = new ModeloUsuario();
                //var LoginValido = usuario.LoginUsuario(txtUsuario.Text,txtContrase�a.Text);


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
                errorAcceso.SetError(btnAcceder, "Ingrese un usuario y contrase�a v�lidos.");
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO" || txtContrase�a.Text == "CONTRASE�A" || txtUsuario.Text == "" || txtContrase�a.Text == "")
            {
         
                btnAcceder.Enabled = false;
            }
            else
            {
             
                btnAcceder.Enabled = true;

                
                errorAcceso.SetError(btnAcceder, "hola");
            }
        }

        private void txtContrase�a_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO" || txtContrase�a.Text == "CONTRASE�A" || txtUsuario.Text == "" || txtContrase�a.Text == "")
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

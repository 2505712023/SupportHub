using Comun.Cache;
using DataAccess;
using System.Data.SqlClient;
namespace Presentacion
{
    public partial class frmCarga : Form
    {
        
        public frmCarga()
        {
            InitializeComponent();
           
        }

        private void TimerCarga1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            cpbCarga.Value += 1;
            cpbCarga.Text = cpbCarga.Value.ToString();
            if (cpbCarga.Value == 100)
            {
                TimerCarga1.Stop();
                TimerCarga2.Start();
            }
        }

        private void TimerCarga2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                TimerCarga2.Stop();
                this.Close();
            }
        }

        private void frmCarga_Load(object sender, EventArgs e)
        {
            lblNombreApellido.Text = CacheInicioUsuario.nombreUser + "  " + CacheInicioUsuario.apellidoUser;
            this.Opacity = 0.0;

            cpbCarga.Value = 0;
            cpbCarga.Minimum = 0;
            cpbCarga.Maximum = 100;
            //Iniciamos el temporizador 1.
            TimerCarga1.Start();
        }

         
       

        }
    }



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
using Dominio;
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
        }
        private void cargarDatoUsuario() {
            lblIdInfo.Text = CacheInicioUsuario.IdUser.ToString();
            lblUser.Text= CacheInicioUsuario.user;
            lblNombreInfo.Text = CacheInicioUsuario.nombreUser;
            lblApellidoInfor.Text = CacheInicioUsuario.apellidoUser;


        }
    }
}

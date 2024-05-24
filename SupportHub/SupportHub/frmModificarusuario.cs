using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Presentacion.frmModificarEmpleado;

namespace Presentacion
{
    public partial class frmModificarUsuario : Form
    {
        ModeloUsuario modeloUsuario = new ModeloUsuario();
        public string Operacion = "Insertar";
        public string codEmpleado;
        public frmModificarUsuario(frmUsuario usuario)
        {
            InitializeComponent();
        }


        private void frmModificarUsuario_Load(object sender, EventArgs e)
        {



        }

        private void gbAddUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void cbxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

           
        
        }
        public event ModificarDelegate UpdateEventHandler;
        public class ModificarEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void Actualizar()
        {
            ModificarEventArgs args = new ModificarEventArgs();
            
        }

        private void btnGuardarUpdate_Click(object sender, EventArgs e)
       {
            this.Close();
        }

       



    }
       
 
    }

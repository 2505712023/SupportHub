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
using static Presentacion.frmAgregarEntrega;

namespace Presentacion
{
    public partial class frmDevolucionEntrega : Form
    {
        public frmDevolucionEntrega(string codEntrega)
        {
            InitializeComponent();
            this.tboxCodigoEntrega.Text = codEntrega;
        }

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        public delegate void UpdateDelagate(object sender, UpdateEventArgs args);
        public event UpdateDelagate UpdateEventHandler;
        public event UpdateDelagate CloseEventHandler;

        protected void actualizardgvEntregas()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        protected void habilitardgvEntregas()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            CloseEventHandler.Invoke(this, args);
        }

        private void frmDevolucionEntrega_Load(object sender, EventArgs e)
        {
            dtpickerFechaDevolucion.Format = DateTimePickerFormat.Custom;
            dtpickerFechaDevolucion.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtpickerFechaDevolucion.ShowUpDown = false;
            dtpickerFechaDevolucion.Value = DateTime.Now;
        }

        private void btnCancelarDevolucion_Click(object sender, EventArgs e)
        {
            habilitardgvEntregas();
            this.Close();
        }

        private void btnGuardarDevolucion_Click(object sender, EventArgs e)
        {
            string asignarDevolucion = ModeloEntrega.asignarFechaDevolucion(dtpickerFechaDevolucion.Text, tboxCodigoEntrega.Text);
            MessageBox.Show(asignarDevolucion, "Devolución exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            actualizardgvEntregas();
            habilitardgvEntregas();
            this.Close();
        }

        public void eliminarFechaDevolucion()
        {
            string asignarDevolucion = ModeloEntrega.asignarFechaDevolucion("ELIMINAR", tboxCodigoEntrega.Text);
            MessageBox.Show("Se eliminó la fecha de devolución exitosamente", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            actualizardgvEntregas();
        }
    }
}

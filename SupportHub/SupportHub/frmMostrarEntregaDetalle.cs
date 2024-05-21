using Comun.Cache;
using Dominio;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml;
using Paragraph = iTextSharp.text.Paragraph;
using Document = iTextSharp.text.Document;
using System.Diagnostics;
//------------


namespace Presentacion
{

    public partial class frmMostrarEntregaDetalle : Form
    {
        int pagina = 0;
        private bool esModificacion = false;
        private int cantidadEntregaAnterior = 0;
        private string codEntrega = string.Empty;

        public frmMostrarEntregaDetalle()
        {
            InitializeComponent();
            dtpickerFechaEntrega.Format = DateTimePickerFormat.Custom;
            dtpickerFechaEntrega.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtpickerFechaEntrega.ShowUpDown = false;
            llenarTiposEntrega();
            llenarEmpleados();
            llenarEquipos();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmMostrarEntregaDetalle_Load(object sender, EventArgs e)
        {
            if (!esModificacion)
            {
                dtpickerFechaEntrega.Value = DateTime.Now;
                cboxTipoEntrega.SelectedItem = 0;
                cboxEmpleadoRecibe.SelectedItem = null;
                cboxEquipo.SelectedItem = null;
                tboxCantidadDisponible.Text = "0";
                tboxEmpleadoEntrega.Text = CacheInicioUsuario.empleado;
            }
            else
            {
                gbAddEntrega.Text = "MODIFICAR ENTREGA: " + codEntrega;
                obtenerCantidadDisponible();
            }
        }

        public frmMostrarEntregaDetalle(
                string codEntrega,
                bool esModificacion,
                int cantidadEntregaAnterior,
                int idTipoEntrega,
                string fechaEntrega,
                string empleadoEntrega,
                int idEmpleadoRecibe,
                int idEquipo,
                int cantidadEntrega,
                string observacion = ""
                )
        {
            InitializeComponent();
            dtpickerFechaEntrega.Format = DateTimePickerFormat.Custom;
            dtpickerFechaEntrega.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtpickerFechaEntrega.ShowUpDown = false;
            llenarTiposEntrega();
            llenarEmpleados();
            llenarEquipos();

            this.codEntrega = codEntrega;
            this.esModificacion = esModificacion;
            this.cantidadEntregaAnterior = cantidadEntregaAnterior;
            this.cboxTipoEntrega.SelectedValue = idTipoEntrega;
            this.dtpickerFechaEntrega.Text = fechaEntrega;
            this.tboxEmpleadoEntrega.Text = empleadoEntrega;
            this.cboxEmpleadoRecibe.SelectedValue = idEmpleadoRecibe;
            this.cboxEquipo.SelectedValue = idEquipo;
            this.tboxCantidadEntrega.Text = cantidadEntrega.ToString();
            this.rtxtObservacionEntrega.Text = observacion;
        }

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        public delegate void UpdateDelagate(object sender, UpdateEventArgs args);
        public event UpdateDelagate UpdateEventHandler;
        public event UpdateDelagate CloseEventHandler;

        protected void habilitardgvEntregas()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            CloseEventHandler.Invoke(this, args);
        }

        private void ibtnCancelarEntrega_Click(object sender, EventArgs e)
        {
            habilitardgvEntregas();
            this.Close();
        }

        private void llenarEmpleados()
        {
            cboxEmpleadoRecibe.DataSource = ModeloEntrega.obtenerEmpleados();
            cboxEmpleadoRecibe.ValueMember = "idEmpleado";
            cboxEmpleadoRecibe.DisplayMember = "Empleado";
        }

        private void llenarEquipos()
        {
            cboxEquipo.DataSource = ModeloEntrega.obtenerEquipos();
            cboxEquipo.ValueMember = "idEquipo";
            cboxEquipo.DisplayMember = "Equipo";
        }

        private void llenarTiposEntrega()
        {
            cboxTipoEntrega.DataSource = ModeloEntrega.obtenerTiposEntrega();
            cboxTipoEntrega.ValueMember = "idTipoEntrega";
            cboxTipoEntrega.DisplayMember = "nombreTipoEntrega";
        }

        private void obtenerCantidadDisponible()
        {
            if (cboxEquipo.SelectedValue != null)
            {
                int cantidadDisponible = ModeloEntrega.cantidadDisponibleEquipo(Convert.ToInt32(cboxEquipo.SelectedValue));
                tboxCantidadDisponible.Text = (cantidadDisponible + cantidadEntregaAnterior).ToString();
            }
            else
            {
                tboxCantidadDisponible.Text = "0";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbAddEntrega_Enter(object sender, EventArgs e)
        {

        }

        private void gbAddEntrega_Enter_1(object sender, EventArgs e)
        {

        }

        private void cboxTipoEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialogGuardar = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialogGuardar.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialogGuardar.SelectedPath;
                Document doc = new Document(PageSize.LETTER);
                try
                {
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(folderName + @"\PDF_SupportHub.pdf", FileMode.Create));

                    doc.AddTitle("PDF_SupportHub");
                    doc.AddCreator("SupporHub");
                    doc.Open();

                    iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    doc.Add(new Paragraph("REPORTE DE ENTREGA EQUIPO", _standardFont));
                    doc.Add(Chunk.NEWLINE);


                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance("C:\\Users\\HP\\Desktop\\TAREA C #\\C#\\SupportHub-removebg-preview.png");
                    img.ScaleToFit(150f, 150f);
                    img.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                    doc.Add(img);

                    PdfPTable tblPrueba = new PdfPTable(3);
                    tblPrueba.WidthPercentage = 85;


                    PdfPCell clNombre = new PdfPCell(new Phrase("Empleado Entrega", _standardFont));
                    clNombre.BorderWidth = 0;
                    clNombre.BorderWidthBottom = 0.5f;
                    clNombre.BackgroundColor = BaseColor.LIGHT_GRAY;

                    PdfPCell clApellido = new PdfPCell(new Phrase("Empledo Recibe", _standardFont));
                    clApellido.BorderWidth = 0;
                    clApellido.BorderWidthBottom = 0.5f;
                    clApellido.BackgroundColor = BaseColor.LIGHT_GRAY;

                    PdfPCell clPais = new PdfPCell(new Phrase("Fecha", _standardFont));
                    clPais.BorderWidth = 0;
                    clPais.BorderWidthBottom = 0.5f;
                    clPais.BackgroundColor = BaseColor.LIGHT_GRAY;

                    tblPrueba.AddCell(clNombre);
                    tblPrueba.AddCell(clApellido);
                    tblPrueba.AddCell(clPais);

                    clNombre = new PdfPCell(new Phrase(tboxEmpleadoEntrega.Text, _standardFont));
                    clNombre.BorderWidth = 0;

                    clApellido = new PdfPCell(new Phrase(cboxEmpleadoRecibe.SelectedValue.ToString(), _standardFont));
                    clApellido.BorderWidth = 0;

                    clPais = new PdfPCell(new Phrase(dtpickerFechaEntrega.Text, _standardFont));
                    clPais.BorderWidth = 0;

                    tblPrueba.AddCell(clNombre);
                    tblPrueba.AddCell(clApellido);
                    tblPrueba.AddCell(clPais);

                    doc.Add(tblPrueba);
                    doc.Add(Chunk.NEWLINE);


                    _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                    PdfContentByte canvas = writer.DirectContent;
                    ColumnText ct = new ColumnText(canvas);

                    ct.SetSimpleColumn(150, 150, 35, 10);


                    ct.AddElement(new Paragraph("Observaciones:", _standardFont));
                    doc.Add(new Paragraph(rtxtObservacionEntrega.Text, _standardFont));
                    ct.Go();
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    doc.Add(new Paragraph("Id del equipo:", _standardFont));

                    _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    doc.Add(new Paragraph(cboxEquipo.SelectedValue.ToString(), _standardFont));
                    doc.Add(Chunk.NEWLINE);

                    _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    doc.Add(new Paragraph("Codigo Entrega:", _standardFont));

                    _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    doc.Add(new Paragraph(codEntrega, _standardFont));
                    doc.Add(Chunk.NEWLINE);


                    MessageBox.Show("Documento creado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear el documento PDF: " + ex.Message);
                }
                finally
                {
                    doc.Close();
                }
            }
        }
    }

}

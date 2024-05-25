using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentacion.CustomMessageBoxes;

namespace Presentacion.ReportesPDF
{
    public class ReporteDetalleEntrega
    {
        public static void GenerarReporte(
                string codEntrega,
                string empleadoEntrega,
                string empleadoRecibe,
                string cantidadEntrega,
                string tipoEquipo,
                string marcaEquipo,
                string modeloEquipo,
                string observacionEntrega
            )
        {
            FolderBrowserDialog folderBrowserDialogGuardar = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialogGuardar.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialogGuardar.SelectedPath;
                string ruta = folderName + @"\Entrega_SupportHub_" + codEntrega + @".pdf";
                Document doc = new Document(PageSize.LETTER);
                try
                {
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));

                    doc.AddTitle("PDF_SupportHub");
                    doc.AddCreator("SupporHub");
                    doc.Open();

                    iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(@"..\..\..\..\logo_para_reporte.jpg");
                    img.ScaleToFit(150f, 150f);
                    img.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                    doc.Add(img);

                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);

                    _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    Paragraph Direccion = new Paragraph("Torre Futura, 87 Avenida Norte y Calle El Mirador, \nColonia Escalón, Oficina 555 San Salvador, El Salvador.", _standardFont);
                    Direccion.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(Direccion);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);

                    _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    doc.Add(new Paragraph("Codigo Entrega: " + codEntrega, _standardFont));
                    doc.Add(Chunk.NEWLINE);

                    _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    doc.Add(new Paragraph("IT Encargado: " + empleadoEntrega, _standardFont));
                    doc.Add(Chunk.NEWLINE);

                    _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    doc.Add(new Paragraph("Usuario Entrega: " + empleadoRecibe, _standardFont));
                    doc.Add(Chunk.NEWLINE);

                    PdfPTable tblPrueba = new PdfPTable(5);
                    tblPrueba.WidthPercentage = 85;

                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);

                    PdfPCell clNombre = new PdfPCell(new Phrase("Código\nEquipo", _standardFont));
                    clNombre.BorderWidth = 0;
                    clNombre.BorderWidthBottom = 0.5f;
                    clNombre.BackgroundColor = BaseColor.LIGHT_GRAY;

                    PdfPCell clApellido = new PdfPCell(new Phrase("Cantidad", _standardFont));
                    clApellido.BorderWidth = 0;
                    clApellido.BorderWidthBottom = 0.5f;
                    clApellido.BackgroundColor = BaseColor.LIGHT_GRAY;

                    PdfPCell clMarca = new PdfPCell(new Phrase("Marca", _standardFont));
                    clMarca.BorderWidth = 0;
                    clMarca.BorderWidthBottom = 0.5f;
                    clMarca.BackgroundColor = BaseColor.LIGHT_GRAY;

                    PdfPCell clModelo = new PdfPCell(new Phrase("Modelo", _standardFont));
                    clModelo.BorderWidth = 0;
                    clModelo.BorderWidthBottom = 0.5f;
                    clModelo.BackgroundColor = BaseColor.LIGHT_GRAY;

                    PdfPCell clEquipo = new PdfPCell(new Phrase("Tipo\nEquipo", _standardFont));
                    clEquipo.BorderWidth = 0;
                    clEquipo.BorderWidthBottom = 0.5f;
                    clEquipo.BackgroundColor = BaseColor.LIGHT_GRAY;

                    tblPrueba.AddCell(clNombre);
                    tblPrueba.AddCell(clApellido);
                    tblPrueba.AddCell(clMarca);
                    tblPrueba.AddCell(clModelo);
                    tblPrueba.AddCell(clEquipo);

                    clNombre = new PdfPCell(new Phrase(codEntrega, _standardFont));
                    clNombre.BorderWidth = 0;

                    clApellido = new PdfPCell(new Phrase(cantidadEntrega, _standardFont));
                    clApellido.BorderWidth = 0;

                    clMarca = new PdfPCell(new Phrase(marcaEquipo, _standardFont));
                    clMarca.BorderWidth = 0;

                    clModelo = new PdfPCell(new Phrase(modeloEquipo, _standardFont));
                    clModelo.BorderWidth = 0;

                    clEquipo = new PdfPCell(new Phrase(tipoEquipo, _standardFont));
                    clEquipo.BorderWidth = 0;

                    tblPrueba.AddCell(clNombre);
                    tblPrueba.AddCell(clApellido);
                    tblPrueba.AddCell(clMarca);
                    tblPrueba.AddCell(clModelo);
                    tblPrueba.AddCell(clEquipo);

                    doc.Add(tblPrueba);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);

                    _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    doc.Add(new Paragraph("Observaciones: " + observacionEntrega, _standardFont));
                    doc.Add(new Paragraph("____________________________________________________________________________________________ ", _standardFont));
                    doc.Add(new Paragraph("____________________________________________________________________________________________ ", _standardFont));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    doc.Add(new Paragraph("F.IT: _____________________________                                 F.Empleado: ___________________________", _standardFont));

                    CustomMessageBox.Exito("Documento creado", "Documento creado exitosamente");
                    try
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                        {
                            FileName = ruta,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        CustomMessageBox.Error("Error al generar", "No se pudo abrir el archivo PDF.\nError: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Error("Error al generar", "No se pudo abrir el archivo PDF.\nError: " + ex.Message);
                }
                finally
                {
                    doc.Close();
                }
            }
        }
    }
}

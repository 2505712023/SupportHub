using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmAcerca : Form
    {
        public frmAcerca()
        {
            InitializeComponent();
        }

        private void rtbAcerca_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAcerca_Load(object sender, EventArgs e)
        {

            

            rtbAcerca.Clear();

            rtbAcerca.SelectionFont = new Font("Arial", 20, FontStyle.Bold); 
            rtbAcerca.SelectionAlignment = HorizontalAlignment.Center;
            rtbAcerca.AppendText("SUPPORTHUB\n\n");


            rtbAcerca.SelectionFont = new Font("Arial", 12); 
            rtbAcerca.SelectionAlignment = HorizontalAlignment.Left; 

            
            rtbAcerca.AppendText("OBJETIVOS DE PROYECTO\n\n");

            rtbAcerca.SelectionFont = new Font("Arial", 10, FontStyle.Bold); 
            rtbAcerca.AppendText("Objetivo General:\n");
            rtbAcerca.SelectionFont = new Font("Arial", 10); 
            rtbAcerca.AppendText("Desarrollar e implementar un sistema de gestión de activos informáticos para la empresa con el fin de mejorar la eficiencia en el seguimiento y control de los equipos asignados a los empleados.\n\n");

          
            rtbAcerca.SelectionFont = new Font("Arial", 10, FontStyle.Bold);
            rtbAcerca.AppendText("Objetivos específicos:\n");
            rtbAcerca.SelectionFont = new Font("Arial", 10);
            rtbAcerca.AppendText("• Crear una base de datos centralizada donde se registren todos los equipos informáticos y los empleados que los utilizan.\n");           
            rtbAcerca.AppendText("• Permitir un seguimiento eficiente de todos los equipos informáticos, incluyendo computadoras, impresoras, celulares, cables de red, etc., para saber quién los tiene asignados en un momento dado.\n");
            rtbAcerca.AppendText("• Mantener un inventario actualizado de todos los equipos informáticos disponibles, incluyendo detalles como marca, modelo, número de serie, fecha de adquisición y estado de disponibilidad.\n");
            rtbAcerca.AppendText("• Contribuir a una mejor gestión de activos informáticos, promoviendo la transparencia en el uso de los equipos y facilitando la toma de decisiones relacionadas con la adquisición y asignación de recursos.\n");
            rtbAcerca.AppendText("• Controlar los Proveedores de Equipos: Mantener una lista actualizada de los proveedores de equipos informáticos y sus detalles de contacto, para facilitar la gestión de compras.\n\n");

           
            rtbAcerca.SelectionFont = new Font("Arial", 10, FontStyle.Bold);
            rtbAcerca.AppendText("Definición del Proyecto:\n");
            rtbAcerca.SelectionFont = new Font("Arial", 10);
            rtbAcerca.AppendText("SupportHub es una herramienta diseñada para el departamento de informática de la empresa, con el propósito de llevar un control exhaustivo de los equipos informáticos y su asignación a los empleados. Permite registrar la información detallada de cada equipo, incluyendo datos como marca, modelo, número de serie, fecha de adquisición, etc. Asimismo, facilita el seguimiento de los equipos asignados a través de diferentes modalidades, ya sea un uso indefinido o un préstamo temporal a un empleado específico.\n\n");

            
            rtbAcerca.SelectionFont = new Font("Arial", 10, FontStyle.Bold);
            rtbAcerca.AppendText("Justificación del Proyecto:\n");
            rtbAcerca.SelectionFont = new Font("Arial", 10);
            rtbAcerca.AppendText("Inventario de equipos tecnológicos en un departamento empresarial proporciona beneficios como la organización y seguimiento eficiente de los activos, la optimización de recursos al identificar equipos subutilizados, la prevención de pérdidas y robos mediante un control detallado, el cumplimiento de normativas legales y regulatorias, la toma de decisiones informadas basadas en datos precisos, y la mejora de la eficiencia operativa al reducir el tiempo dedicado a tareas manuales, todo estos activos se tendrá el control detallado de las entregas o préstamos.\n\n");

            
            rtbAcerca.SelectionFont = new Font("Arial", 10, FontStyle.Bold);
            rtbAcerca.AppendText("ELABORADO POR:\n");
            rtbAcerca.SelectionFont = new Font("Arial", 10);
            rtbAcerca.AppendText("» ALFONSO ISAÍ ÁLVAREZ FRANCO 2512242023.\n");
            rtbAcerca.AppendText("» CARLOS ENRIQUE SURA RENDEROS 2505712023.\n");
            rtbAcerca.AppendText("» GUILLERMO GABRIEL CASTRO LÓPEZ 2501602023.\n");
            rtbAcerca.AppendText("» CARLOS FRANCISCO MELENDEZ GUEVARA 2512532023.\n");
            rtbAcerca.AppendText("» VANESSA ARELY GUEVARA LAZO 2511732023.\n");
            rtbAcerca.AppendText("» ESTRELLA NAARA PALENCIA MONGE 2508302023.\n");
            rtbAcerca.AppendText("» KEVIN ERNESTO CORTEZ CAÑAS 2537132023.\n\n\n\n\n\n");
            Version version = Assembly.GetExecutingAssembly().GetName().Version;

            rtbAcerca.SelectionFont = new Font("Arial", 10, FontStyle.Bold);
            rtbAcerca.AppendText($"Versión: {version}\n\n");
            rtbAcerca.SelectionFont = new Font("Arial", 19, FontStyle.Bold);
            rtbAcerca.AppendText("® Derecho reservados\n");
            rtbAcerca.SelectAll();
            rtbAcerca.SelectionAlignment = HorizontalAlignment.Center;
            rtbAcerca.SelectionLength = 0;
        }
    }
}

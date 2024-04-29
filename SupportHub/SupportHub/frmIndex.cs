using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using Color = System.Drawing.Color;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Presentacion
{
    public partial class frmIndex : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public frmIndex()
        {
            InitializeComponent();


            this.WindowState = FormWindowState.Maximized;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pIzquierdoIndex.Controls.Add(leftBorderBtn);



            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            hideSubMenu();

        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void hideSubMenu()
        {
            pSubMenu.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(6, 41, 107);//isai
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                btnIconoFrmActual.IconChar = currentBtn.IconChar;
                btnIconoFrmActual.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(5, 23, 59);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            btnIconoFrmActual.IconChar = IconChar.HouseChimneyWindow;
            btnIconoFrmActual.IconColor = Color.FromArgb(128, 0, 128);
            lblIconoFrmActual.Text = "HOME";

        }


        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pDesktop.Controls.Add(childForm);
            pDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblIconoFrmActual.Text = childForm.Text;

        }







        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmEmpleado());
            lblIconoFrmActual.Text = "EMPLEADO";
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new frmEntrega());
            lblIconoFrmActual.Text = "ENTREGA";
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new frmProveedor());
            lblIconoFrmActual.Text = "PROVEEDOR";
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new frmEquipo());
            lblIconoFrmActual.Text = "EQUIPO";
        }

        private void btnDetalleEntrega_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new frmDetalleEntrega());
            lblIconoFrmActual.Text = "DETALLE ENTREGA";
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new frmUsuario());
            lblIconoFrmActual.Text = "USUARIO";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            Reset();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMiximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void subMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(pSubMenu);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            pSubMenu.Visible = false;
            OpenChildForm(new frmAcerca());
            lblIconoFrmActual.Text = "ACERCA DE";
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            pSubMenu.Visible = false;
            OpenChildForm(new frmInformacion());
            lblIconoFrmActual.Text = "INFORMACIÓN";
        }

        private void timerIndex_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            timerIndex.Enabled = true;
        }

        private void btnCerrarSeccion_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es");
      


            if (MostrarDialogoPersonalizado("¿Está seguro que desea cerrar la aplicación?", "Advertencia") == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private DialogResult MostrarDialogoPersonalizado(string mensaje, string titulo)
        {
            DialogResult result = DialogResult.No;
            Form dialogo = new Form();
            dialogo.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialogo.StartPosition = FormStartPosition.CenterScreen;
            dialogo.Size = new Size(300, 150);
            dialogo.Text = titulo;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = SystemIcons.Warning.ToBitmap(); // Icono de advertencia
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

            Label lblMensaje = new Label();
            lblMensaje.Text = mensaje;
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            lblMensaje.AutoSize = true;

            Button btnSi = new Button();
            btnSi.Text = "Sí";
            btnSi.DialogResult = DialogResult.Yes;

            Button btnNo = new Button();
            btnNo.Text = "No";
            btnNo.DialogResult = DialogResult.No;

            FlowLayoutPanel panelBotones = new FlowLayoutPanel();
            panelBotones.FlowDirection = FlowDirection.LeftToRight;
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.AutoSize = true;
            panelBotones.Controls.Add(btnSi);
            panelBotones.Controls.Add(btnNo);

            FlowLayoutPanel panelContenido = new FlowLayoutPanel();
            panelContenido.FlowDirection = FlowDirection.TopDown;
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Width = 280; // Ancho fijo para el panel de contenido
            panelContenido.Controls.Add(pictureBox);
            panelContenido.Controls.Add(lblMensaje);

            dialogo.Controls.Add(panelContenido);
            dialogo.Controls.Add(panelBotones);

            dialogo.AcceptButton = btnSi;
            dialogo.CancelButton = btnNo;

            result = dialogo.ShowDialog();
            dialogo.Dispose();
            return result;
        }

    }
}

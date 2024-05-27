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
using Comun.Cache;
using Presentacion.CustomMessageBoxes;

namespace Presentacion
{
    public partial class frmIndex : Form
    {
        private IconButton? currentBtn;
        private Panel leftBorderBtn;
        private Form? currentChildForm;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Shift | Keys.H))
            {
                btnHome_Click(this, EventArgs.Empty);
                return true;
            }

            if (keyData == (Keys.Control | Keys.Shift | Keys.Y))
            {
                btnCerrarSeccion_Click(this, EventArgs.Empty);
                return true;
            }

            if (keyData == (Keys.Control | Keys.Shift | Keys.Z))
            {
                btnCerrar_Click(this, EventArgs.Empty);
                return true;
            }

            if (keyData == (Keys.Control | Keys.Shift | Keys.G))
            {
                btnAcerca_Click(this, EventArgs.Empty);
                return true;
            }

            if (keyData == (Keys.Control | Keys.Shift | Keys.I))
            {
                btnInfo_Click(this, EventArgs.Empty);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

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
            pDerechoIndex.Width = 0;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                pDerechoIndex.Width = 139;
                subMenu.Visible = true;
            }
            else
            {
                hideSubMenu();
            }
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
            hideSubMenu();
            OpenChildForm(new frmAcerca());
            lblIconoFrmActual.Text = "ACERCA DE";
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            hideSubMenu();
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
            if (CacheInicioUsuario.permisosUser.Contains("Realizar todas las acciones"))
            {

            }
            else if (CacheInicioUsuario.permisosUser.Contains("Agregar") &&
                     CacheInicioUsuario.permisosUser.Contains("Modificar") &&
                     CacheInicioUsuario.permisosUser.Contains("Consultar Datos"))
            {
                btnEmpleado.Visible = false;
                btnUsuarios.Visible = false;
            }
            else if (CacheInicioUsuario.permisosUser.Contains("Consultar Datos"))
            {
                btnEmpleado.Visible = false;
                btnUsuarios.Visible = false;
            }
            timerIndex.Enabled = true;
        }

        private void btnCerrarSeccion_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es");

            if (CustomMessageBox.Advertencia("Cerrar sesión", "¿Está seguro que desea cerrar la aplicación?") == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMiximizar_MouseHover(object sender, EventArgs e)
        {
            btnMiximizar.BackColor = Color.FromArgb(171, 235, 235);
        }

        private void btnMiximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMiximizar.BackColor = Color.FromArgb(5, 23, 59);
        }

        private void btnMaximizar_MouseHover(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(171, 235, 235);
        }

        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(5, 23, 59);
        }

        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(171, 235, 235);
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(5, 23, 59);
        }
    }
}

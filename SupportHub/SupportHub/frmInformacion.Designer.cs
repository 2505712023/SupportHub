namespace Presentacion
{
    partial class frmInformacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pDerechoInformacion = new Panel();
            panel1 = new Panel();
            gbMiInformacion = new GroupBox();
            linkEditar = new LinkLabel();
            lblApellidoInfor = new Label();
            lblNombreInfo = new Label();
            lblIdInfo = new Label();
            lblUser = new Label();
            lblID = new Label();
            lblApellidoUsuario = new Label();
            lblNombreUsuario = new Label();
            lblUsuario = new Label();
            panel2 = new Panel();
            lblEditar = new LinkLabel();
            btnCancelaEmpleado = new FontAwesome.Sharp.IconButton();
            btnGuardarContraseña = new FontAwesome.Sharp.IconButton();
            txtContraActual = new TextBox();
            txtConfirmarContra = new TextBox();
            txtNuevaContra = new TextBox();
            txtApellidoUsuario = new TextBox();
            txtNombreUsuario = new TextBox();
            txtUsuario = new TextBox();
            lblContraActual = new Label();
            lblConfirmarContra = new Label();
            lblNuevaContra = new Label();
            lblApellidoPanel = new Label();
            lblNombrePanel = new Label();
            lblUsuarioPanel = new Label();
            lblCambiarContraseña = new Label();
            pDerechoInformacion.SuspendLayout();
            gbMiInformacion.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pDerechoInformacion
            // 
            pDerechoInformacion.Controls.Add(panel1);
            pDerechoInformacion.Dock = DockStyle.Right;
            pDerechoInformacion.Location = new Point(1062, 0);
            pDerechoInformacion.Name = "pDerechoInformacion";
            pDerechoInformacion.Size = new Size(99, 515);
            pDerechoInformacion.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(99, 515);
            panel1.TabIndex = 0;
            // 
            // gbMiInformacion
            // 
            gbMiInformacion.Controls.Add(linkEditar);
            gbMiInformacion.Controls.Add(lblApellidoInfor);
            gbMiInformacion.Controls.Add(lblNombreInfo);
            gbMiInformacion.Controls.Add(lblIdInfo);
            gbMiInformacion.Controls.Add(lblUser);
            gbMiInformacion.Controls.Add(lblID);
            gbMiInformacion.Controls.Add(lblApellidoUsuario);
            gbMiInformacion.Controls.Add(lblNombreUsuario);
            gbMiInformacion.Controls.Add(lblUsuario);
            gbMiInformacion.Location = new Point(12, 12);
            gbMiInformacion.Name = "gbMiInformacion";
            gbMiInformacion.Size = new Size(632, 482);
            gbMiInformacion.TabIndex = 9;
            gbMiInformacion.TabStop = false;
            gbMiInformacion.Text = "MI INFORMACIÓN";
            // 
            // linkEditar
            // 
            linkEditar.AutoSize = true;
            linkEditar.Location = new Point(164, 379);
            linkEditar.Name = "linkEditar";
            linkEditar.Size = new Size(84, 15);
            linkEditar.TabIndex = 8;
            linkEditar.TabStop = true;
            linkEditar.Text = "Editar mi Perfil";
            // 
            // lblApellidoInfor
            // 
            lblApellidoInfor.AutoSize = true;
            lblApellidoInfor.Location = new Point(8, 338);
            lblApellidoInfor.Name = "lblApellidoInfor";
            lblApellidoInfor.Size = new Size(49, 15);
            lblApellidoInfor.TabIndex = 7;
            lblApellidoInfor.Text = "apellido";
            // 
            // lblNombreInfo
            // 
            lblNombreInfo.AutoSize = true;
            lblNombreInfo.Location = new Point(8, 238);
            lblNombreInfo.Name = "lblNombreInfo";
            lblNombreInfo.Size = new Size(49, 15);
            lblNombreInfo.TabIndex = 6;
            lblNombreInfo.Text = "nombre";
            // 
            // lblIdInfo
            // 
            lblIdInfo.AutoSize = true;
            lblIdInfo.Location = new Point(8, 86);
            lblIdInfo.Name = "lblIdInfo";
            lblIdInfo.Size = new Size(17, 15);
            lblIdInfo.TabIndex = 5;
            lblIdInfo.Text = "id";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(8, 159);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(29, 15);
            lblUser.TabIndex = 4;
            lblUser.Text = "user";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(8, 40);
            lblID.Name = "lblID";
            lblID.Size = new Size(41, 30);
            lblID.TabIndex = 3;
            lblID.Text = "ID:";
            // 
            // lblApellidoUsuario
            // 
            lblApellidoUsuario.AutoSize = true;
            lblApellidoUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellidoUsuario.Location = new Point(6, 280);
            lblApellidoUsuario.Name = "lblApellidoUsuario";
            lblApellidoUsuario.Size = new Size(250, 30);
            lblApellidoUsuario.TabIndex = 2;
            lblApellidoUsuario.Text = "APELLIDO DE USUARIO:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreUsuario.Location = new Point(6, 196);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(242, 30);
            lblNombreUsuario.TabIndex = 1;
            lblNombreUsuario.Text = "NOMBRE DE USUARIO:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(8, 119);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(113, 30);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "USUARIO:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(5, 23, 59);
            panel2.Controls.Add(lblEditar);
            panel2.Controls.Add(btnCancelaEmpleado);
            panel2.Controls.Add(btnGuardarContraseña);
            panel2.Controls.Add(txtContraActual);
            panel2.Controls.Add(txtConfirmarContra);
            panel2.Controls.Add(txtNuevaContra);
            panel2.Controls.Add(txtApellidoUsuario);
            panel2.Controls.Add(txtNombreUsuario);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(lblContraActual);
            panel2.Controls.Add(lblConfirmarContra);
            panel2.Controls.Add(lblNuevaContra);
            panel2.Controls.Add(lblApellidoPanel);
            panel2.Controls.Add(lblNombrePanel);
            panel2.Controls.Add(lblUsuarioPanel);
            panel2.Controls.Add(lblCambiarContraseña);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(660, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(402, 515);
            panel2.TabIndex = 10;
            panel2.Visible = false;
            // 
            // lblEditar
            // 
            lblEditar.AutoSize = true;
            lblEditar.LinkColor = Color.Red;
            lblEditar.Location = new Point(142, 270);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(37, 15);
            lblEditar.TabIndex = 9;
            lblEditar.TabStop = true;
            lblEditar.Text = "Editar";
            // 
            // btnCancelaEmpleado
            // 
            btnCancelaEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelaEmpleado.BackColor = Color.White;
            btnCancelaEmpleado.FlatAppearance.BorderSize = 0;
            btnCancelaEmpleado.FlatStyle = FlatStyle.Flat;
            btnCancelaEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelaEmpleado.ForeColor = Color.FromArgb(5, 23, 59);
            btnCancelaEmpleado.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            btnCancelaEmpleado.IconColor = Color.FromArgb(5, 23, 59);
            btnCancelaEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelaEmpleado.IconSize = 20;
            btnCancelaEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelaEmpleado.Location = new Point(172, 456);
            btnCancelaEmpleado.Name = "btnCancelaEmpleado";
            btnCancelaEmpleado.Size = new Size(115, 38);
            btnCancelaEmpleado.TabIndex = 14;
            btnCancelaEmpleado.Text = "CANCELAR";
            btnCancelaEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelaEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelaEmpleado.UseVisualStyleBackColor = false;
            // 
            // btnGuardarContraseña
            // 
            btnGuardarContraseña.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardarContraseña.BackColor = Color.FromArgb(5, 23, 59);
            btnGuardarContraseña.FlatAppearance.BorderSize = 0;
            btnGuardarContraseña.FlatStyle = FlatStyle.Flat;
            btnGuardarContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarContraseña.ForeColor = Color.White;
            btnGuardarContraseña.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardarContraseña.IconColor = Color.White;
            btnGuardarContraseña.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarContraseña.IconSize = 20;
            btnGuardarContraseña.Location = new Point(41, 456);
            btnGuardarContraseña.Name = "btnGuardarContraseña";
            btnGuardarContraseña.Size = new Size(115, 38);
            btnGuardarContraseña.TabIndex = 13;
            btnGuardarContraseña.Text = "GUARDAR";
            btnGuardarContraseña.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarContraseña.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarContraseña.UseVisualStyleBackColor = false;
            // 
            // txtContraActual
            // 
            txtContraActual.Location = new Point(31, 400);
            txtContraActual.Name = "txtContraActual";
            txtContraActual.Size = new Size(256, 23);
            txtContraActual.TabIndex = 12;
            // 
            // txtConfirmarContra
            // 
            txtConfirmarContra.Location = new Point(31, 342);
            txtConfirmarContra.Name = "txtConfirmarContra";
            txtConfirmarContra.Size = new Size(256, 23);
            txtConfirmarContra.TabIndex = 11;
            // 
            // txtNuevaContra
            // 
            txtNuevaContra.Location = new Point(31, 288);
            txtNuevaContra.Name = "txtNuevaContra";
            txtNuevaContra.Size = new Size(256, 23);
            txtNuevaContra.TabIndex = 10;
            // 
            // txtApellidoUsuario
            // 
            txtApellidoUsuario.Location = new Point(31, 217);
            txtApellidoUsuario.Name = "txtApellidoUsuario";
            txtApellidoUsuario.Size = new Size(256, 23);
            txtApellidoUsuario.TabIndex = 9;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(31, 163);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(256, 23);
            txtNombreUsuario.TabIndex = 8;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(31, 98);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(256, 23);
            txtUsuario.TabIndex = 7;
            // 
            // lblContraActual
            // 
            lblContraActual.AutoSize = true;
            lblContraActual.ForeColor = SystemColors.ControlLightLight;
            lblContraActual.Location = new Point(31, 382);
            lblContraActual.Name = "lblContraActual";
            lblContraActual.Size = new Size(105, 15);
            lblContraActual.TabIndex = 6;
            lblContraActual.Text = "Contraseña actual:";
            // 
            // lblConfirmarContra
            // 
            lblConfirmarContra.AutoSize = true;
            lblConfirmarContra.ForeColor = SystemColors.ControlLightLight;
            lblConfirmarContra.Location = new Point(31, 323);
            lblConfirmarContra.Name = "lblConfirmarContra";
            lblConfirmarContra.Size = new Size(125, 15);
            lblConfirmarContra.TabIndex = 5;
            lblConfirmarContra.Text = "Confirmar contraseña:";
            // 
            // lblNuevaContra
            // 
            lblNuevaContra.AutoSize = true;
            lblNuevaContra.ForeColor = SystemColors.ControlLightLight;
            lblNuevaContra.Location = new Point(31, 270);
            lblNuevaContra.Name = "lblNuevaContra";
            lblNuevaContra.Size = new Size(105, 15);
            lblNuevaContra.TabIndex = 4;
            lblNuevaContra.Text = "Nueva contraseña:";
            // 
            // lblApellidoPanel
            // 
            lblApellidoPanel.AutoSize = true;
            lblApellidoPanel.ForeColor = SystemColors.ControlLightLight;
            lblApellidoPanel.Location = new Point(31, 197);
            lblApellidoPanel.Name = "lblApellidoPanel";
            lblApellidoPanel.Size = new Size(97, 15);
            lblApellidoPanel.TabIndex = 3;
            lblApellidoPanel.Text = "Apellido Usuario:";
            // 
            // lblNombrePanel
            // 
            lblNombrePanel.AutoSize = true;
            lblNombrePanel.ForeColor = SystemColors.ControlLightLight;
            lblNombrePanel.Location = new Point(31, 143);
            lblNombrePanel.Name = "lblNombrePanel";
            lblNombrePanel.Size = new Size(97, 15);
            lblNombrePanel.TabIndex = 2;
            lblNombrePanel.Text = "Nombre Usuario:";
            // 
            // lblUsuarioPanel
            // 
            lblUsuarioPanel.AutoSize = true;
            lblUsuarioPanel.ForeColor = SystemColors.ControlLightLight;
            lblUsuarioPanel.Location = new Point(31, 77);
            lblUsuarioPanel.Name = "lblUsuarioPanel";
            lblUsuarioPanel.Size = new Size(50, 15);
            lblUsuarioPanel.TabIndex = 1;
            lblUsuarioPanel.Text = "Usuario:";
            // 
            // lblCambiarContraseña
            // 
            lblCambiarContraseña.AutoSize = true;
            lblCambiarContraseña.ForeColor = SystemColors.ControlLightLight;
            lblCambiarContraseña.Location = new Point(31, 29);
            lblCambiarContraseña.Name = "lblCambiarContraseña";
            lblCambiarContraseña.Size = new Size(113, 15);
            lblCambiarContraseña.TabIndex = 0;
            lblCambiarContraseña.Text = "Cambiar contraseña";
            // 
            // frmInformacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 184, 216);
            ClientSize = new Size(1161, 515);
            Controls.Add(panel2);
            Controls.Add(gbMiInformacion);
            Controls.Add(pDerechoInformacion);
            Name = "frmInformacion";
            Text = "frmInformacion";
            Load += frmInformacion_Load;
            pDerechoInformacion.ResumeLayout(false);
            gbMiInformacion.ResumeLayout(false);
            gbMiInformacion.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pDerechoInformacion;
        private GroupBox gbMiInformacion;
        private Label lblApellidoUsuario;
        private Label lblNombreUsuario;
        private Label lblUsuario;
        private Label lblApellidoInfor;
        private Label lblNombreInfo;
        private Label lblIdInfo;
        private Label lblUser;
        private Label lblID;
        private Panel panel1;
        private LinkLabel linkEditar;
        private Panel panel2;
        private Label lblCambiarContraseña;
        private Label lblContraActual;
        private Label lblConfirmarContra;
        private Label lblNuevaContra;
        private Label lblApellidoPanel;
        private Label lblNombrePanel;
        private Label lblUsuarioPanel;
        private TextBox txtContraActual;
        private TextBox txtConfirmarContra;
        private TextBox txtNuevaContra;
        private TextBox txtApellidoUsuario;
        private TextBox txtNombreUsuario;
        private TextBox txtUsuario;
        private FontAwesome.Sharp.IconButton btnGuardarContraseña;
        private FontAwesome.Sharp.IconButton btnCancelaEmpleado;
        private LinkLabel lblEditar;
    }
}
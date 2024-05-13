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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformacion));
            gbMiInformacion = new GroupBox();
            imgUser = new PictureBox();
            linkEditar = new LinkLabel();
            lblApellidoInfor = new Label();
            lblNombreInfo = new Label();
            lblIdInfo = new Label();
            lblUser = new Label();
            lblID = new Label();
            lblApellidoUsuario = new Label();
            lblNombreUsuario = new Label();
            lblUsuario = new Label();
            pCambiarcontraseña = new Panel();
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
            gbMiInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgUser).BeginInit();
            pCambiarcontraseña.SuspendLayout();
            SuspendLayout();
            // 
            // gbMiInformacion
            // 
            gbMiInformacion.Controls.Add(imgUser);
            gbMiInformacion.Controls.Add(linkEditar);
            gbMiInformacion.Controls.Add(lblApellidoInfor);
            gbMiInformacion.Controls.Add(lblNombreInfo);
            gbMiInformacion.Controls.Add(lblIdInfo);
            gbMiInformacion.Controls.Add(lblUser);
            gbMiInformacion.Controls.Add(lblID);
            gbMiInformacion.Controls.Add(lblApellidoUsuario);
            gbMiInformacion.Controls.Add(lblNombreUsuario);
            gbMiInformacion.Controls.Add(lblUsuario);
            gbMiInformacion.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            gbMiInformacion.Location = new Point(12, 12);
            gbMiInformacion.Name = "gbMiInformacion";
            gbMiInformacion.Size = new Size(632, 482);
            gbMiInformacion.TabIndex = 9;
            gbMiInformacion.TabStop = false;
            gbMiInformacion.Text = "MI INFORMACIÓN";
            // 
            // imgUser
            // 
            imgUser.Image = (Image)resources.GetObject("imgUser.Image");
            imgUser.Location = new Point(428, 17);
            imgUser.Name = "imgUser";
            imgUser.Size = new Size(198, 183);
            imgUser.SizeMode = PictureBoxSizeMode.StretchImage;
            imgUser.TabIndex = 9;
            imgUser.TabStop = false;
            // 
            // linkEditar
            // 
            linkEditar.AutoSize = true;
            linkEditar.Location = new Point(210, 389);
            linkEditar.Name = "linkEditar";
            linkEditar.Size = new Size(154, 28);
            linkEditar.TabIndex = 8;
            linkEditar.TabStop = true;
            linkEditar.Text = "Editar mi Perfil";
            linkEditar.LinkClicked += linkEditar_LinkClicked;
            // 
            // lblApellidoInfor
            // 
            lblApellidoInfor.AutoSize = true;
            lblApellidoInfor.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoInfor.Location = new Point(9, 310);
            lblApellidoInfor.Name = "lblApellidoInfor";
            lblApellidoInfor.Size = new Size(114, 37);
            lblApellidoInfor.TabIndex = 7;
            lblApellidoInfor.Text = "apellido";
            // 
            // lblNombreInfo
            // 
            lblNombreInfo.AutoSize = true;
            lblNombreInfo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreInfo.Location = new Point(8, 226);
            lblNombreInfo.Name = "lblNombreInfo";
            lblNombreInfo.Size = new Size(110, 37);
            lblNombreInfo.TabIndex = 6;
            lblNombreInfo.Text = "nombre";
            // 
            // lblIdInfo
            // 
            lblIdInfo.AutoSize = true;
            lblIdInfo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdInfo.Location = new Point(9, 70);
            lblIdInfo.Name = "lblIdInfo";
            lblIdInfo.Size = new Size(40, 37);
            lblIdInfo.TabIndex = 5;
            lblIdInfo.Text = "id";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(9, 149);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(66, 37);
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
            // pCambiarcontraseña
            // 
            pCambiarcontraseña.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pCambiarcontraseña.BackColor = Color.FromArgb(5, 23, 59);
            pCambiarcontraseña.Controls.Add(lblEditar);
            pCambiarcontraseña.Controls.Add(btnCancelaEmpleado);
            pCambiarcontraseña.Controls.Add(btnGuardarContraseña);
            pCambiarcontraseña.Controls.Add(txtContraActual);
            pCambiarcontraseña.Controls.Add(txtConfirmarContra);
            pCambiarcontraseña.Controls.Add(txtNuevaContra);
            pCambiarcontraseña.Controls.Add(txtApellidoUsuario);
            pCambiarcontraseña.Controls.Add(txtNombreUsuario);
            pCambiarcontraseña.Controls.Add(txtUsuario);
            pCambiarcontraseña.Controls.Add(lblContraActual);
            pCambiarcontraseña.Controls.Add(lblConfirmarContra);
            pCambiarcontraseña.Controls.Add(lblNuevaContra);
            pCambiarcontraseña.Controls.Add(lblApellidoPanel);
            pCambiarcontraseña.Controls.Add(lblNombrePanel);
            pCambiarcontraseña.Controls.Add(lblUsuarioPanel);
            pCambiarcontraseña.Controls.Add(lblCambiarContraseña);
            pCambiarcontraseña.Font = new Font("Segoe UI", 12F);
            pCambiarcontraseña.Location = new Point(759, 0);
            pCambiarcontraseña.Name = "pCambiarcontraseña";
            pCambiarcontraseña.Size = new Size(402, 515);
            pCambiarcontraseña.TabIndex = 10;
            pCambiarcontraseña.Visible = false;
            // 
            // lblEditar
            // 
            lblEditar.AutoSize = true;
            lblEditar.LinkColor = Color.Red;
            lblEditar.Location = new Point(175, 264);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(50, 21);
            lblEditar.TabIndex = 9;
            lblEditar.TabStop = true;
            lblEditar.Text = "Editar";
            lblEditar.LinkClicked += lblEditar_LinkClicked;
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
            btnCancelaEmpleado.Click += btnCancelaEmpleado_Click;
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
            btnGuardarContraseña.Click += btnGuardarContraseña_Click;
            // 
            // txtContraActual
            // 
            txtContraActual.Location = new Point(33, 400);
            txtContraActual.Name = "txtContraActual";
            txtContraActual.Size = new Size(256, 29);
            txtContraActual.TabIndex = 12;
            // 
            // txtConfirmarContra
            // 
            txtConfirmarContra.Location = new Point(31, 344);
            txtConfirmarContra.Name = "txtConfirmarContra";
            txtConfirmarContra.Size = new Size(256, 29);
            txtConfirmarContra.TabIndex = 11;
            // 
            // txtNuevaContra
            // 
            txtNuevaContra.Location = new Point(31, 288);
            txtNuevaContra.Name = "txtNuevaContra";
            txtNuevaContra.Size = new Size(256, 29);
            txtNuevaContra.TabIndex = 10;
            // 
            // txtApellidoUsuario
            // 
            txtApellidoUsuario.Enabled = false;
            txtApellidoUsuario.Location = new Point(33, 211);
            txtApellidoUsuario.Name = "txtApellidoUsuario";
            txtApellidoUsuario.ReadOnly = true;
            txtApellidoUsuario.Size = new Size(256, 29);
            txtApellidoUsuario.TabIndex = 9;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Enabled = false;
            txtNombreUsuario.Location = new Point(31, 155);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.ReadOnly = true;
            txtNombreUsuario.Size = new Size(256, 29);
            txtNombreUsuario.TabIndex = 8;
            // 
            // txtUsuario
            // 
            txtUsuario.Enabled = false;
            txtUsuario.Location = new Point(31, 98);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(256, 29);
            txtUsuario.TabIndex = 7;
            // 
            // lblContraActual
            // 
            lblContraActual.AutoSize = true;
            lblContraActual.ForeColor = SystemColors.ControlLightLight;
            lblContraActual.Location = new Point(33, 376);
            lblContraActual.Name = "lblContraActual";
            lblContraActual.Size = new Size(137, 21);
            lblContraActual.TabIndex = 6;
            lblContraActual.Text = "Contraseña actual:";
            // 
            // lblConfirmarContra
            // 
            lblConfirmarContra.AutoSize = true;
            lblConfirmarContra.ForeColor = SystemColors.ControlLightLight;
            lblConfirmarContra.Location = new Point(30, 320);
            lblConfirmarContra.Name = "lblConfirmarContra";
            lblConfirmarContra.Size = new Size(164, 21);
            lblConfirmarContra.TabIndex = 5;
            lblConfirmarContra.Text = "Confirmar contraseña:";
            // 
            // lblNuevaContra
            // 
            lblNuevaContra.AutoSize = true;
            lblNuevaContra.ForeColor = SystemColors.ControlLightLight;
            lblNuevaContra.Location = new Point(30, 264);
            lblNuevaContra.Name = "lblNuevaContra";
            lblNuevaContra.Size = new Size(138, 21);
            lblNuevaContra.TabIndex = 4;
            lblNuevaContra.Text = "Nueva contraseña:";
            // 
            // lblApellidoPanel
            // 
            lblApellidoPanel.AutoSize = true;
            lblApellidoPanel.ForeColor = SystemColors.ControlLightLight;
            lblApellidoPanel.Location = new Point(32, 187);
            lblApellidoPanel.Name = "lblApellidoPanel";
            lblApellidoPanel.Size = new Size(128, 21);
            lblApellidoPanel.TabIndex = 3;
            lblApellidoPanel.Text = "Apellido Usuario:";
            // 
            // lblNombrePanel
            // 
            lblNombrePanel.AutoSize = true;
            lblNombrePanel.ForeColor = SystemColors.ControlLightLight;
            lblNombrePanel.Location = new Point(31, 131);
            lblNombrePanel.Name = "lblNombrePanel";
            lblNombrePanel.Size = new Size(129, 21);
            lblNombrePanel.TabIndex = 2;
            lblNombrePanel.Text = "Nombre Usuario:";
            // 
            // lblUsuarioPanel
            // 
            lblUsuarioPanel.AutoSize = true;
            lblUsuarioPanel.ForeColor = SystemColors.ControlLightLight;
            lblUsuarioPanel.Location = new Point(30, 74);
            lblUsuarioPanel.Name = "lblUsuarioPanel";
            lblUsuarioPanel.Size = new Size(67, 21);
            lblUsuarioPanel.TabIndex = 1;
            lblUsuarioPanel.Text = "Usuario:";
            // 
            // lblCambiarContraseña
            // 
            lblCambiarContraseña.AutoSize = true;
            lblCambiarContraseña.ForeColor = SystemColors.ControlLightLight;
            lblCambiarContraseña.Location = new Point(31, 29);
            lblCambiarContraseña.Name = "lblCambiarContraseña";
            lblCambiarContraseña.Size = new Size(149, 21);
            lblCambiarContraseña.TabIndex = 0;
            lblCambiarContraseña.Text = "Cambiar contraseña";
            // 
            // frmInformacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 184, 216);
            ClientSize = new Size(1161, 515);
            Controls.Add(pCambiarcontraseña);
            Controls.Add(gbMiInformacion);
            Name = "frmInformacion";
            Text = "frmInformacion";
            Load += frmInformacion_Load;
            gbMiInformacion.ResumeLayout(false);
            gbMiInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgUser).EndInit();
            pCambiarcontraseña.ResumeLayout(false);
            pCambiarcontraseña.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbMiInformacion;
        private Label lblApellidoUsuario;
        private Label lblNombreUsuario;
        private Label lblUsuario;
        private Label lblApellidoInfor;
        private Label lblNombreInfo;
        private Label lblIdInfo;
        private Label lblUser;
        private Label lblID;
        private LinkLabel linkEditar;
        private Panel pCambiarcontraseña;
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
        private PictureBox imgUser;
    }
}
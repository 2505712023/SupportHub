namespace SupportHub
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pImagen = new Panel();
            imgFondoLog = new PictureBox();
            imgLogoLogin = new PictureBox();
            lblLogin = new Label();
            pUser = new Panel();
            pPassword = new Panel();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnAcceder = new Button();
            btnCerrarLogin = new FontAwesome.Sharp.IconButton();
            lblMensajeError = new Label();
            pictureError = new PictureBox();
            pImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgFondoLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogoLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureError).BeginInit();
            SuspendLayout();
            // 
            // pImagen
            // 
            pImagen.BackColor = Color.FromArgb(5, 23, 59);
            pImagen.Controls.Add(imgFondoLog);
            pImagen.Controls.Add(imgLogoLogin);
            pImagen.Dock = DockStyle.Left;
            pImagen.Location = new Point(0, 0);
            pImagen.Name = "pImagen";
            pImagen.Size = new Size(228, 330);
            pImagen.TabIndex = 0;
            // 
            // imgFondoLog
            // 
            imgFondoLog.Image = (Image)resources.GetObject("imgFondoLog.Image");
            imgFondoLog.Location = new Point(0, 86);
            imgFondoLog.Name = "imgFondoLog";
            imgFondoLog.Size = new Size(230, 244);
            imgFondoLog.SizeMode = PictureBoxSizeMode.StretchImage;
            imgFondoLog.TabIndex = 1;
            imgFondoLog.TabStop = false;
            // 
            // imgLogoLogin
            // 
            imgLogoLogin.Image = (Image)resources.GetObject("imgLogoLogin.Image");
            imgLogoLogin.Location = new Point(10, 7);
            imgLogoLogin.Name = "imgLogoLogin";
            imgLogoLogin.Size = new Size(227, 93);
            imgLogoLogin.SizeMode = PictureBoxSizeMode.CenterImage;
            imgLogoLogin.TabIndex = 0;
            imgLogoLogin.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(31, 35, 40);
            lblLogin.Location = new Point(458, 21);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(87, 32);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            // 
            // pUser
            // 
            pUser.BackColor = Color.FromArgb(31, 35, 40);
            pUser.Location = new Point(288, 106);
            pUser.Name = "pUser";
            pUser.Size = new Size(400, 3);
            pUser.TabIndex = 0;
            // 
            // pPassword
            // 
            pPassword.BackColor = Color.FromArgb(31, 35, 40);
            pPassword.Location = new Point(288, 196);
            pPassword.Name = "pPassword";
            pPassword.Size = new Size(400, 3);
            pPassword.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(148, 184, 216);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.FromArgb(31, 35, 40);
            txtUsuario.Location = new Point(288, 86);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(400, 20);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "USUARIO";
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(148, 184, 216);
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Cursor = Cursors.IBeam;
            txtContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = Color.FromArgb(31, 35, 40);
            txtContraseña.Location = new Point(288, 176);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(400, 20);
            txtContraseña.TabIndex = 2;
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(89, 134, 213);
            btnAcceder.Cursor = Cursors.Hand;
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(89, 134, 213);
            btnAcceder.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 29, 52);
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = Color.White;
            btnAcceder.Location = new Point(288, 248);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(404, 43);
            btnAcceder.TabIndex = 3;
            btnAcceder.Text = "ACCEDER";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // btnCerrarLogin
            // 
            btnCerrarLogin.BackColor = Color.FromArgb(148, 184, 216);
            btnCerrarLogin.Cursor = Cursors.Hand;
            btnCerrarLogin.FlatAppearance.BorderSize = 0;
            btnCerrarLogin.FlatStyle = FlatStyle.Flat;
            btnCerrarLogin.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarLogin.IconColor = Color.FromArgb(31, 35, 40);
            btnCerrarLogin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarLogin.IconSize = 20;
            btnCerrarLogin.Location = new Point(739, 12);
            btnCerrarLogin.Name = "btnCerrarLogin";
            btnCerrarLogin.Size = new Size(29, 23);
            btnCerrarLogin.TabIndex = 4;
            btnCerrarLogin.UseVisualStyleBackColor = false;
            btnCerrarLogin.Click += btnCerrarLogin_Click;
            // 
            // lblMensajeError
            // 
            lblMensajeError.AutoSize = true;
            lblMensajeError.ForeColor = Color.FromArgb(31, 35, 40);
            lblMensajeError.ImageAlign = ContentAlignment.MiddleLeft;
            lblMensajeError.Location = new Point(323, 227);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(79, 15);
            lblMensajeError.TabIndex = 5;
            lblMensajeError.Text = "Mensaje Error";
            lblMensajeError.Visible = false;
            // 
            // pictureError
            // 
            pictureError.Image = (Image)resources.GetObject("pictureError.Image");
            pictureError.Location = new Point(288, 216);
            pictureError.Name = "pictureError";
            pictureError.Size = new Size(29, 26);
            pictureError.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureError.TabIndex = 6;
            pictureError.TabStop = false;
            pictureError.Visible = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 184, 216);
            ClientSize = new Size(780, 330);
            Controls.Add(pictureError);
            Controls.Add(lblMensajeError);
            Controls.Add(btnCerrarLogin);
            Controls.Add(btnAcceder);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(pPassword);
            Controls.Add(pUser);
            Controls.Add(lblLogin);
            Controls.Add(pImagen);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmLogin_Load;
            pImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgFondoLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogoLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pImagen;
        private PictureBox imgLogoLogin;
        private Label lblLogin;
        private Panel pUser;
        private Panel pPassword;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnAcceder;
        private FontAwesome.Sharp.IconButton btnCerrarLogin;
        private Label lblMensajeError;
        private PictureBox imgFondoLogin;
        private PictureBox pictureError;
        private PictureBox imgFondoLog;
    }
}

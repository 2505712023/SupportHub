namespace Presentacion
{
    partial class frmAgregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarUsuario));
            pSuperiorAddUsuario = new Panel();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            pboxLogo = new PictureBox();
            btnCerrarAddEmpleado = new FontAwesome.Sharp.IconButton();
            gbAddUsuario = new GroupBox();
            mtboxConfirmarContrasenia = new MaskedTextBox();
            mtboxContrasenia = new MaskedTextBox();
            tboxLoginUsuario = new TextBox();
            lblConfirmarContraseña = new Label();
            lblContraseña = new Label();
            tboxApellidosUsuario = new TextBox();
            lblApellidos = new Label();
            tboxNombresUsuario = new TextBox();
            lblNombre = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            lblErrorCantidad = new Label();
            lblLoginUsuario = new Label();
            ibtnCancelarEntrega = new FontAwesome.Sharp.IconButton();
            ibtnGuardarEntrega = new FontAwesome.Sharp.IconButton();
            btnCancelaEmpleado = new FontAwesome.Sharp.IconButton();
            btnGuardarEmpleado = new FontAwesome.Sharp.IconButton();
            pSuperiorAddUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).BeginInit();
            gbAddUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // pSuperiorAddUsuario
            // 
            pSuperiorAddUsuario.BackColor = Color.FromArgb(5, 23, 59);
            pSuperiorAddUsuario.Controls.Add(btnCerrar);
            pSuperiorAddUsuario.Controls.Add(pboxLogo);
            pSuperiorAddUsuario.Controls.Add(btnCerrarAddEmpleado);
            pSuperiorAddUsuario.Dock = DockStyle.Top;
            pSuperiorAddUsuario.Location = new Point(0, 0);
            pSuperiorAddUsuario.Margin = new Padding(3, 4, 3, 4);
            pSuperiorAddUsuario.Name = "pSuperiorAddUsuario";
            pSuperiorAddUsuario.Size = new Size(609, 80);
            pSuperiorAddUsuario.TabIndex = 2;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = SystemColors.ControlLightLight;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrar.IconColor = SystemColors.Window;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrar.IconSize = 20;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(563, 16);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(32, 32);
            btnCerrar.TabIndex = 18;
            btnCerrar.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pboxLogo
            // 
            pboxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pboxLogo.Image = (Image)resources.GetObject("pboxLogo.Image");
            pboxLogo.Location = new Point(23, 0);
            pboxLogo.Margin = new Padding(3, 4, 3, 4);
            pboxLogo.Name = "pboxLogo";
            pboxLogo.Size = new Size(184, 60);
            pboxLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            pboxLogo.TabIndex = 17;
            pboxLogo.TabStop = false;
            // 
            // btnCerrarAddEmpleado
            // 
            btnCerrarAddEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarAddEmpleado.FlatAppearance.BorderSize = 0;
            btnCerrarAddEmpleado.FlatStyle = FlatStyle.Flat;
            btnCerrarAddEmpleado.ForeColor = SystemColors.ControlLightLight;
            btnCerrarAddEmpleado.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarAddEmpleado.IconColor = SystemColors.Window;
            btnCerrarAddEmpleado.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarAddEmpleado.IconSize = 20;
            btnCerrarAddEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarAddEmpleado.Location = new Point(1174, 16);
            btnCerrarAddEmpleado.Margin = new Padding(3, 4, 3, 4);
            btnCerrarAddEmpleado.Name = "btnCerrarAddEmpleado";
            btnCerrarAddEmpleado.Size = new Size(32, 32);
            btnCerrarAddEmpleado.TabIndex = 16;
            btnCerrarAddEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarAddEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarAddEmpleado.UseVisualStyleBackColor = true;
            // 
            // gbAddUsuario
            // 
            gbAddUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbAddUsuario.Controls.Add(mtboxConfirmarContrasenia);
            gbAddUsuario.Controls.Add(mtboxContrasenia);
            gbAddUsuario.Controls.Add(tboxLoginUsuario);
            gbAddUsuario.Controls.Add(lblConfirmarContraseña);
            gbAddUsuario.Controls.Add(lblContraseña);
            gbAddUsuario.Controls.Add(tboxApellidosUsuario);
            gbAddUsuario.Controls.Add(lblApellidos);
            gbAddUsuario.Controls.Add(tboxNombresUsuario);
            gbAddUsuario.Controls.Add(lblNombre);
            gbAddUsuario.Controls.Add(btnCancelar);
            gbAddUsuario.Controls.Add(btnGuardar);
            gbAddUsuario.Controls.Add(lblErrorCantidad);
            gbAddUsuario.Controls.Add(lblLoginUsuario);
            gbAddUsuario.Controls.Add(ibtnCancelarEntrega);
            gbAddUsuario.Controls.Add(ibtnGuardarEntrega);
            gbAddUsuario.Controls.Add(btnCancelaEmpleado);
            gbAddUsuario.Controls.Add(btnGuardarEmpleado);
            gbAddUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbAddUsuario.Location = new Point(14, 88);
            gbAddUsuario.Margin = new Padding(3, 4, 3, 4);
            gbAddUsuario.Name = "gbAddUsuario";
            gbAddUsuario.Padding = new Padding(3, 4, 3, 4);
            gbAddUsuario.Size = new Size(582, 441);
            gbAddUsuario.TabIndex = 3;
            gbAddUsuario.TabStop = false;
            gbAddUsuario.Text = "AGREGAR USUARIO";
            gbAddUsuario.Enter += gbAddUsuario_Enter;
            // 
            // mtboxConfirmarContrasenia
            // 
            mtboxConfirmarContrasenia.Location = new Point(29, 373);
            mtboxConfirmarContrasenia.Margin = new Padding(3, 4, 3, 4);
            mtboxConfirmarContrasenia.Name = "mtboxConfirmarContrasenia";
            mtboxConfirmarContrasenia.PasswordChar = '●';
            mtboxConfirmarContrasenia.Size = new Size(371, 34);
            mtboxConfirmarContrasenia.TabIndex = 44;
            // 
            // mtboxContrasenia
            // 
            mtboxContrasenia.Location = new Point(29, 301);
            mtboxContrasenia.Margin = new Padding(3, 4, 3, 4);
            mtboxContrasenia.Name = "mtboxContrasenia";
            mtboxContrasenia.PasswordChar = '●';
            mtboxContrasenia.Size = new Size(371, 34);
            mtboxContrasenia.TabIndex = 43;
            // 
            // tboxLoginUsuario
            // 
            tboxLoginUsuario.Enabled = false;
            tboxLoginUsuario.Font = new Font("Segoe UI", 12F);
            tboxLoginUsuario.ForeColor = Color.Black;
            tboxLoginUsuario.Location = new Point(29, 77);
            tboxLoginUsuario.Margin = new Padding(3, 4, 3, 4);
            tboxLoginUsuario.Name = "tboxLoginUsuario";
            tboxLoginUsuario.Size = new Size(371, 34);
            tboxLoginUsuario.TabIndex = 42;
            // 
            // lblConfirmarContraseña
            // 
            lblConfirmarContraseña.AutoSize = true;
            lblConfirmarContraseña.Location = new Point(29, 344);
            lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            lblConfirmarContraseña.Size = new Size(224, 28);
            lblConfirmarContraseña.TabIndex = 41;
            lblConfirmarContraseña.Text = "Confirmar Contraseña:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(29, 269);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(123, 28);
            lblContraseña.TabIndex = 39;
            lblContraseña.Text = "Contraseña:";
            // 
            // tboxApellidosUsuario
            // 
            tboxApellidosUsuario.Enabled = false;
            tboxApellidosUsuario.Font = new Font("Segoe UI", 12F);
            tboxApellidosUsuario.ForeColor = Color.Black;
            tboxApellidosUsuario.Location = new Point(29, 227);
            tboxApellidosUsuario.Margin = new Padding(3, 4, 3, 4);
            tboxApellidosUsuario.Name = "tboxApellidosUsuario";
            tboxApellidosUsuario.Size = new Size(371, 34);
            tboxApellidosUsuario.TabIndex = 38;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(29, 195);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(105, 28);
            lblApellidos.TabIndex = 37;
            lblApellidos.Text = "Apellidos:";
            // 
            // tboxNombresUsuario
            // 
            tboxNombresUsuario.Enabled = false;
            tboxNombresUsuario.Font = new Font("Segoe UI", 12F);
            tboxNombresUsuario.ForeColor = Color.Black;
            tboxNombresUsuario.Location = new Point(29, 152);
            tboxNombresUsuario.Margin = new Padding(3, 4, 3, 4);
            tboxNombresUsuario.Name = "tboxNombresUsuario";
            tboxNombresUsuario.Size = new Size(371, 34);
            tboxNombresUsuario.TabIndex = 36;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(29, 120);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(103, 28);
            lblNombre.TabIndex = 35;
            lblNombre.Text = "Nombres:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(5, 23, 59);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            btnCancelar.IconColor = Color.FromArgb(5, 23, 59);
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 20;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(441, 357);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 53);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(5, 23, 59);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 20;
            btnGuardar.Location = new Point(441, 296);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 53);
            btnGuardar.TabIndex = 33;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // lblErrorCantidad
            // 
            lblErrorCantidad.AutoSize = true;
            lblErrorCantidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblErrorCantidad.ForeColor = Color.Red;
            lblErrorCantidad.Location = new Point(374, 339);
            lblErrorCantidad.Name = "lblErrorCantidad";
            lblErrorCantidad.Size = new Size(0, 23);
            lblErrorCantidad.TabIndex = 30;
            // 
            // lblLoginUsuario
            // 
            lblLoginUsuario.AutoSize = true;
            lblLoginUsuario.Location = new Point(29, 45);
            lblLoginUsuario.Name = "lblLoginUsuario";
            lblLoginUsuario.Size = new Size(69, 28);
            lblLoginUsuario.TabIndex = 22;
            lblLoginUsuario.Text = "Login:";
            // 
            // ibtnCancelarEntrega
            // 
            ibtnCancelarEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ibtnCancelarEntrega.BackColor = Color.White;
            ibtnCancelarEntrega.FlatAppearance.BorderSize = 0;
            ibtnCancelarEntrega.FlatStyle = FlatStyle.Flat;
            ibtnCancelarEntrega.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibtnCancelarEntrega.ForeColor = Color.FromArgb(5, 23, 59);
            ibtnCancelarEntrega.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            ibtnCancelarEntrega.IconColor = Color.FromArgb(5, 23, 59);
            ibtnCancelarEntrega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnCancelarEntrega.IconSize = 20;
            ibtnCancelarEntrega.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnCancelarEntrega.Location = new Point(1022, 136);
            ibtnCancelarEntrega.Margin = new Padding(3, 4, 3, 4);
            ibtnCancelarEntrega.Name = "ibtnCancelarEntrega";
            ibtnCancelarEntrega.Size = new Size(114, 53);
            ibtnCancelarEntrega.TabIndex = 18;
            ibtnCancelarEntrega.Text = "CANCELAR";
            ibtnCancelarEntrega.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnCancelarEntrega.UseVisualStyleBackColor = false;
            // 
            // ibtnGuardarEntrega
            // 
            ibtnGuardarEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ibtnGuardarEntrega.BackColor = Color.FromArgb(5, 23, 59);
            ibtnGuardarEntrega.FlatAppearance.BorderSize = 0;
            ibtnGuardarEntrega.FlatStyle = FlatStyle.Flat;
            ibtnGuardarEntrega.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibtnGuardarEntrega.ForeColor = Color.White;
            ibtnGuardarEntrega.IconChar = FontAwesome.Sharp.IconChar.Save;
            ibtnGuardarEntrega.IconColor = Color.White;
            ibtnGuardarEntrega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnGuardarEntrega.IconSize = 20;
            ibtnGuardarEntrega.Location = new Point(1022, 75);
            ibtnGuardarEntrega.Margin = new Padding(3, 4, 3, 4);
            ibtnGuardarEntrega.Name = "ibtnGuardarEntrega";
            ibtnGuardarEntrega.Size = new Size(114, 53);
            ibtnGuardarEntrega.TabIndex = 17;
            ibtnGuardarEntrega.Text = "GUARDAR";
            ibtnGuardarEntrega.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnGuardarEntrega.UseVisualStyleBackColor = false;
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
            btnCancelaEmpleado.Location = new Point(1750, 317);
            btnCancelaEmpleado.Margin = new Padding(3, 4, 3, 4);
            btnCancelaEmpleado.Name = "btnCancelaEmpleado";
            btnCancelaEmpleado.Size = new Size(131, 51);
            btnCancelaEmpleado.TabIndex = 13;
            btnCancelaEmpleado.Text = "CANCELAR";
            btnCancelaEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelaEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelaEmpleado.UseVisualStyleBackColor = false;
            // 
            // btnGuardarEmpleado
            // 
            btnGuardarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardarEmpleado.BackColor = Color.FromArgb(5, 23, 59);
            btnGuardarEmpleado.FlatAppearance.BorderSize = 0;
            btnGuardarEmpleado.FlatStyle = FlatStyle.Flat;
            btnGuardarEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarEmpleado.ForeColor = Color.White;
            btnGuardarEmpleado.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardarEmpleado.IconColor = Color.White;
            btnGuardarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarEmpleado.IconSize = 20;
            btnGuardarEmpleado.Location = new Point(1599, 317);
            btnGuardarEmpleado.Margin = new Padding(3, 4, 3, 4);
            btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            btnGuardarEmpleado.Size = new Size(131, 51);
            btnGuardarEmpleado.TabIndex = 12;
            btnGuardarEmpleado.Text = "GUARDAR";
            btnGuardarEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarEmpleado.UseVisualStyleBackColor = false;
            // 
            // frmAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 122, 144);
            ClientSize = new Size(609, 545);
            Controls.Add(gbAddUsuario);
            Controls.Add(pSuperiorAddUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "frmAgregarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAgregarUsuario";
            pSuperiorAddUsuario.ResumeLayout(false);
            pSuperiorAddUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).EndInit();
            gbAddUsuario.ResumeLayout(false);
            gbAddUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pSuperiorAddUsuario;
        private PictureBox pboxLogo;
        private FontAwesome.Sharp.IconButton btnCerrarAddEmpleado;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private GroupBox gbAddUsuario;
        private TextBox tboxEmpleadoEntrega;
        private Label lblEmpleadoRecibe;
        private Label lblErrorCantidad;
        private MaskedTextBox tboxCantidadEntrega;
        private Label lblCantidadAEntregar;
        private TextBox tboxCantidadDisponible;
        private Label lblCantidadDisponible;
        private ComboBox cboxEquipo;
        private Label lblEquipo;
        private ComboBox cboxEmpleadoRecibe;
        private Label lblLoginUsuario;
        private RichTextBox rtxtObservacionEntrega;
        private Label lblObservacionEntrega;
        private FontAwesome.Sharp.IconButton ibtnCancelarEntrega;
        private FontAwesome.Sharp.IconButton ibtnGuardarEntrega;
        private Label lblFechaEntrega;
        private DateTimePicker dtpickerFechaEntrega;
        private ComboBox cboxTipoEntrega;
        private FontAwesome.Sharp.IconButton btnCancelaEmpleado;
        private FontAwesome.Sharp.IconButton btnGuardarEmpleado;
        private Label lblTipoDeEntrega;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox tboxNombresUsuario;
        private Label lblNombre;
        private Label lblContraseña;
        private TextBox tboxApellidosUsuario;
        private Label lblApellidos;
        private Label lblConfirmarContraseña;
        private MaskedTextBox mtboxConfirmarContrasenia;
        private MaskedTextBox mtboxContrasenia;
        private TextBox tboxLoginUsuario;
    }
}
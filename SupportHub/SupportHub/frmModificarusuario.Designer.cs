namespace Presentacion
{
    partial class frmModificarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarUsuario));
            btnCerrar = new FontAwesome.Sharp.IconButton();
            checkBox1 = new CheckBox();
            pboxLogo = new PictureBox();
            gbModiUsuario = new GroupBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            cbxEmpModUsuario = new ComboBox();
            lblEmpAddUsuario = new Label();
            cbxTipoUsuario = new ComboBox();
            lblTipoUsuario = new Label();
            mtboxContrasenia = new MaskedTextBox();
            tboxLoginUsuario = new TextBox();
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
            pSuperiorModUsuario = new Panel();
            btnCerrarAddEmpleado = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).BeginInit();
            gbModiUsuario.SuspendLayout();
            pSuperiorModUsuario.SuspendLayout();
            SuspendLayout();
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
            btnCerrar.Location = new Point(2216, 20);
            btnCerrar.Margin = new Padding(4, 5, 4, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(40, 40);
            btnCerrar.TabIndex = 18;
            btnCerrar.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(763, 379);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(120, 36);
            checkBox1.TabIndex = 49;
            checkBox1.Text = "Activo:";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // pboxLogo
            // 
            pboxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pboxLogo.Image = (Image)resources.GetObject("pboxLogo.Image");
            pboxLogo.Location = new Point(29, 0);
            pboxLogo.Margin = new Padding(4, 5, 4, 5);
            pboxLogo.Name = "pboxLogo";
            pboxLogo.Size = new Size(184, 60);
            pboxLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            pboxLogo.TabIndex = 17;
            pboxLogo.TabStop = false;
            // 
            // gbModiUsuario
            // 
            gbModiUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbModiUsuario.Controls.Add(iconButton2);
            gbModiUsuario.Controls.Add(iconButton1);
            gbModiUsuario.Controls.Add(checkBox1);
            gbModiUsuario.Controls.Add(cbxEmpModUsuario);
            gbModiUsuario.Controls.Add(lblEmpAddUsuario);
            gbModiUsuario.Controls.Add(cbxTipoUsuario);
            gbModiUsuario.Controls.Add(lblTipoUsuario);
            gbModiUsuario.Controls.Add(mtboxContrasenia);
            gbModiUsuario.Controls.Add(tboxLoginUsuario);
            gbModiUsuario.Controls.Add(lblContraseña);
            gbModiUsuario.Controls.Add(tboxApellidosUsuario);
            gbModiUsuario.Controls.Add(lblApellidos);
            gbModiUsuario.Controls.Add(tboxNombresUsuario);
            gbModiUsuario.Controls.Add(lblNombre);
            gbModiUsuario.Controls.Add(btnCancelar);
            gbModiUsuario.Controls.Add(btnGuardar);
            gbModiUsuario.Controls.Add(lblErrorCantidad);
            gbModiUsuario.Controls.Add(lblLoginUsuario);
            gbModiUsuario.Controls.Add(ibtnCancelarEntrega);
            gbModiUsuario.Controls.Add(ibtnGuardarEntrega);
            gbModiUsuario.Controls.Add(btnCancelaEmpleado);
            gbModiUsuario.Controls.Add(btnGuardarEmpleado);
            gbModiUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbModiUsuario.Location = new Point(0, 80);
            gbModiUsuario.Margin = new Padding(4, 5, 4, 5);
            gbModiUsuario.Name = "gbModiUsuario";
            gbModiUsuario.Padding = new Padding(4, 5, 4, 5);
            gbModiUsuario.Size = new Size(1230, 520);
            gbModiUsuario.TabIndex = 5;
            gbModiUsuario.TabStop = false;
            gbModiUsuario.Text = "MODIFICAR USUARIO";
            gbModiUsuario.Enter += gbAddUsuario_Enter;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            iconButton2.BackColor = Color.White;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = Color.FromArgb(5, 23, 59);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            iconButton2.IconColor = Color.FromArgb(5, 23, 59);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(1028, 379);
            iconButton2.Margin = new Padding(4, 5, 4, 5);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(142, 66);
            iconButton2.TabIndex = 51;
            iconButton2.Text = "CANCELAR";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            iconButton1.BackColor = Color.FromArgb(5, 23, 59);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(1028, 275);
            iconButton1.Margin = new Padding(4, 5, 4, 5);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(142, 66);
            iconButton1.TabIndex = 50;
            iconButton1.Text = "GUARDAR";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // cbxEmpModUsuario
            // 
            cbxEmpModUsuario.FormattingEnabled = true;
            cbxEmpModUsuario.Location = new Point(741, 190);
            cbxEmpModUsuario.Margin = new Padding(4);
            cbxEmpModUsuario.Name = "cbxEmpModUsuario";
            cbxEmpModUsuario.Size = new Size(268, 40);
            cbxEmpModUsuario.TabIndex = 48;
            // 
            // lblEmpAddUsuario
            // 
            lblEmpAddUsuario.AutoSize = true;
            lblEmpAddUsuario.Location = new Point(749, 152);
            lblEmpAddUsuario.Margin = new Padding(4, 0, 4, 0);
            lblEmpAddUsuario.Name = "lblEmpAddUsuario";
            lblEmpAddUsuario.Size = new Size(134, 32);
            lblEmpAddUsuario.TabIndex = 47;
            lblEmpAddUsuario.Text = "Empleado:";
            // 
            // cbxTipoUsuario
            // 
            cbxTipoUsuario.FormattingEnabled = true;
            cbxTipoUsuario.Location = new Point(741, 96);
            cbxTipoUsuario.Margin = new Padding(4);
            cbxTipoUsuario.Name = "cbxTipoUsuario";
            cbxTipoUsuario.Size = new Size(268, 40);
            cbxTipoUsuario.TabIndex = 46;
            cbxTipoUsuario.SelectedIndexChanged += cbxTipoUsuario_SelectedIndexChanged;
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Location = new Point(742, 58);
            lblTipoUsuario.Margin = new Padding(4, 0, 4, 0);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(200, 32);
            lblTipoUsuario.TabIndex = 45;
            lblTipoUsuario.Text = "Tipo de usuario:";
            // 
            // mtboxContrasenia
            // 
            mtboxContrasenia.Location = new Point(36, 376);
            mtboxContrasenia.Margin = new Padding(4, 5, 4, 5);
            mtboxContrasenia.Name = "mtboxContrasenia";
            mtboxContrasenia.PasswordChar = '●';
            mtboxContrasenia.Size = new Size(463, 39);
            mtboxContrasenia.TabIndex = 43;
            // 
            // tboxLoginUsuario
            // 
            tboxLoginUsuario.Enabled = false;
            tboxLoginUsuario.Font = new Font("Segoe UI", 12F);
            tboxLoginUsuario.ForeColor = Color.Black;
            tboxLoginUsuario.Location = new Point(36, 96);
            tboxLoginUsuario.Margin = new Padding(4, 5, 4, 5);
            tboxLoginUsuario.Name = "tboxLoginUsuario";
            tboxLoginUsuario.Size = new Size(463, 39);
            tboxLoginUsuario.TabIndex = 42;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(37, 338);
            lblContraseña.Margin = new Padding(4, 0, 4, 0);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(150, 32);
            lblContraseña.TabIndex = 39;
            lblContraseña.Text = "Contraseña:";
            // 
            // tboxApellidosUsuario
            // 
            tboxApellidosUsuario.Enabled = false;
            tboxApellidosUsuario.Font = new Font("Segoe UI", 12F);
            tboxApellidosUsuario.ForeColor = Color.Black;
            tboxApellidosUsuario.Location = new Point(36, 284);
            tboxApellidosUsuario.Margin = new Padding(4, 5, 4, 5);
            tboxApellidosUsuario.Name = "tboxApellidosUsuario";
            tboxApellidosUsuario.Size = new Size(463, 39);
            tboxApellidosUsuario.TabIndex = 38;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(37, 246);
            lblApellidos.Margin = new Padding(4, 0, 4, 0);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(128, 32);
            lblApellidos.TabIndex = 37;
            lblApellidos.Text = "Apellidos:";
            // 
            // tboxNombresUsuario
            // 
            tboxNombresUsuario.Enabled = false;
            tboxNombresUsuario.Font = new Font("Segoe UI", 12F);
            tboxNombresUsuario.ForeColor = Color.Black;
            tboxNombresUsuario.Location = new Point(36, 190);
            tboxNombresUsuario.Margin = new Padding(4, 5, 4, 5);
          
            tboxNombresUsuario.Size = new Size(463, 39);
        
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(37, 152);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(126, 32);
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
            btnCancelar.Location = new Point(2063, 877);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 66);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
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
            btnGuardar.Location = new Point(2063, 800);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(142, 66);
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
            lblErrorCantidad.Location = new Point(469, 426);
            lblErrorCantidad.Margin = new Padding(4, 0, 4, 0);
            lblErrorCantidad.Name = "lblErrorCantidad";
            lblErrorCantidad.Size = new Size(0, 28);
            lblErrorCantidad.TabIndex = 30;
            // 
            // lblLoginUsuario
            // 
            lblLoginUsuario.AutoSize = true;
            lblLoginUsuario.Location = new Point(37, 58);
            lblLoginUsuario.Margin = new Padding(4, 0, 4, 0);
            lblLoginUsuario.Name = "lblLoginUsuario";
            lblLoginUsuario.Size = new Size(85, 32);
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
            ibtnCancelarEntrega.Location = new Point(2789, 172);
            ibtnCancelarEntrega.Margin = new Padding(4, 5, 4, 5);
            ibtnCancelarEntrega.Name = "ibtnCancelarEntrega";
            ibtnCancelarEntrega.Size = new Size(142, 66);
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
            ibtnGuardarEntrega.Location = new Point(2789, 96);
            ibtnGuardarEntrega.Margin = new Padding(4, 5, 4, 5);
            ibtnGuardarEntrega.Name = "ibtnGuardarEntrega";
            ibtnGuardarEntrega.Size = new Size(142, 66);
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
            btnCancelaEmpleado.Location = new Point(3699, 398);
            btnCancelaEmpleado.Margin = new Padding(4, 5, 4, 5);
            btnCancelaEmpleado.Name = "btnCancelaEmpleado";
            btnCancelaEmpleado.Size = new Size(164, 64);
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
            btnGuardarEmpleado.Location = new Point(3510, 398);
            btnGuardarEmpleado.Margin = new Padding(4, 5, 4, 5);
            btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            btnGuardarEmpleado.Size = new Size(164, 64);
            btnGuardarEmpleado.TabIndex = 12;
            btnGuardarEmpleado.Text = "GUARDAR";
            btnGuardarEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarEmpleado.UseVisualStyleBackColor = false;
            // 
            // pSuperiorModUsuario
            // 
            pSuperiorModUsuario.BackColor = Color.FromArgb(5, 23, 59);
            pSuperiorModUsuario.Controls.Add(btnCerrar);
            pSuperiorModUsuario.Controls.Add(pboxLogo);
            pSuperiorModUsuario.Controls.Add(btnCerrarAddEmpleado);
            pSuperiorModUsuario.Dock = DockStyle.Top;
            pSuperiorModUsuario.Location = new Point(0, 0);
            pSuperiorModUsuario.Margin = new Padding(4, 5, 4, 5);
            pSuperiorModUsuario.Name = "pSuperiorModUsuario";
            pSuperiorModUsuario.Size = new Size(1230, 80);
            pSuperiorModUsuario.TabIndex = 4;
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
            btnCerrarAddEmpleado.Location = new Point(2980, 20);
            btnCerrarAddEmpleado.Margin = new Padding(4, 5, 4, 5);
            btnCerrarAddEmpleado.Name = "btnCerrarAddEmpleado";
            btnCerrarAddEmpleado.Size = new Size(40, 40);
            btnCerrarAddEmpleado.TabIndex = 16;
            btnCerrarAddEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarAddEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarAddEmpleado.UseVisualStyleBackColor = true;
            // 
            // frmModificarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1230, 566);
            Controls.Add(gbModiUsuario);
            Controls.Add(pSuperiorModUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmModificarUsuario";
            Text = "frmModificarUsuario";
            Load += frmModificarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pboxLogo).EndInit();
            gbModiUsuario.ResumeLayout(false);
            gbModiUsuario.PerformLayout();
            pSuperiorModUsuario.ResumeLayout(false);
            pSuperiorModUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCerrar;
        private CheckBox checkBox1;
        private PictureBox pboxLogo;
        private GroupBox gbModiUsuario;
        private ComboBox cbxEmpModUsuario;
        private Label lblEmpAddUsuario;
        private ComboBox cbxTipoUsuario;
        private Label lblTipoUsuario;
        private MaskedTextBox mtboxContrasenia;
        private TextBox tboxLoginUsuario;
        private Label lblContraseña;
        private TextBox tboxApellidosUsuario;
        private Label lblApellidos;
        private TextBox tboxNombresUsuario;
        private Label lblNombre;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label lblErrorCantidad;
        private Label lblLoginUsuario;
        private FontAwesome.Sharp.IconButton ibtnCancelarEntrega;
        private FontAwesome.Sharp.IconButton ibtnGuardarEntrega;
        private FontAwesome.Sharp.IconButton btnCancelaEmpleado;
        private FontAwesome.Sharp.IconButton btnGuardarEmpleado;
        private Panel pSuperiorModUsuario;
        private FontAwesome.Sharp.IconButton btnCerrarAddEmpleado;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}
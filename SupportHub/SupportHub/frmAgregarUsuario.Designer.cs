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
            gbAddUsuario = new GroupBox();
            txtApellidoUsuario = new MaskedTextBox();
            btnCancelaUsuario = new FontAwesome.Sharp.IconButton();
            btnGuardarUsuario = new FontAwesome.Sharp.IconButton();
            cbxAreaEmpleado = new ComboBox();
            cbxCargoEmpleado = new ComboBox();
            txtPWUsuario = new TextBox();
            txtNombreUsuario = new TextBox();
            txtNombredeUsuario = new TextBox();
            lblPermisoUsuario = new Label();
            lblEmpleadoUsuario = new Label();
            lblPWUsuario = new Label();
            lblApellidoAddUsuario = new Label();
            lblNombreAddUsuario = new Label();
            lblNombredeUsuario = new Label();
            pSuperiorAddUsuario = new Panel();
            pboxLogo = new PictureBox();
            btnCerrarAddEmpleado = new FontAwesome.Sharp.IconButton();
            btnCerrarAddUsuario = new FontAwesome.Sharp.IconButton();
            gbAddUsuario.SuspendLayout();
            pSuperiorAddUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).BeginInit();
            SuspendLayout();
            // 
            // gbAddUsuario
            // 
            gbAddUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbAddUsuario.Controls.Add(txtApellidoUsuario);
            gbAddUsuario.Controls.Add(btnCancelaUsuario);
            gbAddUsuario.Controls.Add(btnGuardarUsuario);
            gbAddUsuario.Controls.Add(cbxAreaEmpleado);
            gbAddUsuario.Controls.Add(cbxCargoEmpleado);
            gbAddUsuario.Controls.Add(txtPWUsuario);
            gbAddUsuario.Controls.Add(txtNombreUsuario);
            gbAddUsuario.Controls.Add(txtNombredeUsuario);
            gbAddUsuario.Controls.Add(lblPermisoUsuario);
            gbAddUsuario.Controls.Add(lblEmpleadoUsuario);
            gbAddUsuario.Controls.Add(lblPWUsuario);
            gbAddUsuario.Controls.Add(lblApellidoAddUsuario);
            gbAddUsuario.Controls.Add(lblNombreAddUsuario);
            gbAddUsuario.Controls.Add(lblNombredeUsuario);
            gbAddUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbAddUsuario.Location = new Point(14, 88);
            gbAddUsuario.Margin = new Padding(3, 4, 3, 4);
            gbAddUsuario.Name = "gbAddUsuario";
            gbAddUsuario.Padding = new Padding(3, 4, 3, 4);
            gbAddUsuario.Size = new Size(643, 354);
            gbAddUsuario.TabIndex = 3;
            gbAddUsuario.TabStop = false;
            gbAddUsuario.Text = "AGREGAR USUARIO";
            // 
            // txtApellidoUsuario
            // 
            txtApellidoUsuario.Font = new Font("Segoe UI", 12F);
            txtApellidoUsuario.Location = new Point(30, 291);
            txtApellidoUsuario.Margin = new Padding(3, 4, 3, 4);
            txtApellidoUsuario.Name = "txtApellidoUsuario";
            txtApellidoUsuario.Size = new Size(303, 34);
            txtApellidoUsuario.TabIndex = 8;
            // 
            // btnCancelaUsuario
            // 
            btnCancelaUsuario.BackColor = Color.White;
            btnCancelaUsuario.FlatAppearance.BorderSize = 0;
            btnCancelaUsuario.FlatStyle = FlatStyle.Flat;
            btnCancelaUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelaUsuario.ForeColor = Color.FromArgb(5, 23, 59);
            btnCancelaUsuario.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            btnCancelaUsuario.IconColor = Color.FromArgb(5, 23, 59);
            btnCancelaUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelaUsuario.IconSize = 20;
            btnCancelaUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelaUsuario.Location = new Point(479, 288);
            btnCancelaUsuario.Margin = new Padding(3, 4, 3, 4);
            btnCancelaUsuario.Name = "btnCancelaUsuario";
            btnCancelaUsuario.Size = new Size(131, 47);
            btnCancelaUsuario.TabIndex = 13;
            btnCancelaUsuario.Text = "CANCELAR";
            btnCancelaUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelaUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelaUsuario.UseVisualStyleBackColor = false;
            // 
            // btnGuardarUsuario
            // 
            btnGuardarUsuario.BackColor = Color.FromArgb(5, 23, 59);
            btnGuardarUsuario.FlatAppearance.BorderSize = 0;
            btnGuardarUsuario.FlatStyle = FlatStyle.Flat;
            btnGuardarUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarUsuario.ForeColor = Color.White;
            btnGuardarUsuario.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardarUsuario.IconColor = Color.White;
            btnGuardarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarUsuario.IconSize = 20;
            btnGuardarUsuario.Location = new Point(479, 217);
            btnGuardarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnGuardarUsuario.Name = "btnGuardarUsuario";
            btnGuardarUsuario.Size = new Size(131, 51);
            btnGuardarUsuario.TabIndex = 12;
            btnGuardarUsuario.Text = "GUARDAR";
            btnGuardarUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarUsuario.UseVisualStyleBackColor = false;
            // 
            // cbxAreaEmpleado
            // 
            cbxAreaEmpleado.Font = new Font("Segoe UI", 12F);
            cbxAreaEmpleado.FormattingEnabled = true;
            cbxAreaEmpleado.Location = new Point(375, 149);
            cbxAreaEmpleado.Margin = new Padding(3, 4, 3, 4);
            cbxAreaEmpleado.Name = "cbxAreaEmpleado";
            cbxAreaEmpleado.Size = new Size(235, 36);
            cbxAreaEmpleado.TabIndex = 11;
            // 
            // cbxCargoEmpleado
            // 
            cbxCargoEmpleado.Font = new Font("Segoe UI", 12F);
            cbxCargoEmpleado.FormattingEnabled = true;
            cbxCargoEmpleado.Location = new Point(375, 71);
            cbxCargoEmpleado.Margin = new Padding(3, 4, 3, 4);
            cbxCargoEmpleado.Name = "cbxCargoEmpleado";
            cbxCargoEmpleado.Size = new Size(235, 36);
            cbxCargoEmpleado.TabIndex = 10;
            // 
            // txtPWUsuario
            // 
            txtPWUsuario.Font = new Font("Segoe UI", 12F);
            txtPWUsuario.Location = new Point(30, 141);
            txtPWUsuario.Margin = new Padding(3, 4, 3, 4);
            txtPWUsuario.Name = "txtPWUsuario";
            txtPWUsuario.Size = new Size(303, 34);
            txtPWUsuario.TabIndex = 9;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreUsuario.Location = new Point(30, 217);
            txtNombreUsuario.Margin = new Padding(3, 4, 3, 4);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(303, 34);
            txtNombreUsuario.TabIndex = 7;
            // 
            // txtNombredeUsuario
            // 
            txtNombredeUsuario.Font = new Font("Segoe UI", 12F);
            txtNombredeUsuario.Location = new Point(30, 71);
            txtNombredeUsuario.Margin = new Padding(3, 4, 3, 4);
            txtNombredeUsuario.Name = "txtNombredeUsuario";
            txtNombredeUsuario.Size = new Size(303, 34);
            txtNombredeUsuario.TabIndex = 6;
            // 
            // lblPermisoUsuario
            // 
            lblPermisoUsuario.AutoSize = true;
            lblPermisoUsuario.Location = new Point(375, 118);
            lblPermisoUsuario.Name = "lblPermisoUsuario";
            lblPermisoUsuario.Size = new Size(92, 28);
            lblPermisoUsuario.TabIndex = 5;
            lblPermisoUsuario.Text = "Permiso:";
            // 
            // lblEmpleadoUsuario
            // 
            lblEmpleadoUsuario.AutoSize = true;
            lblEmpleadoUsuario.Location = new Point(375, 40);
            lblEmpleadoUsuario.Name = "lblEmpleadoUsuario";
            lblEmpleadoUsuario.Size = new Size(110, 28);
            lblEmpleadoUsuario.TabIndex = 4;
            lblEmpleadoUsuario.Text = "Empleado:";
            // 
            // lblPWUsuario
            // 
            lblPWUsuario.AutoSize = true;
            lblPWUsuario.Location = new Point(30, 109);
            lblPWUsuario.Name = "lblPWUsuario";
            lblPWUsuario.Size = new Size(123, 28);
            lblPWUsuario.TabIndex = 3;
            lblPWUsuario.Text = "Contraseña:";
            // 
            // lblApellidoAddUsuario
            // 
            lblApellidoAddUsuario.AutoSize = true;
            lblApellidoAddUsuario.Location = new Point(30, 259);
            lblApellidoAddUsuario.Name = "lblApellidoAddUsuario";
            lblApellidoAddUsuario.Size = new Size(96, 28);
            lblApellidoAddUsuario.TabIndex = 2;
            lblApellidoAddUsuario.Text = "Apellido:";
            // 
            // lblNombreAddUsuario
            // 
            lblNombreAddUsuario.AutoSize = true;
            lblNombreAddUsuario.Location = new Point(30, 179);
            lblNombreAddUsuario.Name = "lblNombreAddUsuario";
            lblNombreAddUsuario.Size = new Size(94, 28);
            lblNombreAddUsuario.TabIndex = 1;
            lblNombreAddUsuario.Text = "Nombre:";
            // 
            // lblNombredeUsuario
            // 
            lblNombredeUsuario.AutoSize = true;
            lblNombredeUsuario.Location = new Point(30, 40);
            lblNombredeUsuario.Name = "lblNombredeUsuario";
            lblNombredeUsuario.Size = new Size(89, 28);
            lblNombredeUsuario.TabIndex = 0;
            lblNombredeUsuario.Text = "Usuario:";
            // 
            // pSuperiorAddUsuario
            // 
            pSuperiorAddUsuario.BackColor = Color.FromArgb(5, 23, 59);
            pSuperiorAddUsuario.Controls.Add(btnCerrarAddUsuario);
            pSuperiorAddUsuario.Controls.Add(pboxLogo);
            pSuperiorAddUsuario.Controls.Add(btnCerrarAddEmpleado);
            pSuperiorAddUsuario.Dock = DockStyle.Top;
            pSuperiorAddUsuario.Location = new Point(0, 0);
            pSuperiorAddUsuario.Margin = new Padding(3, 4, 3, 4);
            pSuperiorAddUsuario.Name = "pSuperiorAddUsuario";
            pSuperiorAddUsuario.Size = new Size(669, 80);
            pSuperiorAddUsuario.TabIndex = 2;
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
            pboxLogo.TabIndex = 16;
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
            btnCerrarAddEmpleado.Location = new Point(1102, 4);
            btnCerrarAddEmpleado.Margin = new Padding(3, 4, 3, 4);
            btnCerrarAddEmpleado.Name = "btnCerrarAddEmpleado";
            btnCerrarAddEmpleado.Size = new Size(32, 32);
            btnCerrarAddEmpleado.TabIndex = 15;
            btnCerrarAddEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarAddEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarAddEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnCerrarAddUsuario
            // 
            btnCerrarAddUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarAddUsuario.FlatAppearance.BorderSize = 0;
            btnCerrarAddUsuario.FlatStyle = FlatStyle.Flat;
            btnCerrarAddUsuario.ForeColor = SystemColors.ControlLightLight;
            btnCerrarAddUsuario.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarAddUsuario.IconColor = SystemColors.Window;
            btnCerrarAddUsuario.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarAddUsuario.IconSize = 20;
            btnCerrarAddUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarAddUsuario.Location = new Point(625, 13);
            btnCerrarAddUsuario.Margin = new Padding(3, 4, 3, 4);
            btnCerrarAddUsuario.Name = "btnCerrarAddUsuario";
            btnCerrarAddUsuario.Size = new Size(32, 32);
            btnCerrarAddUsuario.TabIndex = 17;
            btnCerrarAddUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarAddUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarAddUsuario.UseVisualStyleBackColor = true;
            // 
            // frmAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 122, 144);
            ClientSize = new Size(669, 472);
            Controls.Add(gbAddUsuario);
            Controls.Add(pSuperiorAddUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAgregarUsuario";
            Text = "frmAgregarUsuario";
            gbAddUsuario.ResumeLayout(false);
            gbAddUsuario.PerformLayout();
            pSuperiorAddUsuario.ResumeLayout(false);
            pSuperiorAddUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAddUsuario;
        private MaskedTextBox txtApellidoUsuario;
        private FontAwesome.Sharp.IconButton btnCancelaUsuario;
        private FontAwesome.Sharp.IconButton btnGuardarUsuario;
        private ComboBox cbxAreaEmpleado;
        private ComboBox cbxCargoEmpleado;
        private TextBox txtPWUsuario;
        private TextBox txtNombreUsuario;
        private TextBox txtNombredeUsuario;
        private Label lblPermisoUsuario;
        private Label lblEmpleadoUsuario;
        private Label lblPWUsuario;
        private Label lblApellidoAddUsuario;
        private Label lblNombreAddUsuario;
        private Label lblNombredeUsuario;
        private Panel pSuperiorAddUsuario;
        private PictureBox pboxLogo;
        private FontAwesome.Sharp.IconButton btnCerrarAddEmpleado;
        private FontAwesome.Sharp.IconButton btnCerrarAddUsuario;
    }
}
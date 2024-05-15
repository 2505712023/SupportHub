namespace Presentacion
{
    partial class frmAgregarusuariocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarusuariocs));
            pSuperiorAddUsuario = new Panel();
            pboxLogo = new PictureBox();
            btnCerrarAddEmpleado = new FontAwesome.Sharp.IconButton();
            btnCerrarAddUsuario = new FontAwesome.Sharp.IconButton();
            gbAddUsuario = new GroupBox();
            txtNombreLoginUsuario = new MaskedTextBox();
            btnCancelaUsuario = new FontAwesome.Sharp.IconButton();
            btnGuardarUsuario = new FontAwesome.Sharp.IconButton();
            txtPasswordLoginUsuario = new TextBox();
            txtApellidoUsuario = new TextBox();
            txtNombreUsuario = new TextBox();
            lblPasswordLoginUsuario = new Label();
            lblNombreLoginUsuario = new Label();
            lblApellidoUsuario = new Label();
            lblNombreUsuario = new Label();
            txtValidarPWUsuario = new TextBox();
            lblValidarPWUsuario = new Label();
            pSuperiorAddUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).BeginInit();
            gbAddUsuario.SuspendLayout();
            SuspendLayout();
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
            pSuperiorAddUsuario.Size = new Size(722, 80);
            pSuperiorAddUsuario.TabIndex = 1;
            pSuperiorAddUsuario.Paint += pSuperiorAddEmpleado_Paint;
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
            btnCerrarAddEmpleado.Location = new Point(1155, 4);
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
            btnCerrarAddUsuario.Location = new Point(686, 4);
            btnCerrarAddUsuario.Margin = new Padding(3, 4, 3, 4);
            btnCerrarAddUsuario.Name = "btnCerrarAddUsuario";
            btnCerrarAddUsuario.Size = new Size(32, 32);
            btnCerrarAddUsuario.TabIndex = 17;
            btnCerrarAddUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarAddUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarAddUsuario.UseVisualStyleBackColor = true;
            // 
            // gbAddUsuario
            // 
            gbAddUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbAddUsuario.Controls.Add(lblValidarPWUsuario);
            gbAddUsuario.Controls.Add(txtValidarPWUsuario);
            gbAddUsuario.Controls.Add(txtNombreLoginUsuario);
            gbAddUsuario.Controls.Add(btnCancelaUsuario);
            gbAddUsuario.Controls.Add(btnGuardarUsuario);
            gbAddUsuario.Controls.Add(txtPasswordLoginUsuario);
            gbAddUsuario.Controls.Add(txtApellidoUsuario);
            gbAddUsuario.Controls.Add(txtNombreUsuario);
            gbAddUsuario.Controls.Add(lblPasswordLoginUsuario);
            gbAddUsuario.Controls.Add(lblNombreLoginUsuario);
            gbAddUsuario.Controls.Add(lblApellidoUsuario);
            gbAddUsuario.Controls.Add(lblNombreUsuario);
            gbAddUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbAddUsuario.Location = new Point(14, 88);
            gbAddUsuario.Margin = new Padding(3, 4, 3, 4);
            gbAddUsuario.Name = "gbAddUsuario";
            gbAddUsuario.Padding = new Padding(3, 4, 3, 4);
            gbAddUsuario.Size = new Size(694, 400);
            gbAddUsuario.TabIndex = 2;
            gbAddUsuario.TabStop = false;
            gbAddUsuario.Text = "CREAR USUARIO";
            gbAddUsuario.Enter += gbAddUsuario_Enter;
            // 
            // txtNombreLoginUsuario
            // 
            txtNombreLoginUsuario.Font = new Font("Segoe UI", 12F);
            txtNombreLoginUsuario.Location = new Point(30, 224);
            txtNombreLoginUsuario.Margin = new Padding(3, 4, 3, 4);
            txtNombreLoginUsuario.Name = "txtNombreLoginUsuario";
            txtNombreLoginUsuario.Size = new Size(303, 34);
            txtNombreLoginUsuario.TabIndex = 8;
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
            btnCancelaUsuario.Location = new Point(540, 295);
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
            btnGuardarUsuario.Location = new Point(540, 219);
            btnGuardarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnGuardarUsuario.Name = "btnGuardarUsuario";
            btnGuardarUsuario.Size = new Size(131, 51);
            btnGuardarUsuario.TabIndex = 12;
            btnGuardarUsuario.Text = "GUARDAR";
            btnGuardarUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarUsuario.UseVisualStyleBackColor = false;
            // 
            // txtPasswordLoginUsuario
            // 
            txtPasswordLoginUsuario.Font = new Font("Segoe UI", 12F);
            txtPasswordLoginUsuario.Location = new Point(30, 308);
            txtPasswordLoginUsuario.Margin = new Padding(3, 4, 3, 4);
            txtPasswordLoginUsuario.Name = "txtPasswordLoginUsuario";
            txtPasswordLoginUsuario.Size = new Size(303, 34);
            txtPasswordLoginUsuario.TabIndex = 9;
            // 
            // txtApellidoUsuario
            // 
            txtApellidoUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoUsuario.Location = new Point(30, 149);
            txtApellidoUsuario.Margin = new Padding(3, 4, 3, 4);
            txtApellidoUsuario.Name = "txtApellidoUsuario";
            txtApellidoUsuario.Size = new Size(303, 34);
            txtApellidoUsuario.TabIndex = 7;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Font = new Font("Segoe UI", 12F);
            txtNombreUsuario.Location = new Point(30, 71);
            txtNombreUsuario.Margin = new Padding(3, 4, 3, 4);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(303, 34);
            txtNombreUsuario.TabIndex = 6;
            // 
            // lblPasswordLoginUsuario
            // 
            lblPasswordLoginUsuario.AutoSize = true;
            lblPasswordLoginUsuario.Location = new Point(30, 276);
            lblPasswordLoginUsuario.Name = "lblPasswordLoginUsuario";
            lblPasswordLoginUsuario.Size = new Size(237, 28);
            lblPasswordLoginUsuario.TabIndex = 4;
            lblPasswordLoginUsuario.Text = "Ingrese una contraseña:";
            // 
            // lblNombreLoginUsuario
            // 
            lblNombreLoginUsuario.AutoSize = true;
            lblNombreLoginUsuario.Location = new Point(30, 193);
            lblNombreLoginUsuario.Name = "lblNombreLoginUsuario";
            lblNombreLoginUsuario.Size = new Size(199, 28);
            lblNombreLoginUsuario.TabIndex = 2;
            lblNombreLoginUsuario.Text = "Nombre de usuario:";
            // 
            // lblApellidoUsuario
            // 
            lblApellidoUsuario.AutoSize = true;
            lblApellidoUsuario.Location = new Point(28, 117);
            lblApellidoUsuario.Name = "lblApellidoUsuario";
            lblApellidoUsuario.Size = new Size(96, 28);
            lblApellidoUsuario.TabIndex = 1;
            lblApellidoUsuario.Text = "Apellido:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(30, 40);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(94, 28);
            lblNombreUsuario.TabIndex = 0;
            lblNombreUsuario.Text = "Nombre:";
            // 
            // txtValidarPWUsuario
            // 
            txtValidarPWUsuario.Location = new Point(408, 71);
            txtValidarPWUsuario.Name = "txtValidarPWUsuario";
            txtValidarPWUsuario.Size = new Size(202, 34);
            txtValidarPWUsuario.TabIndex = 14;
            // 
            // lblValidarPWUsuario
            // 
            lblValidarPWUsuario.AutoSize = true;
            lblValidarPWUsuario.Location = new Point(408, 40);
            lblValidarPWUsuario.Name = "lblValidarPWUsuario";
            lblValidarPWUsuario.Size = new Size(211, 28);
            lblValidarPWUsuario.TabIndex = 15;
            lblValidarPWUsuario.Text = "Valide su contraseña:";
            // 
            // frmAgregarusuariocs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 122, 144);
            ClientSize = new Size(722, 504);
            Controls.Add(gbAddUsuario);
            Controls.Add(pSuperiorAddUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAgregarusuariocs";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "frmAgregarusuariocs";
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
        private FontAwesome.Sharp.IconButton btnCerrarAddUsuario;
        private GroupBox gbAddUsuario;
        private MaskedTextBox txtNombreLoginUsuario;
        private FontAwesome.Sharp.IconButton btnCancelaUsuario;
        private FontAwesome.Sharp.IconButton btnGuardarUsuario;
        private ComboBox cbxAreaEmpleado;
        private ComboBox cbxCargoEmpleado;
        private TextBox txtPasswordLoginUsuario;
        private TextBox txtApellidoUsuario;
        private TextBox txtNombreUsuario;
        private Label lblAreaEmpleado;
        private Label lblPasswordLoginUsuario;
        private Label lblEmailEmpleado;
        private Label lblNombreLoginUsuario;
        private Label lblApellidoUsuario;
        private Label lblNombreUsuario;
        private Label lblValidarPWUsuario;
        private TextBox txtValidarPWUsuario;
    }
}
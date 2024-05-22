namespace Presentacion
{
    partial class frmAgregarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarEmpleado));
            pSuperiorAddEmpleado = new Panel();
            pboxLogo = new PictureBox();
            btnCerrarAddEmpleado = new FontAwesome.Sharp.IconButton();
            gbAddEmpleado = new GroupBox();
            txtTelefonoEmpleado = new MaskedTextBox();
            btnCancelaEmpleado = new FontAwesome.Sharp.IconButton();
            btnGuardarEmpleado = new FontAwesome.Sharp.IconButton();
            cbxAreaEmpleado = new ComboBox();
            cbxCargoEmpleado = new ComboBox();
            txtEmailEmpleado = new TextBox();
            txtApellidoEmpleado = new TextBox();
            txtNombreEmpleado = new TextBox();
            lblAreaEmpleado = new Label();
            lblCargoEmpleado = new Label();
            lblEmailEmpleado = new Label();
            lblTelefonoEmpleado = new Label();
            lblApellidoEmpleado = new Label();
            lblNombreEmpleado = new Label();
            pSuperiorAddEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).BeginInit();
            gbAddEmpleado.SuspendLayout();
            SuspendLayout();
            // 
            // pSuperiorAddEmpleado
            // 
            pSuperiorAddEmpleado.BackColor = Color.FromArgb(5, 23, 59);
            pSuperiorAddEmpleado.Controls.Add(pboxLogo);
            pSuperiorAddEmpleado.Controls.Add(btnCerrarAddEmpleado);
            pSuperiorAddEmpleado.Dock = DockStyle.Top;
            pSuperiorAddEmpleado.Location = new Point(0, 0);
            pSuperiorAddEmpleado.Margin = new Padding(3, 4, 3, 4);
            pSuperiorAddEmpleado.Name = "pSuperiorAddEmpleado";
            pSuperiorAddEmpleado.Size = new Size(669, 80);
            pSuperiorAddEmpleado.TabIndex = 0;
            pSuperiorAddEmpleado.Paint += pSuperiorAddEmpleado_Paint;
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
            btnCerrarAddEmpleado.Location = new Point(633, 4);
            btnCerrarAddEmpleado.Margin = new Padding(3, 4, 3, 4);
            btnCerrarAddEmpleado.Name = "btnCerrarAddEmpleado";
            btnCerrarAddEmpleado.Size = new Size(32, 32);
            btnCerrarAddEmpleado.TabIndex = 15;
            btnCerrarAddEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarAddEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarAddEmpleado.UseVisualStyleBackColor = true;
            btnCerrarAddEmpleado.Click += btnCerrarAddEmpleado_Click;
            // 
            // gbAddEmpleado
            // 
            gbAddEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbAddEmpleado.Controls.Add(txtTelefonoEmpleado);
            gbAddEmpleado.Controls.Add(btnCancelaEmpleado);
            gbAddEmpleado.Controls.Add(btnGuardarEmpleado);
            gbAddEmpleado.Controls.Add(cbxAreaEmpleado);
            gbAddEmpleado.Controls.Add(cbxCargoEmpleado);
            gbAddEmpleado.Controls.Add(txtEmailEmpleado);
            gbAddEmpleado.Controls.Add(txtApellidoEmpleado);
            gbAddEmpleado.Controls.Add(txtNombreEmpleado);
            gbAddEmpleado.Controls.Add(lblAreaEmpleado);
            gbAddEmpleado.Controls.Add(lblCargoEmpleado);
            gbAddEmpleado.Controls.Add(lblEmailEmpleado);
            gbAddEmpleado.Controls.Add(lblTelefonoEmpleado);
            gbAddEmpleado.Controls.Add(lblApellidoEmpleado);
            gbAddEmpleado.Controls.Add(lblNombreEmpleado);
            gbAddEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbAddEmpleado.Location = new Point(14, 88);
            gbAddEmpleado.Margin = new Padding(3, 4, 3, 4);
            gbAddEmpleado.Name = "gbAddEmpleado";
            gbAddEmpleado.Padding = new Padding(3, 4, 3, 4);
            gbAddEmpleado.Size = new Size(641, 368);
            gbAddEmpleado.TabIndex = 1;
            gbAddEmpleado.TabStop = false;
            gbAddEmpleado.Text = "AGREGAR EMPLEADO";
            gbAddEmpleado.Enter += gbAddEmpleado_Enter;
            // 
            // txtTelefonoEmpleado
            // 
            txtTelefonoEmpleado.Font = new Font("Segoe UI", 12F);
            txtTelefonoEmpleado.Location = new Point(30, 224);
            txtTelefonoEmpleado.Margin = new Padding(3, 4, 3, 4);
            txtTelefonoEmpleado.Mask = "0000-0000";
            txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            txtTelefonoEmpleado.Size = new Size(303, 34);
            txtTelefonoEmpleado.TabIndex = 8;
            // 
            // btnCancelaEmpleado
            // 
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
            btnCancelaEmpleado.Location = new Point(479, 288);
            btnCancelaEmpleado.Margin = new Padding(3, 4, 3, 4);
            btnCancelaEmpleado.Name = "btnCancelaEmpleado";
            btnCancelaEmpleado.Size = new Size(131, 47);
            btnCancelaEmpleado.TabIndex = 13;
            btnCancelaEmpleado.Text = "CANCELAR";
            btnCancelaEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelaEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelaEmpleado.UseVisualStyleBackColor = false;
            btnCancelaEmpleado.Click += btnCancelaEmpleado_Click;
            // 
            // btnGuardarEmpleado
            // 
            btnGuardarEmpleado.BackColor = Color.FromArgb(5, 23, 59);
            btnGuardarEmpleado.FlatAppearance.BorderSize = 0;
            btnGuardarEmpleado.FlatStyle = FlatStyle.Flat;
            btnGuardarEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarEmpleado.ForeColor = Color.White;
            btnGuardarEmpleado.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardarEmpleado.IconColor = Color.White;
            btnGuardarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarEmpleado.IconSize = 20;
            btnGuardarEmpleado.Location = new Point(479, 217);
            btnGuardarEmpleado.Margin = new Padding(3, 4, 3, 4);
            btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            btnGuardarEmpleado.Size = new Size(131, 51);
            btnGuardarEmpleado.TabIndex = 12;
            btnGuardarEmpleado.Text = "GUARDAR";
            btnGuardarEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarEmpleado.UseVisualStyleBackColor = false;
            btnGuardarEmpleado.Click += btnGuardarEmpleado_Click;
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
            cbxAreaEmpleado.SelectedIndexChanged += cbxAreaEmpleado_SelectedIndexChanged;
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
            cbxCargoEmpleado.SelectedIndexChanged += cbxCargoEmpleado_SelectedIndexChanged;
            // 
            // txtEmailEmpleado
            // 
            txtEmailEmpleado.Font = new Font("Segoe UI", 12F);
            txtEmailEmpleado.Location = new Point(30, 296);
            txtEmailEmpleado.Margin = new Padding(3, 4, 3, 4);
            txtEmailEmpleado.Name = "txtEmailEmpleado";
            txtEmailEmpleado.Size = new Size(303, 34);
            txtEmailEmpleado.TabIndex = 9;
            // 
            // txtApellidoEmpleado
            // 
            txtApellidoEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoEmpleado.Location = new Point(30, 149);
            txtApellidoEmpleado.Margin = new Padding(3, 4, 3, 4);
            txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            txtApellidoEmpleado.Size = new Size(303, 34);
            txtApellidoEmpleado.TabIndex = 7;
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Font = new Font("Segoe UI", 12F);
            txtNombreEmpleado.Location = new Point(30, 71);
            txtNombreEmpleado.Margin = new Padding(3, 4, 3, 4);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(303, 34);
            txtNombreEmpleado.TabIndex = 6;
            // 
            // lblAreaEmpleado
            // 
            lblAreaEmpleado.AutoSize = true;
            lblAreaEmpleado.Location = new Point(375, 117);
            lblAreaEmpleado.Name = "lblAreaEmpleado";
            lblAreaEmpleado.Size = new Size(61, 28);
            lblAreaEmpleado.TabIndex = 5;
            lblAreaEmpleado.Text = "Área:";
            // 
            // lblCargoEmpleado
            // 
            lblCargoEmpleado.AutoSize = true;
            lblCargoEmpleado.Location = new Point(375, 39);
            lblCargoEmpleado.Name = "lblCargoEmpleado";
            lblCargoEmpleado.Size = new Size(72, 28);
            lblCargoEmpleado.TabIndex = 4;
            lblCargoEmpleado.Text = "Cargo:";
            // 
            // lblEmailEmpleado
            // 
            lblEmailEmpleado.AutoSize = true;
            lblEmailEmpleado.Location = new Point(30, 267);
            lblEmailEmpleado.Name = "lblEmailEmpleado";
            lblEmailEmpleado.Size = new Size(69, 28);
            lblEmailEmpleado.TabIndex = 3;
            lblEmailEmpleado.Text = "Email:";
            // 
            // lblTelefonoEmpleado
            // 
            lblTelefonoEmpleado.AutoSize = true;
            lblTelefonoEmpleado.Location = new Point(30, 192);
            lblTelefonoEmpleado.Name = "lblTelefonoEmpleado";
            lblTelefonoEmpleado.Size = new Size(99, 28);
            lblTelefonoEmpleado.TabIndex = 2;
            lblTelefonoEmpleado.Text = "Teléfono:";
            // 
            // lblApellidoEmpleado
            // 
            lblApellidoEmpleado.AutoSize = true;
            lblApellidoEmpleado.Location = new Point(30, 117);
            lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            lblApellidoEmpleado.Size = new Size(96, 28);
            lblApellidoEmpleado.TabIndex = 1;
            lblApellidoEmpleado.Text = "Apellido:";
            // 
            // lblNombreEmpleado
            // 
            lblNombreEmpleado.AutoSize = true;
            lblNombreEmpleado.Location = new Point(30, 39);
            lblNombreEmpleado.Name = "lblNombreEmpleado";
            lblNombreEmpleado.Size = new Size(94, 28);
            lblNombreEmpleado.TabIndex = 0;
            lblNombreEmpleado.Text = "Nombre:";
            // 
            // frmAgregarEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 122, 144);
            ClientSize = new Size(669, 472);
            Controls.Add(gbAddEmpleado);
            Controls.Add(pSuperiorAddEmpleado);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAgregarEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EMPLEADO ";
            Load += frmAgregarEmpleado_Load;
            pSuperiorAddEmpleado.ResumeLayout(false);
            pSuperiorAddEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).EndInit();
            gbAddEmpleado.ResumeLayout(false);
            gbAddEmpleado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pSuperiorAddEmpleado;
        private GroupBox gbAddEmpleado;
        private Label lblAreaEmpleado;
        private Label lblCargoEmpleado;
        private Label lblTelefonoEmpleado;
        private Label lblApellidoEmpleado;
        private Label lblNombreEmpleado;
        private ComboBox cbxAreaEmpleado;
        private ComboBox cbxCargoEmpleado;
        private TextBox txtEmailEmpleado;
        private TextBox txtApellidoEmpleado;
        private TextBox txtNombreEmpleado;
        private FontAwesome.Sharp.IconButton btnCancelaEmpleado;
        private FontAwesome.Sharp.IconButton btnGuardarEmpleado;
        private MaskedTextBox txtTelefonoEmpleado;
        private FontAwesome.Sharp.IconButton btnCerrarAddEmpleado;
        private PictureBox pboxLogo;
        private Label lblEmailEmpleado;
    }
}
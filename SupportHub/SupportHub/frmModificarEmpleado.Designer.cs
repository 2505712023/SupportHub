namespace Presentacion
{
    partial class frmModificarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarEmpleado));
            pSuperiorUpdEmpleado = new Panel();
            pboxLogo = new PictureBox();
            btnCerrarModificarEmpleado = new FontAwesome.Sharp.IconButton();
            btnCerrarAddEmpleado = new FontAwesome.Sharp.IconButton();
            gbUpdEmpleado = new GroupBox();
            btnGuardarUpdate = new FontAwesome.Sharp.IconButton();
            btnGuaardarUpdate = new FontAwesome.Sharp.IconButton();
            txtTelefonoEmpleadoUpdate = new MaskedTextBox();
            btnCancelaEmpleado = new FontAwesome.Sharp.IconButton();
            btnGuardarEmpleado = new FontAwesome.Sharp.IconButton();
            cbxAreaEmpleadoUpdate = new ComboBox();
            cbxCargoEmpleadoUpdate = new ComboBox();
            txtEmailEmpleadoUpdate = new TextBox();
            txtApellidoEmpleadoUpdate = new TextBox();
            txtNombreEmpleadoUpdate = new TextBox();
            lblAreaEmpleadoUpdate = new Label();
            lblCargoEmpleadoUpdate = new Label();
            lblEmailEmpleadoUpdate = new Label();
            lblTelefonoEmpleadoUpdate = new Label();
            lblApellidoEmpleadoUpdate = new Label();
            lblNombreEmpleadoUpdate = new Label();
            pSuperiorUpdEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).BeginInit();
            gbUpdEmpleado.SuspendLayout();
            SuspendLayout();
            // 
            // pSuperiorUpdEmpleado
            // 
            pSuperiorUpdEmpleado.BackColor = Color.FromArgb(5, 23, 59);
            pSuperiorUpdEmpleado.Controls.Add(pboxLogo);
            pSuperiorUpdEmpleado.Controls.Add(btnCerrarModificarEmpleado);
            pSuperiorUpdEmpleado.Controls.Add(btnCerrarAddEmpleado);
            pSuperiorUpdEmpleado.Dock = DockStyle.Top;
            pSuperiorUpdEmpleado.Location = new Point(0, 0);
            pSuperiorUpdEmpleado.Margin = new Padding(3, 4, 3, 4);
            pSuperiorUpdEmpleado.Name = "pSuperiorUpdEmpleado";
            pSuperiorUpdEmpleado.Size = new Size(669, 80);
            pSuperiorUpdEmpleado.TabIndex = 1;
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
            // btnCerrarModificarEmpleado
            // 
            btnCerrarModificarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarModificarEmpleado.FlatAppearance.BorderSize = 0;
            btnCerrarModificarEmpleado.FlatStyle = FlatStyle.Flat;
            btnCerrarModificarEmpleado.ForeColor = SystemColors.ControlLightLight;
            btnCerrarModificarEmpleado.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarModificarEmpleado.IconColor = SystemColors.Window;
            btnCerrarModificarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarModificarEmpleado.IconSize = 20;
            btnCerrarModificarEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarModificarEmpleado.Location = new Point(633, 4);
            btnCerrarModificarEmpleado.Margin = new Padding(3, 4, 3, 4);
            btnCerrarModificarEmpleado.Name = "btnCerrarModificarEmpleado";
            btnCerrarModificarEmpleado.Size = new Size(32, 32);
            btnCerrarModificarEmpleado.TabIndex = 16;
            btnCerrarModificarEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarModificarEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarModificarEmpleado.UseVisualStyleBackColor = true;
            btnCerrarModificarEmpleado.Click += btnCerrarModificarEmpleado_Click;
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
            btnCerrarAddEmpleado.Location = new Point(1509, 4);
            btnCerrarAddEmpleado.Margin = new Padding(3, 4, 3, 4);
            btnCerrarAddEmpleado.Name = "btnCerrarAddEmpleado";
            btnCerrarAddEmpleado.Size = new Size(32, 32);
            btnCerrarAddEmpleado.TabIndex = 15;
            btnCerrarAddEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarAddEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarAddEmpleado.UseVisualStyleBackColor = true;
            // 
            // gbUpdEmpleado
            // 
            gbUpdEmpleado.Controls.Add(btnGuardarUpdate);
            gbUpdEmpleado.Controls.Add(btnGuaardarUpdate);
            gbUpdEmpleado.Controls.Add(txtTelefonoEmpleadoUpdate);
            gbUpdEmpleado.Controls.Add(btnCancelaEmpleado);
            gbUpdEmpleado.Controls.Add(btnGuardarEmpleado);
            gbUpdEmpleado.Controls.Add(cbxAreaEmpleadoUpdate);
            gbUpdEmpleado.Controls.Add(cbxCargoEmpleadoUpdate);
            gbUpdEmpleado.Controls.Add(txtEmailEmpleadoUpdate);
            gbUpdEmpleado.Controls.Add(txtApellidoEmpleadoUpdate);
            gbUpdEmpleado.Controls.Add(txtNombreEmpleadoUpdate);
            gbUpdEmpleado.Controls.Add(lblAreaEmpleadoUpdate);
            gbUpdEmpleado.Controls.Add(lblCargoEmpleadoUpdate);
            gbUpdEmpleado.Controls.Add(lblEmailEmpleadoUpdate);
            gbUpdEmpleado.Controls.Add(lblTelefonoEmpleadoUpdate);
            gbUpdEmpleado.Controls.Add(lblApellidoEmpleadoUpdate);
            gbUpdEmpleado.Controls.Add(lblNombreEmpleadoUpdate);
            gbUpdEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbUpdEmpleado.Location = new Point(14, 88);
            gbUpdEmpleado.Margin = new Padding(3, 4, 3, 4);
            gbUpdEmpleado.Name = "gbUpdEmpleado";
            gbUpdEmpleado.Padding = new Padding(3, 4, 3, 4);
            gbUpdEmpleado.Size = new Size(641, 368);
            gbUpdEmpleado.TabIndex = 2;
            gbUpdEmpleado.TabStop = false;
            gbUpdEmpleado.Text = "MODIFICAR EMPLEADO";
            gbUpdEmpleado.Enter += gbUpdEmpleado_Enter;
            // 
            // btnGuardarUpdate
            // 
            btnGuardarUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardarUpdate.BackColor = Color.White;
            btnGuardarUpdate.FlatAppearance.BorderSize = 0;
            btnGuardarUpdate.FlatStyle = FlatStyle.Flat;
            btnGuardarUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarUpdate.ForeColor = Color.FromArgb(5, 23, 59);
            btnGuardarUpdate.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            btnGuardarUpdate.IconColor = Color.FromArgb(5, 23, 59);
            btnGuardarUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarUpdate.IconSize = 20;
            btnGuardarUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarUpdate.Location = new Point(479, 283);
            btnGuardarUpdate.Margin = new Padding(3, 4, 3, 4);
            btnGuardarUpdate.Name = "btnGuardarUpdate";
            btnGuardarUpdate.Size = new Size(131, 51);
            btnGuardarUpdate.TabIndex = 13;
            btnGuardarUpdate.Text = "CANCELAR";
            btnGuardarUpdate.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarUpdate.UseVisualStyleBackColor = false;
            btnGuardarUpdate.Click += btnGuardarUpdate_Click_1;
            // 
            // btnGuaardarUpdate
            // 
            btnGuaardarUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuaardarUpdate.BackColor = Color.FromArgb(5, 23, 59);
            btnGuaardarUpdate.FlatAppearance.BorderSize = 0;
            btnGuaardarUpdate.FlatStyle = FlatStyle.Flat;
            btnGuaardarUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuaardarUpdate.ForeColor = Color.White;
            btnGuaardarUpdate.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuaardarUpdate.IconColor = Color.White;
            btnGuaardarUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuaardarUpdate.IconSize = 20;
            btnGuaardarUpdate.Location = new Point(479, 212);
            btnGuaardarUpdate.Margin = new Padding(3, 4, 3, 4);
            btnGuaardarUpdate.Name = "btnGuaardarUpdate";
            btnGuaardarUpdate.Size = new Size(131, 51);
            btnGuaardarUpdate.TabIndex = 12;
            btnGuaardarUpdate.Text = "GUARDAR";
            btnGuaardarUpdate.TextAlign = ContentAlignment.MiddleLeft;
            btnGuaardarUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuaardarUpdate.UseVisualStyleBackColor = false;
            btnGuaardarUpdate.Click += btnGuaardarUpdate_Click;
            // 
            // txtTelefonoEmpleadoUpdate
            // 
            txtTelefonoEmpleadoUpdate.Font = new Font("Segoe UI", 12F);
            txtTelefonoEmpleadoUpdate.Location = new Point(26, 220);
            txtTelefonoEmpleadoUpdate.Margin = new Padding(3, 4, 3, 4);
            txtTelefonoEmpleadoUpdate.Mask = "0000-0000";
            txtTelefonoEmpleadoUpdate.Name = "txtTelefonoEmpleadoUpdate";
            txtTelefonoEmpleadoUpdate.Size = new Size(303, 34);
            txtTelefonoEmpleadoUpdate.TabIndex = 8;
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
            btnCancelaEmpleado.Location = new Point(1226, 317);
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
            btnGuardarEmpleado.Location = new Point(1075, 317);
            btnGuardarEmpleado.Margin = new Padding(3, 4, 3, 4);
            btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            btnGuardarEmpleado.Size = new Size(131, 51);
            btnGuardarEmpleado.TabIndex = 12;
            btnGuardarEmpleado.Text = "GUARDAR";
            btnGuardarEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarEmpleado.UseVisualStyleBackColor = false;
            // 
            // cbxAreaEmpleadoUpdate
            // 
            cbxAreaEmpleadoUpdate.Font = new Font("Segoe UI", 12F);
            cbxAreaEmpleadoUpdate.FormattingEnabled = true;
            cbxAreaEmpleadoUpdate.Location = new Point(375, 149);
            cbxAreaEmpleadoUpdate.Margin = new Padding(3, 4, 3, 4);
            cbxAreaEmpleadoUpdate.Name = "cbxAreaEmpleadoUpdate";
            cbxAreaEmpleadoUpdate.Size = new Size(235, 36);
            cbxAreaEmpleadoUpdate.TabIndex = 11;
            // 
            // cbxCargoEmpleadoUpdate
            // 
            cbxCargoEmpleadoUpdate.Font = new Font("Segoe UI", 12F);
            cbxCargoEmpleadoUpdate.FormattingEnabled = true;
            cbxCargoEmpleadoUpdate.ItemHeight = 28;
            cbxCargoEmpleadoUpdate.Location = new Point(375, 71);
            cbxCargoEmpleadoUpdate.Margin = new Padding(3, 4, 3, 4);
            cbxCargoEmpleadoUpdate.Name = "cbxCargoEmpleadoUpdate";
            cbxCargoEmpleadoUpdate.Size = new Size(235, 36);
            cbxCargoEmpleadoUpdate.TabIndex = 10;
            // 
            // txtEmailEmpleadoUpdate
            // 
            txtEmailEmpleadoUpdate.Font = new Font("Segoe UI", 12F);
            txtEmailEmpleadoUpdate.Location = new Point(26, 295);
            txtEmailEmpleadoUpdate.Margin = new Padding(3, 4, 3, 4);
            txtEmailEmpleadoUpdate.Name = "txtEmailEmpleadoUpdate";
            txtEmailEmpleadoUpdate.Size = new Size(303, 34);
            txtEmailEmpleadoUpdate.TabIndex = 9;
            // 
            // txtApellidoEmpleadoUpdate
            // 
            txtApellidoEmpleadoUpdate.Font = new Font("Segoe UI", 12F);
            txtApellidoEmpleadoUpdate.Location = new Point(26, 145);
            txtApellidoEmpleadoUpdate.Margin = new Padding(3, 4, 3, 4);
            txtApellidoEmpleadoUpdate.Name = "txtApellidoEmpleadoUpdate";
            txtApellidoEmpleadoUpdate.Size = new Size(303, 34);
            txtApellidoEmpleadoUpdate.TabIndex = 7;
            // 
            // txtNombreEmpleadoUpdate
            // 
            txtNombreEmpleadoUpdate.Font = new Font("Segoe UI", 12F);
            txtNombreEmpleadoUpdate.Location = new Point(30, 71);
            txtNombreEmpleadoUpdate.Margin = new Padding(3, 4, 3, 4);
            txtNombreEmpleadoUpdate.Name = "txtNombreEmpleadoUpdate";
            txtNombreEmpleadoUpdate.Size = new Size(303, 34);
            txtNombreEmpleadoUpdate.TabIndex = 6;
            // 
            // lblAreaEmpleadoUpdate
            // 
            lblAreaEmpleadoUpdate.AutoSize = true;
            lblAreaEmpleadoUpdate.Location = new Point(375, 117);
            lblAreaEmpleadoUpdate.Name = "lblAreaEmpleadoUpdate";
            lblAreaEmpleadoUpdate.Size = new Size(61, 28);
            lblAreaEmpleadoUpdate.TabIndex = 5;
            lblAreaEmpleadoUpdate.Text = "Área:";
            // 
            // lblCargoEmpleadoUpdate
            // 
            lblCargoEmpleadoUpdate.AutoSize = true;
            lblCargoEmpleadoUpdate.Location = new Point(375, 39);
            lblCargoEmpleadoUpdate.Name = "lblCargoEmpleadoUpdate";
            lblCargoEmpleadoUpdate.Size = new Size(72, 28);
            lblCargoEmpleadoUpdate.TabIndex = 4;
            lblCargoEmpleadoUpdate.Text = "Cargo:";
            // 
            // lblEmailEmpleadoUpdate
            // 
            lblEmailEmpleadoUpdate.AutoSize = true;
            lblEmailEmpleadoUpdate.Location = new Point(26, 263);
            lblEmailEmpleadoUpdate.Name = "lblEmailEmpleadoUpdate";
            lblEmailEmpleadoUpdate.Size = new Size(69, 28);
            lblEmailEmpleadoUpdate.TabIndex = 3;
            lblEmailEmpleadoUpdate.Text = "Email:";
            // 
            // lblTelefonoEmpleadoUpdate
            // 
            lblTelefonoEmpleadoUpdate.AutoSize = true;
            lblTelefonoEmpleadoUpdate.Location = new Point(26, 188);
            lblTelefonoEmpleadoUpdate.Name = "lblTelefonoEmpleadoUpdate";
            lblTelefonoEmpleadoUpdate.Size = new Size(99, 28);
            lblTelefonoEmpleadoUpdate.TabIndex = 2;
            lblTelefonoEmpleadoUpdate.Text = "Teléfono:";
            // 
            // lblApellidoEmpleadoUpdate
            // 
            lblApellidoEmpleadoUpdate.AutoSize = true;
            lblApellidoEmpleadoUpdate.Location = new Point(26, 113);
            lblApellidoEmpleadoUpdate.Name = "lblApellidoEmpleadoUpdate";
            lblApellidoEmpleadoUpdate.Size = new Size(96, 28);
            lblApellidoEmpleadoUpdate.TabIndex = 1;
            lblApellidoEmpleadoUpdate.Text = "Apellido:";
            // 
            // lblNombreEmpleadoUpdate
            // 
            lblNombreEmpleadoUpdate.AutoSize = true;
            lblNombreEmpleadoUpdate.Location = new Point(29, 39);
            lblNombreEmpleadoUpdate.Name = "lblNombreEmpleadoUpdate";
            lblNombreEmpleadoUpdate.Size = new Size(94, 28);
            lblNombreEmpleadoUpdate.TabIndex = 0;
            lblNombreEmpleadoUpdate.Text = "Nombre:";
            // 
            // frmModificarEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 122, 144);
            ClientSize = new Size(669, 472);
            Controls.Add(gbUpdEmpleado);
            Controls.Add(pSuperiorUpdEmpleado);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmModificarEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmModificarEmpleado";
            pSuperiorUpdEmpleado.ResumeLayout(false);
            pSuperiorUpdEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).EndInit();
            gbUpdEmpleado.ResumeLayout(false);
            gbUpdEmpleado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pSuperiorUpdEmpleado;
        private FontAwesome.Sharp.IconButton btnCerrarAddEmpleado;
        private GroupBox gbUpdEmpleado;
        private FontAwesome.Sharp.IconButton btnCancelaEmpleado;
        private FontAwesome.Sharp.IconButton btnGuardarEmpleado;
        private FontAwesome.Sharp.IconButton btnGuardarUpdate;
        private FontAwesome.Sharp.IconButton btnGuaardarUpdate;
        public MaskedTextBox txtTelefonoEmpleadoUpdate;
        public ComboBox cbxAreaEmpleadoUpdate;
        public ComboBox cbxCargoEmpleadoUpdate;
        public TextBox txtEmailEmpleadoUpdate;
        public TextBox txtApellidoEmpleadoUpdate;
        public TextBox txtNombreEmpleadoUpdate;
        public Label lblAreaEmpleadoUpdate;
        public Label lblCargoEmpleadoUpdate;
        public Label lblEmailEmpleadoUpdate;
        public Label lblTelefonoEmpleadoUpdate;
        public Label lblApellidoEmpleadoUpdate;
        public Label lblNombreEmpleadoUpdate;
        private FontAwesome.Sharp.IconButton btnCerrarModificarEmpleado;
        private PictureBox pboxLogo;
    }
}
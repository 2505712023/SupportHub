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
            pSuperiorUpdEmpleado = new Panel();
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
            gbUpdEmpleado.SuspendLayout();
            SuspendLayout();
            // 
            // pSuperiorUpdEmpleado
            // 
            pSuperiorUpdEmpleado.BackColor = Color.FromArgb(5, 23, 59);
            pSuperiorUpdEmpleado.Controls.Add(btnCerrarAddEmpleado);
            pSuperiorUpdEmpleado.Dock = DockStyle.Top;
            pSuperiorUpdEmpleado.Location = new Point(0, 0);
            pSuperiorUpdEmpleado.Name = "pSuperiorUpdEmpleado";
            pSuperiorUpdEmpleado.Size = new Size(966, 60);
            pSuperiorUpdEmpleado.TabIndex = 1;
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
            btnCerrarAddEmpleado.Location = new Point(1701, 3);
            btnCerrarAddEmpleado.Name = "btnCerrarAddEmpleado";
            btnCerrarAddEmpleado.Size = new Size(28, 24);
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
            gbUpdEmpleado.Location = new Point(26, 75);
            gbUpdEmpleado.Name = "gbUpdEmpleado";
            gbUpdEmpleado.Size = new Size(898, 308);
            gbUpdEmpleado.TabIndex = 2;
            gbUpdEmpleado.TabStop = false;
            gbUpdEmpleado.Text = "MODIFICAR EMPLEADO";
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
            btnGuardarUpdate.Location = new Point(738, 250);
            btnGuardarUpdate.Name = "btnGuardarUpdate";
            btnGuardarUpdate.Size = new Size(115, 38);
            btnGuardarUpdate.TabIndex = 16;
            btnGuardarUpdate.Text = "CANCELAR";
            btnGuardarUpdate.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarUpdate.UseVisualStyleBackColor = false;
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
            btnGuaardarUpdate.Location = new Point(606, 250);
            btnGuaardarUpdate.Name = "btnGuaardarUpdate";
            btnGuaardarUpdate.Size = new Size(115, 38);
            btnGuaardarUpdate.TabIndex = 15;
            btnGuaardarUpdate.Text = "GUARDAR";
            btnGuaardarUpdate.TextAlign = ContentAlignment.MiddleLeft;
            btnGuaardarUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuaardarUpdate.UseVisualStyleBackColor = false;
            btnGuaardarUpdate.Click += btnGuaardarUpdate_Click;
            // 
            // txtTelefonoEmpleadoUpdate
            // 
            txtTelefonoEmpleadoUpdate.Location = new Point(55, 183);
            txtTelefonoEmpleadoUpdate.Mask = "0000-0000";
            txtTelefonoEmpleadoUpdate.Name = "txtTelefonoEmpleadoUpdate";
            txtTelefonoEmpleadoUpdate.Size = new Size(266, 23);
            txtTelefonoEmpleadoUpdate.TabIndex = 14;
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
            btnCancelaEmpleado.Location = new Point(1410, 238);
            btnCancelaEmpleado.Name = "btnCancelaEmpleado";
            btnCancelaEmpleado.Size = new Size(115, 38);
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
            btnGuardarEmpleado.Location = new Point(1278, 238);
            btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            btnGuardarEmpleado.Size = new Size(115, 38);
            btnGuardarEmpleado.TabIndex = 12;
            btnGuardarEmpleado.Text = "GUARDAR";
            btnGuardarEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarEmpleado.UseVisualStyleBackColor = false;
            // 
            // cbxAreaEmpleadoUpdate
            // 
            cbxAreaEmpleadoUpdate.FormattingEnabled = true;
            cbxAreaEmpleadoUpdate.Location = new Point(686, 47);
            cbxAreaEmpleadoUpdate.Name = "cbxAreaEmpleadoUpdate";
            cbxAreaEmpleadoUpdate.Size = new Size(155, 23);
            cbxAreaEmpleadoUpdate.TabIndex = 11;
            // 
            // cbxCargoEmpleadoUpdate
            // 
            cbxCargoEmpleadoUpdate.FormattingEnabled = true;
            cbxCargoEmpleadoUpdate.Location = new Point(456, 47);
            cbxCargoEmpleadoUpdate.Name = "cbxCargoEmpleadoUpdate";
            cbxCargoEmpleadoUpdate.Size = new Size(155, 23);
            cbxCargoEmpleadoUpdate.TabIndex = 10;
            // 
            // txtEmailEmpleadoUpdate
            // 
            txtEmailEmpleadoUpdate.Location = new Point(55, 238);
            txtEmailEmpleadoUpdate.Name = "txtEmailEmpleadoUpdate";
            txtEmailEmpleadoUpdate.Size = new Size(266, 23);
            txtEmailEmpleadoUpdate.TabIndex = 9;
            // 
            // txtApellidoEmpleadoUpdate
            // 
            txtApellidoEmpleadoUpdate.Location = new Point(55, 106);
            txtApellidoEmpleadoUpdate.Name = "txtApellidoEmpleadoUpdate";
            txtApellidoEmpleadoUpdate.Size = new Size(266, 23);
            txtApellidoEmpleadoUpdate.TabIndex = 7;
            // 
            // txtNombreEmpleadoUpdate
            // 
            txtNombreEmpleadoUpdate.Location = new Point(55, 47);
            txtNombreEmpleadoUpdate.Name = "txtNombreEmpleadoUpdate";
            txtNombreEmpleadoUpdate.Size = new Size(266, 23);
            txtNombreEmpleadoUpdate.TabIndex = 6;
            // 
            // lblAreaEmpleadoUpdate
            // 
            lblAreaEmpleadoUpdate.AutoSize = true;
            lblAreaEmpleadoUpdate.Location = new Point(686, 29);
            lblAreaEmpleadoUpdate.Name = "lblAreaEmpleadoUpdate";
            lblAreaEmpleadoUpdate.Size = new Size(34, 15);
            lblAreaEmpleadoUpdate.TabIndex = 5;
            lblAreaEmpleadoUpdate.Text = "Área:";
            // 
            // lblCargoEmpleadoUpdate
            // 
            lblCargoEmpleadoUpdate.AutoSize = true;
            lblCargoEmpleadoUpdate.Location = new Point(456, 29);
            lblCargoEmpleadoUpdate.Name = "lblCargoEmpleadoUpdate";
            lblCargoEmpleadoUpdate.Size = new Size(42, 15);
            lblCargoEmpleadoUpdate.TabIndex = 4;
            lblCargoEmpleadoUpdate.Text = "Cargo:";
            // 
            // lblEmailEmpleadoUpdate
            // 
            lblEmailEmpleadoUpdate.AutoSize = true;
            lblEmailEmpleadoUpdate.Location = new Point(55, 220);
            lblEmailEmpleadoUpdate.Name = "lblEmailEmpleadoUpdate";
            lblEmailEmpleadoUpdate.Size = new Size(39, 15);
            lblEmailEmpleadoUpdate.TabIndex = 3;
            lblEmailEmpleadoUpdate.Text = "Email:";
            // 
            // lblTelefonoEmpleadoUpdate
            // 
            lblTelefonoEmpleadoUpdate.AutoSize = true;
            lblTelefonoEmpleadoUpdate.Location = new Point(55, 156);
            lblTelefonoEmpleadoUpdate.Name = "lblTelefonoEmpleadoUpdate";
            lblTelefonoEmpleadoUpdate.Size = new Size(55, 15);
            lblTelefonoEmpleadoUpdate.TabIndex = 2;
            lblTelefonoEmpleadoUpdate.Text = "Teléfono:";
            // 
            // lblApellidoEmpleadoUpdate
            // 
            lblApellidoEmpleadoUpdate.AutoSize = true;
            lblApellidoEmpleadoUpdate.Location = new Point(55, 88);
            lblApellidoEmpleadoUpdate.Name = "lblApellidoEmpleadoUpdate";
            lblApellidoEmpleadoUpdate.Size = new Size(54, 15);
            lblApellidoEmpleadoUpdate.TabIndex = 1;
            lblApellidoEmpleadoUpdate.Text = "Apellido:";
            // 
            // lblNombreEmpleadoUpdate
            // 
            lblNombreEmpleadoUpdate.AutoSize = true;
            lblNombreEmpleadoUpdate.Location = new Point(55, 29);
            lblNombreEmpleadoUpdate.Name = "lblNombreEmpleadoUpdate";
            lblNombreEmpleadoUpdate.Size = new Size(54, 15);
            lblNombreEmpleadoUpdate.TabIndex = 0;
            lblNombreEmpleadoUpdate.Text = "Nombre:";
            // 
            // frmModificarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 122, 144);
            ClientSize = new Size(966, 408);
            Controls.Add(gbUpdEmpleado);
            Controls.Add(pSuperiorUpdEmpleado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmModificarEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmModificarEmpleado";
            Load += frmModificarEmpleado_Load;
            pSuperiorUpdEmpleado.ResumeLayout(false);
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
    }
}
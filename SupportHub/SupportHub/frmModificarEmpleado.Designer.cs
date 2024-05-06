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
            gbUpdEmpleado.SuspendLayout();
            SuspendLayout();
            // 
            // pSuperiorUpdEmpleado
            // 
            pSuperiorUpdEmpleado.BackColor = Color.FromArgb(5, 23, 59);
            pSuperiorUpdEmpleado.Controls.Add(btnCerrarModificarEmpleado);
            pSuperiorUpdEmpleado.Controls.Add(btnCerrarAddEmpleado);
            pSuperiorUpdEmpleado.Dock = DockStyle.Top;
            pSuperiorUpdEmpleado.Location = new Point(0, 0);
            pSuperiorUpdEmpleado.Name = "pSuperiorUpdEmpleado";
            pSuperiorUpdEmpleado.Size = new Size(585, 60);
            pSuperiorUpdEmpleado.TabIndex = 1;
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
            btnCerrarModificarEmpleado.Location = new Point(554, 3);
            btnCerrarModificarEmpleado.Name = "btnCerrarModificarEmpleado";
            btnCerrarModificarEmpleado.Size = new Size(28, 24);
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
            btnCerrarAddEmpleado.Location = new Point(1320, 3);
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
            gbUpdEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbUpdEmpleado.Location = new Point(12, 66);
            gbUpdEmpleado.Name = "gbUpdEmpleado";
            gbUpdEmpleado.Size = new Size(561, 276);
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
            btnGuardarUpdate.Location = new Point(419, 212);
            btnGuardarUpdate.Name = "btnGuardarUpdate";
            btnGuardarUpdate.Size = new Size(115, 38);
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
            btnGuaardarUpdate.Location = new Point(419, 159);
            btnGuaardarUpdate.Name = "btnGuaardarUpdate";
            btnGuaardarUpdate.Size = new Size(115, 38);
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
            txtTelefonoEmpleadoUpdate.Location = new Point(23, 165);
            txtTelefonoEmpleadoUpdate.Mask = "0000-0000";
            txtTelefonoEmpleadoUpdate.Name = "txtTelefonoEmpleadoUpdate";
            txtTelefonoEmpleadoUpdate.Size = new Size(266, 29);
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
            btnCancelaEmpleado.Location = new Point(1073, 238);
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
            btnGuardarEmpleado.Location = new Point(941, 238);
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
            cbxAreaEmpleadoUpdate.Font = new Font("Segoe UI", 12F);
            cbxAreaEmpleadoUpdate.FormattingEnabled = true;
            cbxAreaEmpleadoUpdate.Location = new Point(328, 112);
            cbxAreaEmpleadoUpdate.Name = "cbxAreaEmpleadoUpdate";
            cbxAreaEmpleadoUpdate.Size = new Size(206, 29);
            cbxAreaEmpleadoUpdate.TabIndex = 11;
            // 
            // cbxCargoEmpleadoUpdate
            // 
            cbxCargoEmpleadoUpdate.Font = new Font("Segoe UI", 12F);
            cbxCargoEmpleadoUpdate.FormattingEnabled = true;
            cbxCargoEmpleadoUpdate.ItemHeight = 21;
            cbxCargoEmpleadoUpdate.Location = new Point(328, 53);
            cbxCargoEmpleadoUpdate.Name = "cbxCargoEmpleadoUpdate";
            cbxCargoEmpleadoUpdate.Size = new Size(206, 29);
            cbxCargoEmpleadoUpdate.TabIndex = 10;
            // 
            // txtEmailEmpleadoUpdate
            // 
            txtEmailEmpleadoUpdate.Font = new Font("Segoe UI", 12F);
            txtEmailEmpleadoUpdate.Location = new Point(23, 221);
            txtEmailEmpleadoUpdate.Name = "txtEmailEmpleadoUpdate";
            txtEmailEmpleadoUpdate.Size = new Size(266, 29);
            txtEmailEmpleadoUpdate.TabIndex = 9;
            // 
            // txtApellidoEmpleadoUpdate
            // 
            txtApellidoEmpleadoUpdate.Font = new Font("Segoe UI", 12F);
            txtApellidoEmpleadoUpdate.Location = new Point(23, 109);
            txtApellidoEmpleadoUpdate.Name = "txtApellidoEmpleadoUpdate";
            txtApellidoEmpleadoUpdate.Size = new Size(266, 29);
            txtApellidoEmpleadoUpdate.TabIndex = 7;
            // 
            // txtNombreEmpleadoUpdate
            // 
            txtNombreEmpleadoUpdate.Font = new Font("Segoe UI", 12F);
            txtNombreEmpleadoUpdate.Location = new Point(26, 53);
            txtNombreEmpleadoUpdate.Name = "txtNombreEmpleadoUpdate";
            txtNombreEmpleadoUpdate.Size = new Size(266, 29);
            txtNombreEmpleadoUpdate.TabIndex = 6;
            // 
            // lblAreaEmpleadoUpdate
            // 
            lblAreaEmpleadoUpdate.AutoSize = true;
            lblAreaEmpleadoUpdate.Location = new Point(328, 88);
            lblAreaEmpleadoUpdate.Name = "lblAreaEmpleadoUpdate";
            lblAreaEmpleadoUpdate.Size = new Size(49, 21);
            lblAreaEmpleadoUpdate.TabIndex = 5;
            lblAreaEmpleadoUpdate.Text = "Área:";
            // 
            // lblCargoEmpleadoUpdate
            // 
            lblCargoEmpleadoUpdate.AutoSize = true;
            lblCargoEmpleadoUpdate.Location = new Point(328, 29);
            lblCargoEmpleadoUpdate.Name = "lblCargoEmpleadoUpdate";
            lblCargoEmpleadoUpdate.Size = new Size(59, 21);
            lblCargoEmpleadoUpdate.TabIndex = 4;
            lblCargoEmpleadoUpdate.Text = "Cargo:";
            // 
            // lblEmailEmpleadoUpdate
            // 
            lblEmailEmpleadoUpdate.AutoSize = true;
            lblEmailEmpleadoUpdate.Location = new Point(23, 197);
            lblEmailEmpleadoUpdate.Name = "lblEmailEmpleadoUpdate";
            lblEmailEmpleadoUpdate.Size = new Size(57, 21);
            lblEmailEmpleadoUpdate.TabIndex = 3;
            lblEmailEmpleadoUpdate.Text = "Email:";
            // 
            // lblTelefonoEmpleadoUpdate
            // 
            lblTelefonoEmpleadoUpdate.AutoSize = true;
            lblTelefonoEmpleadoUpdate.Location = new Point(23, 141);
            lblTelefonoEmpleadoUpdate.Name = "lblTelefonoEmpleadoUpdate";
            lblTelefonoEmpleadoUpdate.Size = new Size(81, 21);
            lblTelefonoEmpleadoUpdate.TabIndex = 2;
            lblTelefonoEmpleadoUpdate.Text = "Teléfono:";
            // 
            // lblApellidoEmpleadoUpdate
            // 
            lblApellidoEmpleadoUpdate.AutoSize = true;
            lblApellidoEmpleadoUpdate.Location = new Point(23, 85);
            lblApellidoEmpleadoUpdate.Name = "lblApellidoEmpleadoUpdate";
            lblApellidoEmpleadoUpdate.Size = new Size(79, 21);
            lblApellidoEmpleadoUpdate.TabIndex = 1;
            lblApellidoEmpleadoUpdate.Text = "Apellido:";
            // 
            // lblNombreEmpleadoUpdate
            // 
            lblNombreEmpleadoUpdate.AutoSize = true;
            lblNombreEmpleadoUpdate.Location = new Point(25, 29);
            lblNombreEmpleadoUpdate.Name = "lblNombreEmpleadoUpdate";
            lblNombreEmpleadoUpdate.Size = new Size(77, 21);
            lblNombreEmpleadoUpdate.TabIndex = 0;
            lblNombreEmpleadoUpdate.Text = "Nombre:";
            // 
            // frmModificarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 122, 144);
            ClientSize = new Size(585, 354);
            Controls.Add(gbUpdEmpleado);
            Controls.Add(pSuperiorUpdEmpleado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmModificarEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmModificarEmpleado";
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
        private FontAwesome.Sharp.IconButton btnCerrarModificarEmpleado;
    }
}